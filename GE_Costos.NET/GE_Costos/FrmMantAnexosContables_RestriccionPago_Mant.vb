Public Class FrmMantAnexosContables_RestriccionPago_Mant
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Public sAccion As String
    Public TipoAnexo As String
    Public sec As Integer

    Private Sub FrmMantAnexosContables_RestriccionPago_Mant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel5.BackColor = colEmpresa

        Me.ActiveControl = txtObservacion
    End Sub

    Private Sub txtObservacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservacion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If txtObservacion.Text = "" Then
                MessageBox.Show("Ingrese La Observación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("¿Está usted seguro de realizar la transacción?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC CN_MAN_ANEXOSCONTABLES_PAGO_RESTRINGIDO"
                strSQL &= vbNewLine & String.Format(" @ACCION            = '{0}'", sAccion)
                strSQL &= vbNewLine & String.Format(",@COD_TIPANEX       = '{0}'", TipoAnexo)
                strSQL &= vbNewLine & String.Format(",@COD_ANXO          = '{0}'", TxtCodigo.Text)
                strSQL &= vbNewLine & String.Format(",@SEC               =  {0} ", Val(sec))
                strSQL &= vbNewLine & String.Format(",@COD_USUARIO       = '{0}'", vusu)
                strSQL &= vbNewLine & String.Format(",@OBS_PAGO_RESTRINGIDO        = '{0}'", Trim(txtObservacion.Text))
                strSQL &= vbNewLine & String.Format(",@COD_ESTACION      = '{0}'", ComputerName)

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class