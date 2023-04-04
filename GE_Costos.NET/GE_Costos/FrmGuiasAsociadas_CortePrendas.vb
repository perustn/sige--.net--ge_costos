Imports Janus.Windows.GridEX

Public Class FrmGuiasAsociadas_CortePrendas
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public sNum_Corre As String
    Public sCod_TipAnexo As String
    Public sCod_Anexo As String
    Public sAnexo As String
    Public sCod_Moneda As String
    Public sFactura As String

    Public oParent As Object

    Private Sub FrmGuiasAsociadas_PreTenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        TxtFacturas.Text = sFactura
        TxtTipo.Text = sCod_TipAnexo
        TxtCodAnexo.Text = sCod_Anexo
        TxtAnexo.Text = sAnexo
    End Sub

    Sub CARGA_CABECERA()
        Try
            Dim IREG As Integer
            Dim sum As Double

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC SM_MUESTRA_GUIAS_CORTE_DE_FACTURA"
            strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            gexCabecera.DataSource = oDT
            CheckLayoutGridEx(gexCabecera)

            With gexCabecera
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                With .RootTable
                    .HeaderLines = 1
                    .PreviewRow = False
                    .PreviewRowLines = 10
                    .RowHeight = 20
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("SEC").Width = 50
                    .Columns("COD_FABRICA").Width = 80
                    .Columns("COD_ORDPRO").Width = 60
                    .Columns("NUM_SECORD").Width = 80
                    .Columns("CO_CODORDPRO").Width = 80
                    .Columns("NUM_PRENDAS").Width = 80
                    .Columns("PRE_UNITARIO").Width = 80
                    .Columns("IMP_FACTURA_SOLES").Width = 80
                    .Columns("IMP_FACTURA_DOLARES").Width = 80
                    .Columns("NUM_GUIA").Width = 110


                    .Columns("SEC").Caption = "SEC"
                    .Columns("COD_FABRICA").Caption = "COD. FAB."
                    .Columns("COD_ORDPRO").Caption = "OP"
                    .Columns("NUM_SECORD").Caption = "SEC. ORD"
                    .Columns("CO_CODORDPRO").Caption = "CO.COD ORD"
                    .Columns("NUM_PRENDAS").Caption = "PRENDAS"
                    .Columns("PRE_UNITARIO").Caption = "PREC. UNIT"
                    .Columns("IMP_FACTURA_SOLES").Caption = "FT (S/)"
                    .Columns("IMP_FACTURA_DOLARES").Caption = "FT ($/)"
                    .Columns("NUM_GUIA").Caption = "NRO. GUIA"
                End With
            End With

            For IREG = 1 To gexCabecera.RowCount
                gexCabecera.Row = IREG
                If sCod_Moneda = "USD" Then
                    sum = sum + gexCabecera.GetValue(gexCabecera.RootTable.Columns("imp_factura_dolares").Index)
                Else
                    sum = sum + gexCabecera.GetValue(gexCabecera.RootTable.Columns("imp_factura_soles").Index)
                End If
            Next

            TxtTotal_Valorizado.Text = Strings.Format(sum, "#,###.00")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONARGUIA"
                    Using oAsig As New FrmGuiasAsociadas_CortePrendas_AsigGuias
                        With oAsig
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .oParent = Me
                            .sCOD_TIPANEX = sCod_TipAnexo
                            .sCOD_ANXO = sCod_Anexo
                            .sNum_Corre = sNum_Corre
                            .TxtTipo.Text = sCod_TipAnexo
                            .TxtCodAnexo.Text = sCod_Anexo
                            .TxtAnexo.Text = sAnexo
                            .TxtFactura.Text = sFactura
                            .CARGA_MOVIMIENTOS()
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_CABECERA()
                            End If
                        End With
                    End Using

                Case "DESASIGNAR"
                    If gexCabecera.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("Esta seguro que desea desasignar el movimiento: " & gexCabecera.GetValue(gexCabecera.RootTable.Columns("Movimiento").Index), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        DESASIGNA()
                    End If

                Case "MODIFICAR"
                    If gexCabecera.RowCount = 0 Then Exit Sub
                    Using oMod As New FrmGuiasAsociadas_CortePrendas_Modificar
                        With oMod
                            .oParent = Me
                            .vCod_Fabrica = gexCabecera.GetValue(gexCabecera.RootTable.Columns("cod_fabrica").Index)
                            .TxtOP.Text = gexCabecera.GetValue(gexCabecera.RootTable.Columns("cod_ordpro").Index)
                            .TxtSEc.Text = gexCabecera.GetValue(gexCabecera.RootTable.Columns("num_secord").Index)
                            .TxtSoles = gexCabecera.GetValue(gexCabecera.RootTable.Columns("imp_factura_soles").Index)
                            .TxtDolares = gexCabecera.GetValue(gexCabecera.RootTable.Columns("imp_factura_dolares").Index)
                            .Text = "Modificar - FT : " & sFactura
                            .ShowDialog()
                        End With
                    End Using
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub DESASIGNA()
        Try

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC UP_DESASIGNA_GUIA_FACTURA_CORTE_PRENDAS"
            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@SEC          =  {0} ", gexCabecera.GetValue(gexCabecera.RootTable.Columns("sec").Index))

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Proceso realizado satisfactoria...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                CARGA_CABECERA()
            Else
                MessageBox.Show("No se realizó la designación...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class