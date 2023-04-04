Imports Janus.Windows.GridEX

Public Class FrmMantActivoFijo_VariacionActivo
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Public sCodCta As String
    Public sDesCta As String

    Private Sub FrmMantActivoFijo_VariacionActivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel5.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CARGA_GRID()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MANT_VARIACION_ACTIVO_FIJO"
            strSQL &= vbNewLine & String.Format(" @ACCION       = '{0}'", "v")
            strSQL &= vbNewLine & String.Format(",@COD_ACTIVO   = '{0}'", TxtCodigo.Text)

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            GrdDatos.DataSource = oDT
            CheckLayoutGridEx(GrdDatos)

            With GrdDatos
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                With .RootTable
                    .HeaderLines = 2
                    .PreviewRow = False
                    .PreviewRowLines = 10
                    .RowHeight = 30
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("cod_activo").Width = 100
                    .Columns("secuencia").Width = 80
                    .Columns("des_tipo_variacion_activo").Width = 200
                    .Columns("Fec_Movstk").Width = 120
                    .Columns("Imp_Movimiento_Soles").Width = 100
                    .Columns("Imp_Movimiento_Dolares").Width = 100
                    .Columns("Imp_Movimiento_Dolares").Width = 100
                    .Columns("Imp_Movimiento_Otra_Moneda").Width = 100
                    .Columns("Cod_Moneda").Width = 100
                    .Columns("nom_moneda").Width = 150
                    .Columns("Ano_Registro").Width = 100
                    .Columns("Mes_Registro").Width = 100
                    .Columns("Cod_TipoDiario").Width = 100
                    .Columns("Des_TipoDiario").Width = 300
                    .Columns("Num_Registro").Width = 100
                    .Columns("Cod_Usuario").Width = 150
                    .Columns("Cod_Estacion").Width = 150
                    .Columns("Fec_Modificacion").Width = 120
                End With
            End With
            GrdDatos.FrozenColumns = 2
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    Using oAdd As New FrmMantActivoFijo_VariacionActivo_Add
                        With oAdd
                            .Text = "Adicionar Variacion del Activo Fijo"
                            .oParent = Me
                            .TxtCodigo.Text = TxtCodigo.Text
                            .TxtDescripcion.Text = TxtDescripcion.Text
                            .DTPFec_Operacion.Text = Now.Date
                            .txtTipo_Cambio = oHP.DevuelveDato("Select dbo.SM_OBTIENE_TIPO_CAMBIO('" & Now.Date & "')", cCONNECT)
                            .txtOtro_Tipo_Cambio = oHP.DevuelveDato("Select dbo.FI_ObtieneTipoCambio_venta('" & Now.Date & "','" & .TxtCod_Moneda.Text & "')", cCONNECT)
                            .TxtCod_CtaCont.Text = sCodCta
                            .TxtDes_CtaCont.Text = sDesCta
                            .sAccion = "I"
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_GRID()
                            End If
                        End With
                    End Using
                    
                Case "MODIFICAR"
                    If GrdDatos.RowCount = 0 Then Exit Sub
                    FilaSeleccionada = GrdDatos.CurrentRow.Position
                    Using oAdd As New FrmMantActivoFijo_VariacionActivo_Add
                        With oAdd
                            .TxtCodigo.Text = TxtCodigo.Text
                            .TxtDescripcion.Text = TxtDescripcion.Text
                            .sAccion = "U"
                            .Text = "Modificar Variacion del Activo Fijo"
                            .oParent = Me
                            .sSECUENCIA = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("secuencia").Index))
                            .TxtCod_TipVariacion.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Cod_Tipo_Variacion_Activo").Index))
                            .TxtDes_TipVariacion.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("des_tipo_variacion_activo").Index))
                            .TxtCod_CtaCont.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("cod_ctacont").Index))
                            .TxtDes_CtaCont.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("des_ctacont").Index))
                            .TxtCod_CtaCont.Enabled = False
                            .TxtDes_CtaCont.Enabled = False
                            .DTPFec_Operacion.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Fec_Movstk").Index))
                            .TxtImpSoles.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Imp_Movimiento_Soles").Index))
                            .TxtImpDolares.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Imp_Movimiento_Dolares").Index))
                            .TxtImpOtros.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Imp_Movimiento_Otra_Moneda").Index))
                            .TxtCod_Moneda.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Cod_Moneda").Index))
                            .TxtDes_Moneda.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("nom_moneda").Index))
                            .TxtAnioReg.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Ano_Registro").Index))
                            .TxtMesReg.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Mes_Registro").Index))
                            .TxtCod_TipoDiario.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Cod_TipoDiario").Index))
                            .TxtDes_TipoDiario.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Des_TipoDiario").Index))
                            .TxtNumReg.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Num_Registro").Index))
                            .TxtGlosa.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("glosa").Index))
                            .txtTipo_Cambio.Text = oHP.DevuelveDato("Select dbo.SM_OBTIENE_TIPO_CAMBIO('" & Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Fec_Movstk").Index)) & "')", cCONNECT)
                            .txtOtro_Tipo_Cambio.Text = oHP.DevuelveDato("Select dbo.FI_ObtieneTipoCambio_venta('" & Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Fec_Movstk").Index)) & "','" & .TxtCod_Moneda.Text & "')", cCONNECT)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_GRID()
                                GrdDatos.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "ELIMINAR"
                    If GrdDatos.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("¿Esta seguro que desea eliminar la Variacion del Activo Fijo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC CN_MANT_VARIACION_ACTIVO_FIJO"
                        strSQL &= vbNewLine & String.Format(" @accion           = '{0}'", "D")
                        strSQL &= vbNewLine & String.Format(",@COD_ACTIVO       = '{0}'", TxtCodigo.Text)
                        strSQL &= vbNewLine & String.Format(",@secuencia        =  {0} ", GrdDatos.GetValue(GrdDatos.RootTable.Columns("secuencia").Index))

                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            MessageBox.Show("Se eliminó correctamente...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CARGA_GRID()
                        End If
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class