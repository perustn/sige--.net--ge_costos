Imports Janus.Windows.GridEX

Public Class FrmMantAnexosContables_BajaProveedor
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Public TipoAnexo As String

    Private Sub FrmMantAnexosContables_BajaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel5.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CARGA_GRID()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MAN_ANEXOSCONTABLES_BAJA_ANEXO"
            strSQL &= vbNewLine & String.Format(" @ACCION        = '{0}'", "S")
            strSQL &= vbNewLine & String.Format(",@COD_TIPANEX   = '{0}'", TipoAnexo)
            strSQL &= vbNewLine & String.Format(",@COD_ANXO      = '{0}'", TxtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@SEC           =  {0} ", 0)
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO   = '{0}'", "")
            strSQL &= vbNewLine & String.Format(",@COD_MOTIVO_BAJA   = '{0}'", "")
            strSQL &= vbNewLine & String.Format(",@OBS_BAJA      = '{0}'", "")
            strSQL &= vbNewLine & String.Format(",@COD_ESTACION  = '{0}'", "")

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            GrdDatos.DataSource = oDT
            CheckLayoutGridEx(GrdDatos)

            With GrdDatos
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                With .RootTable
                    .HeaderLines = 2
                    .PreviewRow = False
                    .PreviewRowLines = 10
                    .RowHeight = 30
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("SEC").Visible = False
                    .Columns("FEC_BAJA").Width = 200
                    .Columns("FEC_BAJA").Caption = "FECHA BAJA"
                    .Columns("COD_USUARIO_BAJA").Width = 150
                    .Columns("COD_USUARIO_BAJA").Caption = "USUARIO BAJA"
                    .Columns("COD_MOTIVO_BAJA").Width = 150
                    .Columns("COD_MOTIVO_BAJA").Caption = "COD OBS."
                    .Columns("DES_MOTIVO_BAJA").Width = 150
                    .Columns("DES_MOTIVO_BAJA").Caption = "DESC. MOTIVO."
                    .Columns("OBS_BAJA").Width = 150
                    .Columns("OBS_BAJA").Caption = "OBSERVACION"
                    .Columns("FEC_ALTA").Width = 200
                    .Columns("FEC_ALTA").Caption = "FECHA ALTA"
                    .Columns("COD_USUARIO_ALTA").Width = 150
                    .Columns("COD_USUARIO_ALTA").Caption = "USUARIO ALTA"
                    .Columns("COD_ESTACION_ALTA").Width = 150
                    .Columns("COD_ESTACION_ALTA").Caption = "ESTACION ALTA"

                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    Using oAdd As New FrmMantAnexosContables_BajaProveedor_Mant
                        With oAdd
                            .TipoAnexo = TipoAnexo
                            .TxtCodigo.Text = TxtCodigo.Text
                            .TxtDescripcion.Text = TxtDescripcion.Text
                            .sAccion = "I"
                            .sec = 0
                            .Text = "Adicionar Motivo de baja"
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_GRID()
                            End If
                        End With
                    End Using

                Case "MODIFICAR"
                    If GrdDatos.RecordCount = 0 Then Return
                    FilaSeleccionada = GrdDatos.CurrentRow.Position
                    Using oMod As New FrmMantAnexosContables_BajaProveedor_Mant
                        With oMod
                            .TipoAnexo = TipoAnexo
                            .TxtCodigo.Text = TxtCodigo.Text
                            .TxtDescripcion.Text = TxtDescripcion.Text
                            .sAccion = "U"
                            .Text = "Modificar Restricción"
                            .sec = GrdDatos.GetValue(GrdDatos.RootTable.Columns("sec").Index)
                            .txtCodBaja.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("COD_MOTIVO_BAJA").Index)
                            .txtDesBaja.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("DES_MOTIVO_BAJA").Index)
                            .txtObservacion.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("OBS_BAJA").Index)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_GRID()
                                GrdDatos.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "ELIMINAR"
                    If GrdDatos.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC CN_MAN_ANEXOSCONTABLES_BAJA_ANEXO"
                        strSQL &= vbNewLine & String.Format(" @ACCION        = '{0}'", "D")
                        strSQL &= vbNewLine & String.Format(",@COD_TIPANEX   = '{0}'", TipoAnexo)
                        strSQL &= vbNewLine & String.Format(",@COD_ANXO      = '{0}'", TxtCodigo.Text)
                        strSQL &= vbNewLine & String.Format(",@SEC           =  {0} ", GrdDatos.GetValue(GrdDatos.RootTable.Columns("SEC").Index))
                        strSQL &= vbNewLine & String.Format(",@COD_USUARIO   = '{0}'", vusu)
                        strSQL &= vbNewLine & String.Format(",@COD_MOTIVO_BAJA   = '{0}'", "")
                        strSQL &= vbNewLine & String.Format(",@OBS_BAJA      = '{0}'", "")
                        strSQL &= vbNewLine & String.Format(",@COD_ESTACION  = '{0}'", ComputerName())

                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            MessageBox.Show("Se eliminó correctamente...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CARGA_GRID()
                        End If
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class