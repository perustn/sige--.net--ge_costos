Public Class FrmMantAnexosContables_Certificado_Mant
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Public sAccion As String
    Public sID As String
    Public oParent As Object

    Private Sub FrmMantAnexosContables_Certificado_Mant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel5.BackColor = colEmpresa

        If sAccion = "I" Then
            Me.ActiveControl = txt_TipAnexo
        Else
            Me.ActiveControl = txt_NumeroConstancia
        End If
    End Sub

    Private Sub txt_TipAnexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TipAnexo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txt_CodAnexo.Focus()
        End If
    End Sub

    Private Sub txt_CodAnexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CodAnexo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Busca_Anexo(1)
            If txt_DesAnexo.Text = "" Then
                txt_DesAnexo.Focus()
                Exit Sub
            Else
                txt_DesAnexo.Focus()
            End If
        End If
    End Sub

    Private Sub txt_DesAnexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_DesAnexo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Busca_Anexo(2)
            If txt_DesAnexo.Text = "" Then
                txt_DesAnexo.Focus()
                Exit Sub
            Else
                txt_Ano.Focus()
            End If
        End If
    End Sub

    Sub Busca_Anexo(Tipo As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        If Tipo = 1 Then
            oTipo.sQuery = "SELECT Cod_TipAnEX TIPO, Cod_Anxo CODIGO, Des_Anexo DESCRIPCION FROM dbo.CN_AnexosContables WHERE Cod_TipAnEX ='" & Trim(txt_TipAnexo.Text) & "' and Cod_Anxo like '" & Trim(txt_CodAnexo.Text) & "%'"
        ElseIf Tipo = 2 Then
            oTipo.sQuery = "SELECT Cod_TipAnEX TIPO, Cod_Anxo CODIGO, Des_Anexo DESCRIPCION FROM dbo.CN_AnexosContables WHERE Des_Anexo like '%" & Trim(txt_DesAnexo.Text) & "%'"
        End If
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Tipo")
            Descripcion = oTipo.dtResultados.Rows(0)("CODIGO")
            TipoAdd = oTipo.dtResultados.Rows(0)("DESCRIPCION")
        End If

        If Codigo <> "" Then
            txt_TipAnexo.Text = Trim(Codigo)
            txt_CodAnexo.Text = Trim(Descripcion)
            txt_DesAnexo.Text = Trim(TipoAdd)
            txt_Ano.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txt_Ano_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Ano.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txt_NumeroConstancia.Focus()
        Else
            SoloNumeros(e)
        End If
    End Sub

    Private Sub txt_NumeroConstancia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NumeroConstancia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MAN_CERTIFICADO_CUARTA_CATEGORIA"
            strSQL &= vbNewLine & String.Format(" @ACCION            = '{0}'", sAccion)
            strSQL &= vbNewLine & String.Format(",@Cod_TipAnex       = '{0}'", Trim(txt_TipAnexo.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Anxo          = '{0}'", Trim(txt_CodAnexo.Text))
            strSQL &= vbNewLine & String.Format(",@Ano               = '{0}'", Trim(txt_Ano.Text))
            strSQL &= vbNewLine & String.Format(",@Num_Constancia_Suspension  = '{0}'", Trim(txt_NumeroConstancia.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Usuario_Creacion       = '{0}'", vusu)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                If sAccion = "I" Then
                    MessageBox.Show("Nuevo registro guardado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    oParent.txt_TipAnexo.Text = Trim(txt_TipAnexo.Text)
                    oParent.txt_CodAnexo.Text = Trim(txt_CodAnexo.Text)
                    oParent.txt_Ano.Text = Trim(txt_Ano.Text)
                    oParent.OptAnexo.Checked = True
                Else
                    MessageBox.Show("Registro modificado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

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