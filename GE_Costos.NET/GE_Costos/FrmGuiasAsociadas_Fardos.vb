Imports Janus.Windows.GridEX

Public Class FrmGuiasAsociadas_Fardos
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

    Private Sub FrmGuiasAsociadas_Fardos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
        Panel6.BackColor = colEmpresa

        'sSeguridad = get_botones1(Me, vper, vemp, Me.Name)
        Fa_Lectura_Electronica.Visible = True
        'Me.ActiveControl = TxtBarra
    End Sub

    Sub CARGA_CABECERA()
        Try
            If opcion = 1 Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC SM_MUESTRA_GUIAS_DE_FACTURA_FARDOS"
                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)
            Else
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC SM_MUESTRA_GUIAS_DE_FACTURA_TX_MOVISTK_TELA_TENIDA"
                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)
            End If

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

                    If opcion = 1 Then

                    Else
                        .Columns("TOTAL_VALORIZ").Visible = False
                        .Columns("TOTAL_DOCUM").Visible = False
                        .Columns("TOTAL_VALORIZ_SOLES").Visible = False
                        .Columns("TOTAL_DOCUM_SOLES").Visible = False
                        .Columns("Total_Rollos").Visible = False
                    End If

                    '.Columns("unidades").Width = 90
                    '.Columns("Guia").Width = 120
                    '.Columns("cod_almacen").Visible = False
                    '.Columns("TOTAL_PRENDAS").Visible = False
                    '.Columns("CODMONEDA").Visible = False
                    '.Columns("Almacen").Width = 180
                    '.Columns("Guia").Width = 90
                    '.Columns("MOVIMIENTO").Width = 50
                    '.Columns("MOVIMIENTO").Caption = "MOV"
                    '.Columns("FEC.MOV.").FormatString = "dd/MM/yyyy"
                    '.Columns("TIPO").Width = 40
                    '.Columns("OBSERVACIONES").Width = 50
                    '.Columns("O/C").Width = 85
                    '.Columns("NUM_IMPORTACION_ASOCIADA").Width = 50
                    '.Columns("CORRELATIVO_ASIGNACION_GUIAS").Width = 50
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
                    If opcion = 1 Then
                        If dr("TOTAL_FARDOS") = "" Then
                            txtTotalCantidades.Text = 0
                        Else
                            txtTotalCantidades.Text = dr("TOTAL_FARDOS")
                        End If
                    Else
                        If dr("TOTAL_ROLLOS") = "" Then
                            txtTotalCantidades.Text = 0
                        Else
                            txtTotalCantidades.Text = dr("TOTAL_ROLLOS")
                        End If
                        LblMontoDol.Text = CDbl(dr("TOTAL_VALORIZ"))
                        LblFacturaDol.Text = CDbl(dr("TOTAL_DOCUM"))
                        LblMonto.Text = CDbl(dr("TOTAL_VALORIZ_SOLES"))
                        LblFacturaSol.Text = CDbl(dr("TOTAL_DOCUM_SOLES"))
                    End If

                    CARGA_DETALLE(dr("cod_almacen"), dr("Movimiento"))
                End If
            End If
        End If
    End Sub

    Sub CARGA_DETALLE(ByVal AlmacenSel As String, ByVal MovimientoSel As String)
        Try
            If Trim(AlmacenSel) <> "" Then

                If opcion = 1 Then
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC SM_MUESTRA_GUIAS_POR_FACTURAR_DETALLE_FARDOS"
                    strSQL &= vbNewLine & String.Format(" @COD_ALMACEN  = '{0}'", AlmacenSel)
                    strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK   = '{0}'", MovimientoSel)
                Else
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC SM_MUESTRA_GUIAS_POR_FACTURAR_DETALLE_TX_MOVISTK_TELA_TENIDA"
                    strSQL &= vbNewLine & String.Format(" @COD_ALMACEN  = '{0}'", AlmacenSel)
                    strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK   = '{0}'", MovimientoSel)
                    strSQL &= vbNewLine & String.Format(",@Detallado    = '{0}'", IIf(chkDetallado.Checked = True, "1", "0"))
                End If

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

                        If opcion = 1 Then
                            .Columns("cod_almacen").Visible = False
                            .Columns("cod_calidad").Visible = False
                            .Columns("Num_corre_lote").Visible = False
                        Else
                            .Columns("cod_almacen").Visible = False
                            .Columns("talla").Width = 80
                            .Columns("moneda").Width = 80
                        End If
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
                    Using oAsig As New FrmGuiasAsociadas_Fardos_AsigGuias
                        With oAsig
                            .Opcion_guias = opcion
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .vCod_Anexo = Me.vCod_Anexo
                            .vCod_TipAnexo = Me.vCod_TipAnexo
                            .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                            .vNum_Impor = vNum_Impor
                            If opcion = 2 Then
                                .Text = "Seleccione las Guias a Asignar " & IIf(sNumLiqServ = 0, "", "              Liquidacion de Servicios: " & Trim(sNumLiqServ))
                            End If
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

                Case "GRABARFOBIMPORTACION"
                    IngresoFOBImportacion()

                Case "COSTO"
                    If gexDetalle.RowCount = 0 Then Exit Sub
                    Using oCosto As New FrmGuiasAsociadas_Fardos_CostoMateria
                        With oCosto
                            .s_calidad = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Cod_calidad").Index)
                            .txt_Proveedor.Text = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Des_Proveedor").Index)
                            .txt_algodon.Text = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Descripcion").Index)
                            .s_loteCorrelativo = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Num_corre_lote").Index)
                            .s_almacen = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Cod_almacen").Index)
                            .TxtMovimiento.Text = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Movimiento").Index)
                            .TxtLote.Text = gexDetalle.GetValue(gexDetalle.RootTable.Columns("cod_lote").Index)
                            .txt_soles.Text = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Costo_Materia_Prima_Soles").Index)
                            .txt_dolares.Text = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Costo_Materia_Prima_Dolares").Index)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_DETALLE(gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
                            End If
                        End With
                    End Using                 

                Case "PRORRATEA"
                    Prorratea()

                Case "BARRA"
                    Fa_Lectura_Electronica.Visible = True
                    TxtBarra.Focus()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub Prorratea()
        Try
            Using oPro As New FrmGuiasAsociadas_AlmacenesPrimarios_Prorrateo
                With oPro
                    .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                    .CARGA_GRID()
                    .ShowDialog()
                End With
            End Using
            CARGA_CABECERA()
            CARGA_DETALLE(gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub DESASIGNA()
        Try
            If opcion = 1 Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC UP_DESASIGNA_GUIA_FACTURA_FARDOS"
                strSQL &= vbNewLine & String.Format(" @num_corre        = '{0}'", vnum_corre)
                strSQL &= vbNewLine & String.Format(",@COD_ALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Cod_almacen").Index))
                strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK       = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
                strSQL &= vbNewLine & String.Format(",@NUM_CORRE_LOTE   = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("Num_corre_lote").Index))
                strSQL &= vbNewLine & String.Format(",@COD_CALIDAD      = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("Cod_calidad").Index))
                strSQL &= vbNewLine & String.Format(",@cod_usuario      = '{0}'", vusu)
                strSQL &= vbNewLine & String.Format(",@cod_estacion     = '{0}'", ComputerName())
            Else
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC UP_DESASIGNA_GUIA_FACTURA_TX_MOVISTK_TELA_TENIDA"
                strSQL &= vbNewLine & String.Format(" @num_corre        = '{0}'", vnum_corre)
                strSQL &= vbNewLine & String.Format(",@COD_ALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Cod_almacen").Index))
                strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK       = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
                strSQL &= vbNewLine & String.Format(",@cod_usuario      = '{0}'", vusu)
                strSQL &= vbNewLine & String.Format(",@cod_estacion     = '{0}'", ComputerName())
                strSQL &= vbNewLine & String.Format(",@num_importacion  = '{0}'", vNum_Impor)
            End If
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

    Sub IngresoFOBImportacion()
        Try
            Dim i As Integer
            For i = 1 To gexDetalle.RowCount
                gexDetalle.Row = i

                If opcion = 1 Then
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC UP_ACTUALIZA_FOB_IMPORTACION_FARDOS"
                    strSQL &= vbNewLine & String.Format(" @COD_ALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Cod_almacen").Index))
                    strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK       = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
                    strSQL &= vbNewLine & String.Format(",@Num_Corre_lote   = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("Num_corre_lote").Index))
                    strSQL &= vbNewLine & String.Format(",@Cod_Calidad      = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("Cod_calidad").Index))
                    strSQL &= vbNewLine & String.Format(",@Precio_FOB_Importacion  = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("PRECIO_FOB_IMPORTACION").Index))
                End If

                If opcion = 2 Then
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC UP_ACTUALIZA_FOB_IMPORTACION_FARDOS_TX_MOVISTK_TELA_TENIDA"
                    strSQL &= vbNewLine & String.Format(" @COD_ALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Cod_almacen").Index))
                    strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK       = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
                    strSQL &= vbNewLine & String.Format(",@Precio_FOB_Importacion  = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("PRECIO_FOB_IMPORTACION").Index))
                    strSQL &= vbNewLine & String.Format(",@Num_Corre_lote   = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("Num_secuencia").Index))
                End If

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then

                Else
                    Exit Sub
                End If
            Next

            CARGA_DETALLE(gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub CompletarDatos()
        Try
            Dim i As Integer
            For i = 1 To gexDetalle.RowCount
                gexDetalle.Row = i

                If opcion = 1 Then
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC UP_ACTUALIZA_CN_DATOSCOMPLGUIA_FARDOS"
                    strSQL &= vbNewLine & String.Format(" @COD_ALMACEN          = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Cod_almacen").Index))
                    strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK           = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
                    strSQL &= vbNewLine & String.Format(",@Num_Corre_lote       = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("Num_corre_lote").Index))
                    strSQL &= vbNewLine & String.Format(",@Cod_Calidad          = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("Cod_calidad").Index))
                    strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA      = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("Imp_Valorizado_Dolares").Index))
                    strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA_SOL  = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("Imp_Valorizado_Soles").Index))
                End If

                If opcion = 2 Then
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC UP_ACTUALIZA_CN_DATOSCOMPLGUIA_FARDOS_TX_MOVISTK_TELA_TENIDA"
                    strSQL &= vbNewLine & String.Format(" @COD_ALMACEN          = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Cod_almacen").Index))
                    strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK           = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
                    strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA      = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("Imp_Valorizado_Dolares").Index))
                    strSQL &= vbNewLine & String.Format(",@Num_Secuencia        = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("Num_secuencia").Index))
                End If
               
                oHP.EjecutaOperacion(strSQL, cCONNECT)
            Next
            CARGA_CABECERA()
            CARGA_DETALLE(gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub TxtBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBarra.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            DatoBarra()
        End If
    End Sub

    Sub DatoBarra()
        If Strings.Len(Me.TxtBarra.Text) = 9 Then
            Call GRABAR_DATOS_BARRA()
            Me.TxtBarra.Text = ""
            If ValidaImportes() = True Then
                If oParent Is Nothing Then
                    Exit Sub
                End If
                oParent.sPaseContanet = 1
                Me.Close()
            End If
        End If
    End Sub

    Private Function ValidaImportes() As Boolean
        ValidaImportes = False
        If LblMontoDol.Text = "0" Or LblFacturaDol.Text = "0" Or LblMonto.Text = "0" Or LblFacturaSol.Text = "0" Then
            Exit Function
        Else
            If LblMontoDol.Text = LblFacturaDol.Text And LblMonto.Text = LblFacturaSol.Text Then
                ValidaImportes = True
                Exit Function
            End If
        End If
        'LblMontoDol
        'LblFacturaDol
        'LblMonto
        'LblFacturaSol
    End Function

    Sub GRABAR_DATOS_BARRA()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC UP_ASIGNA_GUIA_FACTURA_ELECTRONICA_AVIOS_CONFECCION_ITEMS"
            strSQL &= vbNewLine & String.Format(" @codigo       = '{0}'", TxtBarra.Text)
            strSQL &= vbNewLine & String.Format(",@num_corre    = '{0}'", TxtNroCorrelativo.Text)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                CARGA_CABECERA()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        TxtBarra.Text = ""
        Fa_Lectura_Electronica.Visible = False
    End Sub

    Private Sub gexDetalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles gexDetalle.EditingCell
        If opcion = 1 Then
            If e.Column.Index <> gexDetalle.RootTable.Columns("IMP_valorizado_DOLARES").Index And e.Column.Index <> gexDetalle.RootTable.Columns("PRECIO_FOB_IMPORTACION").Index And e.Column.Index <> gexDetalle.RootTable.Columns("Imp_Valorizado_SOLES").Index Then
                e.Cancel = True
            Else
                iNro_Servicio = "1"
            End If
        Else
            If e.Column.Index <> gexDetalle.RootTable.Columns("IMP_valorizado_DOLARES").Index And e.Column.Index <> gexDetalle.RootTable.Columns("PRECIO_FOB_IMPORTACION").Index Then
                e.Cancel = True
            Else
                iNro_Servicio = "1"
            End If
        End If
    End Sub
End Class