Imports System.Security.Cryptography
Imports System.Windows.Media.Media3D

Public Class FrmConsolidadosMensualMovConfecciones

    ' César Saavedra Martínez
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private colEmpresa As Color
    Private oHP As New clsHELPER
    Private ds As New DataTable
    Private strSQL As String
    Private rs As New ADODB.Recordset

    Private Tip_Item As String
    Private Tip_Presentacion As String
    Private cod_fabrica_asociada As String
    Private sOpcion As String
    Private lvOpcion As String

    Private Nom_Plantilla As String
    Private sRutaLogo As String

    Private Sub FillAlmacen()
        Try

            strSQL = ""
            strSQL = $"EXEC COSTOS_MUESTRA_LG_ALMACENES '{vusu}'"
            ds = oHP.DevuelveDatos(strSQL, cCONNECT)

            Dim dw As New DataTable
            With dw.Columns
                .Add("codigo")
                .Add("descripcion")
                .Add("combinado")
            End With

            For Each w As DataRow In ds.Rows
                dw.Rows.Add(w.Item(0), w.Item(1), w.Item(0) & " - " & w.Item(1))
            Next

            cmbAlmacenes.DataSource = dw
            cmbAlmacenes.DisplayMember = "combinado"
            cmbAlmacenes.ValueMember = "codigo"

            If cmbAlmacenes.Items.Count > 0 Then
                cmbAlmacenes.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmConsolidadosMensualMovConfecciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        cmbAnioMes.Value = Date.Now
        Call FillAlmacen()
    End Sub

    Private Sub cmbAlmacenes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlmacenes.SelectedIndexChanged
        Try

            strSQL = ""
            strSQL = $"select tip_item from LG_ALMACEN where cod_almacen ='{cmbAlmacenes.SelectedValue}'"
            Tip_Item = oHP.DevuelveDato(strSQL, cCONNECT)

            strSQL = ""
            strSQL = $"select Tip_Presentacion from LG_ALMACEN where cod_almacen ='{cmbAlmacenes.SelectedValue}'"
            Tip_Presentacion = oHP.DevuelveDato(strSQL, cCONNECT)

            strSQL = ""
            strSQL = $"select COD_FABRICA_ASOCIADA from LG_ALMACEN where cod_almacen ='{cmbAlmacenes.SelectedValue}'"
            cod_fabrica_asociada = oHP.DevuelveDato(strSQL, cCONNECT)

            gbDetFam.Visible = (Tip_Item = "T")
            gbOpt.Visible = (Tip_Item = "I")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If rdbSaldoFinal.Checked Then
            Call Reporte_Saldo_Final()
        ElseIf rdbSaldoFinalDetallado.Checked Then
            Call Reporte_Saldo_Final_DETALLADO()
        ElseIf rdbKardexValorizado.Checked Then
            Call Reporte_Kardex_Sunat_New()
        ElseIf rdbKardexFamilia.Checked Then
            Call Reporte_Kardex_Sunat_Familia()
        ElseIf rdbKardexSunatResumido.Checked Then
            Call Reporte_Kardex_Sunat_Resumido()
        ElseIf rdbSinFormato.Checked Then
            Call Reporte_Sunat_Sin_Formato()
        ElseIf rdbFormatoSunat.Checked Then
            Call Reporte_KardexSunatFormato()
        Else
            If Tip_Item = "I" Or Tip_Item = "T" Then
                Call Reporte()
            End If
        End If
    End Sub

