Imports Janus.Windows.GridEX

Public Class FrmGuiasAsociadas_AlmacenesPrimarios_AsigGuias
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public vnum_corre As String
    Public vCod_Anexo As String
    Public vCod_TipAnexo As String
    Public vCod_AnexoAsociado As String
    Public vTipo_Documento As String
    Dim vNumGuia As String, i As Long
    Public vPrevio As String
    Public vVigente As String
    Public vNum_Impor As String
    Public sNumLiqServ As String

    Private Const K_strColCheck As String = "SEL"

    Private Sub FrmGuiasAsociadas_AlmacenesPrimarios_AsigGuias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
        Panel10.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Public Sub CARGA_MOVIMIENTOS(ByVal sVerVIGENTES As String)
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC SM_MUESTRA_GUIAS_POR_FACTURAR"
            strSQL &= vbNewLine & String.Format(" @COD_TIPANEX      = '{0}'", vCod_TipAnexo)
            strSQL &= vbNewLine & String.Format(",@COD_ANXO         = '{0}'", vCod_Anexo)
            strSQL &= vbNewLine & String.Format(",@COD_ANXOASOCIADO = '{0}'", vCod_AnexoAsociado)
            strSQL &= vbNewLine & String.Format(",@COD_TIPDOC       = '{0}'", vTipo_Documento)
            strSQL &= vbNewLine & String.Format(",@VIGENTES         = '{0}'", sVerVIGENTES)
            strSQL &= vbNewLine & String.Format(",@Previo           = '{0}'", vVigente)
            strSQL &= vbNewLine & String.Format(",@NUM_CORRE        = '{0}'", TxtNroCorrelativo.Text)

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

                    .Columns("cod_almacen").Visible = False
                    .Columns("Almacen").Width = 150
                    .Columns("Movimiento").Width = 65
                    .Columns("Movimiento").TextAlignment = TextAlignment.Center
                    .Columns("Movimiento").Caption = "MOV"
                    .Columns("Guia").Width = 90

                    .Columns("FEC.MOV.").FormatString = "dd/MM/yyyy"
                    .Columns("FEC.MOV.").Width = 80
                    .Columns("FEC.MOV.").TextAlignment = TextAlignment.Center

                    .Columns("O/C").Width = 90
                    .Columns("TIPO").Width = 50

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
                    strSQL &= vbNewLine & "EXEC UP_ASIGNA_GUIA_FACTURA"
                    strSQL &= vbNewLine & String.Format(" @num_corre        = '{0}'", TxtNroCorrelativo.Text)
                    strSQL &= vbNewLine & String.Format(",@COD_ALMACEN      = '{0}'", oGridEXRow.Cells("cod_almacen").Value)
                    strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK       = '{0}'", oGridEXRow.Cells("Movimiento").Value)
                    strSQL &= vbNewLine & String.Format(",@TIPO             = '{0}'", oGridEXRow.Cells("Tipo").Value)
                    strSQL &= vbNewLine & String.Format(",@Previo           = '{0}'", vVigente)
                    strSQL &= vbNewLine & String.Format(",@NUM_IMPORTACION  = '{0}'", vNum_Impor)
                    oHP.EjecutaOperacion(strSQL, cCONNECT)
                Next
                MessageBox.Show("Proceso ejecutado satisfactoriamente......", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub BtnPasarGasto_Click(sender As Object, e As EventArgs) Handles BtnPasarGasto.Click
        Call PasarAlGasto()
    End Sub

    '************************************************************************************************************************************************
    '==> ECN : BOTON -> PASAR AL GASTO
    '************************************************************************************************************************************************

    Private Sub PasarAlGasto()
        Try
            If GrdDatos.GetCheckedRows.Length Then
                If MessageBox.Show("¿Esta seguro de pasar a gasto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then Exit Sub

                For Each oGridEXRow As GridEXRow In GrdDatos.GetCheckedRows
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC UP_ASIGNA_GUIA_GASTO_DOCUM_999999"
                    strSQL &= vbNewLine & String.Format(" @COD_ALMACEN      = '{0}'", oGridEXRow.Cells("cod_almacen").Value)
                    strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK       = '{0}'", oGridEXRow.Cells("Movimiento").Value)
                    strSQL &= vbNewLine & String.Format(",@TIPO             = '{0}'", oGridEXRow.Cells("Tipo").Value)
                    oHP.EjecutaOperacion(strSQL, cCONNECT)
                Next
                MessageBox.Show("Proceso ejecutado satisfactoriamente......", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Debe Seleccionar Al Menos un Registro", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class