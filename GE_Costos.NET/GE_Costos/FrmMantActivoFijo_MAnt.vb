Public Class FrmMantActivoFijo_MAnt
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public oParent As Object
    Public sAccion As String
    Public sCodActivo As String

    Private Sub FrmMantActivoFijo_MAnt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel5.BackColor = colEmpresa

        Me.ActiveControl = txtDes_Activo
    End Sub

    Private Sub txtDes_Activo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Activo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            dtpFecha.Focus()
        End If
    End Sub

    Private Sub dtpFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFecha.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtCod_CtaCont.Focus()
        End If
    End Sub

    Private Sub TxtCod_CtaCont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_CtaCont.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If RTrim(TxtCod_CtaCont.Text) = "" Then
                BUSCA_CUENTACONTABLE(3, TxtCod_CtaCont, TxtDes_CtaCont)
            Else
                BUSCA_CUENTACONTABLE(1, TxtCod_CtaCont, TxtDes_CtaCont)
            End If
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
                "WHERE substring(Cod_CtaCont,1,2)='33' and  Des_CtaCont LIKE '%" & Trim(Des_Cta.Text) _
                & "%' and ano=dbo.CN_OBTIENE_ANO_VIGENTE_PLAN_CONTABLE() ORDER BY 1"
        End Select
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = strSQL
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
            If Codigo <> "" Then
                Cod_Cta.Text = Trim(Codigo)
                Des_Cta.Text = Trim(Descripcion)
            End If
        Else
            Cod_Cta.Text = oTipo.dtResultados.Rows(0)("Código")
            Des_Cta.Text = oTipo.dtResultados.Rows(0)("Descripción")
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        TxtCodArea.Focus()
        oTipo = Nothing
    End Sub

    Private Sub TxtCodArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodArea.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAREA(1)
        End If
    End Sub

    Private Sub txtDesArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesArea.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAREA(2)
        End If
    End Sub

    Sub BUSCAREA(Opcion As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "SELECT Cod_Area_Produccion as Cod,Descripcion FROM Mant_Areas_Produccion "
        Select Case Opcion
            Case 1 : oTipo.sQuery = strSQL & "where Cod_Area_Produccion like '%" & TxtCodArea.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & "where Descripcion like '%" & txtDesArea.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Cod")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            TxtCodArea.Text = Trim(Codigo)
            txtDesArea.Text = Trim(Descripcion)
            txtCod_Familia.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub txtCod_Familia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Familia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAFAMILIA(1)
        End If
    End Sub

    Private Sub txtDes_Familia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Familia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAFAMILIA(2)
        End If
    End Sub

    Sub BUSCAFAMILIA(Opcion As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "select Cod_Familia_Activo as Cod,Des_Familia_Activo as Descripcion from CN_Familia_Activo_Fijo where Cod_Area_Produccion = '" & TxtCodArea.Text & "'"
        Select Case Opcion
            Case 1 : oTipo.sQuery = strSQL & " and Cod_Familia_Activo  like '%" & txtCod_Familia.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & " and Des_Familia_Activo like '%" & txtDes_Familia.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Cod")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            txtCod_Familia.Text = Trim(Codigo)
            txtDes_Familia.Text = Trim(Descripcion)
            txtCod_Equipo.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub txtCod_Equipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Equipo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtMarca.Focus()
        End If
    End Sub

    Private Sub txtMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarca.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtModelo.Focus()
        End If
    End Sub

    Private Sub txtModelo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtModelo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtSerie.Focus()
        End If
    End Sub

    Private Sub txtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerie.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Txt_centro.Focus()
        End If
    End Sub

    Private Sub Txt_centro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_centro.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCA_CENTROCOSTO(1)
        End If
    End Sub

    Private Sub Txt_Costo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Costo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCA_CENTROCOSTO(2)
        End If
    End Sub

    Sub BUSCA_CENTROCOSTO(Opcion As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "select Cod_CenCosto as Cod,Des_CenCosto as Descripcion from CN_CentroCostos where  ano=dbo.CN_OBTIENE_ANO_VIGENTE_PLAN_CONTABLE() and " '"
        Select Case Opcion
            Case 1 : oTipo.sQuery = strSQL & "  Cod_CenCosto like '%" & RTrim(Txt_centro.Text) & "%'"
            Case 2 : oTipo.sQuery = strSQL & "  Des_CenCosto like '%" & Txt_Costo.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Cod")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            Txt_centro.Text = Trim(Codigo)
            Txt_Costo.Text = Trim(Descripcion)
            txtPotenciaHP.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub txtPotenciaHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPotenciaHP.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtKws.Focus()
        End If
    End Sub

    Private Sub txtKws_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKws.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtVoltios.Focus()
        End If
    End Sub

    Private Sub txtVoltios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVoltios.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtGlosa.Focus()
        End If
    End Sub

    Private Sub TxtGlosa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtGlosa.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_Mante_Activo_Fijo"
            strSQL &= vbNewLine & String.Format(" @Accion               = '{0}'", sAccion)
            strSQL &= vbNewLine & String.Format(",@cod_activo           = '{0}'", sCodActivo)
            strSQL &= vbNewLine & String.Format(",@Des_Activo           = '{0}'", Trim(txtDes_Activo.Text))
            strSQL &= vbNewLine & String.Format(",@Fecha_Adquisicion    = '{0}'", dtpFecha.Value.ToShortDateString)
            strSQL &= vbNewLine & String.Format(",@Cod_CtaCont          = '{0}'", Trim(TxtCod_CtaCont.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Area_Produccion  = '{0}'", Trim(TxtCodArea.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Familia_Activo   = '{0}'", Trim(txtCod_Familia.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Equipo           = '{0}'", Trim(txtCod_Equipo.Text))
            strSQL &= vbNewLine & String.Format(",@Marca                = '{0}'", Trim(txtMarca.Text))
            strSQL &= vbNewLine & String.Format(",@Serie                = '{0}'", Trim(txtSerie.Text))
            strSQL &= vbNewLine & String.Format(",@Modelo               = '{0}'", Trim(txtModelo.Text))
            strSQL &= vbNewLine & String.Format(",@Potencia_HP          = '{0}'", Trim(txtPotenciaHP.Text))
            strSQL &= vbNewLine & String.Format(",@Kws                  = '{0}'", Trim(txtKws.Text))
            strSQL &= vbNewLine & String.Format(",@Voltios              = '{0}'", Trim(txtVoltios.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_CenCost          = '{0}'", Trim(Txt_centro.Text))
            strSQL &= vbNewLine & String.Format(",@Glosa                = '{0}'", Trim(TxtGlosa.Text))

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class