Imports Janus.Windows.GridEX

Public Class FrmMantAnexosContables_RestriccionPago
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Public TipoAnexo As String

    Private Sub FrmMantAnexosContables_RestriccionPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel5.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CARGA_GRID()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MAN_ANEXOSCONTABLES_PAGO_RESTRINGIDO"
            strSQL &= vbNewLine & String.Format(" @ACCION        = '{0}'", "S")
            strSQL &= vbNewLine & String.Format(",@COD_TIPANEX   = '{0}'", TipoAnexo)
            strSQL &= vbNewLine & String.Format(",@COD_ANXO      = '{0}'", TxtCodigo.Text)

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
                    .Columns("FEC_PAGO_RESTRINGIDO").Width = 200
                    .Columns("FEC_PAGO_RESTRINGIDO").Caption = "FECHA RESTRICCION"
                    .Columns("COD_USUARIO_PAGO_RESTRINGIDO").Width = 150
                    .Columns("COD_USUARIO_PAGO_RESTRINGIDO").Caption = "USUARIO RESTRICCION"
                    .Columns("OBS_PAGO_RESTRINGIDO").Width = 350
                    .Columns("OBS_PAGO_RESTRINGIDO").Caption = "OBSERVACION"
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
                    Using oAdd As New FrmMantAnexosContables_RestriccionPago_Mant
                        With oAdd
                            .TipoAnexo = TipoAnexo
                            .TxtCodigo.Text = TxtCodigo.Text
                            .TxtDescripcion.Text = TxtDescripcion.Text
                            .sAccion = "I"
                            .sec = 0
                            .Text = "Adicionar Restricción"
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_GRID()
                            End If
                        End With
                    End Using

                Case "MODIFICAR"
                    If GrdDatos.RecordCount = 0 Then Return
                    FilaSeleccionada = GrdDatos.CurrentRow.Position
                    Using oMod As New FrmMantAnexosContables_RestriccionPago_Mant
                        With oMod
                            .TipoAnexo = TipoAnexo
                            .TxtCodigo.Text = TxtCodigo.Text
                            .TxtDescripcion.Text = TxtDescripcion.Text
                            .sAccion = "U"
                            .Text = "Modificar Restricción"
                            .sec = GrdDatos.GetValue(GrdDatos.RootTable.Columns("sec").Index)
                            .txtObservacion.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("OBS_PAGO_RESTRINGIDO").Index)
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
                        strSQL &= vbNewLine & "EXEC CN_MAN_ANEXOSCONTABLES_PAGO_RESTRINGIDO"
                        strSQL &= vbNewLine & String.Format(" @ACCION            = '{0}'", "D")
                        strSQL &= vbNewLine & String.Format(",@COD_TIPANEX       = '{0}'", TipoAnexo)
                        strSQL &= vbNewLine & String.Format(",@COD_ANXO          = '{0}'", TxtCodigo.Text)
                        strSQL &= vbNewLine & String.Format(",@SEC               =  {0} ", GrdDatos.GetValue(GrdDatos.RootTable.Columns("SEC").Index))
                        strSQL &= vbNewLine & String.Format(",@COD_USUARIO       = '{0}'", vusu)
                        strSQL &= vbNewLine & String.Format(",@OBS_PAGO_RESTRINGIDO        = '{0}'", "")
                        strSQL &= vbNewLine & String.Format(",@COD_ESTACION      = '{0}'", ComputerName)

                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            MessageBox.Show("Se eliminó correctamente...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CARGA_GRID()
                        End If
                    End If

                Case "ALTRES"
                    AltaBitacora()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub AltaBitacora()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MAN_ANEXOSCONTABLES_PAGO_RESTRINGIDO"
            strSQL &= vbNewLine & String.Format(" @ACCION            = '{0}'", "A")
            strSQL &= vbNewLine & String.Format(",@COD_TIPANEX       = '{0}'", TipoAnexo)
            strSQL &= vbNewLine & String.Format(",@COD_ANXO          = '{0}'", TxtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@SEC               =  {0} ", GrdDatos.GetValue(GrdDatos.RootTable.Columns("SEC").Index))
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO       = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@OBS_PAGO_RESTRINGIDO        = '{0}'", "")
            strSQL &= vbNewLine & String.Format(",@COD_ESTACION      = '{0}'", ComputerName)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Los datos fueron procesados con éxito.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                CARGA_GRID()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class