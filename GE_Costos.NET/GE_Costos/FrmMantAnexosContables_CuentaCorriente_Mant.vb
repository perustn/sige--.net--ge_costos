Public Class FrmMantAnexosContables_CuentaCorriente_Mant
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Public sAccion As String
    Public TipoAnexo As String

    Private Sub FrmMantAnexosContables_CuentaCorriente_Mant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel5.BackColor = colEmpresa

        If txtBanco_Cod.Enabled = True Then
            Me.ActiveControl = txtBanco_Cod
        Else
            Me.ActiveControl = TxtCodCtaCte
        End If
    End Sub

    Private Sub txtBanco_Cod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBanco_Cod.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_Banco", "Nom_Banco", " TG_Banco Where Flg_Operativo = '*' and ", txtBanco_Cod, txtBanco_Des, 1, Me)
        End If
    End Sub

    Private Sub txtBanco_Des_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBanco_Des.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_Banco", "Nom_Banco", " TG_Banco Where Flg_Operativo = '*' and ", txtBanco_Cod, txtBanco_Des, 2, Me)
        End If
    End Sub

    Public Sub Busca_Opcion(strCampo1 As String, strCampo2 As String, StrTabla As String, txtCod As TextBox, txtDes As TextBox, opcion As Integer, frmME As Form)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "Select " & strCampo1 & " AS Cod," & strCampo2 & " as Descripcion from " & StrTabla
        Select Case opcion
            Case 1 : oTipo.sQuery = strSQL & strCampo1 & " like '%" & txtCod.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & strCampo2 & " like '%" & txtDes.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Cod")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            txtCod.Text = Trim(Codigo)
            txtDes.Text = Trim(Descripcion)
            txtCuenta_Cod.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub txtCuenta_Cod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta_Cod.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCuenta_Cod.Text = Strings.Format(txtCuenta_Cod.Text, "000")
            Call Busca_Opcion_Cuenta("Sec_Cuenta_Banco", "cod_cuenta", "Tg_Bancos_Cuentas where Cod_Banco ='" & txtBanco_Cod.Text & "' and ", txtCuenta_Cod, txtCuenta_Des, 1, Me)
        End If
    End Sub

    Private Sub txtCuenta_Des_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta_Des.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion_Cuenta("Sec_Cuenta_Banco", "cod_cuenta", "Tg_Bancos_Cuentas where Cod_Banco ='" & txtBanco_Cod.Text & "' and ", txtCuenta_Cod, txtCuenta_Des, 2, Me)
        End If
    End Sub

    Public Sub Busca_Opcion_Cuenta(strCampo1 As String, strCampo2 As String, StrTabla As String, txtCod As TextBox, txtDes As TextBox, opcion As Integer, frmME As Form)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "select Cod = Sec_Cuenta_Banco, Descripcion = Cod_Moneda + '-' + Cod_Cuenta from " & StrTabla
        Select Case opcion
            Case 1 : oTipo.sQuery = strSQL & strCampo1 & " like '%" & txtCod.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & strCampo2 & " like '%" & txtDes.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Cod")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            txtCod.Text = Trim(Codigo)
            txtDes.Text = Trim(Descripcion)
            TxtCodCtaCte.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub TxtCodCtaCte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodCtaCte.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtTipCtaCte.Focus()
        End If
    End Sub

    Private Sub txtTipCtaCte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipCtaCte.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCA_TIPCUENTA("1")
        End If
    End Sub

    Private Sub TxtDesTipCtaCte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDesTipCtaCte.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCA_TIPCUENTA("1")
        End If
    End Sub

    Sub BUSCA_TIPCUENTA(Tipo As String)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        If Tipo = "1" Then
            oTipo.sQuery = "select Cod_TipCuenta as Codigo ,Des_TipCuenta as Descripcion from CN_TIPO_CUENTA "
        Else
            oTipo.sQuery = "select Cod_TipCuenta as Codigo ,Des_TipCuenta as Descripcion from CN_TIPO_CUENTA "
        End If
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            txtTipCtaCte.Text = Trim(Codigo)
            TxtDesTipCtaCte.Text = Trim(Descripcion)
            BtnAceptar.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_UP_MAN_CTA_CORRIENTE"
            strSQL &= vbNewLine & String.Format(" @ACCION            = '{0}'", sAccion)
            strSQL &= vbNewLine & String.Format(",@Cod_TipAnex       = '{0}'", TipoAnexo)
            strSQL &= vbNewLine & String.Format(",@COD_ANXO          = '{0}'", TxtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@COD_BANCO         = '{0}'", txtBanco_Cod.Text)
            strSQL &= vbNewLine & String.Format(",@SEC_CUENTA_BANCO  = '{0}'", txtCuenta_Cod.Text)
            strSQL &= vbNewLine & String.Format(",@COD_CUENTA        = '{0}'", TxtCodCtaCte.Text)
            strSQL &= vbNewLine & String.Format(",@COD_TIPCUENTA     = '{0}'", txtTipCtaCte.Text)

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