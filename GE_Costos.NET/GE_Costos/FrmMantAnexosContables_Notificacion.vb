Imports Janus.Windows.GridEX

Public Class FrmMantAnexosContables_Notificacion
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private OpcionMantenimiento As String
    Private colEmpresa As Color

    Public TipoAnexo As String
    Private IntSecuencia As Integer

    Private Sub FrmMantAnexosContables_Notificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))

        Panel5.BackColor = colEmpresa
        CARGA_GRID()
    End Sub

    Private Sub CARGA_GRID()
        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC Cn_Man_AnexosContales_Notificaciones"
        strSQL &= vbNewLine & String.Format(" @lvCond               = '{0}'", "C")
        strSQL &= vbNewLine & String.Format(",@cod_tipanex          = '{0}'", TipoAnexo)
        strSQL &= vbNewLine & String.Format(",@cod_anxo             = '{0}'", TxtCodigo.Text)

        oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
        GrdMntTest.DataSource = oDT
        CheckLayoutGridEx(GrdMntTest)

        With GrdMntTest
            With .RootTable
                .HeaderLines = 2
                .RowHeight = 30
                .PreviewRow = True
                .PreviewRowLines = 15
                .PreviewRowMember = "COMENTARIOS"

                For Each oGridEXColumn As GridEXColumn In .Columns
                    With oGridEXColumn
                        .WordWrap = True
                        .Visible = True
                        .FilterEditType = FilterEditType.Combo
                    End With
                Next

                With .Columns("Secuencia")
                    .Caption = "SEC"
                    .Width = 50
                    .TextAlignment = TextAlignment.Center
                End With

                With .Columns("Fec_Notificacion")
                    .Caption = "FECHA NOTIFICACION"
                    .Width = 210
                End With

                With .Columns("Fec_Levantamiento_Embargo")
                    .Caption = "FECHA LEVANTAMIENTO EMBARGO"
                    .Width = 210
                End With
            End With
        End With

        If GrdMntTest.RowCount > 0 Then
            GrdMntTest.Enabled = True
        Else
            GrdMntTest.Enabled = False
        End If
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Dim Eliminar As Short
            Dim vRow As Integer
            Dim cRow As Integer
            Select Case e.Item.Key
                Case "ADICIONAR"
                    OpcionMantenimiento = "I"
                    Call LIMPIA_DATOS()
                    Call HABILITA_DATOS()
                    Me.txtMonEmbSales.Focus()
                    With BarraOpciones.Groups(0)
                        .Items("MODIFICAR").Enabled = False
                        .Items("ELIMINAR").Enabled = False
                        .Items("GRABAR").Enabled = True
                        .Items("DESHACER").Enabled = True
                    End With

                Case "MODIFICAR"
                    OpcionMantenimiento = "U"
                    Call HABILITA_DATOS()
                    Me.txtMonEmbSales.Focus()
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = False
                        .Items("ELIMINAR").Enabled = False
                        .Items("GRABAR").Enabled = True
                        .Items("DESHACER").Enabled = True
                    End With

                Case "ELIMINAR"
                    Eliminar = MsgBox("¿Esta usted seguro de eliminar el registro seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
                    If Eliminar = MsgBoxResult.Yes Then
                        OpcionMantenimiento = "D"
                        Call SALVAR_DATOS()
                        Call CARGA_GRID()
                        OpcionMantenimiento = ""
                    End If

                Case "GRABAR"
                    vRow = GrdMntTest.Row
                    cRow = GrdMntTest.RowCount
                    Call SALVAR_DATOS()
                    Call CARGA_GRID()
                    Call INHABILITA_DATOS()
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = True
                        .Items("MODIFICAR").Enabled = True
                        .Items("ELIMINAR").Enabled = True
                        .Items("GRABAR").Enabled = False
                        .Items("DESHACER").Enabled = False
                    End With

                    If OpcionMantenimiento = "U" Then
                        GrdMntTest.Row = vRow
                    Else
                        'GrdMntMedidas.Row = cRow
                    End If
                    OpcionMantenimiento = ""

                Case "DESHACER"
                    Call LIMPIA_DATOS()
                    Call Carga_Datos()
                    Call INHABILITA_DATOS()
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = True
                        .Items("MODIFICAR").Enabled = True
                        .Items("ELIMINAR").Enabled = True
                        .Items("GRABAR").Enabled = False
                        .Items("DESHACER").Enabled = False
                    End With
                    OpcionMantenimiento = ""
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub HABILITA_DATOS()
        TxtFecNoct.Enabled = True
        txtFecLev.Enabled = True
        txtMonEmbSales.Enabled = True
        txtNroResolucionEmbargo.Enabled = True
        txtResolucionLevantamiento.Enabled = True
        txtImpLevanEmb.Enabled = True
        TxtFecNoct.Focus()
    End Sub

    Public Sub INHABILITA_DATOS()
        TxtFecNoct.Enabled = False
        txtFecLev.Enabled = False
        txtMonEmbSales.Enabled = False
        txtNroResolucionEmbargo.Enabled = False
        txtResolucionLevantamiento.Enabled = False
        txtImpLevanEmb.Enabled = False
    End Sub

    Public Sub LIMPIA_DATOS()
        TxtFecNoct.Text = String.Empty
        txtFecLev.Text = String.Empty
        txtMonEmbSales.Text = "0.00"
        txtNroResolucionEmbargo.Text = String.Empty
        txtResolucionLevantamiento.Text = String.Empty
        txtImpLevanEmb.Text = "0.00"
    End Sub

    Sub SALVAR_DATOS()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Cn_Man_AnexosContales_Notificaciones"
            strSQL &= vbNewLine & String.Format(" @lvCond               = '{0}'", OpcionMantenimiento)
            strSQL &= vbNewLine & String.Format(",@cod_tipanex          = '{0}'", TipoAnexo)
            strSQL &= vbNewLine & String.Format(",@cod_anxo             = '{0}'", TxtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@secuencia            =  {0} ", IntSecuencia)
            strSQL &= vbNewLine & String.Format(",@Fec_Notificacion     =  {0} ", IIf(TxtFecNoct.Text = "", "Null", "'" & TxtFecNoct.Text & "'"))
            strSQL &= vbNewLine & String.Format(",@Fec_Levantamiento_Embargo    =  {0} ", IIf(txtFecLev.Text = "", "Null", "'" & txtFecLev.Text & "'"))
            strSQL &= vbNewLine & String.Format(",@Monto_Embargo_Soles  =  {0} ", Val(txtMonEmbSales.Text))
            strSQL &= vbNewLine & String.Format(",@Nro_Resolucion_Embargo       = '{0}'", txtNroResolucionEmbargo.Text)
            strSQL &= vbNewLine & String.Format(",@Nro_Resolucion_Levantamiento = '{0}'", txtResolucionLevantamiento.Text)
            strSQL &= vbNewLine & String.Format(",@Imp_Levantamiento_Embargo    =  {0} ", Val(txtImpLevanEmb.Text))



            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                CARGA_GRID()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub GrdMntTest_SelectionChanged(sender As Object, e As EventArgs) Handles GrdMntTest.SelectionChanged
        Call Me.Carga_Datos()
    End Sub

    Public Sub Carga_Datos()
        If Me.GrdMntTest.RowCount > 0 Then
            Dim odr As DataRow
            odr = ObtenerDr_DeGridEx(GrdMntTest)
            If Not odr Is Nothing Then
                IntSecuencia = odr("secuencia")
                TxtFecNoct.Text = IIf(IsDBNull(odr("Fec_Notificacion")), "", odr("Fec_Notificacion"))
                txtFecLev.Text = IIf(IsDBNull(odr("Fec_Levantamiento_Embargo")), "", odr("Fec_Levantamiento_Embargo"))
                txtMonEmbSales.Text = odr("Monto_Embargo_Soles")
                txtNroResolucionEmbargo.Text = Trim(odr("Nro_Resolucion_Embargo"))
                txtResolucionLevantamiento.Text = Trim(odr("Nro_Resolucion_Levantamiento"))
                txtImpLevanEmb.Text = odr("Imp_Levantamiento_Embargo")
            End If
        Else
            Call LIMPIA_DATOS()
        End If
    End Sub

    Private Sub TxtFecNoct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFecNoct.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNroResolucionEmbargo.Focus()
        End If
    End Sub

    Private Sub txtNroResolucionEmbargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroResolucionEmbargo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtMonEmbSales.Focus()
        End If
    End Sub

    Private Sub txtMonEmbSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonEmbSales.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtFecLev.Focus()
        End If
    End Sub

    Private Sub txtFecLev_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecLev.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtResolucionLevantamiento.Focus()
        End If
    End Sub

    Private Sub txtResolucionLevantamiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResolucionLevantamiento.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtImpLevanEmb.Focus()
        End If
    End Sub

    Private Sub txtImpLevanEmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImpLevanEmb.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BarraOpciones.Focus()
        End If
    End Sub
End Class