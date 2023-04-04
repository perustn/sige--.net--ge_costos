Public Class FrmMantActivoFijo_ActFijoHistorico
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Dim sCta As String

    Private Sub FrmMantActivoFijo_ActFijoHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel5.BackColor = colEmpresa

        Me.ActiveControl = TxtCod_Moneda
    End Sub

    Private Sub TxtAno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAno.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtMes.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub TxtMes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMes.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtCod_Moneda.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub TxtCod_Moneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_Moneda.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAMONEDA(1)
        End If
    End Sub

    Private Sub TxtDes_Moneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDes_Moneda.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAMONEDA(2)
        End If
    End Sub

    Sub BUSCAMONEDA(Opcion As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "SELECT cod_moneda as Codigo,NOM_MONEDA as Descripcion FROM TG_MONEDA "
        Select Case Opcion
            Case 1 : oTipo.sQuery = strSQL & "where cod_moneda like '%" & TxtCod_Moneda.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & "where NOM_MONEDA like '%" & TxtDes_Moneda.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            TxtCod_Moneda.Text = Trim(Codigo)
            TxtDes_Moneda.Text = Trim(Descripcion)
            TxtCod_CtaCont.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub TxtCod_CtaCont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_CtaCont.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCA_CUENTACONTABLE(1, TxtCod_CtaCont, TxtDes_CtaCont)
        End If
    End Sub

    Private Sub TxtDes_CtaCont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDes_CtaCont.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCA_CUENTACONTABLE(2, TxtCod_CtaCont, TxtDes_CtaCont)
        End If
    End Sub

    Private Sub BUSCA_CUENTACONTABLE(tipo As Integer, ByRef Cod_Cta As TextBox, ByRef Des_Cta As TextBox)
        Select Case tipo
            Case 1
                strSQL = "SELECT Cod_CtaCont as 'Código', Des_CtaCont as 'Descripción' " & _
                            "FROM CN_PlanContable WHERE substring(Cod_CtaCont,1,2)='33' and Cod_CtaCont like '" & Trim(Cod_Cta.Text) & "%' and ano=dbo.CN_OBTIENE_ANO_VIGENTE_PLAN_CONTABLE() ORDER BY Cod_CtaCont "

            Case 2, 3
                strSQL = "SELECT Cod_CtaCont AS 'Código', " & _
                " Des_CtaCont as 'Descripción' " & _
                "FROM CN_PlanContable " & _
                "WHERE Cod_CtaCont like '33%' and  Des_CtaCont LIKE '%" & Trim(Des_Cta.Text) _
                & "%' and ano=dbo.CN_OBTIENE_ANO_VIGENTE_PLAN_CONTABLE() ORDER BY 1"
        End Select

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = strSQL
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            Cod_Cta.Text = Trim(Codigo)
            Des_Cta.Text = Trim(Descripcion)
            TxtCod_Moneda.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCod_Activo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Activo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCA_ACTIVO_FIJO(1, txtCod_Activo, Txt_DesActivo)
        End If
    End Sub

    Private Sub Txt_DesActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_DesActivo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCA_ACTIVO_FIJO(2, txtCod_Activo, Txt_DesActivo)
        End If
    End Sub

    Private Sub BUSCA_ACTIVO_FIJO(tipo As Integer, ByRef Cod_Cta As TextBox, ByRef Des_Cta As TextBox)
        Select Case tipo
            Case 1
                strSQL = " SELECT cod_activo AS 'Codigo', des_activo AS 'Descripcion' " & _
                         "FROM cn_activo_fijo WHERE cod_activo like '%" & Trim(Cod_Cta.Text) & "%' ORDER BY 1 "

            Case 2, 3
                strSQL = "SELECT cod_activo  AS 'Codigo', " & _
                " des_activo as 'Descripcion' " & _
                "FROM cn_activo_fijo " & _
                "WHERE des_activo LIKE '%" & Trim(Des_Cta.Text) _
                & "%' ORDER BY 1"
        End Select

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = strSQL
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            Cod_Cta.Text = Trim(Codigo)
            Des_Cta.Text = Trim(Descripcion)
            TxtCod_Moneda.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub TxtCta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaOCorte1()
        End If
    End Sub

    Sub BuscaOCorte1()
        If TxtCta.Text = "" Then
            TxtCta.Select()
        Else
            If Trim(Len(TxtCta.Text)) < 2 Then
                MessageBox.Show("Ingrese como minimo 2 caracteres", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If lstOps.Items.Count > 20 Then
                MessageBox.Show("Ha llegado el limite de Cta Contable en la lista" & vbNewLine & "puede seguir agregando otra Cta Contable...", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If oHP.DevuelveDato("SELECT COUNT(*) FROM dbo.CN_PlanContable WHERE Cod_CtaCont='" & Trim(TxtCta.Text) & "' and ano=dbo.CN_OBTIENE_ANO_VIGENTE_PLAN_CONTABLE() ", cCONNECT) = 0 Then
                MessageBox.Show("Cta Contable Inválido o Inexistente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtCta.Text = ""
                TxtCta.Select()
                Exit Sub
            Else
                If Not lstOps.Items.Contains(TxtCta.Text) Then
                    lstOps.Items.Add(TxtCta.Text.Trim)
                End If
                TxtCta.Text = ""
                TxtCta.Select()
            End If
        End If
    End Sub

    Private Sub lstOps_DoubleClick(sender As Object, e As EventArgs) Handles lstOps.DoubleClick
        If lstOps.Items.Count > 0 Then
            lstOps.Items.RemoveAt(lstOps.SelectedIndex)
        End If
    End Sub


    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ImprimirReporte()
    End Sub

    Sub lst_Cta()
        Dim I As Integer
        If lstOps.Items.Count <= 0 Then
            MessageBox.Show("Debe Seleccionar " & optRelCta.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        sCta = ""
        For I = 0 To lstOps.Items.Count - 1

            lstOps.SelectedIndex = I
            sCta = sCta & lstOps.Text
            If I <> lstOps.Items.Count - 1 Then
                sCta = sCta & ","
            End If
        Next
    End Sub

    Public Sub ImprimirReporte()
        Dim oo As Object
        Dim rutaLogo As String
        Dim sopcion As String

        rutaLogo = oHP.DevuelveDato("select ruta_logo=isNUll(ruta_logo,'') from seguridad..seg_empresas where cod_empresa='" & vemp & "'", cCONNECT)

        If optCta.Checked = True Then
            sopcion = "1"
        End If

        If optRelCta.Checked = True Then
            sopcion = "2"
        End If

        If optActivo.Checked = True Then
            sopcion = "3"
        End If

        lst_Cta()

        strSQL = " EXEC SM_MUESTRA_CALCULO_DEPRECIACION_ACTIVO_FIJO '" & TxtAno.Text & "','" & TxtMes.Text & "','" & Trim(TxtCod_Moneda.Text) & "','" & sopcion & "','" & Trim(TxtCod_CtaCont.Text) & "','" & sCta & "','" & txtCod_Activo.Text & "'"

        oo = CreateObject("Excel.Application")
        oo.Workbooks.Open(vRuta & "\Rpt_Historico_Activo_Fijo.xlt")
        oo.Visible = True
        oo.DisplayAlerts = False
        oo.Run("Reporte", strSQL, rutaLogo, TxtAno.Text, TxtMes.Text, TxtCod_Moneda, vusu, cCONNECTVB6)
        oo = Nothing
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class