Public Class FrmGuiasAsociadas_CortePrendas_Modificar
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public vCod_Fabrica As String
    Public oParent As Object

    Private Sub FrmGuiasAsociadas_CortePrendas_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = TxtSoles
    End Sub

    Private Sub TxtSoles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSoles.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtDolares.Focus()
        Else
            ValidarSoloDecimales(TxtSoles.Text, e)
        End If
    End Sub

    Private Sub TxtDolares_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDolares.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        Else
            ValidarSoloDecimales(TxtDolares.Text, e)
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try

            If Trim(TxtSoles.Text) = "" Then TxtSoles.Text = 0
            If Trim(TxtDolares.Text) = "" Then TxtDolares.Text = 0

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CF_MAN_ACTUALIZA_IMPORTES_ORDPRO_CORTE_PRENDAS"
            strSQL &= vbNewLine & String.Format(" @COD_FABRICA          = '{0}'", vCod_Fabrica)
            strSQL &= vbNewLine & String.Format(",@COD_ORDPRO           = '{0}'", TxtOP.Text)
            strSQL &= vbNewLine & String.Format(",@NUM_SECORD           = '{0}'", TxtSEc.Text)
            strSQL &= vbNewLine & String.Format(",@PImp_Factura_Soles   = '{0}'", CDbl(TxtSoles.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_Factura_Dolares  = '{0}'", CDbl(TxtDolares.Text))

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