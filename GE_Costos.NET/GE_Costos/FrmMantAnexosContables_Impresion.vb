Public Class FrmMantAnexosContables_Impresion
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo, Descripcion, TipoAdd, TipoAdd2, TipoAdd3, TipoAdd4 As String

    Private Sub FrmMantAnexosContables_Impresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))

        Panel1.BackColor = colEmpresa
        Panel7.BackColor = colEmpresa
    End Sub

    Private Sub OptConProblemas_Click(sender As Object, e As EventArgs) Handles OptConProblemas.Click
        FraRango.Visible = False
    End Sub

    Private Sub OptConLevantamiento_Click(sender As Object, e As EventArgs) Handles OptConLevantamiento.Click
        FraRango.Visible = True
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call Reporte()
    End Sub

    Sub Reporte()
        Dim oo As Object
        Dim Ruta As String

        Ruta = vRuta & "\RptAnexosConProblemasSunat.XLT"
        strSQL = "CN_REPORTE_ANEXOSCONTABLES_PROBLEMASSUNAT '" & DTPInicio.Value & "','" & DTPFin.Value & "','" & IIf(OptConProblemas.Checked = True, "S", "N") & "'"
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(Ruta)
        oo.Visible = True
        oo.DisplayAlerts = False
        oo.Run("reporte", strSQL, cCONNECTVB6, IIf(OptConProblemas.Checked = True, "S", "N"), "Del: " & DTPInicio.Value.ToShortDateString & " Al: " & DTPFin.Value.ToShortDateString)
        oo = Nothing
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class