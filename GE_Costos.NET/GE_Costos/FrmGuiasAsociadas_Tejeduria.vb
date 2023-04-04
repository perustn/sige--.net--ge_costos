Imports Janus.Windows.GridEX

Public Class FrmGuiasAsociadas_Tejeduria
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private sVerVIGENTES As String

    Private Const K_strColCheck As String = "flg"

    Public vCod_TipAnexo As String, vCod_Anexo As String, vCod_AnexoAsociado As String
    Public vCod_Moneda As String, vMoneda As String, vTipo_Cambio As Double
    Public sNumLiqServ As Integer
    Public oParent As Object

    Private Sub FrmGuiasAsociadas_Tejeduria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
        Panel6.BackColor = colEmpresa

        'sSeguridad = get_botones1(Me, vper, vemp, Me.Name)
        Fa_Lectura_Electronica.Visible = True
        TxtBarra.Focus()
    End Sub

    Sub CARGA_CABECERA()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC sm_muestras_guias_asignadas_tejeduria_factura"
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

                    .Columns("SER_GUIA").Width = 100
                    .Columns("NUMERO_GUIA").Width = 140
                    .Columns("COD_ORDTRA").Width = 120
                    .Columns("FEC_MOVSTK").Width = 140
                    .Columns("KGS_RECIBIDOS").Width = 130
                    .Columns("UNI_RECIBIDOS").Width = 130
                    .Columns("IMP_VALORIZADO_SOLES").Width = 140
                    .Columns("IMP_VALORIZADO_DOLARES").Width = 140

                    .Columns("SER_GUIA").Caption = "SERIE GUIA"
                    .Columns("NUMERO_GUIA").Caption = "NUMERO GUIA"
                    .Columns("COD_ORDTRA").Caption = "OT"
                    .Columns("FEC_MOVSTK").Caption = "FECHA"
                    .Columns("KGS_RECIBIDOS").Caption = "KILOS"
                    .Columns("UNI_RECIBIDOS").Caption = "UNIDADES"
                    .Columns("IMP_VALORIZADO_SOLES").Caption = "IMP. SOLES"
                    .Columns("IMP_VALORIZADO_DOLARES").Caption = "IMP. DOLARES"

                    .Columns("TOTAL_VALORIZADO_SOLES").Visible = False
                    .Columns("TOTAL_VALORIZADO_DOLARES").Visible = False
                    .Columns("GRAVABLE_SOLES").Visible = False
                    .Columns("GRAVABLE_DOLARES").Visible = False

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

    Private Sub gexCabecera_SelectionChanged(sender As Object, e As EventArgs) Handles gexCabecera.SelectionChanged
        Call Me.Carga_Datos()
    End Sub

    Public Sub Carga_Datos()
        If Me.gexCabecera.RowCount > 0 Then
            If Me.Visible Or gexCabecera.Row = 1 Then
                Dim dr As DataRow
                dr = ObtenerDr_DeGridEx(gexCabecera)
                If Not dr Is Nothing Then
                    LblMontoDol.Text = CDbl(dr("total_valorizado_dolares"))
                    LblFacturaDol.Text = CDbl(dr("gravable_dolares"))
                    LblMonto.Text = CDbl(dr("total_valorizado_soles"))
                    LblFacturaSol.Text = CDbl(dr("gravable_soles"))
                End If
            End If
        End If
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "ASIGNAR"
                    Using oAsig As New FrmGuiasAsociadas_Tejeduria_AsigGuias
                        With oAsig
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .vCod_TipAnexo = Me.vCod_TipAnexo
                            .vCod_Anexo = Me.vCod_Anexo
                            .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                            .Text = "Seleccione las Guias a Asignar " & IIf(sNumLiqServ = 0, "", "              Liquidacion de Servicios: " & Trim(sNumLiqServ))
                            .CARGA_MOVIMIENTOS()
                            .ShowDialog()
                            CARGA_CABECERA()
                        End With
                    End Using

                Case "DESASIGNAR"
                    If gexCabecera.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("¿Está seguro de desasignar Guia-Factura?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        DESASIGNA()
                    End If

                Case "VALORIZAR"
                    If gexCabecera.RowCount = 0 Then Exit Sub
                    Using oVal As New FrmGuiasAsociadas_Tejeduria_Valorizar
                        With oVal
                            .vnum_corre = TxtNroCorrelativo.Text
                            .vCod_TipAnexo = Me.vCod_TipAnexo
                            .vCod_Anexo = Me.vCod_Anexo
                            .vCod_Moneda = Me.vCod_Moneda
                            .TxtMoneda.Text = Me.vMoneda
                            .TxtTipoCambio.Text = Me.vTipo_Cambio
                            .vTipo_Cambio = Me.vTipo_Cambio
                            .vSer_Guia = gexCabecera.GetValue(gexCabecera.RootTable.Columns("Ser_Guia").Index)
                            .vNumero_Guia = gexCabecera.GetValue(gexCabecera.RootTable.Columns("numero_Guia").Index)
                            .vCod_OrdTra = gexCabecera.GetValue(gexCabecera.RootTable.Columns("cod_ordtra").Index)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_CABECERA()
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
            If gexCabecera.GetCheckedRows.Length Then
                For Each oGridEXRow As GridEXRow In gexCabecera.GetCheckedRows
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC UP_DESASIGNA_TEJEDURIA_GUIA_FACTURA"
                    strSQL &= vbNewLine & String.Format(" @cod_tipanex  = '{0}'", vCod_TipAnexo)
                    strSQL &= vbNewLine & String.Format(",@cod_anxo     = '{0}'", vCod_Anexo)
                    strSQL &= vbNewLine & String.Format(",@Ser_Guia     = '{0}'", oGridEXRow.Cells("Ser_Guia").Value)
                    strSQL &= vbNewLine & String.Format(",@Numero_guia  = '{0}'", oGridEXRow.Cells("Numero_Guia").Value)
                    strSQL &= vbNewLine & String.Format(",@Cod_OrdTra   = '{0}'", oGridEXRow.Cells("Cod_ordtra").Value)
                    oHP.EjecutaOperacion(strSQL, cCONNECT)
                Next
                MessageBox.Show("Proceso ejecutado satisfactoriamente......", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CARGA_CABECERA()
            Else
                MessageBox.Show("Debe Seleccionar Al Menos un Registro", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
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

    Sub SALVAR_DATOS_BARRA(sBarra As String)
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC UP_ASIGNA_TEJEDURIA_GUIA_FACTURA_BARRA"
            strSQL &= vbNewLine & String.Format(" @cod_tipanex      = '{0}'", vCod_TipAnexo)
            strSQL &= vbNewLine & String.Format(",@cod_anxo         = '{0}'", vCod_Anexo)
            strSQL &= vbNewLine & String.Format(",@COD_ANXOASOCIADO = '{0}'", vCod_AnexoAsociado)
            strSQL &= vbNewLine & String.Format(",@NUM_CORRE        = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@Barra            = '{0}'", sBarra)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                CARGA_CABECERA()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Fa_Lectura_Electronica.Visible = False
        TxtBarra.Text = ""
    End Sub
End Class