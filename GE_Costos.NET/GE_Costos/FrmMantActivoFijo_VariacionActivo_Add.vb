Public Class FrmMantActivoFijo_VariacionActivo_Add
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public oParent As Object
    Public sAccion As String
    Public sSECUENCIA As Integer

    Private Sub FrmMantActivoFijo_VariacionActivo_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel5.BackColor = colEmpresa

        If sAccion = "I" Then
            Me.ActiveControl = TxtCod_TipVariacion
        Else

        End If
    End Sub

    Private Sub TxtCod_TipVariacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_TipVariacion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCATIPOVARIACION(1)
        End If
    End Sub

    Private Sub TxtDes_TipVariacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDes_TipVariacion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCATIPOVARIACION(2)
        End If
    End Sub

    Sub BUSCATIPOVARIACION(Opcion As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "SELECT cod_tipo_variacion_activo as CodIGO,des_tipo_variacion_activo as Descripcion FROM CN_Tipo_Variacion_Activo_Fijo "
        Select Case Opcion
            Case 1 : oTipo.sQuery = strSQL & "where cod_tipo_variacion_activo like '%" & TxtCod_TipVariacion.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & "where des_tipo_variacion_activo like '%" & TxtDes_TipVariacion.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("CodIGO")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            TxtCod_TipVariacion.Text = Trim(Codigo)
            TxtDes_TipVariacion.Text = Trim(Descripcion)
            TxtCod_CtaCont.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub TxtCod_CtaCont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_CtaCont.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCA_CUENTACONTABLE(1, TxtCod_CtaCont, TxtDes_CtaCont)
        End If
    End Sub

    Private Sub TxtDes_CtaCont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDes_CtaCont.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCA_CUENTACONTABLE(2, TxtCod_CtaCont, TxtDes_CtaCont)
        End If
    End Sub

    Private Sub BUSCA_CUENTACONTABLE(tipo As Integer, ByRef Cod_Cta As TextBox, ByRef Des_Cta As TextBox)
        Select Case tipo
            Case 1
                strSQL = "SELECT Cod_CtaCont as 'Código', Des_CtaCont as 'Descripción' " & _
                        "FROM CN_PlanContable WHERE substring(Cod_CtaCont,1,2)='33' and Cod_CtaCont like '" & Trim(Cod_Cta.Text) & "%' and ano=dbo.CN_OBTIENE_ANO_VIGENTE_PLAN_CONTABLE() ORDER BY Cod_CtaCont "

            Case 2, 3
                strSQL = "SELECT Cod_CtaCont AS 'Código', " & _
                " Des_CtaCont as 'Descripción' " & _
                "FROM CN_PlanContable " & _
                "WHERE Cod_CtaCont like '33%' and  Des_CtaCont LIKE '%" & Trim(Des_Cta.Text) _
                & "%' and ano=dbo.CN_OBTIENE_ANO_VIGENTE_PLAN_CONTABLE() ORDER BY 1"
        End Select

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = strSQL
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            Cod_Cta.Text = Trim(Codigo)
            Des_Cta.Text = Trim(Descripcion)
            TxtCod_Moneda.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub TxtCod_Moneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_Moneda.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAMONEDA(1)
        End If
    End Sub

    Private Sub TxtDes_Moneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDes_Moneda.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAMONEDA(2)
        End If
    End Sub

    Sub BUSCAMONEDA(Opcion As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "SELECT cod_moneda as Codigo,NOM_MONEDA as Descripcion FROM TG_MONEDA "
        Select Case Opcion
            Case 1 : oTipo.sQuery = strSQL & "where cod_moneda like '%" & TxtCod_Moneda.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & "where NOM_MONEDA like '%" & TxtDes_Moneda.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            TxtCod_Moneda.Text = Trim(Codigo)
            TxtDes_Moneda.Text = Trim(Descripcion)
            DTPFec_Operacion.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub DTPFec_Operacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTPFec_Operacion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtTipo_Cambio.Focus()
        End If
    End Sub

    Private Sub DTPFec_Operacion_LostFocus(sender As Object, e As EventArgs) Handles DTPFec_Operacion.LostFocus
        If DTPFec_Operacion.Text <> "" Then
            txtTipo_Cambio.Text = oHP.DevuelveDato("Select dbo.SM_OBTIENE_TIPO_CAMBIO('" & DTPFec_Operacion.Value.ToShortDateString & "')", cCONNECT)
            txtOtro_Tipo_Cambio.Text = oHP.DevuelveDato("Select dbo.FI_ObtieneTipoCambio_venta('" & DTPFec_Operacion.Value.ToShortDateString & "','" & TxtCod_Moneda.Text & "')", cCONNECT)
        Else
            Me.DTPFec_Operacion.Focus()
        End If
    End Sub

    Private Sub txtTipo_Cambio_GotFocus(sender As Object, e As EventArgs) Handles txtTipo_Cambio.GotFocus
        If TxtCod_Moneda.Text = "SOL" Then
            TxtImpSoles.Focus()
        ElseIf TxtCod_Moneda.Text = "USD" Then
            TxtImpDolares.Focus()
        Else
            TxtImpOtros.Focus()
        End If
    End Sub

    Private Sub txtTipo_Cambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipo_Cambio.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If TxtCod_Moneda.Text = "SOL" Then
                TxtImpSoles.Focus()
            ElseIf TxtCod_Moneda.Text = "USD" Then
                TxtImpDolares.Focus()
            Else
                TxtImpOtros.Focus()
            End If
        End If
    End Sub

    Private Sub txtOtro_Tipo_Cambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtro_Tipo_Cambio.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtImpSoles.Focus()
        End If
    End Sub

    Private Sub TxtImpSoles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtImpSoles.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Trim(TxtCod_Moneda.Text) = "SOL" Then
                TxtImpDolares.Text = IIf(Val(txtTipo_Cambio.Text) > 0, Math.Round(Val(TxtImpSoles.Text) / Val(txtTipo_Cambio.Text), 2), 0)
            End If
            TxtCod_TipoDiario.Focus()
        Else
            ValidarSoloDecimales(TxtImpSoles.Text, e)
        End If
    End Sub

    Private Sub TxtImpDolares_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtImpDolares.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Trim(TxtCod_Moneda.Text) = "USD" Then
                TxtImpSoles.Text = Math.Round(Val(TxtImpDolares.Text) * Val(txtTipo_Cambio.Text), 2)
            End If
            TxtCod_TipoDiario.Focus()
        Else
            ValidarSoloDecimales(TxtImpDolares.Text, e)
        End If
    End Sub

    Private Sub TxtImpOtros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtImpOtros.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If TxtCod_Moneda.Text <> "SOL" Or TxtCod_Moneda.Text <> "USD" Then
                TxtImpDolares.Text = Math.Round(Val(TxtImpOtros.Text) * Val(txtOtro_Tipo_Cambio.Text), 2)
                TxtImpSoles.Text = Math.Round(Val(TxtImpDolares.Text) * Val(txtTipo_Cambio.Text), 2)
                TxtCod_TipoDiario.Focus()
            End If
        Else
            ValidarSoloDecimales(TxtImpOtros.Text, e)
        End If
    End Sub

    Private Sub TxtCod_TipoDiario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_TipoDiario.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCARSUBDIARIO(1)
        End If
    End Sub

    Private Sub TxtDes_TipoDiario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDes_TipoDiario.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCARSUBDIARIO(2)
        End If
    End Sub

    Sub BUSCARSUBDIARIO(Opcion As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "SELECT cod_tipodiario as Codigo,Des_TipoDiario as Descripcion FROM cn_tipodiario "
        Select Case Opcion
            Case 1 : oTipo.sQuery = strSQL & "where cod_tipodiario like '%" & TxtCod_TipoDiario.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & "where Des_TipoDiario like '%" & TxtDes_TipoDiario.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            TxtCod_TipoDiario.Text = Trim(Codigo)
            TxtDes_TipoDiario.Text = Trim(Descripcion)
            TxtAnioReg.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub TxtAnioReg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAnioReg.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtMesReg.Focus()
        End If
    End Sub

    Private Sub TxtMesReg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMesReg.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtNumReg.Focus()
        End If
    End Sub

    Private Sub TxtNumReg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumReg.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtGlosa.Focus()
        End If
    End Sub

    Private Sub TxtGlosa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtGlosa.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MANT_VARIACION_ACTIVO_FIJO"
            strSQL &= vbNewLine & String.Format(" @accion               = '{0}'", sAccion)
            strSQL &= vbNewLine & String.Format(",@COD_ACTIVO           = '{0}'", TxtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@secuencia            =  {0} ", sSECUENCIA)
            strSQL &= vbNewLine & String.Format(",@Cod_Tipo_Variacion_Activo    = '{0}'", Trim(TxtCod_TipVariacion.Text))
            strSQL &= vbNewLine & String.Format(",@Fec_Movstk           = '{0}'", DTPFec_Operacion.Value.ToShortDateString)
            strSQL &= vbNewLine & String.Format(",@Imp_Movimiento_Soles = '{0}'", Trim(TxtImpSoles.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_Movimiento_Dolares       = '{0}'", TxtImpDolares.Text)
            strSQL &= vbNewLine & String.Format(",@Imp_Movimiento_Otra_Moneda   = '{0}'", TxtImpOtros.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_Moneda           = '{0}'", Trim(TxtCod_Moneda.Text))
            strSQL &= vbNewLine & String.Format(",@Ano_Registro         = '{0}'", Trim(TxtAnioReg.Text))
            strSQL &= vbNewLine & String.Format(",@Mes_Registro         = '{0}'", Trim(TxtMesReg.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_TipoDiario       = '{0}'", Trim(TxtCod_TipoDiario.Text))
            strSQL &= vbNewLine & String.Format(",@Num_Registro         = '{0}'", Trim(TxtNumReg.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Usuario          = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@Cod_Estacion         = '{0}'", ComputerName())
            strSQL &= vbNewLine & String.Format(",@COD_CTACONT          = '{0}'", Trim(TxtCod_CtaCont.Text))
            strSQL &= vbNewLine & String.Format(",@GLOSA                = '{0}'", TxtGlosa.Text)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
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