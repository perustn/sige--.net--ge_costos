Imports Janus.Windows.GridEX

Public Class FrmMantAnexosContables
    Private strSQL As String = String.Empty
    Private strSQLTrazaImp As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Enum ModoVentana
        ModoGUIAnexossDesdeOtraVentana = 1
    End Enum

    Property ModoGUIAnexosContables As ModoVentana

    Public OpcionFiltroBusqueda As String
    Public sNum_Ruc As String
    Dim ruc As String
    Dim ruc_2 As String
    Dim Estado As String
    Public sConstAfiliacion As String
    Public sOpcionbut As String
    Dim sMensaje As String
    Dim sOrigen As String
    Public sprueba As Integer
    Dim sflag As String
    Dim FilaSeleccionada As Integer

    Private Sub FrmMantAnexosContables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))

        strSQL = "select cod_tipanex, des_tipanex  from CN_TipoAnexoContable order by 1"
        Dim dtTipAnexBusqueda As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)
        cboTipAnexBusqueda.DataSource = dtTipAnexBusqueda
        cboTipAnexBusqueda.ValueMember = "cod_tipanex"
        cboTipAnexBusqueda.DisplayMember = "des_tipanex"

        strSQL = "select cod_tipanex, des_tipanex  from CN_TipoAnexoContable order by 1"
        Dim dtTipAnex As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)
        cboTipAnex.DataSource = dtTipAnex
        cboTipAnex.ValueMember = "cod_tipanex"
        cboTipAnex.DisplayMember = "des_tipanex"

        'BuscaCombo("P", 2, cboTipAnex)

        DESHABILITA_DATOS()

        Select Case ModoGUIAnexosContables
            Case ModoVentana.ModoGUIAnexossDesdeOtraVentana
                Panel1.Visible = False
                ButtonBar1.Visible = False
                Cargar_Datos()
            Case Else
                With BarraOpciones.Groups(0)
                    .Items("NOTIFICACIONSUNAT").Visible = False
                End With
        End Select

        dtpFechaNacimiento.Value = Now.Date
        dtpFechaNacimiento.Visible = False
        Me.lblFechaNac.Visible = False
        Me.fraFechas.Visible = False

        If chkConstAfiliacion.Checked = False Then
            Frame9.Visible = False
            DTAfiliacion.Visible = False
            lblFec_Afiliacion.Visible = False
            txtCod_AFP.Text = ""
            txtDes_AFP.Text = ""
            txtCUSPP.Text = ""
            txtNroDocAfil.Text = ""
        Else
            Frame9.Visible = True
            DTAfiliacion.Visible = True
            lblFec_Afiliacion.Visible = True
            txtCod_AFP.Text = ""
            txtDes_AFP.Text = ""
            txtCUSPP.Text = ""
            txtNroDocAfil.Text = ""
            optSPP.Checked = True
        End If

        DTAfiliacion.Value = Now.Date

        If optSPP.Checked = True Then
            lblCod_Afp.Visible = True
            txtCod_AFP.Visible = True
            txtDes_AFP.Visible = True
            lblCUSPP.Visible = True
            txtCUSPP.Visible = True
            lblNroDocAfil.Visible = False
            txtNroDocAfil.Visible = False
        ElseIf optSNP.Checked = True Then
            lblCod_Afp.Visible = False
            txtCod_AFP.Visible = False
            txtDes_AFP.Visible = False
            lblCUSPP.Visible = False
            txtCUSPP.Visible = False
            lblNroDocAfil.Visible = True
            txtNroDocAfil.Visible = True
        End If

        If Trim(Strings.Left(cboTipAnexBusqueda.Text, 9)) = "PROVEEDOR" Then
            chkConstAfiliacion.Visible = True
        Else
            chkConstAfiliacion.Visible = False
        End If

        chkmayordeedadlimite.Enabled = False

    End Sub

    Private Sub FondoDegrade(sender As Object, e As PaintEventArgs) Handles PanelGuia.Paint
        FondoDegradeDiagonalEnPanel(sender, e, colEmpresa)
    End Sub

    Private Sub OpcionBusqueda(sender As Object, e As EventArgs) Handles OptAnexo.Click,
                                                                         OptNumCorrelativo.Click
        LimpiarTextos()
        Select Case (sender.TAG)
            Case "1"
                grbRUC.Visible = True
                OpcionFiltroBusqueda = "3"
                TxtRucBusqueda.Focus()

            Case "2"
                grbDescripcion.Visible = True
                OpcionFiltroBusqueda = "4"
                TxtDescripcionBusqueda.Focus()
        End Select
    End Sub

    Sub LimpiarTextos()
        grbRUC.Visible = False
        grbDescripcion.Visible = False
        TxtRucBusqueda.Text = String.Empty
        TxtDescripcionBusqueda.Text = String.Empty
    End Sub

    Private Sub cboTipAnexBusqueda_Click(sender As Object, e As EventArgs) Handles cboTipAnexBusqueda.Click
        If cboTipAnexBusqueda.Text = "PROVEEDOR" Then
            chkConstAfiliacion.Visible = True
        Else
            chkConstAfiliacion.Visible = False
        End If
    End Sub

    Private Sub TxtRucBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRucBusqueda.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub TxtDescripcionBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDescripcionBusqueda.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub OpcionOrigen(sender As Object, e As EventArgs) Handles OptOrigenN.Click, OptOrigenE.Click
        If OptOrigenN.Checked = True Then
            LabelDistrito.Visible = True
            txtCodDistritoDomicilio.Visible = True
            txtDesDistritoDomicilio.Visible = True
        ElseIf OptOrigenE.Checked = True Then
            LabelDistrito.Visible = False
            txtCodDistritoDomicilio.Visible = False
            txtDesDistritoDomicilio.Visible = False
        End If
    End Sub

    Private Sub OpcionFechas(sender As Object, e As EventArgs) Handles chkFechas.Click
        If chkFechas.Checked = True Then
            Me.fraFechas.Visible = True
            dtpFechaInicio.Focus()
        Else
            Me.fraFechas.Visible = False
        End If
    End Sub

    Private Sub dtpFechaInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFechaInicio.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            dtpFechaFin.Focus()
        End If
    End Sub

    Private Sub dtpFechaFin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFechaFin.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Cargar_Datos()

        If Trim(cboTipAnexBusqueda.Text) = "PROVEEDOR" Then
            fraArea.Visible = True
            txtCodArea.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_Tip_proveedor_area_negocio").Index))
            TxtDesArea.Text = IIf(IsDBNull(GrdLista.GetValue(GrdLista.RootTable.Columns("Area_Proveedor").Index)), "", GrdLista.GetValue(GrdLista.RootTable.Columns("Area_Proveedor").Index))
        Else
            fraArea.Visible = False
        End If
    End Sub

    Public Sub Cargar_Datos()
        Try
            Select Case ModoGUIAnexosContables
                Case ModoVentana.ModoGUIAnexossDesdeOtraVentana
                    strSQL = "EXEC UP_SEL_CN_ANXCON"
                Case Else
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC UP_SEL_CN_ANXCON"
                    strSQL &= vbNewLine & String.Format(" @Opcion       = '{0}'", OpcionFiltroBusqueda)
                    strSQL &= vbNewLine & String.Format(",@Cod_TipAnex  = '{0}'", cboTipAnexBusqueda.SelectedValue())
                    strSQL &= vbNewLine & String.Format(",@Des_Anexo    = '{0}'", Trim(TxtDescripcionBusqueda.Text))
                    strSQL &= vbNewLine & String.Format(",@Num_Ruc      = '{0}'", Trim(TxtRucBusqueda.Text))
                    strSQL &= vbNewLine & String.Format(",@Origen       = '{0}'", IIf(OptOrigenN.Checked = True, "N", "E"))
                    strSQL &= vbNewLine & String.Format(",@FechaInicio  = '{0}'", IIf(Me.chkFechas.Checked = True, Me.dtpFechaInicio.Value.ToShortDateString, ""))
                    strSQL &= vbNewLine & String.Format(",@FechaFin     = '{0}'", IIf(Me.chkFechas.Checked = True, Me.dtpFechaFin.Value.ToShortDateString, ""))
                    strSQLTrazaImp = strSQL
            End Select

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            If oDT Is Nothing Then Exit Sub
            'GrdLista.RootTable.Columns.Clear()
            GrdLista.DataSource = oDT
            CheckLayoutGridEx(GrdLista)

            With GrdLista
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                .FilterRowButtonStyle = FilterRowButtonStyle.ConditionOperatorDropDown
                With .RootTable
                    .HeaderLines = 2
                    .RowHeight = 30
                    .PreviewRow = False
                    .PreviewRowLines = 15
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("Tipo").Width = 60
                    .Columns("Codigo").Width = 75
                    .Columns("Origen").Width = 60
                    .Columns("Flg_Suspension_Email").Width = 80
                    .Columns("Cod_Pais").Visible = False
                    .Columns("Cod_Zona").Visible = False
                    .Columns("Codigo_Postal").Width = 90
                    .Columns("Codigo_Postal").Width = 90

                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub GrdLista_SelectionChanged(sender As Object, e As EventArgs) Handles GrdLista.SelectionChanged
        Call Me.Carga_Datos()
    End Sub

    Public Sub Carga_Datos()
        If Me.GrdLista.RowCount > 0 Then
            Dim dr As DataRow
            dr = ObtenerDr_DeGridEx(GrdLista)
            If Not dr Is Nothing Then
                'If OptBUSCA.Checked = True Then Exit Sub

                txt_codtip.Text = dr("Codigo")
                txt_desTip.Text = dr("Descripcion")
                txt_numruc.Text = dr("Ruc")

                ruc = txt_numruc.Text
                ruc_2 = Strings.Left(ruc, 2)

                txt_diranexo.Text = dr("Dir_anexo")
                txt_rucant.Text = dr("ruc_ant")

                If Trim(dr("Flag_RecHon")) = "S" Then
                    chkReciboHon.Checked = True
                Else
                    chkReciboHon.Checked = False
                End If

                If Trim(dr("cod_tipopersona")) = "NA" And dr("Flag_RecHon") = "S" Then
                    Me.lblFechaNac.Visible = True
                    Me.dtpFechaNacimiento.Visible = True
                Else
                    Me.lblFechaNac.Visible = False
                    Me.dtpFechaNacimiento.Visible = False
                End If
                cboTipAnex.SelectedValue = dr("Tipo")
                chkSunat.Checked = IIf(dr("Problemas_Sunat") = "S", 1, 0)
                TxtApellido_Paterno.Text = RTrim(dr("Apellido_Paterno"))
                TxtApellido_Materno.Text = RTrim(dr("Apellido_Materno"))
                TxtNombres.Text = RTrim(dr("Nombres"))

                If Trim(dr("Origen")) = "N" Then
                    OptNacional.Checked = True
                Else
                    OptExtranjero.Checked = True
                End If

                TxtCod_Pais.Text = Trim(dr("Cod_Pais"))
                TxtDes_Pais.Text = Trim(dr("Pais"))
                TxtCod_Ciudad.Text = IIf(Trim(dr("Cod_Ciudad")) = "0", "", Trim(dr("Cod_Ciudad")))
                TxtDes_Ciudad.Text = Trim(dr("Ciudad"))
                TxtTelefono.Text = Trim(dr("Telefono"))
                TxtCod_Zona.Text = Trim(dr("cod_Zona"))
                TxtDes_Zona.Text = Trim(dr("Des_Zona"))
                TxtCod_Postal.Text = Trim(dr("codigo_Postal"))
                TxtDes_Postal.Text = Trim(dr("Des_Postal"))
                TxtCtaCteDetracciones.Text = Trim(dr("CTACTE_DETRACCIONES"))
                If (UCase(Trim$(dr("Tipo"))) = "C" Or UCase(dr("Tipo")) = "W") And UCase(Trim(dr("Origen"))) = "E" Then
                    FraClienteComercial.Visible = True
                    txtAbr_Cliente.Text = Trim(dr("ABR_CLIENTE"))
                    txtDes_Cliente.Text = Trim(dr("NOM_CLIENTE"))
                Else
                    FraClienteComercial.Visible = False
                End If
                txtCod_TipoPersona.Text = RTrim(dr("cod_tipopersona"))
                txtDes_TipoPersona.Text = RTrim(dr("des_tipopersona"))
                Me.dtpFechaNacimiento.Value = IIf(IsDBNull(dr("fec_Nacimiento")), Now.Date, dr("fec_Nacimiento"))
                Me.txtEmailElectronico.Text = Trim(dr("email_facturacion_electronica"))
                txtAnalisisAdicional.Text = Trim(dr("Analisis_Adicional"))
                txtCodZona.Text = Trim(dr("cod_Zona_domicilio"))
                'txtDesZona.Text = Trim(gexList.Value(gexList.Columns("Des_Zona").Index))
                Me.txtCodNomZona.Text = Trim(dr("nom_zona_domicilio"))
                txtCodArea.Text = dr("Cod_Tip_proveedor_area_negocio")
                TxtDesArea.Text = IIf(IsDBNull(dr("Area_Proveedor")), "", dr("Area_Proveedor"))
                If ruc_2 <> "" And Estado = "MODIFICAR" Then
                    If CInt(ruc_2) < 20 Then
                        If txt_numruc.Text <> "" Then
                            txt_desTip.Enabled = False
                            Me.TxtApellido_Paterno.Enabled = True
                            Me.TxtApellido_Materno.Enabled = True
                            Me.TxtNombres.Enabled = True
                        End If
                    End If

                    If CInt(ruc_2) >= 20 Then
                        If txt_numruc.Text <> "" Then
                            txtCod_TipoPersona.Text = "JU"
                            'Me.txt_desTip.SetFocus
                            Me.TxtApellido_Paterno.Enabled = False
                            Me.TxtApellido_Materno.Enabled = False
                            Me.TxtNombres.Enabled = False
                            Me.txt_desTip.Enabled = True
                        End If
                    End If
                    If Me.txt_desTip.Enabled Then
                        Me.txt_desTip.Focus()
                    Else
                        Me.TxtApellido_Paterno.Focus()
                    End If
                End If
                txtDni.Text = RTrim(dr("num_doc"))
                txtCodDistritoDomicilio.Text = RTrim(dr("COD_UBIGEO"))
                txtDesDistritoDomicilio.Text = IIf(IsDBNull(dr("Desc_Ubigeo")), "", dr("Desc_Ubigeo"))

                If Trim(dr("Flg_Presento_Constancia_Afiliacion_Sistema_Pensionario")) = "S" Then
                    chkConstAfiliacion.Checked = True
                Else
                    chkConstAfiliacion.Checked = False
                End If

                If Trim(dr("Flg_Sistema_Privado_Pensiones")) = "S" Then
                    optSPP.Checked = True
                Else
                    optSNP.Checked = True
                End If

                txtCod_AFP.Text = Trim(dr("Cod_AFP_Asociado"))
                txtDes_AFP.Text = Trim(dr("Des_AFP_Asociado"))
                txtCUSPP.Text = Trim(dr("CUSPP_AFP_Asociado"))
                txtNroDocAfil.Text = Trim(dr("Nro_Docum_Afiliacion_Sistema_Pensionario"))
                Me.DTAfiliacion.Value = IIf(IsDBNull(dr("Fec_Afiliacion_Sistema_Pensionario")), Now.Date, dr("Fec_Afiliacion_Sistema_Pensionario"))
                If Trim(dr("Flg_Fec_Maxima_Sistema_Pensionario_Independientes")) = "S" Then
                    chkmayordeedadlimite.Checked = True
                Else
                    chkmayordeedadlimite.Checked = False
                End If
            End If
        Else
            Call LIMPIAR_DATOS()
        End If
    End Sub

    Sub LIMPIAR_DATOS()
        txt_codtip.Text = ""
        txt_desTip.Text = ""
        txt_numruc.Text = ""
        txt_diranexo.Text = ""
        txt_rucant.Text = ""
        chkReciboHon.Checked = False
        chkSunat.Checked = False
        TxtApellido_Paterno.Text = ""
        TxtApellido_Materno.Text = ""
        TxtNombres.Text = ""
        OptNacional.Checked = True
        TxtCod_Pais.Text = ""
        TxtDes_Pais.Text = ""
        TxtTelefono.Text = ""
        TxtCod_Zona.Text = ""
        TxtDes_Zona.Text = ""
        TxtCod_Postal.Text = ""
        TxtDes_Postal.Text = ""
        TxtCtaCteDetracciones.Text = ""
        txtCod_TipoPersona.Text = ""
        txtDes_TipoPersona.Text = ""
        txtAbr_Cliente.Text = ""
        txtDes_Cliente.Text = ""
        txtCodDistritoDomicilio.Text = ""
        txtCodArea.Text = ""
        TxtDesArea.Text = ""
        chkConstAfiliacion.Checked = False
        txtCod_AFP.Text = ""
        txtDes_AFP.Text = ""
        txtCUSPP.Text = ""
        txtNroDocAfil.Text = ""
        optSPP.Checked = True
        chkmayordeedadlimite.Checked = False
    End Sub

    Sub DESHABILITA_DATOS()
        CmdAdd.Enabled = False
        txt_codtip.Enabled = False
        txt_desTip.Enabled = False
        txt_numruc.Enabled = False
        txt_diranexo.Enabled = False
        txt_rucant.Enabled = False
        chkReciboHon.Enabled = False
        txtCodZona.Enabled = False
        txtDesZona.Enabled = False
        txtCodNomZona.Enabled = False
        txtEmailElectronico.Enabled = False
        txtAnalisisAdicional.Enabled = False
        txtCodDoc.Enabled = False
        txtDesDoc.Enabled = False
        cboTipAnex.Enabled = False
        TxtApellido_Paterno.Enabled = False
        TxtApellido_Materno.Enabled = False
        TxtNombres.Enabled = False
        FraPais.Enabled = False
        FraOrigen.Enabled = False
        TxtTelefono.Enabled = False
        FraZona.Enabled = False
        TxtCtaCteDetracciones.Enabled = False
        txtCod_TipoPersona.Enabled = False
        txtDes_TipoPersona.Enabled = False
        txtAbr_Cliente.Enabled = False
        txtDes_Cliente.Enabled = False
        Me.lblFechaNac.Enabled = False
        Me.dtpFechaNacimiento.Enabled = False
        fraArea.Enabled = False
        chkConstAfiliacion.Enabled = False
        txtCod_AFP.Enabled = False
        txtDes_AFP.Enabled = False
        txtCUSPP.Enabled = False
        DTAfiliacion.Enabled = False
        txtNroDocAfil.Enabled = False
        optSPP.Enabled = False
        optSNP.Enabled = False
    End Sub

    Sub HABILITA_DATOS()

        ruc = txt_numruc.Text
        ruc_2 = Strings.Left(ruc, 2)

        txt_desTip.Enabled = True
        CmdAdd.Enabled = True
        txt_diranexo.Enabled = True
        txt_rucant.Enabled = True
        chkReciboHon.Enabled = True
        cboTipAnex.Enabled = True
        TxtApellido_Paterno.Enabled = True
        TxtApellido_Materno.Enabled = True
        TxtNombres.Enabled = True
        txt_numruc.Enabled = True
        TxtTelefono.Enabled = True
        TxtCtaCteDetracciones.Enabled = True
        If Estado = "MODIFICAR" Then
            If ruc_2 <> "" Then
                If IsNumeric(ruc_2) Then
                    If CInt(ruc_2) < 20 Or Len(ruc) <= 8 Then
                        If txt_numruc.Text <> "" Then
                            txt_desTip.Enabled = False
                            Me.TxtApellido_Paterno.Enabled = True
                            Me.TxtApellido_Materno.Enabled = True
                            Me.TxtNombres.Enabled = True
                            '                Me.TxtApellido_Paterno.SetFocus
                        End If
                    End If
                End If
            End If

            If ruc_2 <> "" Then
                If IsNumeric(ruc_2) And Len(ruc) > 8 Then
                    If CInt(ruc_2) >= 20 Then
                        If txt_numruc.Text <> "" Then
                            txtCod_TipoPersona.Text = "JU"
                            'Me.txt_desTip.SetFocus
                            Me.TxtApellido_Paterno.Enabled = False
                            Me.TxtApellido_Materno.Enabled = False
                            Me.TxtNombres.Enabled = False
                            Me.txt_desTip.Enabled = True
                        End If
                    End If
                End If
            End If
        End If
        FraPais.Enabled = True
        FraOrigen.Enabled = True
        FraZona.Enabled = True
        fraArea.Enabled = True
        txtCod_TipoPersona.Enabled = True
        txtDes_TipoPersona.Enabled = True
        txtCodDoc.Enabled = True
        txtDesDoc.Enabled = True
        txtAbr_Cliente.Enabled = True
        txtDes_Cliente.Enabled = True
        Me.lblFechaNac.Enabled = True
        Me.dtpFechaNacimiento.Enabled = True

        If Estado = "MODIFICAR" Then
            If Me.txt_desTip.Enabled Then
                Me.txt_desTip.Focus()
            Else
                Me.TxtApellido_Paterno.Focus()
            End If
        Else
            Me.txtCod_TipoPersona.Focus()
        End If

        txtCodZona.Enabled = True
        txtDesZona.Enabled = True
        txtCodNomZona.Enabled = True
        txtEmailElectronico.Enabled = True
        txtAnalisisAdicional.Enabled = True
        chkConstAfiliacion.Enabled = True
        txtCod_AFP.Enabled = True
        txtDes_AFP.Enabled = True
        txtCUSPP.Enabled = True
        DTAfiliacion.Enabled = True
        txtNroDocAfil.Enabled = True
        optSPP.Enabled = True
        optSNP.Enabled = True
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    Estado = "NUEVO"
                    HABILITA_DATOS()
                    Me.dtpFechaNacimiento.Checked = False
                    LIMPIAR_DATOS()
                    With BarraOpciones.Groups(0)
                        .Items("MODIFICAR").Enabled = False
                        .Items("ELIMINAR").Enabled = False
                        .Items("GRABAR").Enabled = True
                        .Items("DESHACER").Enabled = True
                    End With

                Case "MODIFICAR"
                    Estado = "MODIFICAR"
                    HABILITA_DATOS()
                    txt_numruc.Enabled = False
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = False
                        .Items("ELIMINAR").Enabled = False
                        .Items("GRABAR").Enabled = True
                        .Items("DESHACER").Enabled = True
                    End With

                Case "ELIMINAR"
                    ELIMINAR_DATOS()

                Case "GRABAR"
                    FilaSeleccionada = GrdLista.CurrentRow.Position
                    If VALIDA_DATOS() Then
                        SALVAR_DATOS()
                        If sMensaje = "1" Then
                            Cargar_Datos()
                            If Estado = "MODIFICAR" Then
                                GrdLista.Row = FilaSeleccionada
                            End If
                            With BarraOpciones.Groups(0)
                                .Items("ADICIONAR").Enabled = True
                                .Items("MODIFICAR").Enabled = True
                                .Items("ELIMINAR").Enabled = True
                                .Items("GRABAR").Enabled = False
                                .Items("DESHACER").Enabled = False
                            End With
                            DESHABILITA_DATOS()
                        End If
                    End If

                Case "DESHACER"
                    Estado = ""
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = True
                        .Items("MODIFICAR").Enabled = True
                        .Items("ELIMINAR").Enabled = True
                        .Items("GRABAR").Enabled = False
                        .Items("DESHACER").Enabled = False
                    End With
                    DESHABILITA_DATOS()
                    Cargar_Datos()

                Case "NOTIFICACIONSUNAT"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oNoti As New FrmMantAnexosContables_Notificacion
                        With oNoti
                            .TxtCodigo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("CODIGO").Index)
                            .TxtDescripcion.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCION").Index)
                            .TipoAnexo = GrdLista.GetValue(GrdLista.RootTable.Columns("TIPO").Index)
                            .ShowDialog()
                        End With
                    End Using
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function VALIDA_DATOS() As Boolean
        VALIDA_DATOS = True

        If cboTipAnex.SelectedValue = "P" Then
            If Len(txt_desTip.Text) = 0 And txtCod_TipoPersona.Text <> "NA" Then
                MessageBox.Show("Ingrese la descripcion del Anexo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                VALIDA_DATOS = False
                txt_desTip.Focus()
            End If
        End If

        If cboTipAnex.SelectedValue = "P" Or (cboTipAnex.SelectedValue = "C" Or cboTipAnex.SelectedValue = "W") Then
            If Len(RTrim(TxtApellido_Paterno.Text)) = 0 And txtCod_TipoPersona.Text = "NA" Then
                MessageBox.Show("Ingrese Apellido Paterno", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                VALIDA_DATOS = False
                TxtApellido_Paterno.Focus()
                Exit Function
            End If
        End If

        If cboTipAnex.SelectedValue = "P" Or (cboTipAnex.SelectedValue = "C" Or cboTipAnex.SelectedValue = "W") Then
            If Len(RTrim(TxtApellido_Materno.Text)) = 0 And txtCod_TipoPersona.Text = "NA" Then
                MessageBox.Show("Ingrese Apellido Materno", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                VALIDA_DATOS = False
                TxtApellido_Materno.Focus()
                Exit Function
            End If
        End If

        If cboTipAnex.SelectedValue = "P" Or (cboTipAnex.SelectedValue = "C" Or cboTipAnex.SelectedValue = "W") Then
            If Len(RTrim(TxtNombres.Text)) = 0 And txtCod_TipoPersona.Text = "NA" Then
                MessageBox.Show("Ingrese Nombres ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                VALIDA_DATOS = False
                TxtNombres.Focus()
                Exit Function
            End If
        End If

        If Trim(TxtCod_Postal.Text) = "" And Trim(TxtCod_Zona.Text) <> "" Then
            MessageBox.Show("Ingrese Codigo Postal asociado a la Zona", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            VALIDA_DATOS = False
            TxtCod_Postal.Focus()
            Exit Function
        End If

        If Trim(TxtCod_Postal.Text) <> "" And Trim(TxtCod_Zona.Text) = "" Then
            MessageBox.Show("Ingrese Zona del Codigo Postal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            VALIDA_DATOS = False
            TxtCod_Zona.Focus()
            Exit Function
        End If

        If Estado = "NUEVO" Then
            If Len(txt_numruc.Text) > 0 Then
                If valida_ruc() Then
                    MessageBox.Show("El ruc ya existe", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_numruc.Text = ""
                    VALIDA_DATOS = False
                    Exit Function
                End If
            End If
        End If
    End Function

    Private Function valida_ruc()
        valida_ruc = False

        strSQL = "SELECT * FROM CN_AnexosContables where num_ruc ='" & RTrim(txt_numruc.Text) & "' and cod_tipanex ='" & cboTipAnex.SelectedValue & "'"
        Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
        Dim oDr As DataRow
        If Not oDtResult Is Nothing Then
            If oDtResult.Rows.Count = 0 Then Exit Function
            valida_ruc = True
        End If
    End Function

    Sub ELIMINAR_DATOS()
        Try
            If (MessageBox.Show("¿Seguro de Eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC UP_MAN_CN_AnexosContables"
                strSQL &= vbNewLine & String.Format(" @Opc_Mant     = '{0}'", "D")
                strSQL &= vbNewLine & String.Format(",@Cod_TipAnex  = '{0}'", cboTipAnex.SelectedValue)
                strSQL &= vbNewLine & String.Format(",@Cod_Anxo     = '{0}'", Trim(txt_codtip.Text))
                strSQL &= vbNewLine & String.Format(",@Des_anexo    = '{0}'", "")
                strSQL &= vbNewLine & String.Format(",@Num_Ruc      = '{0}'", "")
                strSQL &= vbNewLine & String.Format(",@Dir_Anexo    = '{0}'", "")
                strSQL &= vbNewLine & String.Format(",@Ruc_Ant      = '{0}'", "")
                strSQL &= vbNewLine & String.Format(",@flg_RecHon   = '{0}'", "")
                strSQL &= vbNewLine & String.Format(",@cod_TipIte   = '{0}'", "")

                If (oHP.EjecutaOperacion(strSQL, cCONNECT)) Then
                    GeneraPaseAnexo(cboTipAnex.SelectedValue, Trim(txt_codtip.Text), "D")
                    LIMPIAR_DATOS()
                    Cargar_Datos()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub SALVAR_DATOS()
        Try
            Dim vCod_Cliente_Comercial As String
            Dim Tipo As String, SFLG_RecHon As String

            If Estado = "NUEVO" Then
                Tipo = "I"
            Else
                Tipo = "U"
            End If

            If chkReciboHon.Checked = True Then
                SFLG_RecHon = "S"
            Else
                SFLG_RecHon = "N"
            End If

            If chkConstAfiliacion.Checked = True Then
                sConstAfiliacion = "S"
            Else
                sConstAfiliacion = "N"
            End If

            If optSPP.Checked = True Then
                sOpcionbut = "S"
            Else
                sOpcionbut = "N"
            End If

            sNum_Ruc = txt_numruc.Text

            Dim vFlgMayor As String
            vFlgMayor = oHP.DevuelveDato("Select dbo.CN_VALIDAR_FEC_NACIMIENTO('" & dtpFechaNacimiento.Value & "')", cCONNECT)

            vCod_Cliente_Comercial = oHP.DevuelveDato("select cod_cliente from tg_cliente where abr_cliente='" & txtAbr_Cliente.Text & "'", cCONNECT)

            sMensaje = "1"

            If dtpFechaNacimiento.Visible = True Then
                If vFlgMayor = "S" Then
                    If chkConstAfiliacion.Checked = False Then
                        MessageBox.Show("Debe Ingresar Constancia de Afiliacion", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        sMensaje = "0"
                        Exit Sub
                    End If
                ElseIf vFlgMayor = "N" Then
                    If chkConstAfiliacion.Checked = True Then
                        MessageBox.Show("No Debe Ingresar Constancia de Afiliacion", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        sMensaje = "0"
                        Exit Sub
                    End If
                End If
            End If

            strSQL = "exec UP_MAN_CN_AnexosContables '" & Tipo & "','" & cboTipAnex.SelectedValue & "','" & Trim(txt_codtip.Text) & _
                "','" & UCase(Des_Apos(Trim(txt_desTip.Text))) & "','" & Trim(txt_numruc.Text) & "','" & Des_Apos(Trim(txt_diranexo.Text)) & _
                "','" & txt_rucant.Text & "','" & Trim(SFLG_RecHon) & "','','" & IIf(chkSunat.Checked = True, "S", "N") & _
                "','S','" & Des_Apos(Trim(TxtApellido_Paterno.Text)) & "','" & Des_Apos(Trim(TxtApellido_Materno.Text)) & _
                "','" & Des_Apos(Trim(TxtNombres.Text)) & "','" & IIf(OptNacional.Checked = True, "N", "E") & _
                "','" & Trim(TxtCod_Pais.Text) & "','" & Trim(TxtTelefono.Text) & "','" & Trim(TxtCod_Zona.Text) & _
                "','" & Trim(TxtCod_Postal.Text) & "','" & vCod_Cliente_Comercial & "','" & Trim(TxtCtaCteDetracciones.Text) & _
                "','" & txtCod_TipoPersona.Text & "'," & IIf(IsDBNull(Me.dtpFechaNacimiento.Value), "NULL", "'" & Me.dtpFechaNacimiento.Value & "'") & _
                ", '01', '" & txtDni.Text & "','" & txtCodDistritoDomicilio.Text & "','" & txtCodArea.Text & "','" & vusu & _
                "','" & sConstAfiliacion & "', '" & sOpcionbut & "','" & Trim(txtCod_AFP.Text) & "','" & Trim(txtCUSPP.Text) & _
                "','" & DTAfiliacion.Value.ToShortDateString & "','" & Trim(txtNroDocAfil.Text) & "'," & Val(TxtCod_Ciudad.Text) & ",'" & txtCodZona.Text & _
                "','" & txtCodNomZona.Text & "','" & txtEmailElectronico.Text & "','" & txtCodDoc.Text & "','" & txtAnalisisAdicional.Text & "'"

            Dim var As String
            var = ""
            var = oHP.DevuelveDato(strSQL, cCONNECT)

            If Not var Is Nothing Then
                If var <> "" Then GeneraPaseAnexo(cboTipAnex.SelectedValue, var, Tipo)
                sOrigen = oHP.DevuelveDato("select origen from cn_anexoscontables where cod_tipanex ='" & cboTipAnex.SelectedValue & "' and cod_anxo='" & var & "'", cCONNECT)
            Else
                sMensaje = "0"
            End If

            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function Des_Apos(strDes As String) As String
        Des_Apos = Replace(strDes, "'", "''")
    End Function

    Sub GeneraPaseAnexo(ByVal Tipo As String, Cod As String, Soption As String)

        'On Error GoTo errx
        '
        'Dim sConexion As String
        'Dim ssql As String, SSQL1 As String
        'Dim mRs As ADODB.RecordSet, Rs As ADODB.RecordSet
        'Dim i As Integer
        '
        'Set mRs = GetRecordset(cCONNECT, "SM_AnexosContables '" & Tipo & "','" & Cod & "'")
        '
        ''Set MRS = GetRecordset(cCONNECT, "SM_AnexosContables1 ") ''
        ''Soption = "I" ''
        '
        ''For i = 1 To MRS.RecordCount
        ''MsgBox i
        'With mRs
        ' Select Case Soption
        '    Case Is = "I"
        'dprInsert:
        '      ssql = "INSERT INTO " & sPrefijoTablaASIENTOSLIM & "ANEXOS(CODIGO,COD_TIPANEX,COD_ANXO,DES_ANXO,NUM_RUC,DIR_ANEXO,RUC_ANT,FLG_RECHON,COD_TIPITE,FLG_PROVEEDOR_ESPECIAL,FLG_PROBLEMAS_SUNAT) VALUES (" _
        '              & "'" & !COD_TIPANEX & "*" & !Cod_Anxo & "','" & !COD_TIPANEX & "','" & !Cod_Anxo & "','" & Des_Apos(!Des_Anexo) & "','" & Trim(!NUM_RUC) & "','" & Des_Apos(!DIR_ANEXO) & "','" & !RUC_ANT & "','" & !FLG_RECHON & "','" & !Cod_TipIte & "','" & !FLG_PROVEEDOR_ESPECIAL & "','" & !FLG_PROBLEMAS_SUNAT & "')"
        '      'SSQL1 = "INSERT INTO " & sPrefijoTablaASIENTOSLIM & "FAPROVEEDOR_1(CODIGO,RAZON_SOCIAL,RAZ_CORTA,R_U_C_,COD_CATEG) VALUES ('" _
        '              & !COD_TIPANEX & !Cod_Anxo & "','" & !Des_Anexo & "','" & !Des_Anexo & "','" & Trim(!NUM_RUC) & "','NAC')"
        '      SSQL1 = "INSERT INTO FAPROVEEDOR_1(CODIGO,RAZON_SOCIAL,RAZ_CORTA,R_U_C_,COD_CATEG) VALUES ('" _
        '              & !COD_TIPANEX & !Cod_Anxo & "','" & Des_Apos(!Des_Anexo) & "','" & Des_Apos(!Des_Anexo) & "','" & Trim(!NUM_RUC) & "','NAC')"
        '    Case Is = "U"
        '
        '      Set Rs = SLIMGetRecordset(sSLIMConnect, "SELECT * FROM " & sPrefijoTablaASIENTOSLIM & "ANEXOS WHERE CODIGO = '" & !COD_TIPANEX & "*" & !Cod_Anxo & "'")
        '      If (Rs.BOF Or Rs.EOF) Then GoTo dprInsert
        '      ssql = "UPDATE " & sPrefijoTablaASIENTOSLIM & "ANEXOS SET DES_ANXO= '" & Des_Apos(!Des_Anexo) & "', NUM_RUC='" & Trim(!NUM_RUC) & "', DIR_ANEXO='" & Des_Apos(!DIR_ANEXO) _
        '              & "', RUC_ANT='" & !RUC_ANT & "', FLG_RECHON='" & !FLG_RECHON & "', COD_TIPITE='" & !Cod_TipIte & _
        '              "', FLG_PROVEEDOR_ESPECIAL='" & !FLG_PROVEEDOR_ESPECIAL & "', FLG_PROBLEMAS_SUNAT='" & !FLG_PROBLEMAS_SUNAT _
        '              & "' WHERE CODIGO = '" & !COD_TIPANEX & "*" & !Cod_Anxo & "'"
        '      'SSQL1 = "UPDATE " & sPrefijoTablaASIENTOSLIM & "FAPROVEEDOR_1 SET RAZON_SOCIAL='" & !Des_Anexo & "',RAZ_CORTA='" & !Des_Anexo & "',R_U_C_='" & Trim(!NUM_RUC) _
        '              & "' WHERE CODIGO ='" & !COD_TIPANEX & !Cod_Anxo & "'"
        '      SSQL1 = "UPDATE FAPROVEEDOR_1 SET RAZON_SOCIAL='" & Des_Apos(!Des_Anexo) & "',RAZ_CORTA='" & Des_Apos(!Des_Anexo) & "',R_U_C_='" & Trim(!NUM_RUC) _
        '              & "' WHERE CODIGO ='" & !COD_TIPANEX & !Cod_Anxo & "'"
        '    Case Is = "D"
        '      ssql = "DELETE FROM " & sPrefijoTablaASIENTOSLIM & "ANEXOS WHERE CODIGO ='" & Tipo & "*" & Cod & "'"
        '      'SSQL1 = "DELETE FROM " & sPrefijoTablaASIENTOSLIM & "FAPROVEEDOR_1 WHERE CODIGO ='" & tipo & Cod & "'"
        '      SSQL1 = "DELETE FROM FAPROVEEDOR_1 WHERE CODIGO ='" & Tipo & Cod & "'"
        '    End Select
        'End With
        '    SLIMExecuteSQL sSLIMConnect, ssql
        '    SLIMExecuteSQL sSLIMConnect, SSQL1
        '  '  MRS.MoveNext  '    SSQL1 = "UPDATE FAPROVEEDOR_1 SET RAZON_SOCIAL='" & !Des_Anexo & "',RAZ_CORTA='" & !Des_Anexo & "',R_U_C_='" & Trim(!Num_Ruc) _
        '              & "' WHERE CODIGO ='" & !COD_TIPANEX & !COD_ANXO & "'"
        '
        ''Next i '
        'Exit Sub
        'errx:
        '    ExecuteSQL cCONNECT, "Cn_Man__Errores_Interfase_Slim '010" & Soption & "','" & Tipo & "','" & Cod & "','','','" & vusu & "','" & ComputerName & "','" & err.Description & "'"
        '    errores err
    End Sub

    Private Sub cboTipAnex_Click(sender As Object, e As EventArgs) Handles cboTipAnex.Click
        If UCase(oHP.DevuelveDato("select flg_modificable from CN_TipoAnexoContable where cod_tipanex = '" & cboTipAnex.SelectedValue & "'", cCONNECT)) = "N" Then
            MessageBox.Show("Tipo de anexo no se permite editar", "Tipo Anexo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If (cboTipAnex.SelectedValue = "C" Or cboTipAnex.SelectedValue = "W") And OptExtranjero.Checked = True Then
            FraClienteComercial.Visible = True
            txtCod_TipoPersona.Text = "JU"
            CodTipoPersona()
        End If
        If cboTipAnex.SelectedValue = "P" Then
            '        txtCod_TipoPersona = "JU"
            '        txtCod_TipoPersona_KeyPress vbKeyReturn
        End If

        If cboTipAnex.Text = "PROVEEDOR" Then
            chkConstAfiliacion.Visible = True
        Else
            chkConstAfiliacion.Visible = False
        End If
    End Sub

    Private Sub OptNacional_Click(sender As Object, e As EventArgs) Handles OptNacional.Click
        If OptNacional.Checked = True Then
            FraPais.Visible = False
            TxtCod_Pais.Text = ""
            TxtDes_Pais.Text = ""
        Else
            FraPais.Visible = True
            TxtCod_Zona.Text = ""
            TxtDes_Zona.Text = ""
            TxtCod_Postal.Text = ""
            TxtDes_Postal.Text = ""
        End If

        If (OptNacional.Checked = True) Then
            If txtCod_TipoPersona.Text = "JU" Then
                txtCodDoc.Text = "6"
            ElseIf (txtCod_TipoPersona.Text = "NA") Then
                txtCodDoc.Text = "1"
            End If
        Else
            txtCodDoc.Text = "0"
        End If
        BUSCA_DOCUMENTO(1)
    End Sub

    Private Sub OptExtranjero_Click(sender As Object, e As EventArgs) Handles OptExtranjero.Click
        If OptNacional.Checked = True Then
            FraPais.Visible = False
            'FraZona.Visible = True
            TxtCod_Pais.Text = ""
            TxtDes_Pais.Text = ""
            FraClienteComercial.Visible = False
            txtAbr_Cliente.Text = ""
            txtDes_Cliente.Text = ""
        Else
            FraPais.Visible = True
            'FraZona.Visible = False
            TxtCod_Zona.Text = ""
            TxtDes_Zona.Text = ""
            TxtCod_Postal.Text = ""
            TxtDes_Postal.Text = ""
            If cboTipAnex.SelectedValue = "C" Or cboTipAnex.SelectedValue = "W" Then
                FraClienteComercial.Visible = True
            End If
        End If

        If (OptNacional.Checked = True) Then
            If txtCod_TipoPersona.Text = "JU" Then
                txtCodDoc.Text = "6"
            ElseIf (txtCod_TipoPersona.Text = "NA") Then
                txtCodDoc.Text = "1"
            End If
        Else
            txtCodDoc.Text = "0"
        End If
        BUSCA_DOCUMENTO(1)
    End Sub

    Private Sub txt_codtip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codtip.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If OptBUSCA.Checked = True Then
                Optmante.Checked = True
            End If
        End If
    End Sub

    Private Sub txtCod_TipoPersona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_TipoPersona.KeyPress
        sprueba = 0
        If (Asc(e.KeyChar) = Keys.Enter) Then
            CodTipoPersona()
        End If
    End Sub

    Sub CodTipoPersona()
        If Me.Visible Then
            If OptOrigenE.Checked = True Then
                txtCod_TipoPersona.Text = "OT"
                BuscaTipoPersona(1)
            Else
                BuscaTipoPersona(1)
            End If
        End If

        If txtCod_TipoPersona.Text = "NA" And Estado = "NUEVO" Then
            txt_desTip.Text = ""
            txt_desTip.Enabled = False
        Else
            txt_desTip.Enabled = True
        End If

        If txtCod_TipoPersona.Text = "NA" And Me.chkReciboHon.Checked = True Then
            Me.dtpFechaNacimiento.Checked = True
            Me.lblFechaNac.Visible = True
            Me.dtpFechaNacimiento.Visible = True
        Else
            Me.dtpFechaNacimiento.Checked = True
            Me.lblFechaNac.Visible = False
            Me.dtpFechaNacimiento.Visible = False
        End If
    End Sub

    Private Sub txtDes_TipoPersona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_TipoPersona.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaTipoPersona(2)
        End If
    End Sub

    Sub BuscaTipoPersona(Tipo As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        If Tipo = 1 Then
            oTipo.sQuery = "select Cod_TipoPersona as Codigo, Des_TipoPersona as Descripcion from CN_TIPOPERSONA where Cod_TipoPersona <> '' AND Cod_TipoPersona  like '%" & Trim(txtCod_TipoPersona.Text) & "%' order by COD_TIPOPERSONA"
        Else
            oTipo.sQuery = "select Cod_TipoPersona  as Codigo, Des_TipoPersona as Descripcion from cn_tipopersona where Cod_TipoPersona <> '' AND des_tipopersona like '%" & Trim(txtDes_TipoPersona.Text) & "%' order by des_tipopersona"
        End If
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            txtCod_TipoPersona.Text = Trim(Codigo)
            txtDes_TipoPersona.Text = Trim(Descripcion)
        End If

        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        txtCodDoc.Focus()
        oTipo = Nothing
    End Sub

    Private Sub txtCodDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodDoc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Trim(txtCodDoc.Text) = "" Then
                Call Me.BUSCA_DOCUMENTO(3)
            Else
                Call Me.BUSCA_DOCUMENTO(1)
            End If
        End If
    End Sub

    Private Sub txtDesDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesDoc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Me.BUSCA_DOCUMENTO(2)
        End If
    End Sub

    Public Sub BUSCA_DOCUMENTO(Tipo As Integer)
        Select Case Tipo
            Case 1
                strSQL = "SELECT Des_Tipo_Doc_Proveedor FROM CN_Tipo_Doc_Ide_Proveedor WHERE Cod_Tipo_Doc_Proveedor = '" & Trim(txtCodDoc.Text) & "'"
                Me.txtDesDoc.Text = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
            Case 2, 3
                Dim oTipo As New frmBusqGeneral6
                oTipo.oParent = Me
                If Tipo = 2 Then
                    oTipo.sQuery = "SELECT Cod_Tipo_Doc_Proveedor, Des_Tipo_Doc_Proveedor FROM CN_Tipo_Doc_Ide_Proveedor WHERE Des_CondVent LIKE '%" & Trim(txtDesDoc.Text) & "%' ORDER BY Des_Tipo_Doc_Proveedor"
                Else
                    oTipo.sQuery = "SELECT Cod_Tipo_Doc_Proveedor, Des_Tipo_Doc_Proveedor FROM CN_Tipo_Doc_Ide_Proveedor ORDER BY Des_Tipo_Doc_Proveedor"
                End If
                oTipo.Cargar_Datos()
                If oTipo.dtResultados.Rows.Count <> 1 Then
                    oTipo.ShowDialog()
                Else
                    Codigo = oTipo.dtResultados.Rows(0)("Cod_Tipo_Doc_Proveedor")
                    Descripcion = oTipo.dtResultados.Rows(0)("Des_Tipo_Doc_Proveedor")
                End If

                If Codigo <> "" Then
                    txtCodDoc.Text = Trim(Codigo)
                    txtDesDoc.Text = Trim(Descripcion)
                End If

                Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
                txt_numruc.Focus()
                oTipo = Nothing
        End Select
    End Sub

    Private Sub txt_numruc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numruc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            ruc = txt_numruc.Text
            ruc_2 = Strings.Left(ruc, 2)

            If OptBUSCA.Checked = True Then
                Optmante.Checked = True
                'gexList.Find(4, jgexEqual, txt_numruc.Text)
            End If

            If cboTipAnex.SelectedValue = "P" Or cboTipAnex.SelectedValue = "C" Or cboTipAnex.SelectedValue = "W" Then
                If Len(ruc) <= 8 Or (Len(ruc) > 8 And ruc_2 = "10") Then
                    If txt_numruc.Text <> "" Then
                        txtCod_TipoPersona.Text = "NA"
                        CodTipoPersona()
                        txt_desTip.Enabled = False
                        Me.TxtApellido_Paterno.Enabled = True
                        Me.TxtApellido_Materno.Enabled = True
                        Me.TxtNombres.Enabled = True
                        Me.TxtApellido_Paterno.Focus()
                    End If
                Else
                    If Len(ruc) > 8 Then
                        If txt_numruc.Text <> "" Then
                            txtCod_TipoPersona.Text = "JU"
                            CodTipoPersona()
                            txt_desTip.Enabled = True
                            Me.TxtApellido_Paterno.Enabled = False
                            Me.TxtApellido_Materno.Enabled = False
                            Me.TxtNombres.Enabled = False
                            txt_desTip.Focus()
                        End If
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub cmdbuscaruc_Click(sender As Object, e As EventArgs) Handles cmdbuscaruc.Click
        'txt_codtip.Text = ""
        'sflag = "RUC_ANXCON"
        'If Filtrar(sflag, Me, txt_codtip, txt_desTip) Then
        '    BUSCA_DATOS("CODIGO")
        'End If
        'Opciones_Mant()
        'Optmante.Checked = True
    End Sub

    Private Sub txt_desTip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_desTip.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If OptBUSCA.Checked Then
                Optmante.Checked = True
                TxtApellido_Paterno.Focus()
            End If
        End If
    End Sub

    Private Sub CmdBuscaDes_Click(sender As Object, e As EventArgs) Handles CmdBuscaDes.Click
        'txt_codtip.Text = ""
        'sflag = "DES_ANXCON"
        'If Filtrar(sflag, Me, txt_codtip, txt_desTip) Then
        '    BUSCA_DATOS("CODIGO")
        'End If
        'Opciones_Mant()
    End Sub

    Private Sub TxtApellido_Paterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellido_Paterno.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtApellido_Materno.Focus()
        End If
    End Sub

    Private Sub TxtApellido_Materno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellido_Materno.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtNombres.Focus()
        End If
    End Sub

    Private Sub TxtNombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombres.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            dtpFechaNacimiento.Focus()
        End If
    End Sub

    Private Sub dtpFechaNacimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFechaNacimiento.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If dtpFechaNacimiento.Visible = True Then
                Dim vFlgMayor As String
                vFlgMayor = oHP.DevuelveDato("Select dbo.CN_VALIDAR_FEC_NACIMIENTO('" & dtpFechaNacimiento.Value & "')", cCONNECT)
                If vFlgMayor = "S" Then
                    chkmayordeedadlimite.Checked = True
                    txtDni.Focus()
                Else
                    chkmayordeedadlimite.Checked = False
                    txtDni.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub dtpFechaNacimiento_LostFocus(sender As Object, e As EventArgs) Handles dtpFechaNacimiento.LostFocus
        If dtpFechaNacimiento.Visible = True Then
            Dim vFlgMayor As String
            vFlgMayor = oHP.DevuelveDato("Select dbo.CN_VALIDAR_FEC_NACIMIENTO('" & dtpFechaNacimiento.Value & "')", cCONNECT)
            If vFlgMayor = "S" Then
                chkmayordeedadlimite.Checked = True
            Else
                chkmayordeedadlimite.Checked = False
            End If
        End If
    End Sub

    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtTelefono.Focus()
        End If
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txt_rucant.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txt_rucant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rucant.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txt_diranexo.Focus()
        End If
    End Sub

    Private Sub txt_diranexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_diranexo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCodDistritoDomicilio.Focus()
        End If
    End Sub

    Private Sub txtCodDistritoDomicilio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodDistritoDomicilio.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If txtCodDistritoDomicilio.Text = "" Then
                Using oUbig As New FrmMantAnexosContables_MantenimientoUbigeo
                    With oUbig
                        .ShowDialog()
                        txtCodDistritoDomicilio.Text = .CodDistrito
                        txtDesDistritoDomicilio.Text = .DesDistrito
                    End With
                End Using
            Else
                strSQL = "select descripcion from tg_ubigeo  where cod_ubigeo='" & txtCodDistritoDomicilio.Text & "' and substring(cod_ubigeo,5,6)<>'00'"
                txtDesDistritoDomicilio.Text = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
            End If
            txtCodZona.Focus()
        End If
    End Sub

    Private Sub txtCodZona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodZona.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Trim(txtCodZona.Text) = "" Then
                Call Me.BUSCAR_ZONAS(3)
            Else
                Call Me.BUSCAR_ZONAS(1)
            End If
        End If
    End Sub

    Private Sub txtDesZona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesZona.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Me.BUSCAR_ZONAS(2)
        End If
    End Sub

    Public Sub BUSCAR_ZONAS(Tipo As Integer)
        Select Tipo
            Case 1
                strSQL = "SELECT Des_Zona FROM TG_ZONA WHERE Cod_Zona = '" & Trim(txtCodZona.Text) & "'"
                Me.txtDesZona.Text = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                If Trim(txtDesZona.Text) <> "" Then
                    txtCodNomZona.Focus()
                End If
            Case 2, 3
                Dim oTipo As New frmBusqGeneral6
                oTipo.oParent = Me
                If Tipo = 2 Then
                    oTipo.sQuery = "select Cod_Zona, Des_Zona from  TG_ZONA  WHERE Des_Zona LIKE '%" & Trim(txtDesZona.Text) & "%' ORDER BY Des_Zona"
                Else
                    oTipo.sQuery = "SELECT Cod_Zona, Des_Zona FROM TG_ZONA ORDER BY Des_Zona"
                End If
                oTipo.Cargar_Datos()
                If oTipo.dtResultados.Rows.Count <> 1 Then
                    oTipo.ShowDialog()
                Else
                    Codigo = oTipo.dtResultados.Rows(0)("Cod_Zona")
                    Descripcion = oTipo.dtResultados.Rows(0)("Des_Zona")
                End If

                If Codigo <> "" Then
                    txtCodZona.Text = Trim(Codigo)
                    txtDesZona.Text = Trim(Descripcion)
                End If

                Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
                txtCodNomZona.Focus()
                oTipo = Nothing
        End Select
    End Sub

    Private Sub txtCodNomZona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodNomZona.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtEmailElectronico.Focus()
        End If
    End Sub

    Private Sub txtEmailElectronico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmailElectronico.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtCod_Pais.Focus()
        End If
    End Sub

    Private Sub TxtCod_Pais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_Pais.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Pais("1")
        End If
    End Sub

    Private Sub TxtDes_Pais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDes_Pais.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Pais("2")
        End If
    End Sub

    Sub Busca_Pais(Tipo As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        If Tipo = 1 Then
            oTipo.sQuery = "select Cod_Pais as Codigo, Descripcion from cn_Paises where Cod_pais like '%" & Trim(TxtCod_Pais.Text) & "%' order by cod_pais"
        Else
            oTipo.sQuery = "select Cod_Pais as Codigo, Descripcion from cn_Paises where Descripcion like '%" & Trim(TxtDes_Pais.Text) & "%' order by descripcion"
        End If
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            TxtCod_Pais.Text = Trim(Codigo)
            TxtDes_Pais.Text = Trim(Descripcion)
        End If

        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        TxtCod_Ciudad.Focus()
        oTipo = Nothing
    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        Using oPais As New FrmMantenimientoPaises
            With oPais
                .oParent = Me
                .ShowDialog()
            End With
        End Using
    End Sub

    Private Sub TxtCod_Ciudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_Ciudad.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Trim(TxtCod_Pais.Text) <> "" Then
                Call Busca_Ciudad_P("1")
            End If
        End If
    End Sub

    Private Sub TxtDes_Ciudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDes_Ciudad.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Trim(TxtCod_Pais.Text) <> "" Then
                Call Busca_Ciudad_P("2")
            End If
        End If
    End Sub

    Sub Busca_Ciudad_P(Tipo As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        If Tipo = 1 Then
            oTipo.sQuery = "select Cod_Ciudad as Codigo, Nom_Ciudad As Descripcion from cn_ciudades where Cod_Pais = '" & Trim(TxtCod_Pais.Text) & "' And Cod_Ciudad like '%" & Trim(TxtCod_Ciudad.Text) & "%' order by Cod_Ciudad"
        Else
            oTipo.sQuery = "select Cod_Ciudad as Codigo, Nom_Ciudad As Descripcion from cn_ciudades where Cod_Pais = '" & Trim(TxtCod_Pais.Text) & "' And Nom_Ciudad like '%" & Trim(TxtDes_Ciudad.Text) & "%' order by Nom_Ciudad"
        End If
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            TxtCod_Ciudad.Text = Trim(Codigo)
            TxtDes_Ciudad.Text = Trim(Descripcion)
        End If

        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        TxtCod_Zona.Focus()
        oTipo = Nothing
    End Sub

    Private Sub TxtCod_Zona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_Zona.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call BUSCA_ZONA("1")
        End If
    End Sub

    Private Sub TxtDes_Zona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDes_Zona.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call BUSCA_ZONA("2")
        End If
    End Sub

    Sub BUSCA_ZONA(Tipo As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        If Tipo = 1 Then
            oTipo.sQuery = "select Cod_Zona as Codigo, Descripcion from cn_Zonas where Cod_Zona like '%" & Trim(TxtCod_Zona.Text) & "%' order by cod_zona"
        Else
            oTipo.sQuery = "select Cod_Zona as Codigo, Descripcion from cn_Zonas where Descripcion like '%" & Trim(TxtDes_Pais.Text) & "%' order by descripcion"
        End If
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            TxtCod_Zona.Text = Trim(Codigo)
            TxtDes_Zona.Text = Trim(Descripcion)
        End If

        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        TxtCod_Postal.Focus()
        oTipo = Nothing
    End Sub

    Private Sub TxtCod_Postal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_Postal.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Trim(TxtCod_Zona.Text) = "" Then
                MessageBox.Show("Debe ingresar Zona", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtCod_Zona.Focus()
                Exit Sub
            End If
            Call Busca_Postal("1")
        End If
    End Sub

    Private Sub TxtDes_Postal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDes_Postal.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Postal("2")
        End If
    End Sub

    Sub Busca_Postal(Tipo As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        If Tipo = 1 Then
            oTipo.sQuery = "select Codigo_Postal as Codigo, Descripcion from Cn_Zonas_Codigo_Postal where cod_zona ='" & Trim(TxtCod_Zona.Text) & "' and Codigo_Postal like '%" & Trim(TxtCod_Postal.Text) & "%' order by Codigo_Postal"
        Else
            oTipo.sQuery = "select Codigo_Postal as Codigo, Descripcion from Cn_Zonas_Codigo_Postal where cod_zona ='" & Trim(TxtCod_Zona.Text) & "' and Descripcion like '%" & Trim(TxtDes_Pais.Text) & "%' order by descripcion"
        End If
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            TxtCod_Postal.Text = Trim(Codigo)
            TxtDes_Postal.Text = Trim(Descripcion)
        End If

        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        txtAnalisisAdicional.Focus()
        oTipo = Nothing
    End Sub

    Private Sub txtAnalisisAdicional_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnalisisAdicional.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtAbr_Cliente.Focus()
        End If
    End Sub

    Private Sub txtAbr_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbr_Cliente.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call BUSCA_CLIENTE("1")
        End If
    End Sub

    Private Sub txtDes_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Cliente.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call BUSCA_CLIENTE("2")
        End If
    End Sub

    Sub BUSCA_CLIENTE(Tipo As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        If Tipo = 1 Then
            oTipo.sQuery = "select Abr_Cliente as Codigo, Nom_Cliente As Descripcion from TG_CLIENTE where Abr_Cliente like '%" & Trim(txtAbr_Cliente.Text) & "%' order by Abr_Cliente"
        Else
            oTipo.sQuery = "select Abr_Cliente as Codigo, Nom_Cliente As Descripcion from TG_CLIENTE where Nom_Cliente like '%" & Trim(txtDes_Cliente.Text) & "%' order by Nom_Cliente"
        End If
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            txtAbr_Cliente.Text = Trim(Codigo)
            txtDes_Cliente.Text = Trim(Descripcion)
        End If

        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        txtCodArea.Focus()
        oTipo = Nothing
    End Sub

    Private Sub txtCodArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodArea.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_ProveeAN("1")
        End If
    End Sub

    Sub Busca_ProveeAN(Tipo As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        If Tipo = 1 Then
            oTipo.sQuery = "select Cod_Tip_proveedor_area_negocio as Codigo, Descripcion from tg_tipos_proveedores_area_negocio where Cod_Tip_proveedor_area_negocio like '%" & Trim(txtCodArea.Text) & "%' order by Cod_Tip_proveedor_area_negocio"
        Else
            oTipo.sQuery = "select Cod_Tip_proveedor_area_negocio as Codigo, Descripcion from tg_tipos_proveedores_area_negocio where Descripcion like '%" & Trim(TxtDesArea.Text) & "%' order by Descripcion"
        End If
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            txtCodArea.Text = Trim(Codigo)
            TxtDesArea.Text = Trim(Descripcion)
        End If

        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        DTAfiliacion.Focus()
        oTipo = Nothing
    End Sub

    Private Sub TxtDesArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDesArea.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Len(TxtDesArea) > 4 Then
                strSQL = "SELECT Cod_Tip_proveedor_area_negocio FROM tg_tipos_proveedores_area_negocio WHERE Descripcion LIKE '" & Trim(TxtDesArea.Text) & "%'"
                txtCodArea.Text = oHP.DevuelveDato(strSQL, cCONNECT)
                strSQL = "SELECT Descripcion FROM tg_tipos_proveedores_area_negocio WHERE Cod_Tip_proveedor_area_negocio='" & Trim(txtCodArea.Text) & "'"
                TxtDesArea.Text = oHP.DevuelveDato(strSQL, cCONNECT)
                BarraOpciones.Focus()
            Else
                MessageBox.Show("El Texto Ingresado debe contar con un mínimo de 5 caracteres", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                DTAfiliacion.Focus()
            End If
        End If
    End Sub

    Private Sub DTAfiliacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTAfiliacion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BarraOpciones.Focus()
        End If
    End Sub

    Private Sub chkReciboHon_Click(sender As Object, e As EventArgs) Handles chkReciboHon.Click
        If txtCod_TipoPersona.Text = "NA" And chkReciboHon.Checked = True Then
            dtpFechaNacimiento.Visible = True
            Me.lblFechaNac.Visible = True
        Else
            Me.dtpFechaNacimiento.Checked = False
            dtpFechaNacimiento.Visible = False
            Me.lblFechaNac.Visible = False
        End If
    End Sub

    Private Sub chkConstAfiliacion_Click(sender As Object, e As EventArgs) Handles chkConstAfiliacion.Click
        If chkConstAfiliacion.Checked = False Then
            Frame9.Visible = False
            DTAfiliacion.Visible = False
            lblFec_Afiliacion.Visible = False
            txtCod_AFP.Text = ""
            txtDes_AFP.Text = ""
            txtCUSPP.Text = ""
            txtNroDocAfil.Text = ""
        Else
            Frame9.Visible = True
            DTAfiliacion.Visible = True
            lblFec_Afiliacion.Visible = True
            txtCod_AFP.Text = ""
            txtDes_AFP.Text = ""
            txtCUSPP.Text = ""
            txtNroDocAfil.Text = ""
            optSPP.Checked = True
        End If
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            If GrdLista.RecordCount > 0 Then
                FilaSeleccionada = GrdLista.CurrentRow.Position
            End If
            Select Case e.Item.Key
                Case "NOTIFICACIONSUNAT"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oNoti As New FrmMantAnexosContables_Notificacion
                        With oNoti
                            .TxtCodigo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("CODIGO").Index)
                            .TxtDescripcion.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCION").Index)
                            .TipoAnexo = GrdLista.GetValue(GrdLista.RootTable.Columns("TIPO").Index)
                            .ShowDialog()
                        End With
                    End Using

                Case "EMAILPAGOS"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oEmail As New FrmMantAnexosContables_EmailPagos
                        With oEmail
                            .TxtCodigo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("CODIGO").Index)
                            .TxtDescripcion.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCION").Index)
                            .TipoAnexo = GrdLista.GetValue(GrdLista.RootTable.Columns("TIPO").Index)
                            .TxtMail.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("E_mail_comunicacion_pago").Index)
                            .TxtContacto.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Contacto_Pago").Index)
                            If GrdLista.GetValue(GrdLista.RootTable.Columns("Flg_Suspension_Email").Index) = "S" Then
                                .ChkSuspension.Checked = True
                            Else
                                .ChkSuspension.Checked = False
                            End If
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                Cargar_Datos()
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "DATOSADICIONALES"
                    Using oDatos As New FrmMantAnexosContables_DatosAdicionales
                        With oDatos
                            .TxtCodigo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("CODIGO").Index)
                            .TxtDescripcion.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCION").Index)
                            .TipoAnexo = GrdLista.GetValue(GrdLista.RootTable.Columns("TIPO").Index)

                            If GrdLista.GetValue(GrdLista.RootTable.Columns("Flg_Buen_Contribuyente").Index) = "S" Then
                                .optSiBuenContribuyente.Checked = True
                                .optNOBuenContribuyente.Checked = False
                            Else
                                .optSiBuenContribuyente.Checked = False
                                .optNOBuenContribuyente.Checked = True
                            End If

                            If GrdLista.GetValue(GrdLista.RootTable.Columns("Flg_Agente_Retencion_IGV").Index) = "S" Then
                                .optSIAgenteRetencionIGV.Checked = True
                                .optNOAgenteRetencionIGV.Checked = False
                            Else
                                .optSIAgenteRetencionIGV.Checked = False
                                .optNOAgenteRetencionIGV.Checked = True
                            End If

                            If GrdLista.GetValue(GrdLista.RootTable.Columns("Flg_Agente_Percepcion").Index) = "S" Then
                                .optSIAgente_Percepcion.Checked = True
                                .optNOAgente_Percepcion.Checked = False
                            Else
                                .optSIAgente_Percepcion.Checked = False
                                .optNOAgente_Percepcion.Checked = True
                            End If

                            If GrdLista.GetValue(GrdLista.RootTable.Columns("Flg_Considerado_Para_Retencion").Index) = "S" Then
                                .optSIConsiderado_Para_Retencion.Checked = True
                                .optNOConsiderado_Para_Retencion.Checked = False
                            Else
                                .optSIConsiderado_Para_Retencion.Checked = False
                                .optNOConsiderado_Para_Retencion.Checked = True
                            End If

                            If GrdLista.GetValue(GrdLista.RootTable.Columns("Flg_No_Habido").Index) = "S" Then
                                .OptSiEncuentra_Habido.Checked = True
                                .OptNoEncuentra_Habido.Checked = False
                            Else
                                .OptSiEncuentra_Habido.Checked = False
                                .OptNoEncuentra_Habido.Checked = True
                            End If
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                Cargar_Datos()
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "IMPRESION"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oImp As New FrmMantAnexosContables_Impresion
                        With oImp
                            .ShowDialog()
                        End With
                    End Using

                Case "IMPFECCREA"
                    ReporteAnexCont()

                Case "EDICTACTEDET"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oDet As New FrmMantAnexosContables_EditDetraccion
                        With oDet
                            .TxtCodigo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("CODIGO").Index)
                            .TxtDescripcion.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCION").Index)
                            .TipoAnexo = GrdLista.GetValue(GrdLista.RootTable.Columns("TIPO").Index)
                            .TxtCtaCteDetracciones.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("CTACTE_DETRACCIONES").Index)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                Cargar_Datos()
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "CTACORRIENTE"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oCTaCrr As New FrmMantAnexosContables_CuentaCorriente
                        With oCTaCrr
                            .TxtCodigo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("CODIGO").Index)
                            .TxtDescripcion.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCION").Index)
                            .TipoAnexo = GrdLista.GetValue(GrdLista.RootTable.Columns("TIPO").Index)
                            .CARGA_GRID()
                            .ShowDialog()
                        End With
                    End Using

                Case "RESPAG"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oCTaCrr As New FrmMantAnexosContables_RestriccionPago
                        With oCTaCrr
                            .TxtCodigo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("CODIGO").Index)
                            .TxtDescripcion.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCION").Index)
                            .TipoAnexo = GrdLista.GetValue(GrdLista.RootTable.Columns("TIPO").Index)
                            .CARGA_GRID()
                            .ShowDialog()
                        End With
                    End Using

                Case "ALTRES"
                    If GrdLista.RowCount > 0 Then
                        AltaBitacora()
                        GrdLista.Row = FilaSeleccionada
                    Else
                        MessageBox.Show("Busque un Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                Case "BAJP"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oCTaCrr As New FrmMantAnexosContables_BajaProveedor
                        With oCTaCrr
                            .TxtCodigo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("CODIGO").Index)
                            .TxtDescripcion.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCION").Index)
                            .TipoAnexo = GrdLista.GetValue(GrdLista.RootTable.Columns("TIPO").Index)
                            .CARGA_GRID()
                            .ShowDialog()
                        End With
                    End Using

                Case "ALPR"
                    If GrdLista.RowCount > 0 Then
                        BajaProveedor()
                        GrdLista.Row = FilaSeleccionada
                    Else
                        MessageBox.Show("Busque un Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                Case "CERSUCAT"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oCTaCrr As New FrmMantAnexosContables_Certificado
                        With oCTaCrr
                            .txt_CodAnexo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("CODIGO").Index)
                            .txt_DesAnexo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("DESCRIPCION").Index)
                            .txt_TipAnexo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("TIPO").Index)
                            .CARGA_GRID()
                            .ShowDialog()
                        End With
                    End Using

                Case "LIBCTACTEPEDCLI"
                    If GrdLista.RowCount > 0 Then
                        If GrdLista.GetValue(GrdLista.RootTable.Columns("Tipo").Index) = "N" Then
                            If MessageBox.Show("¿Esta seguro que desea liberar la Cuenta Corriente Pendiente de Cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                Liberar_o_Bloquear()
                            End If
                        Else
                            If MessageBox.Show("¿Esta seguro que desea bloquear la Cuenta Corriente Pendiente de Cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                Liberar_o_Bloquear()
                            End If
                        End If
                    Else
                        MessageBox.Show("No Hay Cuentas Para Liberar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Case "LIBCTACTEPEDCLIXAPLI"
                    If GrdLista.RowCount > 0 Then
                        If GrdLista.GetValue(GrdLista.RootTable.Columns("Tipo").Index) = "N" Then
                            If MessageBox.Show("¿Esta seguro que desea liberar la Cuenta Corriente Pendiente de Cliente por Aplicar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                Liberar_o_bloquear_X_Aplicar()
                            End If
                        Else
                            If MessageBox.Show("¿Esta seguro que desea bloquear la Cuenta Corriente Pendiente de Cliente por Aplicar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                Liberar_o_bloquear_X_Aplicar()
                            End If
                        End If
                    Else
                        MessageBox.Show("No Hay Cuentas Por Aplicar Para Liberar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub AltaBitacora()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MAN_ANEXOSCONTABLES_PAGO_RESTRINGIDO"
            strSQL &= vbNewLine & String.Format(" @ACCION       = '{0}'", "A")
            strSQL &= vbNewLine & String.Format(",@COD_TIPANEX  = '{0}'", Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("tipo").Index)))
            strSQL &= vbNewLine & String.Format(",@COD_ANXO     = '{0}'", Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("codigo").Index)))
            strSQL &= vbNewLine & String.Format(",@SEC          =  {0} ", 0)
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO  = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@OBS_PAGO_RESTRINGIDO = '{0}'", "")
            strSQL &= vbNewLine & String.Format(",@COD_ESTACION = '{0}'", ComputerName())

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Proceso Culminó Satisfactoriamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cargar_Datos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub BajaProveedor()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MAN_ANEXOSCONTABLES_BAJA_ANEXO"
            strSQL &= vbNewLine & String.Format(" @ACCION       = '{0}'", "A")
            strSQL &= vbNewLine & String.Format(",@COD_TIPANEX  = '{0}'", cboTipAnex.SelectedValue)
            strSQL &= vbNewLine & String.Format(",@COD_ANXO     = '{0}'", txt_codtip.Text)
            strSQL &= vbNewLine & String.Format(",@SEC          =  {0} ", 0)
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO  = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@COD_MOTIVO_BAJA  = '{0}'", "")
            strSQL &= vbNewLine & String.Format(",@OBS_BAJA     = '{0}'", "")
            strSQL &= vbNewLine & String.Format(",@COD_ESTACION = '{0}'", ComputerName())

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Proceso Culminó Satisfactoriamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cargar_Datos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub ReporteAnexCont()
        Dim oo As Object
        Dim Ruta As String
        Dim fechas As String

        If Me.chkFechas.Checked = True Then
            fechas = "Fecha Crea. Inicio : " & Me.dtpFechaInicio.Value.ToShortDateString & " - Fecha Crea. Fin : " & Me.dtpFechaFin.Value.ToShortDateString
        End If
        Ruta = vRuta & "\RptAnexosContables.XLT"
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(Ruta)
        oo.Visible = True
        oo.DisplayAlerts = False
        oo.Run("reporte", strSQLTrazaImp, Me.cboTipAnexBusqueda, IIf(Me.OptNacional.Checked = True, "N", "E"), fechas, vemp, cCONNECTVB6)
        oo = Nothing
    End Sub

    Sub Liberar_o_Bloquear()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC up_man_anexoscontables_libera_ctacte_pend_clientes"
            strSQL &= vbNewLine & String.Format(" @COD_TIPANEX  = '{0}'", Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("tipo").Index)))
            strSQL &= vbNewLine & String.Format(",@COD_ANXO     = '{0}'", Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("codigo").Index)))
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO  = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@COD_ESTACION = '{0}'", ComputerName())

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("La Cuenta Fue Liberada con éxito.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cargar_Datos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub Liberar_o_bloquear_X_Aplicar()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC up_man_anexoscontables_libera_ctacte_pend_clientes_por_aplicar"
            strSQL &= vbNewLine & String.Format(" @COD_TIPANEX  = '{0}'", Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("tipo").Index)))
            strSQL &= vbNewLine & String.Format(",@COD_ANXO     = '{0}'", Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("codigo").Index)))
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO  = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@COD_ESTACION = '{0}'", ComputerName())

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("La Cuenta Fue Liberada con éxito.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cargar_Datos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

#Region "CAMPOS OCULTOS"
    Private Sub Optmante_Click(sender As Object, e As EventArgs) Handles Optmante.Click
        If Optmante.Checked = True Then
            Opciones_Mant()
            Optmante.Checked = True
            OptBUSCA.Checked = False
        End If
    End Sub

    Private Sub Opciones_Mant()
        txt_codtip.BackColor = Color.White
        txt_desTip.BackColor = Color.White
        txt_numruc.BackColor = Color.White
        txt_diranexo.BackColor = Color.White
        Me.cboTipAnex.BackColor = Color.White
        cmdBuscaCodigo.Enabled = False
        CmdBuscaDes.Enabled = False
        cmdbuscaruc.Enabled = False
        txt_diranexo.Enabled = True
        chkReciboHon.Enabled = False
        Me.cboTipAnex.Enabled = True
        With BarraOpciones.Groups(0)
            .Items("MODIFICAR").Enabled = False
            .Items("ELIMINAR").Enabled = False
            .Items("GRABAR").Enabled = True
            .Items("DESHACER").Enabled = True
        End With
        DESHABILITA_DATOS()
    End Sub

    Private Sub optSNP_Click(sender As Object, e As EventArgs) Handles optSNP.Click
        lblCod_Afp.Visible = False
        txtCod_AFP.Visible = False
        txtDes_AFP.Visible = False
        lblCUSPP.Visible = False
        txtCUSPP.Visible = False
        '    lblFec_Afiliacion.Visible = False
        '    DTAfiliacion.Visible = False

        lblNroDocAfil.Visible = True
        txtNroDocAfil.Visible = True

        txtCod_AFP.Text = ""
        txtDes_AFP.Text = ""
        txtCUSPP.Text = ""
    End Sub

    Private Sub optSPP_Click(sender As Object, e As EventArgs) Handles optSPP.Click
        lblCod_Afp.Visible = True
        txtCod_AFP.Visible = True
        txtDes_AFP.Visible = True
        lblCUSPP.Visible = True
        txtCUSPP.Visible = True
        '    lblFec_Afiliacion.Visible = True
        '    DTAfiliacion.Visible = True

        lblNroDocAfil.Visible = False
        txtNroDocAfil.Visible = False

        txtNroDocAfil.Text = ""
    End Sub

    Private Sub txtCod_AFP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_AFP.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Cod_AFP(1)
        End If
    End Sub

    Private Sub txtDes_AFP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_AFP.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Cod_AFP(2)
        End If
    End Sub

    Sub Busca_Cod_AFP(Tipo As Integer)
        'Dim oTipo As New frmBusqGeneral3
        'Dim rs As New ADODB.RecordSet

        'oTipo.oParent = Me
        'If Tipo = 1 Then
        '    oTipo.sQuery = "SELECT Cod_Afp as Codigo, Descripcion as Descripcion FROM Rh_Afp_Personal Where Cod_Afp like '%" & Trim(txtCod_AFP.Text) & "%' order by Cod_Afp"
        'Else
        '    oTipo.sQuery = "Select Cod_Afp as Codigo, Descripcion as Descripcion FROM Rh_Afp_Personal Where Descripcion like '%" & Trim(txtDes_AFP.Text) & "%' order by Descripcion"
        'End If

        'oTipo.Caption = "Buscar Cod. AFP"
        'oTipo.Cargar_Datos()

        'oTipo.gexLista.Columns("Codigo").Width = 900
        'oTipo.gexLista.Columns("Descripcion").Width = 3500

        'If oTipo.gexLista.RowCount > 1 Then
        '    oTipo.Show vbModal
        'Else
        '    Codigo = oTipo.gexLista.Value(oTipo.gexLista.Columns("Codigo").Index)
        '    Descripcion = oTipo.gexLista.Value(oTipo.gexLista.Columns("Descripcion").Index)
        'End If

        'If Trim(Codigo) <> "" Then
        '    txtCod_AFP.Text = Codigo 'oTipo.gexLista.Value(oTipo.gexLista.Columns("Codigo").Index)
        '    txtDes_AFP.Text = Descripcion 'oTipo.gexLista.Value(oTipo.gexLista.Columns("Descripcion").Index)
        '    Codigo = "" : Descripcion = "" : TipoAdd = ""

        '    '    txtCUSPP.SetFocus

        'End If
        'Unload oTipo
        'oTipo = Nothing
        'rs = Nothing
    End Sub

    Private Sub txtCUSPP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCUSPP.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BarraOpciones.Focus()
        End If
    End Sub

    Private Sub txtNroDocAfil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDocAfil.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BarraOpciones.Focus()
        End If
    End Sub

    Private Sub TxtCtaCteDetracciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCtaCteDetracciones.KeyPress

    End Sub

    Sub GeneraInterfaseAnexo(ByVal Tipo As String, Cod As String)

        '        On Error GoTo errx
        '        Dim sFileFINANZAS As String, i As Integer, lvLinea As String
        '        Dim mRS As ADODB.RecordSet

        '        mRS = GetRecordset(cCONNECT, "SM_AnexosContables '" & Tipo & "','" & Cod & "'")

        '        sFileFINANZAS = DevuelveCampo("SELECT RutaSistemaFINANZAS FROM CN_CONTROL", cCONNECT) & "\" & mRS!Cod_TipAnEx & mRS!Cod_ANXO & ".mct"

        '        If Not mRS.EOF Then
        '        Close #1
        '        Open sFileFINANZAS For Output As #1

        '            Plin "DB=ACTIVITY_HIALPESA"
        '            Plin "TABLA=PASE.ANEXOS"
        '            Plin "Key=" & mRS!Cod_TipAnEx & "*" & mRS!Cod_ANXO
        '            lvLinea = "RECORD=]"
        '            For i = 0 To 8
        '                lvLinea = lvLinea & Trim(FixNulos(mRS.Fields(i), vbString)) & "]"
        '            Next i

        '            Plin lvLinea

        '        Close #1

        '            sFileFINANZAS = DevuelveCampo("SELECT RutaSistemaFINANZAS FROM CN_CONTROL", cCONNECT) & "\" & mRS!Cod_TipAnEx & mRS!Cod_ANXO & "_1.mct"

        '        Open sFileFINANZAS For Output As #1

        '            Plin "DB=ACTIVITY_HIALPESA"
        '            Plin "TABLA=FAPROVEEDOR"
        '            Plin "Key=" & mRS!Cod_TipAnEx & mRS!Cod_ANXO
        '            lvLinea = "RECORD=" & mRS!Des_Anexo & "]" & mRS!Des_Anexo & "]]" & Trim(mRS!Num_Ruc) & "]]]]]]]]]]]]]]]]]NAC]]"
        '            Plin lvLinea

        '        Close #1


        '        Else
        '            ExecuteSQL(cCONNECT, "UP_MAN_CN_LogEnviosaFinanzas '01', 'I', '" & Tipo & Cod & "','','DOCUM NO ENCONTRADO EN CN_DOCUM '")
        '        End If
        '        Exit Sub
        'errx:
        '        ExecuteSQL(cCONNECT, "UP_MAN_CN_LogEnviosaFinanzas '01', 'I', '" & Tipo & Cod & "','','" & err.Description & "'")
        '        errores err.Description

    End Sub

    Private Sub OptBUSCA_Click(sender As Object, e As EventArgs) Handles OptBUSCA.Click
        If OptBUSCA.Checked = True Then
            Opciones_Busca()
        End If
    End Sub

    Private Sub Opciones_Busca()
        txt_codtip.Enabled = True
        txt_desTip.Enabled = True
        txt_numruc.Enabled = True
        txt_codtip.Text = ""
        txt_desTip.Text = ""
        txt_numruc.Text = ""
        txt_codtip.BackColor = Color.LemonChiffon
        txt_desTip.BackColor = Color.LemonChiffon
        txt_numruc.BackColor = Color.LemonChiffon
        txt_diranexo.BackColor = Color.Gray
        Me.cboTipAnex.BackColor = Color.Gray
        cmdBuscaCodigo.Enabled = True
        CmdBuscaDes.Enabled = True
        cmdbuscaruc.Enabled = True
        txt_diranexo.Enabled = False
        chkReciboHon.Enabled = False
        Me.cboTipAnex.Enabled = False
        chkSunat.Checked = False
        'HabilitaMant Me.MantFunc1, "DESHACER"
    End Sub

    Private Function GENERA_CODIGO(ByVal Tipo As String) As String
        'Dim flgLon As Integer
        'If Trim(Right(cboTipAnex, 3)) <> "" Then
        '    strSQL = "SELECT Flg_LongitudKey FROM CN_TipoAnexoContable where cod_tipanex='" & Trim(Right(cboTipAnex, 3)) & "'"
        '    flgLon = CInt(IIf(IsNull(DevuelveCampo(strSQL, cCONNECT)), 4, DevuelveCampo(strSQL, cCONNECT)))
        'End If
        'GENERA_CODIGO = Format(DevuelveCampo("select isnull(max(isnull(convert(int,cod_anxo),0)),0) +1 from CN_AnexosContables where cod_TipAnex='" & Tipo & "'", cCONNECT), "0#")
        'GENERA_CODIGO = LPad(GENERA_CODIGO, flgLon, 0)
    End Function

    Private Sub cmdBuscaCodigo_Click(sender As Object, e As EventArgs) Handles cmdBuscaCodigo.Click
        'sflag = "COD_ANXCON"
        'If Filtrar(sflag, Me, txt_codtip, txt_desTip) Then
        '    BUSCA_DATOS "CODIGO"
        'End If
        'Opciones_Mant()
    End Sub

    Private Sub DcboTipoAnexo_Click(Area As Integer)
        'If Area = 2 Then
        '    txt_codtip.Text = DevuelveCampo("select isnull((max(convert(int,Cod_Anxo))+1),0) from CN_AnexosContables where cod_tipanex='" & UCase(DcboTipoAnexo.BoundText) & "'", cCONNECT)
        'End If
    End Sub

    Private Sub DcboTipoAnexo_Validate(Cancel As Boolean)
        'DcboTipoAnexo_Click 2
    End Sub
#End Region
End Class