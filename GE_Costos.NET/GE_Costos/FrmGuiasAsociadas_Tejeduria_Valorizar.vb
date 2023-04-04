Public Class FrmGuiasAsociadas_Tejeduria_Valorizar
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public vCod_Moneda As String, vTipo_Cambio As Double
    Public vCod_Anexo As String, vCod_TipAnexo As String
    Public vSer_Guia As String, vNumero_Guia As String, vCod_OrdTra As String
    Public vnum_corre As String

    Private Sub FrmGuiasAsociadas_Fardos_CostoMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        If Trim(UCase(Me.vCod_Moneda)) = "USD" Then
            Me.ActiveControl = TxtDolares
        Else
            Me.ActiveControl = TxtSoles
        End If
    End Sub

    Private Sub TxtDolares_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDolares.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Trim(TxtDolares.Text) <> "" Then
                If Trim(UCase(vCod_Moneda)) = "USD" Then
                    TxtSoles.Text = CDbl(TxtDolares.Text) * vTipo_Cambio
                End If
            End If
            BtnAceptar.Focus()
        Else
            ValidarSoloDecimales(TxtDolares.Text, e)
        End If
    End Sub

    Private Sub TxtSoles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSoles.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Trim(TxtSoles.Text) <> "" Then
                If Trim(UCase(vCod_Moneda)) <> "USD" Then
                    TxtDolares.Text = CDbl(TxtSoles.Text) / vTipo_Cambio
                End If
            End If
            BtnAceptar.Focus()
        Else
            ValidarSoloDecimales(TxtSoles.Text, e)
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try

            If Trim(TxtSoles.Text) = "" Then TxtSoles.Text = 0
            If Trim(TxtDolares.Text) = "" Then TxtDolares.Text = 0

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC UP_VALORIZA_TEJEDURIA_GUIA_FACTURA"
            strSQL &= vbNewLine & String.Format(" @Num_corre            = '{0}'", vnum_corre)
            strSQL &= vbNewLine & String.Format(",@cod_tipanex          = '{0}'", vCod_TipAnexo)
            strSQL &= vbNewLine & String.Format(",@cod_anxo             = '{0}'", vCod_Anexo)
            strSQL &= vbNewLine & String.Format(",@Ser_Guia             = '{0}'", vSer_Guia)
            strSQL &= vbNewLine & String.Format(",@Numero_guia          = '{0}'", vNumero_Guia)
            strSQL &= vbNewLine & String.Format(",@Cod_OrdTra           = '{0}'", vCod_OrdTra)
            strSQL &= vbNewLine & String.Format(",@Imp_valorizado_soles =  {0} ", CDbl(TxtSoles.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_valorizado_dolares  =  {0} ", CDbl(TxtDolares.Text))
            strSQL &= vbNewLine & String.Format(",@precio_unitario      = '{0}'", IIf(Me.chkPU.Checked = True, "S", "N"))
            strSQL &= vbNewLine & String.Format(",@todas_las_guias      = '{0}'", IIf(Me.chkTodasGuias.Checked = True, "S", "N"))

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