Public Class FrmDocumentosPago_AsignarGuias
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public vnum_corre As String, vCod_TipAnexo As String, vCod_Anexo As String, vCod_AnexoAsociado As String
    Public vCod_Moneda As String, vMoneda As String, vTipo_Cambio As Double
    Public vFactura As String
    Public vAnexo As String
    Public vPrevio As String
    Public vNum_Impor As String
    Public sNumLiqServ As Integer
    Public vImporte As String

    Private Sub FrmDocumentosPago_AsignarGuias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
        ' FunctButt1.FunctionsUser = get_botones1(Me, vper, vemp, Me.Name)

        Me.ActiveControl = ButtonBar2
    End Sub

    Private Sub ButtonBar2_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar2.ItemClick
        Try
            Select Case e.Item.Key
                Case "CONFEC"
                    Using oAlm As New FrmGuiasAsociadas_AlmacenesPrimarios   'frmGuiasAsociadas
                        With oAlm
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .vnum_corre = TxtNroCorrelativo.Text
                            .vCod_TipAnexo = Me.vCod_TipAnexo
                            .vCod_Anexo = Me.vCod_Anexo
                            .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                            .vPrevio = vPrevio
                            .vNum_Impor = vNum_Impor
                            .sNumLiqServ = sNumLiqServ
                            .CARGA_CABECERA()
                            .ShowDialog()
                        End With
                    End Using

                Case "FARDOS"
                    Using oFardo As New FrmGuiasAsociadas_Fardos
                        With oFardo
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .LabelTotal.Text = "TOTAL FARDOS"
                            .Text = "Guías Asociadas - Fardos"
                            .opcion = 1
                            .vnum_corre = Me.vnum_corre
                            .vCod_TipAnexo = Me.vCod_TipAnexo
                            .vCod_Anexo = Me.vCod_Anexo
                            .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                            .CARGA_CABECERA()
                            .ShowDialog()
                        End With
                    End Using

                Case "TEXTILTINTO"
                    Using oFardo As New FrmGuiasAsociadas_Fardos
                        With oFardo
                            .oParent = Me
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .LabelTotal.Text = "TOTAL ROLLOS"
                            .Text = "Guías Asociadas - Textil Tintorería"
                            .opcion = 2
                            .vnum_corre = Me.vnum_corre
                            .vCod_TipAnexo = Me.vCod_TipAnexo
                            .vCod_Anexo = Me.vCod_Anexo
                            .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                            .LabelDolares.Visible = True
                            .LabelTotalVal.Visible = True
                            .LabelFactura.Visible = True
                            .LblMontoDol.Visible = True
                            .LblFacturaDol.Visible = True
                            .LblMonto.Visible = True
                            .LblFacturaSol.Visible = True
                            .vNum_Impor = vNum_Impor
                            .sNumLiqServ = sNumLiqServ
                            .CARGA_CABECERA()
                            .ShowDialog()
                        End With
                    End Using

                    'Case "HILANDERIA"   NO VISIBLE 
                    '    Load(frmGuiasAsociadasRepuestos)
                    '    With frmGuiasAsociadasRepuestos
                    '        .vnum_corre = Me.vnum_corre
                    '        .vCod_TipAnexo = Me.vCod_TipAnexo
                    '        .vCod_Anexo = Me.vCod_Anexo
                    '        .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                    '        .CARGA_CABECERA()
                    '        .Show 1
                    '    End With
                    '    frmGuiasAsociadasRepuestos = Nothing

                Case "TEJEDURIA"
                    Using oTej As New FrmGuiasAsociadas_Tejeduria
                        With oTej
                            .oParent = Me
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .vCod_TipAnexo = Me.vCod_TipAnexo
                            .vCod_Anexo = Me.vCod_Anexo
                            .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                            .vCod_Moneda = Me.vCod_Moneda
                            .vMoneda = Me.vMoneda
                            .vTipo_Cambio = Me.vTipo_Cambio
                            .sNumLiqServ = sNumLiqServ
                            .CARGA_CABECERA()
                            .ShowDialog()
                        End With
                    End Using

                    'Case "HILADOS"      NO VISIBLE 
                    '    Load(frmGuiasAsociadasHilados)
                    '    With frmGuiasAsociadasHilados
                    '        .vnum_corre = Me.vnum_corre
                    '        .vCod_TipAnexo = Me.vCod_TipAnexo
                    '        .vCod_Anexo = Me.vCod_Anexo
                    '        .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                    '        .CARGA_CABECERA()
                    '        .Show 1
                    '    End With
                    '    frmGuiasAsociadasHilados = Nothing

                Case "HILADOSNEW"
                    Using oHil As New FrmGuiasAsociadas_Hilados
                        With oHil
                            .oParent = Me
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .vnum_corre = Me.vnum_corre
                            .vCod_TipAnexo = Me.vCod_TipAnexo
                            .vCod_Anexo = Me.vCod_Anexo
                            .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                            .vNum_Impor = vNum_Impor
                            .CARGA_CABECERA()
                            .ShowDialog()
                        End With
                    End Using

                Case "PRETENIDO"
                    Using oTend As New FrmGuiasAsociadas_PreTenido
                        With oTend
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .vnum_corre = Me.vnum_corre
                            .vCod_TipAnexo = Me.vCod_TipAnexo
                            .vCod_Anexo = Me.vCod_Anexo
                            .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                            .CARGA_CABECERA()
                            .ShowDialog()
                        End With
                    End Using

                Case "POSTTEJIDO"
                    Using oTej As New FrmGuiasAsociadas_PostTejido
                        With oTej
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .vnum_corre = Me.vnum_corre
                            .vCod_TipAnexo = Me.vCod_TipAnexo
                            .vCod_Anexo = Me.vCod_Anexo
                            .vCod_AnexoAsociado = Me.vCod_AnexoAsociado
                            .CARGA_CABECERA()
                            .ShowDialog()
                        End With
                    End Using

                Case "CORTEPRENDAS"
                    Using oCorte As New FrmGuiasAsociadas_CortePrendas
                        With oCorte
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .sCod_TipAnexo = Me.vCod_TipAnexo
                            .sCod_Anexo = Me.vCod_Anexo
                            .sFactura = vFactura
                            .sAnexo = vAnexo
                            .LblMoneda.Text = vMoneda
                            .TxtFactura.Text = Strings.Format(vImporte, "#,###.00")
                            .sCod_Moneda = vCod_Moneda
                            .CARGA_CABECERA()
                            .ShowDialog()
                        End With
                    End Using
            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class