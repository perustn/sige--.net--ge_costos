Public Class frmCierreAlmacenesPrimarios_ErrSecuencia

    Public Sub New(iColEmpresa As Color, iStrSQL As String, iTipItem As String, iTipPresentacion As String, iCodAlmacen As String, iMes As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Panel2.BackColor = iColEmpresa
        strSQL = iStrSQL
        sTipItem = iTipItem
        sTipPresentacion = iTipPresentacion
        sCodAlmacen = iCodAlmacen
        sMes = iMes
    End Sub

    Private strSQL As String
    Private ds As New DataTable
    Private oHP As New clsHELPER
    Private sTipItem As String
    Private sTipPresentacion As String
    Private sCodAlmacen As String
    Private sMes As String

    Private rs As New ADODB.Recordset
    Private lvRuta As String = ""

    Private Sub Buscar()
        Try

            ds = oHP.DevuelveDatos(strSQL, cCONNECT, True)
            GridEX1.DataSource = ds
            CheckLayoutGridEx(GridEX1)
            rs = ConvertToRecordset(ds)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCierreAlmacenesPrimarios_ErrSecuencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buscar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try

            If ds.Rows.Count = 0 Then Exit Sub

            lvRuta = ""
            Select Case sTipItem
                Case "I"
                    lvRuta = "\ErroresItems.xlt"
                Case "T"
                    If sTipPresentacion = "T" Then
                        lvRuta = "\ErroresTelaAcabada.xlt"
                    Else
                        lvRuta = "\ErroresTelaCruda.xlt"
                    End If
            End Select

            Dim oo As Object

            oo = CreateObject("excel.application")

            oo.Workbooks.Open(vRuta & lvRuta)

            oo.Visible = True
            oo.DisplayAlerts = False
            If sTipItem = "I" Then
                oo.Run("REPORTE", rs, sMes, sCodAlmacen)
            Else
                oo.Run("REPORTE", rs)
            End If
            oo.Visible = True
            oo = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class