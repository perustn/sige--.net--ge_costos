Imports Janus.Windows.GridEX

Public Class FrmAsignacionCostosPartidaPO
    Private strSQL As String = String.Empty
    Private strSQLTrazaImp As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmAsignacionCostosPartidaPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))

        Me.ActiveControl = TxtPartida
    End Sub

    Private Sub FondoDegrade(sender As Object, e As PaintEventArgs) Handles PanelGuia.Paint
        FondoDegradeDiagonalEnPanel(sender, e, colEmpresa)
    End Sub

    Private Sub TxtPartida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPartida.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtPartida.Text = RellenaDeCerosEnIzquierda(TxtPartida.Text, 5)
            BtnBuscar.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        cargarDatosGrilla
    End Sub

    Public Sub cargarDatosGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC costos_muestra_detalle_asignacion_partida_expo_saldos"
            strSQL &= vbNewLine & String.Format(" @cod_ordtra  = '{0}'", TxtPartida.Text)
            strSQLTrazaImp = strSQL

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            If oDT Is Nothing Then Exit Sub
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

                    With .Columns("cod_tela")
                        .Caption = "TELA"
                        .Width = 70
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("Des_Tela")
                        .Caption = "DESCRIPCION TELA"
                        .Width = 130
                    End With

                    With .Columns("cod_comb")
                        .Caption = "COMBO"
                        .Width = 70
                    End With

                    With .Columns("Des_Comb")
                        .Caption = "DESCRIPCION COMBO"
                        .Width = 110
                    End With

                    With .Columns("cod_color")
                        .Caption = "COLOR"
                        .Width = 70
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("Des_Color")
                        .Caption = "DESCRIPCION COLOR"
                        .Width = 120
                    End With

                    With .Columns("Cod_Medida")
                        .Caption = "MEDIDA"
                        .Width = 70
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("Descripcion")
                        .Caption = "DESCRIPCION MEDIDA"
                        .Width = 120
                    End With

                    With .Columns("Kgs_Consumo")
                        .Caption = "KGS CONSUMO"
                        .Width = 80
                        .TextAlignment = TextAlignment.Far
                    End With

                    With .Columns("soles")
                        .Caption = "SOLES"
                        .Width = 80
                        .TextAlignment = TextAlignment.Far
                    End With

                    With .Columns("Dolares")
                        .Caption = "DOLARES"
                        .Width = 80
                        .TextAlignment = TextAlignment.Far
                    End With

                    With .Columns("num_movstk")
                        .Caption = "Nº MOVIMIENTO"
                        .Width = 80
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("OP")
                        .Caption = "OP"
                        .Width = 60
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("OC")
                        .Caption = "OC"
                        .Width = 80
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("Num_Guia")
                        .Caption = "Nº GUIA"
                        .Width = 80
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("Nom_Cliente")
                        .Caption = "CLIENTE"
                        .Width = 140
                    End With

                    With .Columns("PO")
                        .Caption = "PO"
                        .Width = 80
                    End With

                    With .Columns("Estilo_Cliente")
                        .Caption = "ESTILO CLIENTE"
                        .Width = 80
                    End With

                    With .Columns("Fec_Movstk")
                        .Caption = "FECHA MOVIM"
                        .Width = 80
                        .FormatString = "dd/MM/yyyy"
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("Almacen")
                        .Caption = "ALMACEN"
                        .Width = 120
                    End With

                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "IMPRIMIR"
                    Dim oo As Object
                    Dim Ruta As String
                    Ruta = vRuta & "\RptAsignacionCostosPartidaPO.XLT"
                    oo = CreateObject("excel.application")
                    oo.Workbooks.Open(Ruta)
                    oo.Visible = True
                    oo.DisplayAlerts = False
                    oo.Run("REPORTE", strSQLTrazaImp, TxtPartida.Text, cCONNECTVB6)
                    oo = Nothing
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class