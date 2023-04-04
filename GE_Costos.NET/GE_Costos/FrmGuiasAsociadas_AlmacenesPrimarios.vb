Imports Janus.Windows.GridEX

Public Class FrmGuiasAsociadas_AlmacenesPrimarios
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private sVerVIGENTES As String
    Private i As Long

    Public vnum_corre As String
    Public vCod_Anexo As String
    Public vCod_TipAnexo As String
    Public vCod_AnexoAsociado As String
    Public iNro_Servicio As String

    Public vPrevio As String
    Public vNum_Impor As String
    Public sNumLiqServ As String
    Public oParent As Object

    Private Sub FrmGuiasAsociadas_AlmacenesPrimarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
        Panel6.BackColor = colEmpresa
        Panel8.BackColor = colEmpresa
        Panel10.BackColor = colEmpresa

        'sSeguridad = get_botones1(Me, vper, vemp, Me.Name)
        sVerVIGENTES = "0"

        Fa_Lectura_Electronica.Visible = True
        Me.ActiveControl = TxtBarra
    End Sub

    Sub CARGA_CABECERA()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC SM_MUESTRA_GUIAS_DE_FACTURA"
            strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@Previo       = '{0}'", vPrevio)

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

                    .Columns("cod_almacen").Visible = False
                    .Columns("TOTAL_PRENDAS").Visible = False
                    .Columns("TOTAL_VALORIZ").Visible = False
                    .Columns("TOTAL_DOCUM").Visible = False
                    .Columns("TOTAL_VALORIZADO_OTRO").Visible = False
                    .Columns("TOTAL_DOCUM_OTRO").Visible = False
                    .Columns("CODMONEDA").Visible = False
                    .Columns("Almacen").Width = 180
                    .Columns("Guia").Width = 90
                    .Columns("MOVIMIENTO").Width = 50
                    .Columns("MOVIMIENTO").Caption = "MOV"
                    .Columns("FEC.MOV.").FormatString = "dd/MM/yyyy"
                    .Columns("TIPO").Width = 40
                    .Columns("OBSERVACIONES").Width = 50
                    .Columns("O/C").Width = 85
                    .Columns("NUM_IMPORTACION_ASOCIADA").Width = 50
                    .Columns("CORRELATIVO_ASIGNACION_GUIAS").Width = 50
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

                    txtTotalCantidades.Text = dr("TOTAL_PRENDAS")

                    If dr("codmoneda") = "USD" Then
                        LblMontoDol.Text = CDbl(dr("TOTAL_VALORIZ"))
                        LblFacturaDol.Text = CDbl(dr("TOTAL_DOCUM"))
                        LblMonto.Text = CDbl(dr("TOTAL_VALORIZADO_OTRO"))
                        LblFacturaSol.Text = CDbl(dr("TOTAL_DOCUM_OTRO"))
                    Else
                        LblMontoDol.Text = CDbl(dr("TOTAL_VALORIZADO_OTRO"))
                        LblFacturaDol.Text = CDbl(dr("TOTAL_DOCUM_OTRO"))
                        LblMonto.Text = CDbl(dr("TOTAL_VALORIZ"))
                        LblFacturaSol.Text = CDbl(dr("TOTAL_DOCUM"))
                    End If

                    CARGA_DETALLE(dr("cod_almacen"), dr("Movimiento"), dr("Tipo"))
                End If
            End If
        End If
    End Sub

    Sub CARGA_DETALLE(ByVal AlmacenSel As String, ByVal MovimientoSel As String, ByVal TipoSel As String)
        Try
            If Trim(AlmacenSel) <> "" Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC SM_MUESTRA_GUIAS_POR_FACTURAR_DETALLE"
                strSQL &= vbNewLine & String.Format(" @COD_ALMACEN  = '{0}'", AlmacenSel)
                strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK   = '{0}'", MovimientoSel)
                strSQL &= vbNewLine & String.Format(",@TIPOALMACEN  = '{0}'", TipoSel)
                strSQL &= vbNewLine & String.Format(",@DETALLADO    = '{0}'", IIf(chkDetallado.Checked = True, "1", "0"))
                strSQL &= vbNewLine & String.Format(",@Previo       = '{0}'", vPrevio)

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
                                .EditType = EditType.NoEdit
                            End With
                        Next

                        .Columns("SECUENCIA").Width = 40
                        .Columns("IMP_FACTURA_DOLARES").Caption = "IMP.VALORIZADO"
                        .Columns("IMP_FACTURA_DOLARES").EditType = EditType.TextBox
                        .Columns("IMP_FACTURA_DOLARES").TextAlignment = TextAlignment.Far
                        '.COLUMNS("P.U.").FORMATSTRING = "##,##0.000"
                        .Columns("P.U.").TextAlignment = TextAlignment.Far
                        .Columns("P.U.").Width = 80
                        .Columns("CANTIDAD").FormatString = "##,##0"
                        .Columns("CANTIDAD").TextAlignment = TextAlignment.Far
                        .Columns("CANTIDAD").Width = 80
                        .Columns("MONEDA").Width = 60
                        .Columns("PEDIDO").Width = 60

                        .Columns("IMP_FACTURA_OTRA_MONEDA").EditType = EditType.TextBox
                        .Columns("IMP_FACTURA_OTRA_MONEDA").TextAlignment = TextAlignment.Far

                        If TipoSel = "2" Then
                            .Columns("IMP_FACTURAADICIONAL1_DOLARES").Caption = "IMP.VALORIZADO ADIC 1"
                            .Columns("IMP_FACTURAADICIONAL2_DOLARES").Caption = "IMP.VALORIZADO ADIC 2"
                            .Columns("IMP_FACTURAADICIONAL2_DOLARES").TextAlignment = TextAlignment.Far
                            .Columns("IMP_FACTURAADICIONAL1_DOLARES").EditType = EditType.TextBox
                            .Columns("IMP_FACTURAADICIONAL2_DOLARES").EditType = EditType.TextBox
                            .Columns("IMP_FACTURAADICIONAL2_DOLARES").TextAlignment = TextAlignment.Far
                        End If

                        For ICOL = 2 To gexDetalle.RootTable.Columns.Count - 1
                            gexDetalle.RootTable.Columns(ICOL).Width = 90
                        Next
                    End With
                End With

                Dim oAGRUPADOR As New Janus.Windows.GridEX.GridEXGroup(gexDetalle.RootTable.Columns("AGRUPADOR"), SortOrder.Ascending)
                oAGRUPADOR.GroupPrefix = ""
                Try
                    gexDetalle.RootTable.Groups.Clear()
                    gexDetalle.RootTable.Groups.Add(oAGRUPADOR)
                Catch ex As Exception

                End Try

                If TipoSel = "2" Then
                    With gexDetalle.RootTable.Columns("CANTIDAD")
                        .AggregateFunction = AggregateFunction.Sum
                        .DefaultGroupPrefix = ""
                        .TotalFormatString = "##,##0"
                    End With
                    With gexDetalle.RootTable.Columns("IMP_FACTURA_Dolares")
                        .AggregateFunction = AggregateFunction.Sum
                        .DefaultGroupPrefix = ""
                    End With
                    With gexDetalle.RootTable.Columns("Imp_FacturaAdicional1_Dolares")
                        .AggregateFunction = AggregateFunction.Sum
                        .DefaultGroupPrefix = ""
                    End With
                    With gexDetalle.RootTable.Columns("Imp_FacturaAdicional2_Dolares")
                        .AggregateFunction = AggregateFunction.Sum
                        .DefaultGroupPrefix = ""
                    End With
                Else
                    With gexDetalle.RootTable.Columns("CANTIDAD")
                        .AggregateFunction = AggregateFunction.Sum
                        .DefaultGroupPrefix = ""
                    End With
                    With gexDetalle.RootTable.Columns("IMP_FACTURA_Dolares")
                        .AggregateFunction = AggregateFunction.Sum
                        .DefaultGroupPrefix = ""
                    End With
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub chkDetallado_Click(sender As Object, e As EventArgs) Handles chkDetallado.Click
        Dim dr As DataRow
        dr = ObtenerDr_DeGridEx(gexCabecera)
        If Not dr Is Nothing Then
            CARGA_DETALLE(dr("cod_almacen"), dr("Movimiento"), dr("Tipo"))
        End If
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "ASIGNAR"
                    famAsignar.Visible = True

                Case "DESASIGNAR"
                    If gexCabecera.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("Esta seguro que desea desasignar el movimiento: " & gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        DESASIGNA()
                    End If

                Case "COMPLETARDATOS"
                    CompletarDatos()

                Case "PRORRATEAR"
                    PRORRATEAR()

                Case "GRABARFOBIMPORTACION"
                    IngresoFOBImportacion()

                Case "LECTELECT"
                    Fa_Lectura_Electronica.Visible = True
                    TxtBarra.Focus()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub PRORRATEAR()
        Try
            Using oPro As New FrmGuiasAsociadas_AlmacenesPrimarios_Prorrateo
                With oPro
                    .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                    .CARGA_GRID()
                    .ShowDialog()
                End With
            End Using
            CARGA_CABECERA()
            CARGA_DETALLE(gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub DESASIGNA()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC UP_DESASIGNA_GUIA_FACTURA"
            strSQL &= vbNewLine & String.Format(" @num_corre        = '{0}'", vnum_corre)
            strSQL &= vbNewLine & String.Format(",@COD_ALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index))
            strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK       = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
            strSQL &= vbNewLine & String.Format(",@TIPOALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index))
            strSQL &= vbNewLine & String.Format(",@cod_usuario      = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@cod_estacion     = '{0}'", ComputerName())
            strSQL &= vbNewLine & String.Format(",@num_importacion  = '{0}'", vNum_Impor)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Proceso realizado satisfactoria...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                CARGA_CABECERA()
            Else
                MessageBox.Show("No se realizó la designación...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub IngresoFOBImportacion()
        Try
            For i = IIf(gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index) = "1", 1, 2) To gexDetalle.RowCount
                gexDetalle.Row = i

                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC UP_ACTUALIZA_FOB_IMPORTACION"
                strSQL &= vbNewLine & String.Format(" @TIPOALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index))
                strSQL &= vbNewLine & String.Format(",@COD_ALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index))
                strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK       = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
                strSQL &= vbNewLine & String.Format(",@NUM_SECUENCIA    = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("SECUENCIA").Index))
                strSQL &= vbNewLine & String.Format(",@Precio_FOB_Importacion  =  {0} ", Val(gexDetalle.GetValue(gexDetalle.RootTable.Columns("PRECIO_FOB_IMPORTACION").Index)))

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then

                Else
                    Exit Sub
                End If
            Next

            CARGA_DETALLE(gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub CompletarDatos()
        Try
            For i = IIf(gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index) = "1", 1, 2) To gexDetalle.RowCount
                gexDetalle.Row = i

                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC UP_ACTUALIZA_CN_DATOSCOMPLGUIA"
                strSQL &= vbNewLine & String.Format(" @TIPOALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index))
                strSQL &= vbNewLine & String.Format(",@COD_ALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index))
                strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK       = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
                strSQL &= vbNewLine & String.Format(",@NUM_SECUENCIA    = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("SECUENCIA").Index))
                strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA  =  {0} ", Val(gexDetalle.GetValue(gexDetalle.RootTable.Columns("IMP_FACTURA_DOLARES").Index)))
                strSQL &= vbNewLine & String.Format(",@NRO_SERVICIO     = '{0}'", iNro_Servicio)
                strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA_USD  =  {0} ", Val(gexDetalle.GetValue(gexDetalle.RootTable.Columns("IMP_FACTURA_otra_moneda").Index)))

                oHP.EjecutaOperacion(strSQL, cCONNECT)

                If gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index) = "2" And chkDetallado.Checked = False Then
                    Exit For
                End If
            Next
            CARGA_CABECERA()
            CARGA_DETALLE(gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index))
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
        Fa_Lectura_Electronica.Visible = False
    End Sub

    Private Sub BtnAceptarAsignar_Click(sender As Object, e As EventArgs) Handles BtnAceptarAsignar.Click
        If optVigente.Checked = True Then
            sVerVIGENTES = "S"
        ElseIf OptAntiguas.Checked = True Then
            sVerVIGENTES = "N"
        End If
        Using oAsig As New FrmGuiasAsociadas_AlmacenesPrimarios_AsigGuias
            With oAsig
                .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                .vnum_corre = Me.vnum_corre
                .vCod_Anexo = Me.vCod_Anexo
                .vCod_TipAnexo = Me.vCod_TipAnexo
                .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                .vVigente = vPrevio
                .vNum_Impor = vNum_Impor
                .vTipo_Documento = oHP.DevuelveDato("select cod_tipdoc from cn_docum where num_corre='" & Me.vnum_corre & "'", cCONNECT)
                .sNumLiqServ = sNumLiqServ
                .Frame1.Text = "Seleccione las Guias a Asignar " & IIf(sNumLiqServ = 0, "", "              Liquidacion de Servicios: " & Trim(sNumLiqServ))
                .CARGA_MOVIMIENTOS(sVerVIGENTES)
                .ShowDialog()
                CARGA_CABECERA()
            End With
        End Using
        famAsignar.Visible = False
    End Sub

    Private Sub BtnCancelarAsignar_Click(sender As Object, e As EventArgs) Handles BtnCancelarAsignar.Click
        famAsignar.Visible = False
        optVigente.Checked = True
    End Sub

    Private Sub BtnAceptarProrrateo_Click(sender As Object, e As EventArgs) Handles BtnAceptarProrrateo.Click
        Try
            For i = 2 To 2
                gexDetalle.Row = i
                If optPrendasVoucher.Checked = True Then
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC UP_ACTUALIZA_CN_DATOSCOMPLGUIA"
                    strSQL &= vbNewLine & String.Format(" @TIPOALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index))
                    strSQL &= vbNewLine & String.Format(",@COD_ALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index))
                    strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK       = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
                    strSQL &= vbNewLine & String.Format(",@NUM_SECUENCIA    = '{0}'", gexDetalle.GetValue(gexDetalle.RootTable.Columns("SECUENCIA").Index))
                    If iNro_Servicio = "1" Then
                        strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA  =  {0} ", Val(gexDetalle.GetValue(gexDetalle.RootTable.Columns("IMP_FACTURA_DOLARES").Index)))
                    End If
                    If iNro_Servicio = "2" Then
                        strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA  =  {0} ", Val(gexDetalle.GetValue(gexDetalle.RootTable.Columns("Imp_FacturaAdicional1_DOLARES").Index)))
                    End If
                    If iNro_Servicio = "3" Then
                        strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA  =  {0} ", Val(gexDetalle.GetValue(gexDetalle.RootTable.Columns("Imp_FacturaAdicional2_DOLARES").Index)))
                    End If
                    If iNro_Servicio = "4" Then
                        strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA  =  {0} ", Val(gexDetalle.GetValue(gexDetalle.RootTable.Columns("Imp_FacturaAdicional2_DOLARES").Index)))
                    End If
                    strSQL &= vbNewLine & String.Format(",@NRO_SERVICIO     = '{0}'", iNro_Servicio)
                Else
                    strSQL &= vbNewLine & "EXEC UP_ACTUALIZA_CN_DATOSCOMPLGUIA_ALLVOUCHER_CORRE"
                    strSQL &= vbNewLine & String.Format(" @TIPOALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index))
                    strSQL &= vbNewLine & String.Format(",@NUM_CORRE      = '{0}'", TxtNroCorrelativo.Text)
                    If iNro_Servicio = "1" Then
                        strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA  =  {0} ", Val(gexDetalle.GetValue(gexDetalle.RootTable.Columns("IMP_FACTURA_DOLARES").Index)))
                    End If
                    If iNro_Servicio = "2" Then
                        strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA  =  {0} ", Val(gexDetalle.GetValue(gexDetalle.RootTable.Columns("Imp_FacturaAdicional1_DOLARES").Index)))
                    End If
                    If iNro_Servicio = "3" Then
                        strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA  =  {0} ", Val(gexDetalle.GetValue(gexDetalle.RootTable.Columns("Imp_FacturaAdicional2_DOLARES").Index)))
                    End If
                    If iNro_Servicio = "4" Then
                        strSQL &= vbNewLine & String.Format(",@IMPORTE_FACTURA  =  {0} ", Val(gexDetalle.GetValue(gexDetalle.RootTable.Columns("Imp_FacturaAdicional2_DOLARES").Index)))
                    End If
                    strSQL &= vbNewLine & String.Format(",@NRO_SERVICIO          = '{0}'", iNro_Servicio)
                    strSQL &= vbNewLine & String.Format(",@COD_ALMACENORIG       = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index))
                End If
                oHP.EjecutaOperacion(strSQL, cCONNECT)
            Next
            Me.fraProrrateo.Visible = False

            CARGA_CABECERA()
            CARGA_DETALLE(gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCancelarProrrateo_Click(sender As Object, e As EventArgs) Handles BtnCancelarProrrateo.Click
        Me.fraProrrateo.Visible = False
    End Sub

    Sub ActivaLecturaBarra()
        TxtBarra.Text = ""
        Fa_Lectura_Electronica.Visible = True
        Call DatoBarra()
    End Sub

    Public Sub LecturaElectronica()
        'Load Frm_LectElect
        'Frm_LectElect.oParent = Me
        'With Frm_LectElect
        '    .vnum_corre = Me.vnum_corre
        '    .txtcodigo.Text = ""
        '    .Show 1
        'End With
    End Sub

    Private Sub gexDetalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles gexDetalle.EditingCell
        If gexCabecera.GetValue(gexCabecera.RootTable.Columns("Tipo").Index) = "1" Then
            If e.Column.Index <> gexDetalle.RootTable.Columns("IMP_FACTURA_DOLARES").Index And e.Column.Index <> gexDetalle.RootTable.Columns("PRECIO_FOB_IMPORTACION").Index And e.Column.Index <> gexDetalle.RootTable.Columns("IMP_FACTURA_OTRA_MONEDA").Index Then
                e.Cancel = True
            Else
                iNro_Servicio = "1"
            End If
        Else
            If e.Column.Index <> gexDetalle.RootTable.Columns("IMP_FACTURA_DOLARES").Index And e.Column.Index <> gexDetalle.RootTable.Columns("IMP_FACTURA_OTRA_MONEDA").Index And e.Column.Index <> gexDetalle.RootTable.Columns("Imp_FacturaAdicional1_DOLARES").Index And e.Column.Index <> gexDetalle.RootTable.Columns("Imp_FacturaAdicional2_DOLARES").Index Then
                e.Cancel = True
            Else
                If e.Column.Index = gexDetalle.RootTable.Columns("IMP_FACTURA_DOLARES").Index Then
                    iNro_Servicio = "1"
                End If

                If e.Column.Index = gexDetalle.RootTable.Columns("Imp_FacturaAdicional1_DOLARES").Index Then
                    iNro_Servicio = "2"
                End If

                If e.Column.Index = gexDetalle.RootTable.Columns("Imp_FacturaAdicional2_DOLARES").Index Then
                    iNro_Servicio = "3"
                End If

                If e.Column.Index = gexDetalle.RootTable.Columns("IMP_FACTURA_OTRA_MONEDA").Index Then
                    iNro_Servicio = "4"
                End If

            End If
        End If
    End Sub
End Class