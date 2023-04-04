Imports Janus.Windows.GridEX

Public Class FrmGuiasAsociadas_CortePrendas_AsigGuias
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public sCOD_TIPANEX As String
    Public sCOD_ANXO As String
    Public sNum_Corre As String
    Public oParent As Object

    Private Const K_strColCheck As String = "SEL"

    Private Sub FrmGuiasAsociadas_AlmacenesPrimarios_AsigGuias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
        Panel10.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Public Sub CARGA_MOVIMIENTOS()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC SM_MUESTRA_GUIAS_CORTE_POR_FACTURAR"
            strSQL &= vbNewLine & String.Format(" @COD_TIPANEX      = '{0}'", sCOD_TIPANEX)
            strSQL &= vbNewLine & String.Format(",@COD_ANXO         = '{0}'", sCOD_ANXO)

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

                    .Columns("SEC").Width = 60
                    .Columns("COD_FABRICA").Width = 80
                    .Columns("COD_ORDPRO").Width = 80
                    .Columns("NUM_SECORD").Width = 60
                    .Columns("CO_CODORDPRO").Width = 110
                    .Columns("NUM_PRENDAS").Width = 80
                    .Columns("PRE_UNITARIO").Width = 110
                    .Columns("IMP_FACTURA_SOLES").Width = 80
                    .Columns("IMP_FACTURA_DOLARES").Width = 80

                    .Columns("SEC").Caption = "SEC"
                    .Columns("COD_FABRICA").Caption = "COD. FAB."
                    .Columns("COD_ORDPRO").Caption = "OP"
                    .Columns("NUM_SECORD").Caption = "SEC. ORD"
                    .Columns("CO_CODORDPRO").Caption = "CO. OP"
                    .Columns("NUM_PRENDAS").Caption = "PRENDAS"
                    .Columns("PRE_UNITARIO").Caption = "PREC. UNIT."
                    .Columns("IMP_FACTURA_SOLES").Caption = "FT (S/)"
                    .Columns("IMP_FACTURA_DOLARES").Caption = "FT ($/)"

                    With .Columns(K_strColCheck)
                        .Caption = "SEL"
                        .Visible = True
                        .ColumnType = ColumnType.CheckBox
                        .EditType = EditType.CheckBox
                        .ActAsSelector = True
                        .Width = 25
                        .Caption = String.Empty
                        .Position = 0
                    End With
                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnAceptarProrrateo_Click(sender As Object, e As EventArgs) Handles BtnAceptarProrrateo.Click
        Try
            If GrdDatos.GetCheckedRows.Length Then
                For Each oGridEXRow As GridEXRow In GrdDatos.GetCheckedRows
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC UP_ASIGNA_GUIA_FACTURA_CORTE_PRENDAS"
                    strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", TxtNroCorrelativo.Text)
                    strSQL &= vbNewLine & String.Format(",@SEC          =  {0} ", oGridEXRow.Cells("sec").Value)
                    oHP.EjecutaOperacion(strSQL, cCONNECT)
                Next
                MessageBox.Show("Se Asignó Correctamante los Registros Seleccionados", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Debe Seleccionar Al Menos un Registro", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelarProrrateo_Click(sender As Object, e As EventArgs) Handles BtnCancelarProrrateo.Click
        Me.Close()
    End Sub
End Class