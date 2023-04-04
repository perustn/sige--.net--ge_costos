Imports Janus.Windows.GridEX

Public Class FrmMantActivoFijo
    Private strSQL As String = String.Empty
    Private ssql_cmt As String = String.Empty
    Private oDtDataTotal As New DataTable
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private FilaSeleccionada As Integer
    Private sModoBusqueda As String

    Private Sub FrmMantActivoFijo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))

        dtpFecha.Value = Now.Date
        CargarGrilla()
        'FunctButt1.FunctionsUser = get_botones1(Me, vper, vemp, Me.Name)
    End Sub

    Private Sub FondoDegrade(sender As Object, e As PaintEventArgs) Handles PanelGuia.Paint
        FondoDegradeDiagonalEnPanel(sender, e, colEmpresa)
    End Sub

    Private Sub OpcionBusqueda(sender As Object, e As EventArgs) Handles optActivoFijo.Click,
                                                                         optnum_imp.Click,
                                                                         optFecAdquisicion.Click,
                                                                         optCuentaContable.Click,
                                                                         OptAMN.Click,
                                                                         opt_Familia.Click

        LimpiarTextos()
        Select Case (sender.TAG)
            Case "1"
                grbActivo.Visible = True
                txtCod_Activo.Focus()

            Case "2"
                grbFechaAdquisicion.Visible = True
                dtpFecha.Focus()

            Case "3"
                grbCuenteContable.Visible = True
                TxtCod_CtaCont.Focus()

            Case "4"
                grbAreaFamilia.Visible = True
                TxtCodArea.Focus()

            Case "5"
                grbSubsidiario.Visible = True
                TxtDes_TipoDiario.Focus()

            Case "6"
                grbImportacion.Visible = True
                txtnum_imp.Focus()
        End Select
    End Sub

    Sub LimpiarTextos()
        grbActivo.Visible = False
        grbFechaAdquisicion.Visible = False
        grbCuenteContable.Visible = False
        grbAreaFamilia.Visible = False
        grbSubsidiario.Visible = False
        grbImportacion.Visible = False

        txtCod_Activo.Text = String.Empty
        Txt_DesActivo.Text = String.Empty
        dtpFecha.Value = Now.Date
        TxtCod_CtaCont.Text = String.Empty
        TxtDes_CtaCont.Text = String.Empty
        TxtCodArea.Text = String.Empty
        txtDesArea.Text = String.Empty
        txtCod_Familia.Text = String.Empty
        txtDes_Familia.Text = String.Empty
        TxtCod_TipoDiario.Text = "30"
        TxtDes_TipoDiario.Text = String.Empty
        TxtAnioReg.Text = String.Empty
        TxtMesReg.Text = String.Empty
        TxtNumReg.Text = String.Empty
        txtnum_imp.Text = String.Empty
    End Sub

    Private Sub txtCod_Activo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Activo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCA_ACTIVO_FIJO(1, txtCod_Activo, Txt_DesActivo)
        End If
    End Sub

    Private Sub Txt_DesActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_DesActivo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCA_ACTIVO_FIJO(2, txtCod_Activo, Txt_DesActivo)
        End If
    End Sub

    Private Sub BUSCA_ACTIVO_FIJO(tipo As Integer, ByRef Cod_Cta As TextBox, ByRef Des_Cta As TextBox)
        Select Case tipo
            Case 1
                strSQL = " SELECT cod_activo AS 'Codigo', des_activo AS 'Descripcion' " & _
                         "FROM cn_activo_fijo WHERE cod_activo like '%" & Trim(Cod_Cta.Text) & "%' ORDER BY 1 "

            Case 2, 3
                strSQL = "SELECT cod_activo  AS 'Código', " & _
                " des_activo as 'Descripción' " & _
                "FROM cn_activo_fijo " & _
                "WHERE des_activo LIKE '%" & Trim(Des_Cta.Text) _
                & "%' ORDER BY 1"
        End Select
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = strSQL
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
            If Codigo <> "" Then
                Cod_Cta.Text = Trim(Codigo)
                Des_Cta.Text = Trim(Descripcion)
            End If
        Else
            Cod_Cta.Text = oTipo.dtResultados.Rows(0)("Codigo")
            Des_Cta.Text = oTipo.dtResultados.Rows(0)("Descripcion")
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        BtnBuscar.Focus()
        oTipo = Nothing
    End Sub

    Private Sub dtpFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFecha.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub TxtCod_CtaCont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_CtaCont.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If RTrim(TxtCod_CtaCont.Text) = "" Then
                BUSCA_CUENTACONTABLE(3, TxtCod_CtaCont, TxtDes_CtaCont)

            Else
                BUSCA_CUENTACONTABLE(1, TxtCod_CtaCont, TxtDes_CtaCont)

            End If
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
                "WHERE substring(Cod_CtaCont,1,2)='33' and  Des_CtaCont LIKE '%" & Trim(Des_Cta.Text) _
                & "%' and ano=dbo.CN_OBTIENE_ANO_VIGENTE_PLAN_CONTABLE() ORDER BY 1"
        End Select
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = strSQL
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
            If Codigo <> "" Then
                Cod_Cta.Text = Trim(Codigo)
                Des_Cta.Text = Trim(Descripcion)
            End If
        Else
            Cod_Cta.Text = oTipo.dtResultados.Rows(0)("Codigo")
            Des_Cta.Text = oTipo.dtResultados.Rows(0)("Descripcion")
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        BtnBuscar.Focus()
        oTipo = Nothing
    End Sub

    Private Sub TxtCodArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodArea.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAREA(1)
        End If
    End Sub

    Private Sub txtDesArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesArea.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAREA(1)
        End If
    End Sub

    Sub BUSCAREA(Opcion As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "SELECT Cod_Area_Produccion as Codigo,Descripcion FROM Mant_Areas_Produccion "
         Select Case Opcion
            Case 1 : oTipo.sQuery = strSQL & "where Cod_Area_Produccion like '%" & TxtCodArea.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & "where Descripcion like '%" & txtDesArea.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            TxtCodArea.Text = Trim(Codigo)
            txtDesArea.Text = Trim(Descripcion)
            txtCod_Familia.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCod_Familia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Familia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAFAMILIA(1)
        End If
    End Sub

    Private Sub txtDes_Familia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Familia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BUSCAFAMILIA(2)
        End If
    End Sub

    Sub BUSCAFAMILIA(Opcion As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "select Cod_Familia_Activo as Codigo,Des_Familia_Activo as Descripcion from CN_Familia_Activo_Fijo where Cod_Area_Produccion = '" & TxtCodArea.Text & "'"
        Select Case Opcion
            Case 1 : oTipo.sQuery = strSQL & " and Cod_Familia_Activo  like '%" & txtCod_Familia.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & " and Des_Familia_Activo like '%" & txtDes_Familia.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            txtCod_Familia.Text = Trim(Codigo)
            txtDes_Familia.Text = Trim(Descripcion)
            BtnBuscar.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub TxtCod_TipoDiario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_TipoDiario.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_SubDiario("1")
        End If
    End Sub

    Private Sub TxtDes_TipoDiario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDes_TipoDiario.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_SubDiario("2")
        End If
    End Sub

    Sub Busca_SubDiario(tipo As String)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        If tipo = "1" Then
            oTipo.sQuery = "SELECT cod_tipodiario as Codigo, Des_TipoDiario as Descripcion, flg_canjefacturasporpagarconletras as Flg from cn_tipodiario where cod_tipodiario like '" & Trim(TxtCod_TipoDiario.Text) & "%'"
        Else
            oTipo.sQuery = "SELECT cod_tipodiario as Codigo, Des_TipoDiario as Descripcion, flg_canjefacturasporpagarconletras as Flg from cn_tipodiario where des_tipodiario like '%" & Trim(TxtDes_TipoDiario.Text) & "%'"
        End If
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
            TipoAdd = Trim(oTipo.dtResultados.Rows(0)("flg"))
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
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub TxtMesReg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMesReg.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtNumReg.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub TxtNumReg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumReg.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub txtnum_imp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnum_imp.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CargarGrilla()
    End Sub

    Public Sub CargarGrilla()
        Try
            If optActivoFijo.Checked = True Then
                sModoBusqueda = "1"
            ElseIf optFecAdquisicion.Checked = True Then
                sModoBusqueda = "2"
            ElseIf optCuentaContable.Checked = True Then
                sModoBusqueda = "3"
            ElseIf opt_Familia.Checked = True Then
                sModoBusqueda = "4"
            ElseIf OptAMN.Checked = True Then
                sModoBusqueda = "5"
            Else
                sModoBusqueda = "6"
            End If

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_Sel_Activo_Fijo"
            strSQL &= vbNewLine & String.Format(" @opcion               = '{0}'", sModoBusqueda)
            strSQL &= vbNewLine & String.Format(",@cod_activo           = '{0}'", Trim(txtCod_Activo.Text))
            strSQL &= vbNewLine & String.Format(",@Fecha_Adquisicion    = '{0}'", dtpFecha.Value.ToShortDateString)
            strSQL &= vbNewLine & String.Format(",@cod_ctacont          = '{0}'", Trim(TxtCod_CtaCont.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Area_Produccion  = '{0}'", Trim(TxtCodArea.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Familia_Activo   = '{0}'", Trim(txtCod_Familia.Text))
            strSQL &= vbNewLine & String.Format(",@Ano_Registro         = '{0}'", Trim(TxtAnioReg.Text))
            strSQL &= vbNewLine & String.Format(",@Mes_Registro         = '{0}'", Trim(TxtMesReg.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_TipoDiario       = '{0}'", TxtNumReg.Text)
            strSQL &= vbNewLine & String.Format(",@Num_Registro         = '{0}'", Trim(TxtCod_TipoDiario.Text))
            strSQL &= vbNewLine & String.Format(",@NUM_IMPORTACION      = '{0}'", txtnum_imp.Text)

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            oDtDataTotal = oDT
            If oDT Is Nothing Then Exit Sub
            GrdLista.RootTable.Columns.Clear()
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
                    '.PreviewRowMember = "OBSERVACIONES"
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("cod_activo").Width = 120
                    .Columns("Des_Activo").Width = 200
                    .Columns("Cod_CtaCont").Width = 150
                    .Columns("des_ctacont").Width = 250
                    .Columns("Cod_Area_Produccion").Width = 80
                    .Columns("Area").Width = 180
                    .Columns("Cod_Familia_Activo").Width = 80
                    .Columns("des_familia_activo").Width = 250
                    .Columns("Cod_Equipo").Width = 100
                    .Columns("Marca").Width = 150
                    .Columns("Serie").Width = 150
                    .Columns("Modelo").Width = 150
                    .Columns("Potencia_HP").Width = 100
                    .Columns("Kws").Width = 100
                    .Columns("Voltios").Width = 100
                    .Columns("Cod_CenCost").Width = 100
                    .Columns("Centro_Costo").Width = 250
                    .Columns("Glosa").Width = 200
                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    Using oAdd As New FrmMantActivoFijo_MAnt
                        With oAdd
                            .sAccion = "I"
                            .dtpFecha.Value = Now.Date
                            .Text = "Adicionar Activo Fijo"
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "MODIFICAR"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    FilaSeleccionada = GrdLista.CurrentRow.Position
                    Using oAdd As New FrmMantActivoFijo_MAnt
                        With oAdd
                            .sAccion = "U"
                            .Text = "Modificar Activo Fijo"
                            .sCodActivo = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_Activo").Index))
                            .txtDes_Activo.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Des_Activo").Index))
                            .dtpFecha.Value = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Fecha_Adquisicion").Index))
                            .TxtCod_CtaCont.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_CtaCont").Index))
                            .TxtDes_CtaCont.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("des_ctacont").Index))
                            .TxtCodArea.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_Area_Produccion").Index))
                            .txtDesArea.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Area").Index))
                            .txtCod_Familia.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_Familia_Activo").Index))
                            .txtDes_Familia.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("des_familia_activo").Index))
                            .txtCod_Equipo.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_Equipo").Index))
                            .txtMarca.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Marca").Index))
                            .txtSerie.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("serie").Index))
                            .txtModelo.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("modelo").Index))
                            .txtPotenciaHP.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Potencia_HP").Index))
                            .txtKws.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Kws").Index))
                            .txtVoltios.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Voltios").Index))
                            .Txt_centro.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_CenCost").Index))
                            .Txt_Costo.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Centro_Costo").Index))
                            .TxtGlosa.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Glosa").Index))
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "ELIMINAR"
                    eliminar()

                Case "VARACTFIJO"
                    If GrdLista.RecordCount = 0 Then Exit Sub
                    Using oVar As New FrmMantActivoFijo_VariacionActivo
                        With oVar
                            .TxtCodigo.Text = Trim(GrdLista.GetValue(Me.GrdLista.RootTable.Columns("Cod_Activo").Index))
                            .TxtDescripcion.Text = Trim(GrdLista.GetValue(Me.GrdLista.RootTable.Columns("Des_Activo").Index))
                            .sCodCta = Trim(GrdLista.GetValue(Me.GrdLista.RootTable.Columns("Cod_CtaCont").Index))
                            .sDesCta = Trim(GrdLista.GetValue(Me.GrdLista.RootTable.Columns("des_ctacont").Index))
                            .CARGA_GRID()
                            .ShowDialog()
                        End With
                    End Using

                Case "CALCDEPRE"
                    Using oCal As New FrmMantActivoFijo_CalculoDepreciacion
                        With oCal
                            .TxtAno.Text = Strings.Format(Now.Date, "yyyy")
                            .TxtMes.Text = Strings.Format(Now.Date, "MM")
                            .ShowDialog()
                            CargarGrilla()
                        End With
                    End Using

                Case "HISTORICO"
                    Using oAct As New FrmMantActivoFijo_ActFijoHistorico
                        With oAct
                            .txtAno.Text = Strings.Format(Now.Date, "yyyy")
                            .txtMes.Text = Strings.Format(Now.Date, "MM")
                            .ShowDialog()
                        End With
                    End Using

                Case "MODFECHA"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oMod As New FrmMantActivoFijo_ModificarFecha
                        With oMod
                            .TxtCodigo.Text = Trim(GrdLista.GetValue(Me.GrdLista.RootTable.Columns("Cod_Activo").Index))
                            .TxtDescripcion.Text = Trim(GrdLista.GetValue(Me.GrdLista.RootTable.Columns("Des_Activo").Index))
                            If IsDBNull(GrdLista.GetValue(Me.GrdLista.RootTable.Columns("Fecha_Adquisicion").Index)) = True Or Trim(GrdLista.GetValue(Me.GrdLista.RootTable.Columns("Fecha_Adquisicion").Index)) = "01/01/1900" Then
                                .dtpFecAdquisicicon.Value = Now.Date
                                .dtpFecAdquisicicon.Checked = False
                            Else
                                .dtpFecAdquisicicon.Checked = True
                                .dtpFecAdquisicicon.Value = Trim(GrdLista.GetValue(Me.GrdLista.RootTable.Columns("Fecha_Adquisicion").Index))
                            End If

                            If IsDBNull(GrdLista.GetValue(Me.GrdLista.RootTable.Columns("Fec_inicio_vigencia").Index)) = True Or Trim(GrdLista.GetValue(Me.GrdLista.RootTable.Columns("Fec_inicio_vigencia").Index)) = "01/01/1900" Then
                                .dtpFecVigencia.Value = Now.Date
                                .dtpFecVigencia.Checked = False
                            Else
                                .dtpFecVigencia.Checked = True
                                .dtpFecVigencia.Value = Trim(GrdLista.GetValue(Me.GrdLista.RootTable.Columns("Fec_inicio_vigencia").Index))
                            End If
                        End With
                    End Using
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub eliminar()
        Try
            If MessageBox.Show("Esta seguro que desea eliminar el Activo Fijo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC CN_Mante_Activo_Fijo"
                strSQL &= vbNewLine & String.Format(" @Accion       = '{0}'", "D")
                strSQL &= vbNewLine & String.Format(",@cod_activo   = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_Activo").Index))

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("Se eliminó correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarGrilla()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

End Class