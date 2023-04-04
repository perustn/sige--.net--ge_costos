Imports Janus.Windows.GridEX

Public Class FrmGuiasAsociadas_Hilados
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private i As Long
    Public vVigente As String

    Public vnum_corre As String
    Public vCod_Anexo As String
    Public vCod_TipAnexo As String
    Public vCod_AnexoAsociado As String
    Public iNro_Servicio As String

    Public vPrevio As String
    Public vNum_Impor As String
    Public sNumLiqServ As String
    Public oParent As Object

    Private Sub FrmGuiasAsociadas_Hilados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
        Panel6.BackColor = colEmpresa

        'sSeguridad = get_botones1(Me, vper, vemp, Me.Name)
        Fa_Lectura_Electronica.Visible = True
        Me.ActiveControl = TxtBarra
    End Sub

    Sub CARGA_CABECERA()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC HIL_MUESTRA_GUIAS_POR_ASIGNAR"
            strSQL &= vbNewLine & String.Format(" @Cod_TipAnex      = '{0}'", vCod_TipAnexo)
            strSQL &= vbNewLine & String.Format(",@Cod_Anxo         = '{0}'", vCod_Anexo)
            strSQL &= vbNewLine & String.Format(",@Num_Corre        = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_AnxoAsociado = '{0}'", vCod_AnexoAsociado)
            strSQL &= vbNewLine & String.Format(",@Previo           = '{0}'", vVigente)

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

                    .Columns("TOTAL_VALORIZ").Visible = False
                    .Columns("TOTAL_DOCUM").Visible = False
                    .Columns("Almacen").Width = 180
                    .Columns("Guia").Width = 90
                    .Columns("MOVIMIENTO").Width = 50
                    .Columns("MOVIMIENTO").Caption = "MOV"
                    .Columns("Fecha").FormatString = "dd/MM/yyyy"
                    .Columns("cantidad").Width = 70
                    .Columns("Total").Width = 80
                    .Columns("O/C").Width = 85
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
                    Cargar_Cantidad_Total()
                    Cargar_Importe_Total()
                    LblMontoDol.Text = CDbl(dr("TOTAL_VALORIZ"))
                    LblFacturaDol.Text = CDbl(dr("TOTAL_DOCUM"))
                    LblMonto.Text = CDbl(dr("TOTAL_VALORIZ_SOLES"))
                    LblFacturaSol.Text = CDbl(dr("TOTAL_DOCUM_soles"))

                    CARGA_DETALLE(dr("cod_almacen"), dr("Movimiento"))
                End If
            End If
        End If
    End Sub

    Private Sub Cargar_Cantidad_Total()
        Dim IREG As Integer
        Dim sum As Double
        For IREG = 1 To gexCabecera.RowCount
            gexCabecera.Row = IREG
            sum = sum + gexCabecera.GetValue(gexCabecera.RootTable.Columns("Cantidad").Index)
        Next
        TxtCantTotal.Text = sum
    End Sub

    Public Sub Cargar_Importe_Total()
        Dim IREG As Integer
        For IREG = 1 To gexCabecera.RowCount
            gexCabecera.Row = IREG
            strSQL = "EXEC HIL_MUESTRA_DETALLE_GUIAS_POR_ASIGNAR '" & gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index) &
                                                              "','" & gexCabecera.GetValue(gexCabecera.RootTable.Columns("cod_almacen").Index) & _
                                                              "','" & vnum_corre & "'"

            Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
            Dim oDr As DataRow
            If Not oDtResult Is Nothing Then
                If oDtResult.Rows.Count = 0 Then Exit Sub
                oDr = oDtResult.Rows(0)
                TxtImporteTotal.Text = oDr("SUMA")
            End If
        Next
    End Sub

    Sub CARGA_DETALLE(ByVal AlmacenSel As String, ByVal MovimientoSel As String)
        Try
            If Trim(AlmacenSel) <> "" Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC HIL_MUESTRA_DETALLE_GUIAS_POR_ASIGNAR"
                strSQL &= vbNewLine & String.Format(" @Num_Movstk  = '{0}'", MovimientoSel)
                strSQL &= vbNewLine & String.Format(",@COD_ALMACEN   = '{0}'", AlmacenSel)

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

                        .Columns("Descripcion").Width = 150
                        .Columns("U.M.").Width = 50
                        .Columns("Moneda").Width = 90
                        .Columns("Imp Val").Width = 75
                        .Columns("P.U.").TextAlignment = TextAlignment.Far
                        .Columns("P.U.").Width = 80
                    End With
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "ASIGNAR"
                    Using oAsig As New FrmGuiasAsociadas_Hilados_AsigGuias    'frmAsignaGuiasHiladosNew
                        With oAsig
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .vCod_Anexo = Me.vCod_Anexo
                            .vCod_TipAnexo = Me.vCod_TipAnexo
                            .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                            .vVigente = vVigente
                            .vNum_Impor = vNum_Impor
                            .CARGA_MOVIMIENTOS()
                            .ShowDialog()
                            CARGA_CABECERA()
                        End With
                    End Using

                Case "DESASIGNAR"
                    If gexCabecera.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("Esta seguro que desea desasignar el movimiento: " & gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        DESASIGNA()
                    End If

                Case "INGRESOFOBIMPORTACION"
                    Using oPRe As New FrmGuiasAsociadas_Hilados_Precios
                        With oPRe
                            .TxtMovimiento.Text = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Movimiento").Index)
                            .TxtSecuencia.Text = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Num_Secuencia").Index)
                            .txtCod_Moneda.Text = Trim(gexDetalle.GetValue(gexDetalle.RootTable.Columns("Moneda").Index))
                            .txtPre_Tot.Text = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Imp Val").Index)
                            .txtPrecioFob.Text = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Pre_Unit_Fob").Index)
                            .AlmacenSel = gexDetalle.GetValue(gexDetalle.RootTable.Columns("cod_almacen").Index)
                            .Cod_OrdTraSel = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Cod_OrdTra").Index)
                            .Num_kilos_netoSel = gexDetalle.GetValue(gexDetalle.RootTable.Columns("Num_kilos_neto").Index)
                            If .txtCod_Moneda.Text = "SOL" Then
                                .TxtImpOtraMoneda.Text = gexDetalle.GetValue(gexDetalle.RootTable.Columns("imp_factura_dolares").Index)
                            Else
                                .TxtImpOtraMoneda.Text = gexDetalle.GetValue(gexDetalle.RootTable.Columns("imp_factura_soles").Index)
                            End If
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_DETALLE(gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index), gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
                            End If
                        End With
                    End Using

                Case "BARRA"
                    Fa_Lectura_Electronica.Visible = True
                    TxtBarra.Focus()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub DESASIGNA()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC HIL_ASIGNAR_GUIA_FACTURA"
            strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK       = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index))
            strSQL &= vbNewLine & String.Format(",@COD_ALMACEN      = '{0}'", gexCabecera.GetValue(gexCabecera.RootTable.Columns("COD_ALMACEN").Index))
            strSQL &= vbNewLine & String.Format(" @num_corre        = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@Previo           = '{0}'", vVigente)
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

    Private Sub TxtBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBarra.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            DatoBarra()
        End If
    End Sub

    Sub DatoBarra()
        If Strings.Len(Me.TxtBarra.Text) = 9 Then
            Call SALVAR_DATOS_BARRA(Trim(TxtBarra.Text))
            Me.TxtBarra.Text = ""
            If ValidaImportes() = True Then
                If oParent Is Nothing Then
                    Me.Close()
                Else
                    oParent.sPaseContanet = 1
                    Me.Close()
                End If
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

    Sub SALVAR_DATOS_BARRA(vlBarra As String)
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC up_asigna_guia_factura_electronica_Hilados"
            strSQL &= vbNewLine & String.Format(" @codigo       = '{0}'", vlBarra)
            strSQL &= vbNewLine & String.Format(",@num_corre    = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@Previo       = '{0}'", vVigente)
            strSQL &= vbNewLine & String.Format(",@NUM_IMPORTACION    = '{0}'", vNum_Impor)

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

    Private Sub gexDetalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles gexDetalle.EditingCell
        iNro_Servicio = 1
    End Sub
End Class