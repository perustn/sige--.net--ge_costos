Public Class FrmMantAnexosContables_DatosAdicionales
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo, Descripcion, TipoAdd, TipoAdd2, TipoAdd3, TipoAdd4 As String

    Public TipoAnexo As String

    Dim sBuenContribuyente As String
    Dim sAgenteRetencionIGV As String
    Dim sAgentePercepcion As String
    Dim sConsiderado_Para_Retencion As String
    Dim sEncuentra_Habido As String

    Private Sub FrmMantAnexosContables_DatosAdicionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))

        Panel1.BackColor = colEmpresa
        Panel5.BackColor = colEmpresa
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If optSiBuenContribuyente.Checked = True Then
                sBuenContribuyente = "S"
            Else
                sBuenContribuyente = "N"
            End If


            If optSIAgenteRetencionIGV.Checked = True Then
                sAgenteRetencionIGV = "S"
            Else
                sAgenteRetencionIGV = "N"
            End If

            If optSIAgente_Percepcion.Checked = True Then
                sAgentePercepcion = "S"

            Else
                sAgentePercepcion = "N"
            End If

            If optSIConsiderado_Para_Retencion.Checked = True Then
                sConsiderado_Para_Retencion = "S"
            Else
                sConsiderado_Para_Retencion = "N"
            End If

            If OptSiEncuentra_Habido.Checked = True Then
                sEncuentra_Habido = "S"
            Else
                sEncuentra_Habido = "N"
            End If

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_UP_MAN_DATOS_CONTRIB_ANEXO_CONTABLE"
            strSQL &= vbNewLine & String.Format(" @COD_TIPANEX              = '{0}'", TipoAnexo)
            strSQL &= vbNewLine & String.Format(",@COD_ANXO                 = '{0}'", TxtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@FLG_BUEN_CONTRIBUYENTE   = '{0}'", sBuenContribuyente)
            strSQL &= vbNewLine & String.Format(",@FLG_AGENTE_RETENCION_IGV = '{0}'", sAgenteRetencionIGV)
            strSQL &= vbNewLine & String.Format(",@Flg_Considerado_Para_Retencion    = '{0}'", sConsiderado_Para_Retencion)
            strSQL &= vbNewLine & String.Format(",@FLG_AGENTE_PERCEPCION    = '{0}'", sAgentePercepcion)
            strSQL &= vbNewLine & String.Format(",@FLG_Encuentra_Habido     = '{0}'", sEncuentra_Habido)
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