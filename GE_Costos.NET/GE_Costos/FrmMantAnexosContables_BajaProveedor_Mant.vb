Public Class FrmMantAnexosContables_BajaProveedor_Mant
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Public sAccion As String
    Public TipoAnexo As String
    Public sec As Integer

    Private Sub FrmMantAnexosContables_BajaProveedor_Mant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel5.BackColor = colEmpresa

        If sAccion = "I" Then
            Me.ActiveControl = txtCodBaja
        Else
            txtCodBaja.Enabled = False
            txtDesBaja.Enabled = False
            Me.ActiveControl = txtObservacion
        End If
    End Sub

    Private Sub txtCodBaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodBaja.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If RTrim(txtCodBaja.Text) = "" Then
                BUSCAMOTIVO(3)
            Else
                BUSCAMOTIVO(1)
            End If
        End If
    End Sub

    Private Sub txtDesBaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesBaja.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAMOTIVO(3)
        End If
    End Sub

    Private Sub BUSCAMOTIVO(Tipo As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        Select Case Tipo
            Case 1
                oTipo.sQuery = "SELECT cod_motivo_baja as 'Código', Des_Motivo_Baja as 'Descripción' " & _
                         "FROM CN_Motivo_Baja_AnexosContables WHERE cod_motivo_baja  like '" & Trim(txtCodBaja.Text) & "%' ORDER BY cod_motivo_baja "
            Case 2, 3
                oTipo.sQuery = "SELECT cod_motivo_baja AS 'Código', " & _
                " Des_Motivo_Baja as 'Descripción' " & _
                "FROM CN_Motivo_Baja_AnexosContables  " & _
                "WHERE Des_Motivo_Baja LIKE '%" & Trim(Me.txtDesBaja.Text) _
                & "%' ORDER BY 2"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Código")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripción")
        End If

        If Codigo <> "" Then
            txtCodBaja.Text = Trim(Codigo)
            txtDesBaja.Text = Trim(Descripcion)
            txtObservacion.Focus()
        End If
        oTipo = Nothing
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

            If txtCodBaja.Text = "" Then
                MessageBox.Show("Ingrese El Motiv", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("¿Está usted seguro de realizar la transacción?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC CN_MAN_ANEXOSCONTABLES_BAJA_ANEXO"
                strSQL &= vbNewLine & String.Format(" @ACCION        = '{0}'", sAccion)
                strSQL &= vbNewLine & String.Format(",@COD_TIPANEX   = '{0}'", TipoAnexo)
                strSQL &= vbNewLine & String.Format(",@COD_ANXO      = '{0}'", TxtCodigo.Text)
                strSQL &= vbNewLine & String.Format(",@SEC           =  {0} ", Val(sec))
                strSQL &= vbNewLine & String.Format(",@COD_USUARIO   = '{0}'", vusu)
                strSQL &= vbNewLine & String.Format(",@COD_MOTIVO_BAJA   = '{0}'", Trim(txtCodBaja.Text))
                strSQL &= vbNewLine & String.Format(",@OBS_BAJA      = '{0}'", Trim(txtObservacion.Text))
                strSQL &= vbNewLine & String.Format(",@COD_ESTACION  = '{0}'", ComputerName())

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