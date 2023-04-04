Public Class FrmMantAnexosContables_EditDetraccion
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo, Descripcion, TipoAdd, TipoAdd2, TipoAdd3, TipoAdd4 As String

    Public TipoAnexo As String

    Private Sub FrmMantAnexosContables_EditDetraccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))

        Panel1.BackColor = colEmpresa
        Panel5.BackColor = colEmpresa

        Me.ActiveControl = TxtCtaCteDetracciones
    End Sub

    Private Sub TxtCtaCteDetracciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCtaCteDetracciones.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_ANEXOS_CONTABLES_ACTUALIZA_CTA_CTE_DETRACCIONES"
            strSQL &= vbNewLine & String.Format(" @COD_TIPANEX              = '{0}'", TipoAnexo)
            strSQL &= vbNewLine & String.Format(",@COD_ANXO                 = '{0}'", TxtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_CtaCte_Detracciones  = '{0}'", TxtCtaCteDetracciones.Text)
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO              = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@COD_ESTACION             = '{0}'", ComputerName)
  
            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("La edición de Cta. Cte. Detracciones se ha realizado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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