#Region "Metodos para exportación"
    Private Sub Reporte_Saldo_Final()
        Try

            strSQL = ""

            '''''ALMACEN  06
            If Tip_Item = "T" And Tip_Presentacion = "C" Then
                strSQL = $"exec costos_lg_almacen_tela_cruda_consolidado_mensual_solo_stocks '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_ItemQyC_saldo_final_06.XLT"
                ''''ALMACEN  07
            ElseIf Tip_Item = "T" And Tip_Presentacion = "T" Then
                strSQL = $"exec costos_lg_almacen_tela_acabada_consolidado_mensual_SOLO_STOCKS '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_ItemQyC_saldo_final_07.XLT"
            ElseIf Tip_Item = "I" Then
                strSQL = $"costos_lg_almacen_items_consolidado_mensual_familias_solo_stocks '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_ItemQyC_saldo_final.XLT"
                '''''ALMACEN  04
            ElseIf Tip_Item = "H" And Tip_Presentacion = "C" Then
                strSQL = $"costos_lg_almacen_hilo_crudo_consolidado_mensual_solo_stocks '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_ItemQyC_saldo_final_04.XLT"
                ''''ALMACEN   05
            ElseIf Tip_Item = "H" And Tip_Presentacion = "T" Then
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_ItemQyC_saldo_final_05.XLT"
            Else
                MessageBox.Show("Consolidado no disponible para Almacén selecionado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ds = oHP.DevuelveDatos(strSQL, cCONNECT, True)
            If ds.Rows.Count = 0 Then
                MessageBox.Show("No se han encontrado datos para la impresión.....", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            rs = ConvertToRecordset(ds)

            If sRutaLogo = "" Then
                sRutaLogo = oHP.DevuelveDato("SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'", cCONNECT)
            End If

            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & Nom_Plantilla)
            oo.Visible = True
            oo.DisplayAlerts = False
            oo.Run("REPORTE", rs, CStr(cmbAlmacenes.Text), cmbAnioMes.Value.Year, cmbAnioMes.Value.Month, "Saldo Final")
            oo.Visible = True
            oo = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reporte_Saldo_Final_DETALLADO()
        Try

            strSQL = ""
            If Tip_Item = "I" Then
                strSQL = $"EXEC costos_lg_almacen_items_consolidado_mensual_familias_solo_stocks_DETALLADO '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_ItemQyC_saldo_final_DETALLADO.XLT"
                ''''ALMACEN  07
            ElseIf Tip_Item = "T" And Tip_Presentacion = "T" Then
                strSQL = $"exec costos_lg_almacen_tela_acabada_consolidado_mensual_SOLO_STOCKS '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_ItemQyC_saldo_final_DETALLADO_T.XLT"
            Else
                MessageBox.Show("Consolidado no disponible para Almacén selecionado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ds = oHP.DevuelveDatos(strSQL, cCONNECT, True)
            If ds.Rows.Count = 0 Then
                MessageBox.Show("No se han encontrado datos para la impresión.....", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            rs = ConvertToRecordset(ds)

            If sRutaLogo = "" Then
                sRutaLogo = oHP.DevuelveDato("SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'", cCONNECT)
            End If

            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & Nom_Plantilla)
            oo.Visible = True
            oo.DisplayAlerts = False
            oo.Run("REPORTE", rs, CStr(cmbAlmacenes.Text), cmbAnioMes.Value.Year, cmbAnioMes.Value.Month, "Saldo Final")
            oo.Visible = True
            oo = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reporte_Kardex_Sunat_New()
        Try

            If cod_fabrica_asociada = "" Then
                MessageBox.Show("Almacén no tiene empresa definida, verifique", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cod_fabrica_asociada <> "001" And cod_fabrica_asociada <> "002" Then
                cod_fabrica_asociada = "001"
            End If

            strSQL = ""
            '''''ALMACEN  06
            If Tip_Item = "T" And Tip_Presentacion = "C" Then
                strSQL = $"exec ct_kardex_mensual_telas_crudas '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','S','N'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_ItemQyC_SUNAT_06.XLT"
                ''''ALMACEN  07
            ElseIf Tip_Item = "T" And Tip_Presentacion = "T" Then
                strSQL = $"exec costos_nuevo_kardex_tela_acabada_07 '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                Nom_Plantilla = "\Rpt_KardexTextil_TelaTenidoNew.xlt"
            ElseIf Tip_Item = "I" Then
                strSQL = $"exec costos_nuevo_kardex_almacenes_avios '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                'NOM_PLANTILLA = "\Rpt_KardexAviosNewFORMATO.xlt"
                Nom_Plantilla = "\Rpt_KardexAviosNew.xltm"

                ''''ALAMCEN  04
            ElseIf Tip_Item = "H" And Tip_Presentacion = "C" Then
                strSQL = $"exec ct_kardex_mensual_hilos_crudos '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','S','N'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_ItemQyC_SUNAT_04.XLT"
                ''''ALMACEN   05
            ElseIf Tip_Item = "H" And Tip_Presentacion = "T" Then
                strSQL = $"exec ct_kardex_mensual_hilos_tenidos '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','S','N'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_ItemQyC_SUNAT_05.XLT"
            Else
                MessageBox.Show("Consolidado no disponible para Almacén selecionado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ds = oHP.DevuelveDatos(strSQL, cCONNECT, True)
            If ds.Rows.Count = 0 Then
                MessageBox.Show("No se han encontrado datos para la impresión.....", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            rs = ConvertToRecordset(ds)

            sRutaLogo = oHP.DevuelveDato("SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') from tg_empresa WHERE cod_fabrica = '" & cod_fabrica_asociada & "'", cCONNECT)

            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & Nom_Plantilla)
            oo.Visible = True
            oo.DisplayAlerts = False
            If (Tip_Item = "T" And Tip_Presentacion = "T") Or Tip_Item = "I" Then
                oo.Run("REPORTE", strSQL, cmbAlmacenes.Text, cmbAnioMes.Value.Year, cmbAnioMes.Value.ToString("MM"), sRutaLogo, cCONNECTVB6)
            Else
                oo.Run("REPORTE", sRutaLogo, rs, CStr(cmbAlmacenes.Text), cmbAnioMes.Value.Year, cmbAnioMes.Value.ToString("MM"))
            End If
            oo.Visible = True
            oo = Nothing

            sRutaLogo = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reporte_Kardex_Sunat_Familia()
        Try

            If Tip_Item = "I" Then
                strSQL = $"exec ct_kardex_mensual_items_avios_familia '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','','S','N'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_ItemQyC_SUNAT_Familia.XLTM"
            Else
                MessageBox.Show("Consolidado no disponible para Almacén selecionado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ds = oHP.DevuelveDatos(strSQL, cCONNECT, True)
            If ds.Rows.Count = 0 Then
                MessageBox.Show("No se han encontrado datos para la impresión.....", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            rs = ConvertToRecordset(ds)

            If sRutaLogo = "" Then
                sRutaLogo = oHP.DevuelveDato("SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'", cCONNECT)
            End If

            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & Nom_Plantilla)
            oo.Visible = True
            oo.DisplayAlerts = False
            oo.Run("REPORTE", sRutaLogo, rs, CStr(cmbAlmacenes.Text), cmbAnioMes.Value.Year, cmbAnioMes.Value.ToString("MM"))
            oo.Visible = True
            oo = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reporte_Kardex_Sunat_Resumido()
        Try

            Dim strSQL1 As String = ""
            Dim rs1 As New ADODB.Recordset

            strSQL = ""
            '''''ALMACEN  06
            If Tip_Item = "T" And Tip_Presentacion = "C" Then
                strSQL = $"exec ct_kardex_mensual_telas_crudas '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','s','N','S','1'"
                strSQL1 = $"exec ct_kardex_mensual_telas_crudas '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','s','N','S','2'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_Tela_Cruda_SUNAT_Familia_resumido.XLTM"
                ''''ALMACEN  07
            ElseIf Tip_Item = "T" And Tip_Presentacion = "T" Then
                strSQL = $"exec ct_kardex_mensual_telas_acabadas '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','s','N','S','1'"
                strSQL1 = $"exec ct_kardex_mensual_telas_acabadas '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','s','N','S','2'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_Tela_Acabada_SUNAT_Familia_resumido.XLTM"
                ''''ALMACEN  01 , 50,51,60,17
            ElseIf Tip_Item = "I" Then
                strSQL = $"exec ct_kardex_mensual_items_avios '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','','s','N','S','1'"
                strSQL1 = $"exec ct_kardex_mensual_items_avios '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','','s','N','S','2'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_Avios_SUNAT_Familia_resumido.XLTM"
                ''''ALAMCEN  04
            ElseIf Tip_Item = "H" And Tip_Presentacion = "C" Then
                strSQL = $"exec ct_kardex_mensual_hilos_crudos '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','s','N','S','1'"
                strSQL1 = $"exec ct_kardex_mensual_hilos_crudos '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','s','N','S','2'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_hILO_CRUDO_SUNAT_Familia_resumido_INKA.XLTM"
                ''''ALMACEN   05
            ElseIf Tip_Item = "H" And Tip_Presentacion = "T" Then
                'NOM_PLANTILLA = "\RptTI_ConsolidadoMensual_ItemQyC_saldo_final_05.XLT"
                strSQL = $"exec ct_kardex_mensual_hilos_tenidos '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','s','N','S','1'"
                strSQL1 = $"exec ct_kardex_mensual_hilos_tenidos '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','s','N','S','2'"
                Nom_Plantilla = "\RptTI_ConsolidadoMensual_hILO_CRUDO_SUNAT_Familia_resumido_INKA.XLTM"
            Else
                MessageBox.Show("Consolidado no disponible para Almacén selecionado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ds = oHP.DevuelveDatos(strSQL, cCONNECT, True)
            If ds.Rows.Count = 0 Then
                MessageBox.Show("No se han encontrado datos para la impresión.....", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            rs = ConvertToRecordset(ds)

            ds = oHP.DevuelveDatos(strSQL1, cCONNECT, True)
            rs1 = ConvertToRecordset(ds)

            If sRutaLogo = "" Then
                sRutaLogo = oHP.DevuelveDato("SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'", cCONNECT)
            End If

            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & Nom_Plantilla)
            oo.Visible = True
            oo.DisplayAlerts = False
            oo.Run("REPORTE", sRutaLogo, rs, rs1, CStr(cmbAlmacenes.Text), cmbAnioMes.Value.Year, cmbAnioMes.Value.ToString("MM"))
            oo.Visible = True
            oo = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reporte_Sunat_Sin_Formato()
        Try

            strSQL = ""
            strSQL = $"exec ct_kardex_mensual_items_avios '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','','s','N','N','1'"

            ds = oHP.DevuelveDatos(strSQL, cCONNECT, True)
            If ds.Rows.Count = 0 Then
                MessageBox.Show("No se han encontrado datos para la impresión.....", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            rs = ConvertToRecordset(ds)

            If sRutaLogo = "" Then
                sRutaLogo = oHP.DevuelveDato("SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'", cCONNECT)
            End If

            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & "\Rpt_Sunat_Sin_Formato.XLT")
            oo.Visible = True
            oo.DisplayAlerts = False
            oo.Run("REPORTE", sRutaLogo, rs, CStr(cmbAlmacenes.Text), cmbAnioMes.Value.Year, cmbAnioMes.Value.ToString("MM"))
            oo.Visible = True
            oo = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reporte_KardexSunatFormato()
        Try

            If cmbAlmacenes.SelectedValue = "01" Then
                strSQL = $"exec costos_nuevo_kardex_almacenes_avios '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                Nom_Plantilla = "\Rpt_KardexAviosNewFORMATO.xlt"
            ElseIf cmbAlmacenes.SelectedValue = "07" Then
                strSQL = $"exec costos_nuevo_kardex_tela_acabada_07_formato '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                Nom_Plantilla = "\Rpt_KardexTextil_TelaTenidoNewFORMATO.xlt"
            Else
                MessageBox.Show("Kardex sólo habilitado para Almacenes 01 y 07", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ds = oHP.DevuelveDatos(strSQL, cCONNECT, True)
            If ds.Rows.Count = 0 Then
                MessageBox.Show("No se han encontrado datos para la impresión.....", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            rs = ConvertToRecordset(ds)

            If sRutaLogo = "" Then
                sRutaLogo = oHP.DevuelveDato("SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'", cCONNECT)
            End If

            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & Nom_Plantilla)
            oo.Visible = True
            oo.DisplayAlerts = False
            oo.Run("REPORTE", strSQL, CStr(cmbAlmacenes.Text), cmbAnioMes.Value.Year, cmbAnioMes.Value.ToString("MM"), sRutaLogo, cCONNECTVB6)
            oo.Visible = True
            oo = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reporte()
        Try

            Dim Cadena As String = ""
            Dim Cadena1 As String = ""

            If rdbKilos.Checked Then
                sOpcion = 0
                lvOpcion = " EN KILOS"
                If Tip_Item = "I" Then lvOpcion = " EN UNIDADES"
            ElseIf rdbSoles.Checked Then
                sOpcion = 1
                lvOpcion = " EN SOLES"
            Else
                sOpcion = 2
                lvOpcion = " EN DOLARES"
            End If

            If Tip_Item = "T" And Tip_Presentacion = "C" Then
                Cadena = $"exec costos_lg_almacen_tela_cruda_confecciones_consolidado_mensual_Tipos_Mov '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                Cadena1 = $"exec costos_lg_almacen_tela_cruda_consolidado_mensual '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'," & Val(sOpcion)
                Nom_Plantilla = "\RptConsolidadoMensualAlmConf.XLT"
            ElseIf Tip_Item = "T" And Tip_Presentacion = "T" Then
                If rdbDetalladoFam.Checked Then
                    Cadena = $"exec costos_lg_almacen_tela_acabada_confecciones_consolidado_mensual_Tipos_Mov '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                    Cadena1 = $"exec costos_lg_almacen_tela_acabada_consolidado_mensual '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'," & Val(sOpcion)
                    Nom_Plantilla = "\RptConsolidadoMensualAlmConfCruda.XLT"
                Else
                    Cadena = $"exec costos_lg_almacen_tela_acabada_confecciones_consolidado_mensual_Tipos_Mov '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                    Cadena1 = $"exec costos_lg_almacen_tela_acabada_consolidado_mensual_Resumen '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'," & Val(sOpcion)
                    Nom_Plantilla = "\RptConsolidadoMensualAlmConfCruda_Resumen.XLT"
                End If
            ElseIf Tip_Item = "I" Then
                If Not rdbDetallado.Checked Then
                    Cadena = $"exec costos_lg_almacen_items_consolidado_mensual_Tipos_Mov '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                    Cadena1 = $"exec costos_lg_almacen_items_consolidado_mensual_familias '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'," & Val(sOpcion) & ",'" & IIf(rdbResumido.Checked, "N", "S") & "'"
                    Nom_Plantilla = "\RptConsolidadoMensualItems.XLT"
                    lvOpcion = lvOpcion & IIf(rdbResumido.Checked, " RESUMIDO", " DETALLADO")
                Else
                    Cadena = $"exec costos_lg_almacen_items_consolidado_mensual_Tipos_Mov_Items '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}','{txtCodFamItem.Text.Trim}'"
                    Cadena1 = $"exec costos_lg_almacen_items_consolidado_mensual '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}',{Val(sOpcion)},'{IIf(rdbResumido.Checked, "N", "S")}','{txtCodFamItem.Text.Trim}'"
                    Nom_Plantilla = "\RptConsolidadoMensualItemsdet.XLT"
                    lvOpcion = lvOpcion & IIf(rdbResumido.Checked, " RESUMIDO", " DETALLADO")
                End If
            ElseIf Tip_Item = "H" And Tip_Presentacion = "C" Then
                Cadena = $"EXEC costos_lg_almacen_hilo_crudo_confecciones_consolidado_mensual_Tipos_Mov '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                Cadena1 = $"EXEC costos_lg_almacen_hilo_crudo_consolidado_mensual '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'," & Val(sOpcion)
                Nom_Plantilla = "\RptConsolidadoMensualAlmHiloCrudo.XLT"
                lvOpcion = lvOpcion & IIf(rdbResumido.Checked, " RESUMIDO", " DETALLADO")
            ElseIf Tip_Item = "H" And Tip_Presentacion = "T" Then
                Cadena = $"EXEC costos_lg_almacen_hilo_tenido_confecciones_consolidado_mensual_Tipos_Mov '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'"
                Cadena1 = $"EXEC costos_lg_almacen_hilo_tenido_consolidado_mensual '{cmbAlmacenes.SelectedValue}','{cmbAnioMes.Value.Year}','{cmbAnioMes.Value.ToString("MM")}'," & Val(sOpcion)
                Nom_Plantilla = "\RptConsolidadoMensualAlmHiloTenido.XLT"
                lvOpcion = lvOpcion & IIf(rdbResumido.Checked, " RESUMIDO", " DETALLADO")
            Else
                MessageBox.Show("Consolidado no disponible para Almacén selecionado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & Nom_Plantilla)
            oo.Visible = True
            oo.DisplayAlerts = False
            If Tip_Item = "I" Then
                oo.Run("REPORTE", Cadena, Cadena1, CStr(cmbAlmacenes.Text), cmbAnioMes.Value.Year, cmbAnioMes.Value.ToString("MM"), cCONNECTVB6, lvOpcion, rdbResumido.Checked)
            Else
                oo.Run("REPORTE", Cadena, Cadena1, CStr(cmbAlmacenes.Text), cmbAnioMes.Value.Year, cmbAnioMes.Value.ToString("MM"), cCONNECTVB6, lvOpcion)
            End If
            oo.Visible = True
            oo = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

End Class