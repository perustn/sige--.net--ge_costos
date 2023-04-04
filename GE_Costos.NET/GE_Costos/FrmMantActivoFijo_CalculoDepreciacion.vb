Public Class FrmMantActivoFijo_CalculoDepreciacion
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo, Descripcion, TipoAdd, TipoAdd2, TipoAdd3, TipoAdd4 As String

    Private Sub FrmMantActivoFijo_CalculoDepreciacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))

        Panel1.BackColor = colEmpresa
        Panel7.BackColor = colEmpresa

        Me.ActiveControl = TxtAno
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
            TxtMes.Text = RellenaDeCerosEnIzquierda(TxtMes.Text, 2)
            BtnAceptar.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            'NO EXISTE SP EN STN
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_Activo_Fijo_Calculador_Depreciacion"
            strSQL &= vbNewLine & String.Format(" @Anio     = '{0}'", Trim(TxtAno.Text))
            strSQL &= vbNewLine & String.Format(",@Mes      = '{0}'", Trim(TxtMes.Text))

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Proceso culminado satisfactoriamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class