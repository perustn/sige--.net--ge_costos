Public Class FrmMantActivoFijo_ModificarFecha
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo, Descripcion, TipoAdd, TipoAdd2, TipoAdd3, TipoAdd4 As String

    Private Sub FrmMantActivoFijo_ModificarFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))

        Panel1.BackColor = colEmpresa
        Panel5.BackColor = colEmpresa

        Me.ActiveControl = dtpFecAdquisicicon
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MAN_FECHAS_ACTIVO_FIJO"
            strSQL &= vbNewLine & String.Format(" @COD_ACTIVO           = '{0}'", TxtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@FECHA_ADQUISICION    = '{0}'", dtpFecAdquisicicon.Value.ToShortDateString)
            strSQL &= vbNewLine & String.Format(",@FEC_INICIO_VIGENCIA  = '{0}'", dtpFecVigencia.Value.ToShortDateString)
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO          = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@COD_ESTACION         = '{0}'", ComputerName)

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