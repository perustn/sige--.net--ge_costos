Public Class FrmMantAnexosContables_EmailPagos
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo, Descripcion, TipoAdd, TipoAdd2, TipoAdd3, TipoAdd4 As String

    Public TipoAnexo As String

    Private Sub FrmMantAnexosContables_EmailPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))

        Panel1.BackColor = colEmpresa
        Panel5.BackColor = colEmpresa
    End Sub

    Private Sub TxtMail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMail.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtContacto.Focus()
        End If
    End Sub

    Private Sub TxtContacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContacto.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Cn_Modifica_Anexos_Email_Notificacion"
            strSQL &= vbNewLine & String.Format(" @Cod_TipAnex              = '{0}'", TipoAnexo)
            strSQL &= vbNewLine & String.Format(",@Cod_Anxo                 = '{0}'", TxtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@E_mail_comunicacion_pago = '{0}'", Trim(TxtMail.Text))
            strSQL &= vbNewLine & String.Format(",@Contacto_Pago            = '{0}'", Trim(TxtContacto.Text))
            strSQL &= vbNewLine & String.Format(",@flg_suspension_email     = '{0}'", IIf(ChkSuspension.Checked = True, "S", "N"))
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