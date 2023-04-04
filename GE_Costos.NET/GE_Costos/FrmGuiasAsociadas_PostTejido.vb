Imports Janus.Windows.GridEX

Public Class FrmGuiasAsociadas_PostTejido
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private sVerVIGENTES As String

    Public opcion As Integer
    Public vnum_corre As String
    Public vCod_Anexo As String
    Public vCod_TipAnexo As String
    Public vCod_AnexoAsociado As String
    Public iNro_Servicio As String

    Public vPrevio As String
    Public vNum_Impor As String
    Public sNumLiqServ As String
    Public oParent As Object

    Private Sub FrmGuiasAsociadas_PreTenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
    End Sub

    Sub CARGA_CABECERA()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Costos_Muestra_Guias_Cabecera_Asignadas"
            strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            gexCabecera.DataSource = oDT
            CheckLayoutGridEx(gexCabecera)

            With gexCabecera
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                With .RootTable
                    .HeaderLines = 1
                    .PreviewRow = False
                    .PreviewRowLines = 10
                    .RowHeight = 20
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("Guia").Width = 90
                    .Columns("Almacen").Width = 120
                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub gexCabecera_SelectionChanged(sender As Object, e As EventArgs) Handles gexCabecera.SelectionChanged
        Call Me.Carga_Datos()
    End Sub

    Public Sub Carga_Datos()
        If Me.gexCabecera.RowCount > 0 Then
            If Me.Visible Or gexCabecera.Row = 1 Then
                Dim dr As DataRow
                dr = ObtenerDr_DeGridEx(gexCabecera)
                If Not dr Is Nothing Then

                    'LblMontoDol.Text = CDbl(dr("TOTAL_VALORIZ"))
                    'LblFacturaDol.Text = CDbl(dr("TOTAL_DOCUM"))
                    'LblMonto.Text = CDbl(dr("TOTAL_VALORIZ_SOLES"))
                    'LblFacturaSol.Text = CDbl(dr("TOTAL_DOCUM_SOLES"))

                    CARGA_DETALLE(dr("cod_almacen"), dr("Movimiento"))
                End If
            End If
        End If
    End Sub

    Sub CARGA_DETALLE(ByVal AlmacenSel As String, ByVal MovimientoSel As String)
        Try
            If Trim(AlmacenSel) <> "" Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC Costos_Muestra_Detalle_Guia_Asignada_Post_Tejido"
                strSQL &= vbNewLine & String.Format(" @COD_ALMACEN  = '{0}'", AlmacenSel)
                strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK   = '{0}'", MovimientoSel)

                oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
                gexDetalle.RootTable.Columns.Clear()
                gexDetalle.DataSource = oDT
                CheckLayoutGridEx(gexDetalle)

                With gexDetalle
                    .FilterMode = FilterMode.None
                    .DefaultFilterRowComparison = FilterConditionOperator.Contains
                    With .RootTable
                        .HeaderLines = 1
                        .PreviewRow = False
                        .PreviewRowLines = 10
                        .RowHeight = 20
                        For Each oGridEXColumn As GridEXColumn In .Columns
                            With oGridEXColumn
                                .WordWrap = True
                                .FilterEditType = FilterEditType.Combo
                                '.EditType = EditType.NoEdit
                            End With
                        Next
                    End With
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub chkDetallado_Click(sender As Object, e As EventArgs) Handles chkDetallado.Click
        Dim dr As DataRow
        dr = ObtenerDr_DeGridEx(gexCabecera)
        If Not dr Is Nothing Then
            CARGA_DETALLE(dr("cod_almacen"), dr("Movimiento"))
        End If
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "ASIGNAR"
                    Using oAsig As New FrmGuiasAsociadas_PostTejido_AsigGuias
                        With oAsig
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .vCod_Anexo = Me.vCod_Anexo
                            .vCod_TipAnexo = Me.vCod_TipAnexo
                            .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                            .CARGA_MOVIMIENTOS()
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_CABECERA()
                            End If
                        End With
                    End Using

                Case "DESASIGNAR"
                    If gexCabecera.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("Esta seguro que desea desasignar el movimiento: " & gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        DESASIGNA()
                    End If

                Case "COMPLETARDATOS"
                    CompletarDatos()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub DESASIGNA()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Costos_DeAsigna_Guias_Post_Tejido_rollo"
            strSQL &= vbNewLine & String.Format(" @num_corre        = '{0}'", vnum_corre)
            strSQL &= vbNewLine & String.Format(",@cod_almacen      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Cod_almacen").Index))
            strSQL &= vbNewLine & String.Format(",@num_movstk       = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Proceso realizado satisfactoria...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                CARGA_CABECERA()
                CARGA_DETALLE(gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
            Else
                MessageBox.Show("No se realizó la designación...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub CompletarDatos()
        Try
            Dim i As Integer
            For i = 1 To gexDetalle.RowCount
                gexDetalle.Row = i

                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC Costos_Valoriza_Movimiento_Post_Tejido_por_Rollos"
                strSQL &= vbNewLine & String.Format(" @cod_almacen          = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Cod_almacen").Index))
                strSQL &= vbNewLine & String.Format(",@num_movstk           = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
                strSQL &= vbNewLine & String.Format(",@cod_ordtra           = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("ot").Index))
                strSQL &= vbNewLine & String.Format(",@kgs_movimiento       = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("kgs_movimiento").Index))
                strSQL &= vbNewLine & String.Format(",@imp_valorizado_soles = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("valorizado_soles").Index))
                strSQL &= vbNewLine & String.Format(",@imp_valorizado_dolares   = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("valorizado_dolares").Index))
                strSQL &= vbNewLine & String.Format(",@num_corre            = '{0}'", TxtNroCorrelativo.Text)

                oHP.EjecutaOperacion(strSQL, cCONNECT)
            Next
            CARGA_CABECERA()
            CARGA_DETALLE(gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub gexDetalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles gexDetalle.EditingCell
        If e.Column.Index <> gexDetalle.RootTable.Columns("valorizado_DOLARES").Index And e.Column.Index <> gexDetalle.RootTable.Columns("valorizado_SOLES").Index Then
            e.Cancel = True
        Else
            iNro_Servicio = "1"
        End If
    End Sub
End Class