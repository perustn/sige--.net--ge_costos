Public Class FrmGuiasAsociadas_Fardos_CostoMateria
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public s_almacen As String
    Public s_calidad As String
    Public s_loteCorrelativo As String

    Private Sub FrmGuiasAsociadas_Fardos_CostoMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txt_soles
    End Sub

    Private Sub txt_soles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_soles.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txt_dolares.Focus()
        Else
            ValidarSoloDecimales(txt_soles.Text, e)
        End If
    End Sub

    Private Sub txt_dolares_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dolares.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        Else
            ValidarSoloDecimales(txt_dolares.Text, e)
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC HI_UP_COSTOMATERIAPRIMA"
            strSQL &= vbNewLine & String.Format(" @Cod_Almacen          = '{0}'", s_almacen)
            strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK           = '{0}'", TxtMovimiento.Text)
            strSQL &= vbNewLine & String.Format(",@NUM_CORRE_LOTE       = '{0}'", s_loteCorrelativo)
            strSQL &= vbNewLine & String.Format(",@Cod_Calidad          = '{0}'", s_calidad)
            strSQL &= vbNewLine & String.Format(",@Costo_Materia_Prima_Soles    = '{0}'", CDbl(txt_soles.Text))
            strSQL &= vbNewLine & String.Format(",@Costo_Materia_Prima_Dolares  = '{0}'", CDbl(txt_dolares.Text))

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