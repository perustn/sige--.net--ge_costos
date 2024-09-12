Public Class frmCierreAlmacenesPrimarios

    Private strSQL As String
    Private oHP As New clsHELPER
    Private ds As New DataTable
    Private ds_new As New DataTable
    Private colEmpresa As Color
    Private oSeguridad As New ClsBtnSeguridad
    Private TipItem As String = ""
    Private TipPresentacion As String = ""
    Private IsComplete As Boolean = False

    Private Sub frmCierreAlmacenesPrimarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa

        dtpFecha.Value = Date.Now

        'Por habilitar seguridad
        'oSeguridad.GetBotonesJanus(vper, vemp, Name, ButtonBar1, "")
        'oSeguridad.GetBotonesJanus(vper, vemp, Name, ButtonBar2, "")

        Call CargarAlmacen()

        cmbTipoCierre.SelectedIndex = 0
    End Sub

    Private Sub cmbAlmacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlmacen.SelectedIndexChanged
        Try

            lblUltCierre.Text = ds_new.Rows.Find(cmbAlmacen.SelectedValue).Item("Fecha_Cierre").ToString
            If IsDate(ds_new.Rows.Find(cmbAlmacen.SelectedValue).Item("Fecha_Cierre").ToString) Then
                dtpFecha.Value = CDate(ds_new.Rows.Find(cmbAlmacen.SelectedValue).Item("Fecha_Cierre").ToString).AddMonths(1)
            End If
            TipItem = ds_new.Rows.Find(cmbAlmacen.SelectedValue).Item("Tip_Item").ToString
            TipPresentacion = ds_new.Rows.Find(cmbAlmacen.SelectedValue).Item("Tip_Presentacion").ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonBar2_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar2.ItemClick
        Select Case e.Item.Key.ToUpper
            Case "CERRAR"
                Call CerrarMes()
            Case "ERRORES"
                Call ErrorSecuenciaFechas()
            Case "ERRORVAL"
                Call ErrorValorizacion()
        End Select
    End Sub

#Region "Métodos"

    Private Sub CargarAlmacen()
        Try
            strSQL = ""
            strSQL = $"exec lg_muestra_almacenes_disponibles_a_cerrar '{vusu}'"
            ds = oHP.DevuelveDatos(strSQL, cCONNECT)
            If Not IsNothing(ds) Then

                ds_new.Rows.Clear()

                If ds_new.Columns.Count = 0 Then
                    Dim dc As New DataColumn("Codigo")
                    ds_new.Columns.Add(dc)
                    ds_new.Columns.Add("Descripcion")
                    ds_new.Columns.Add("Combinado")
                    ds_new.Columns.Add("Fecha_Cierre")
                    ds_new.Columns.Add("Tip_Item")
                    ds_new.Columns.Add("Tip_Presentacion")
                    ds_new.PrimaryKey = New DataColumn() {dc}
                End If

                For Each w As DataRow In ds.Rows
                    ds_new.Rows.Add(w("cod_almacen"), w("nom_almacen"), w("cod_almacen") & " - " & w("nom_almacen"), w("FecCierre"), w("Tip_Item"), w("Tip_Presentacion"))
                Next

                With cmbAlmacen
                    .DataSource = ds_new
                    .DisplayMember = "Combinado"
                    .ValueMember = "Codigo"
                End With
                If cmbAlmacen.Items.Count > 0 Then cmbAlmacen.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CerrarMes()
        Try

            If lblUltCierre.Text.Trim = "" Then
                MessageBox.Show("No se puede determinar el ultimo cierre para este Almacen, no se puede continuar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            strSQL = ""
            Select Case TipItem
                Case "I"
                    strSQL = "EXEC CT_CIERRE_ALMACEN_AVIOS "
                Case "H"
                    If TipPresentacion = "C" Then
                        strSQL = "EXEC CT_CIERRE_ALMACEN_HILOS_CRUDOS "
                    Else
                        strSQL = "EXEC CT_CIERRE_ALMACEN_HILOS_TENIDOS "
                    End If
                Case "T"
                    If TipPresentacion = "T" Then
                        strSQL = "EXEC UP_CIERRE_ALMACEN_TELA_ACABADA "
                    ElseIf TipPresentacion = "C" Then
                        strSQL = "EXEC UP_CIERRE_ALMACEN_TELA_CRUDA "
                    End If
            End Select

            strSQL += $"'{cmbAlmacen.SelectedValue}','{dtpFecha.Value.ToString("yyyy")}','{dtpFecha.Value.ToString("MM")}','{cmbTipoCierre.SelectedValue}'"

            ButtonBar1.Enabled = False
            ButtonBar2.Enabled = False
            panelCarga.Visible = True
            BackgroundWorker1.RunWorkerAsync()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ErrorSecuenciaFechas()

        strSQL = ""
        Select Case TipItem
            Case "I"
                strSQL = "EXEC COSTOS_ERRORES_LG_MOVISTKITEM_KARDEX '"
            Case "T"
                If TipPresentacion = "T" Then
                    strSQL = "EXEC COSTOS_ERRORES_LG_MOVISTKTELTEN_KARDEX '"
                ElseIf TipPresentacion = "C" Then
                    strSQL = "EXEC COSTOS_ERRORES_LG_MOVISTKTELcru_KARDEX '"
                End If
        End Select
        strSQL += $"{cmbAlmacen.SelectedValue}','{dtpFecha.Value.ToString("yyyy")}','{dtpFecha.Value.ToString("MM")}'"

        Using xfrm As New frmCierreAlmacenesPrimarios_ErrSecuencia(colEmpresa, strSQL, TipItem, TipPresentacion, cmbAlmacen.SelectedValue, dtpFecha.Value.ToString("MM"))
            With xfrm
                .ShowDialog()
            End With
        End Using

    End Sub

    Private Sub ErrorValorizacion()
        Try

            Dim lvRuta As String = ""

            Select Case TipItem
                Case "I"
                    lvRuta = "\ErrCostoMesAvios.xlt"
                Case "H"
                    lvRuta = "\ErrCostoMesHilado.xlt"
                Case "T"
                    If TipPresentacion = "T" Then
                        lvRuta = "\ErrCostoMesTelAca.xlt"
                    ElseIf TipPresentacion = "C" Then
                        lvRuta = "\ErrCostoMesTelCru.xlt"
                    End If
            End Select

            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & lvRuta)
            oo.Visible = True
            oo.DisplayAlerts = False
            oo.Run("REPORTE", cmbAlmacen.SelectedValue, dtpFecha.Value.ToString("yyyy"), dtpFecha.Value.ToString("MM"), "", cCONNECTVB6)
            oo.Visible = True
            oo = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            oHP.EjecutaOperacion(strSQL, cCONNECT, True)
        Catch ex As Exception
            ButtonBar1.Enabled = True
            ButtonBar2.Enabled = True
            panelCarga.Visible = False
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            ButtonBar1.Enabled = True
            ButtonBar2.Enabled = True
            panelCarga.Visible = False
            MessageBox.Show("Datos procesados", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call CargarAlmacen()
        Catch ex As Exception
            ButtonBar1.Enabled = True
            ButtonBar2.Enabled = True
            panelCarga.Visible = False
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class