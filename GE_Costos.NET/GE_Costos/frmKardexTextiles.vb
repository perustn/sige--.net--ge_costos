Public Class frmKardexTextiles

    Private Cod_Almacen As String
    Private colEmpresa As Color

    Private strSQL As String
    Private oHP As New clsHELPER
    Private ds As New DataTable

    Private vRutaLogo As String = ""
    Private Ruta As String = ""

    Private Sub ReporteSunat()
        Try

            Dim Cadena As String = ""
            Dim Nom_almacen As String = ""

            strSQL = ""
            strSQL = $"SELECT Ruta_Logo From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '{vemp}'"
            vRutaLogo = oHP.DevuelveDato(strSQL, cCONNECT)

            strSQL = ""
            Cadena = ""

            Dim oo As Object
            oo = CreateObject("excel.application")

            Select Case Cod_Almacen
                Case "20" Or "40"
                    strSQL = $"select nom_almacen from hi_almacen where cod_Almacen = '{Cod_Almacen}'"
                    Nom_almacen = Cod_Almacen & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_Hilado.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_HILADOS_APT '{Cod_Almacen}','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", cCONNECTVB6, Cadena, vRutaLogo, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"))

                Case "30" Or "41"
                    strSQL = $"select nom_almacen from hi_almacen where cod_Almacen = '{Cod_Almacen}'"
                    Nom_almacen = Cod_Almacen & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_Hilado_Color.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_HILADOS_APT_TENIDOS '{Cod_Almacen}','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", cCONNECTVB6, Cadena, vRutaLogo, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"))

                Case "50"
                    strSQL = $"select nom_almacen from tx_almacen where cod_Almacen = '{Cod_Almacen}'"
                    Nom_almacen = Cod_Almacen & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_Tela_Cruda.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_TELA_CRUDA_TEJEDURIA '{Cod_Almacen}','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", cCONNECTVB6, Cadena, vRutaLogo, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"))

                Case "25"
                    strSQL = $"select nom_almacen from tx_almacen where cod_Almacen = '{Cod_Almacen}'"
                    Nom_almacen = Cod_Almacen & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_PreTenido.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_TELA_CRUDA_TINTORERIA '{Cod_Almacen}','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", Cod_Almacen, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"), vRutaLogo, cCONNECTVB6)

                Case "38"
                    strSQL = $"select nom_almacen from tx_almacen where cod_Almacen = '{Cod_Almacen}'"
                    Nom_almacen = Cod_Almacen & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_TelaTenido.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_TELA_ACABADA_TINTORERIA '{Cod_Almacen}','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}','{IIf(chkSoloCMT.Checked, "S", "N")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", Cod_Almacen, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"), vRutaLogo, cCONNECTVB6, IIf(chkSoloCMT.Checked, "S", "N"))

                Case "C-20"
                    strSQL = $"select nom_almacen from tx_almacen where cod_Almacen = '20'"
                    Nom_almacen = "20" & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_Hilado_Crudo_Tinto.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_HILADO_CRUDO_TINTORERIA '20','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", cCONNECTVB6, Cadena, vRutaLogo, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"))

                Case "T-21"
                    strSQL = $"select nom_almacen from tx_almacen where cod_Almacen = '21'"
                    Nom_almacen = "21" & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_Hilado_Tenido_Tinto.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_HILADO_TENIDO_TINTORERIA '21','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", cCONNECTVB6, Cadena, vRutaLogo, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"))
            End Select
            oo.Visible = True
            oo = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reporte()
        Try

            Dim Cadena As String = ""
            Dim Nom_almacen As String = ""

            strSQL = ""
            strSQL = $"SELECT Ruta_Logo From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '{vemp}'"
            vRutaLogo = oHP.DevuelveDato(strSQL, cCONNECT)

            strSQL = ""
            Cadena = ""

            Dim oo As Object
            oo = CreateObject("excel.application")

            Select Case Cod_Almacen
                Case "20" Or "40"
                    strSQL = $"select nom_almacen from hi_almacen where cod_Almacen = '{Cod_Almacen}'"
                    Nom_almacen = Cod_Almacen & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_Hilado.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_HILADOS_APT '{Cod_Almacen}','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", cCONNECTVB6, Cadena, vRutaLogo, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"))

                Case "30" Or "41"
                    strSQL = $"select nom_almacen from hi_almacen where cod_Almacen = '{Cod_Almacen}'"
                    Nom_almacen = Cod_Almacen & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_Hilado_Color.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_HILADOS_APT_TENIDOS '{Cod_Almacen}','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", cCONNECTVB6, Cadena, vRutaLogo, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"))

                Case "50"
                    strSQL = $"select nom_almacen from tx_almacen where cod_Almacen = '{Cod_Almacen}'"
                    Nom_almacen = Cod_Almacen & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_Tela_Cruda.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_TELA_CRUDA_TEJEDURIA '{Cod_Almacen}','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", cCONNECTVB6, Cadena, vRutaLogo, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"))

                Case "25"
                    strSQL = $"select nom_almacen from tx_almacen where cod_Almacen = '{Cod_Almacen}'"
                    Nom_almacen = Cod_Almacen & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_PreTenido.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_TELA_CRUDA_TINTORERIA '{Cod_Almacen}','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", Cod_Almacen, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"), vRutaLogo, cCONNECTVB6)

                Case "38"
                    strSQL = $"select nom_almacen from tx_almacen where cod_Almacen = '{Cod_Almacen}'"
                    Nom_almacen = Cod_Almacen & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_TelaTenido.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_TELA_ACABADA_TINTORERIA '{Cod_Almacen}','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}','{IIf(chkSoloCMT.Checked, "S", "N")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", Cod_Almacen, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"), vRutaLogo, cCONNECTVB6, IIf(chkSoloCMT.Checked, "S", "N"))

                Case "C-20"
                    strSQL = $"select nom_almacen from tx_almacen where cod_Almacen = '20'"
                    Nom_almacen = "20" & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_Hilado_Crudo_Tinto.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_HILADO_CRUDO_TINTORERIA '20','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", cCONNECTVB6, Cadena, vRutaLogo, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"))

                Case "T-21"
                    strSQL = $"select nom_almacen from tx_almacen where cod_Almacen = '21'"
                    Nom_almacen = "21" & "-" & oHP.DevuelveDato(strSQL, cCONNECT)
                    Ruta = vRuta & "\Rpt_KardexTextil_Hilado_Tenido_Tinto.XLT"
                    Cadena = $"Exec COSTOS_KARDEX_MENSUAL_ALMACEN_HILADO_TENIDO_TINTORERIA '21','{dtpAnio.Value.Year}','{dtpMes.Value.ToString("MM")}'"

                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", cCONNECTVB6, Cadena, vRutaLogo, Nom_almacen, dtpAnio.Value.ToString("yyyy"), dtpMes.Value.ToString("MM"))
            End Select
            oo.Visible = True
            oo = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmKardexTextiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cod_Almacen = "20"
        dtpAnio.Value = Date.Now
        dtpMes.Value = Date.Now

        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa

    End Sub

    Private Sub rdbHiladoCrudo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHiladoCrudo.CheckedChanged
        If rdbHiladoCrudo.Checked Then
            Cod_Almacen = "20"
            dtpAnio.Select()
            chkSoloCMT.Visible = False
        End If
    End Sub

    Private Sub rdbHiladoCrudoSaldos_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHiladoCrudoSaldos.CheckedChanged
        If rdbHiladoCrudoSaldos.Checked Then
            Cod_Almacen = "40"
            dtpAnio.Select()
            chkSoloCMT.Visible = False
        End If
    End Sub

    Private Sub rdbHiladoTenido_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHiladoTenido.CheckedChanged
        If rdbHiladoTenido.Checked Then
            Cod_Almacen = "30"
            dtpAnio.Select()
            chkSoloCMT.Visible = False
        End If
    End Sub

    Private Sub rdbHiladoTenidoSaldos_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHiladoTenidoSaldos.CheckedChanged
        If rdbHiladoTenidoSaldos.Checked Then
            Cod_Almacen = "41"
            dtpAnio.Select()
            chkSoloCMT.Visible = False
        End If
    End Sub

    Private Sub rdbHiladoCrudoTintoreria_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHiladoCrudoTintoreria.CheckedChanged
        If rdbHiladoCrudoTintoreria.Checked Then
            Cod_Almacen = "C-20"
            dtpAnio.Select()
            chkSoloCMT.Visible = False
        End If
    End Sub

    Private Sub rdbHiladoTenidoTintoreria_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHiladoTenidoTintoreria.CheckedChanged
        If rdbHiladoTenidoTintoreria.Checked Then
            Cod_Almacen = "T-21"
            dtpAnio.Select()
            chkSoloCMT.Visible = False
        End If
    End Sub

    Private Sub rdbTelaCrudaTejeduria_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTelaCrudaTejeduria.CheckedChanged
        If rdbTelaCrudaTejeduria.Checked Then
            Cod_Almacen = "50"
            dtpAnio.Select()
            chkSoloCMT.Visible = False
        End If
    End Sub

    Private Sub rdbTelaCrudaPreTenido_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTelaCrudaPreTenido.CheckedChanged
        If rdbTelaCrudaPreTenido.Checked Then
            Cod_Almacen = "25"
            dtpAnio.Select()
            chkSoloCMT.Visible = False
        End If
    End Sub

    Private Sub rdbTelaTenida_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTelaTenida.CheckedChanged
        If rdbTelaTenida.Checked Then
            Cod_Almacen = "38"
            chkSoloCMT.Visible = True
            chkSoloCMT.Checked = True
            dtpAnio.Select()
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If chkSunat.Checked Then
            Call ReporteSunat()
        Else
            Call Reporte()
        End If
    End Sub
End Class