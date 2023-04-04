Imports Janus.Windows.GridEX

Public Class FrmMantAnexosContables_CuentaCorriente
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Public TipoAnexo As String

    Private Sub FrmMantAnexosContables_CuentaCorriente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel5.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CARGA_GRID()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_UP_MAN_CTA_CORRIENTE"
            strSQL &= vbNewLine & String.Format(" @ACCION        = '{0}'", "V")
            strSQL &= vbNewLine & String.Format(",@Cod_TipAnex   = '{0}'", TipoAnexo)
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

                    .Columns("cod_tipanex").Visible = False
                    .Columns("cod_anxo").Visible = False
                    .Columns("cod_banco").Width = 100
                    .Columns("nom_banco").Width = 220
                    .Columns("sec_cuenta_banco").Width = 100
                    .Columns("nom_cuenta").Width = 220
                    .Columns("cod_cuenta").Width = 150
                    .Columns("tip_cuenta").Width = 100
                    .Columns("des_tipcuenta").Width = 200
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
                    Using oAdd As New FrmMantAnexosContables_CuentaCorriente_Mant
                        With oAdd
                            .TipoAnexo = TipoAnexo
                            .TxtCodigo.Text = TxtCodigo.Text
                            .TxtDescripcion.Text = TxtDescripcion.Text
                            .sAccion = "I"
                            .Text = "Adicionar Cuenta Corriente "
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_GRID()
                            End If
                        End With
                    End Using

                Case "MODIFICAR"
                    If GrdDatos.RecordCount = 0 Then Return
                    FilaSeleccionada = GrdDatos.CurrentRow.Position
                    Using oMod As New FrmMantAnexosContables_CuentaCorriente_Mant
                        With oMod
                            .TipoAnexo = TipoAnexo
                            .TxtCodigo.Text = TxtCodigo.Text
                            .TxtDescripcion.Text = TxtDescripcion.Text
                            .sAccion = "U"
                            .Text = "Modificar Cuenta Corriente "
                            .txtBanco_Cod.Enabled = False
                            .txtBanco_Des.Enabled = False
                            .txtCuenta_Cod.Enabled = False
                            .txtCuenta_Des.Enabled = False
                            .txtBanco_Cod.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("cod_banco").Index)
                            .txtBanco_Des.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("nom_banco").Index)
                            .txtCuenta_Cod.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("sec_cuenta_banco").Index)
                            .txtCuenta_Des.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("nom_cuenta").Index)
                            .TxtCodCtaCte.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("cod_cuenta").Index)
                            .txtTipCtaCte.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("tip_cuenta").Index)
                            .TxtDesTipCtaCte.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("des_tipcuenta").Index)
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
                        strSQL &= vbNewLine & "EXEC CN_UP_MAN_CTA_CORRIENTE"
                        strSQL &= vbNewLine & String.Format(" @ACCION            = '{0}'", "D")
                        strSQL &= vbNewLine & String.Format(",@Cod_TipAnex       = '{0}'", TipoAnexo)
                        strSQL &= vbNewLine & String.Format(",@COD_ANXO          = '{0}'", TxtCodigo.Text)
                        strSQL &= vbNewLine & String.Format(",@COD_BANCO         = '{0}'", GrdDatos.GetValue(GrdDatos.RootTable.Columns("cod_banco").Index))
                        strSQL &= vbNewLine & String.Format(",@SEC_CUENTA_BANCO  = '{0}'", GrdDatos.GetValue(GrdDatos.RootTable.Columns("sec_cuenta_banco").Index))
                        strSQL &= vbNewLine & String.Format(",@COD_CUENTA        = '{0}'", GrdDatos.GetValue(GrdDatos.RootTable.Columns("cod_cuenta").Index))
                        strSQL &= vbNewLine & String.Format(",@COD_TIPCUENTA     = '{0}'", GrdDatos.GetValue(GrdDatos.RootTable.Columns("tip_cuenta").Index))
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