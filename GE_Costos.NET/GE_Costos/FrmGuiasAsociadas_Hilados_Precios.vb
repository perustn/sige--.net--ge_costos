Public Class FrmGuiasAsociadas_Hilados_Precios
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public vCod_Moneda As String, vTipo_Cambio As Double
    Public vCod_Anexo As String, vCod_TipAnexo As String
    Public vSer_Guia As String, vNumero_Guia As String, vCod_OrdTra As String
    Public vnum_corre As String

    Public AlmacenSel As String
    Public Cod_OrdTraSel As String
    Public Num_kilos_netoSel As Double

    Private Sub FrmGuiasAsociadas_Fardos_CostoMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtCod_Moneda
    End Sub

    Private Sub txtCod_Moneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Moneda.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If txtCod_Moneda.Text <> "" Then
                Busca_Moneda(1)
            Else
                Busca_Moneda(3)
            End If
        End If
    End Sub

    Private Sub txtDes_Moneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Moneda.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If txtDes_Moneda.Text <> "" Then
                Busca_Moneda(2)
            Else
                Busca_Moneda(3)
            End If
        End If
    End Sub

    Sub Busca_Moneda(Tipo As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        Select Case Tipo
            Case 1 : oTipo.sQuery = "select cod_moneda as Codigo ,nom_moneda as Descripcion from tg_moneda where cod_moneda like '%" & Trim(txtCod_Moneda.Text) & "%' order by 2"
            Case 2 : oTipo.sQuery = "select cod_moneda as Codigo ,nom_moneda as Descripcion from tg_moneda where nom_moneda like '%" & Trim(txtDes_Moneda.Text) & "%' order by 2"
            Case 3 : oTipo.sQuery = "select cod_moneda as Codigo ,nom_moneda as Descripcion from tg_moneda order by 2"
        End Select

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
            If Codigo <> "" Then
                txtCod_Moneda.Text = Trim(Codigo)
                txtDes_Moneda.Text = Trim(Descripcion)
            End If
        Else
            txtCod_Moneda.Text = oTipo.dtResultados.Rows(0)("Codigo")
            txtDes_Moneda.Text = oTipo.dtResultados.Rows(0)("Descripcion")
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        txtPre_Tot.Focus()
        oTipo = Nothing
    End Sub

    Private Sub txtPre_Tot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPre_Tot.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtImpOtraMoneda.Focus()
        Else
            ValidarSoloDecimales(txtPre_Tot.Text, e)
        End If
    End Sub

    Private Sub TxtImpOtraMoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtImpOtraMoneda.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtPrecioFob.Focus()
        Else
            ValidarSoloDecimales(TxtImpOtraMoneda.Text, e)
        End If
    End Sub

    Private Sub txtPrecioFob_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioFob.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        Else
            ValidarSoloDecimales(txtPrecioFob.Text, e)
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try

            If Trim(TxtImpOtraMoneda.Text) = "" Then TxtImpOtraMoneda.Text = 0
            If Trim(txtPre_Tot.Text) = "" Then txtPre_Tot.Text = 0
            If Trim(txtPrecioFob.Text) = "" Then txtPrecioFob.Text = 0

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC HIL_ACTUALIZA_PRECIO_HILADOS"
            strSQL &= vbNewLine & String.Format(" @Num_MovStk       = '{0}'", TxtMovimiento.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_Almacen      = '{0}'", AlmacenSel)
            strSQL &= vbNewLine & String.Format(",@Cod_OrdTra       = '{0}'", Cod_OrdTraSel)
            strSQL &= vbNewLine & String.Format(",@Num_Secuencia    =  {0} ", TxtSecuencia.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_Moneda       = '{0}'", txtCod_Moneda.Text)
            strSQL &= vbNewLine & String.Format(",@Precio_Unitario  =  {0} ", CDbl(txtPre_Tot.Text / Num_kilos_netoSel))
            strSQL &= vbNewLine & String.Format(",@Pre_Unit_Fob     =  {0} ", CDbl(txtPrecioFob.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_Factura_Dolares  =  {0} ", CDbl(txtPre_Tot.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_Factura_Soles1   =  {0} ", CDbl(TxtImpOtraMoneda.Text))

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Proceso culminado satisfactoriamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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