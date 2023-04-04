Imports Janus.Windows.GridEX

Public Class FrmGuiasAsociadas_AlmacenesPrimarios_Prorrateo
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmGuiasAsociadas_AlmacenesPrimarios_Prorrateo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CARGA_GRID()
        Try

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC USPSET_DOCUM_DET_GUIA"
            strSQL &= vbNewLine & String.Format(" @OPCION       =  {0} ", 1)
            strSQL &= vbNewLine & String.Format(",@NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            GrdDatos.DataSource = oDT
            CheckLayoutGridEx(GrdDatos)

            With GrdDatos
                .FilterMode = FilterMode.None
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

                    .Columns("COD_ITEM").Width = 90
                    .Columns("NUM_GUIA").Width = 90
                    .Columns("COD_ORDPROV").Width = 95
                    .Columns("DESCRIP").Width = 220
                    .Columns("CANTIDAD").Width = 80
                    .Columns("PRE_UNIT").Width = 80
                    .Columns("PRE_TOTAL").Width = 80

                    .Columns("COD_ITEM").EditType = EditType.NoEdit
                    .Columns("NUM_GUIA").EditType = EditType.NoEdit
                    .Columns("COD_ORDPROV").EditType = EditType.NoEdit
                    .Columns("DESCRIP").EditType = EditType.NoEdit
                    .Columns("CANTIDAD").EditType = EditType.NoEdit
                    .Columns("PRE_UNIT").EditType = EditType.NoEdit
                    .Columns("SECUENCIA_DET").Visible = False
                    .Columns("COD_TIP_ALM").Visible = False
                    .Columns("PRE_TOTAL").FormatString = "$#,##0.00"
                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC USPSET_DOCUM_DET_GUIA"
            strSQL &= vbNewLine & String.Format(" @OPCION       =  {0} ", 4)
            strSQL &= vbNewLine & String.Format(",@NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                CARGA_GRID()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnRevertir_Click(sender As Object, e As EventArgs) Handles BtnRevertir.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC USPSET_DOCUM_DET_GUIA"
            strSQL &= vbNewLine & String.Format(" @OPCION       =  {0} ", 3)
            strSQL &= vbNewLine & String.Format(",@NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                CARGA_GRID()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub GrdDatos_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles GrdDatos.CellUpdated
        Try
            If IsNumeric(GrdDatos.GetValue(GrdDatos.RootTable.Columns("PRE_TOTAL").Index)) = False Then
                Exit Sub
            End If

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC USPSET_DOCUM_DET_GUIA"
            strSQL &= vbNewLine & String.Format(" @OPCION       =  {0} ", 2)
            strSQL &= vbNewLine & String.Format(",@NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@SECUENCIA_DET=  {0} ", GrdDatos.GetValue(GrdDatos.RootTable.Columns("SECUENCIA_DET").Index))
            strSQL &= vbNewLine & String.Format(",@PRE_TOTAL    = '{0}'", GrdDatos.GetValue(GrdDatos.RootTable.Columns("PRE_TOTAL").Index))

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                CARGA_GRID()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class