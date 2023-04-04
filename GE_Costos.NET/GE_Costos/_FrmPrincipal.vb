Friend Class _FrmPrincipal
    Inherits System.Windows.Forms.Form

    Private Sub Frm_Principal_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        cCONNECT = "Initial Catalog=sige_stn;Data Source=192.168.30.55;uid=vluna;pwd=X@tGDmdq3E##"
        cSEGURIDAD = "Initial Catalog=Seguridad;Data Source=192.168.30.55;uid=vluna;pwd=X@tGDmdq3E##"

        cCONNECTVB6 = "Provider=SQLOLEDB.1;Initial Catalog=sige_stn;Data Source=192.168.30.55;uid=vluna;pwd=X@tGDmdq3E##"
        cSEGURIDADVB6 = "Provider=SQLOLEDB.1;Initial Catalog=Seguridad;Data Source=192.168.30.55;uid=vluna;pwd=X@tGDmdq3E##"

        vusu = "vluna"
        vper = "0001"
        vemp = "01"
        vemp1 = vemp.ToString
        vRuta = My.Application.Info.DirectoryPath
        iLanguage = CShort(GetSetting("Visuales", "Settings", "Language", "1"))
    End Sub

    Private Sub UiButton2_Click(sender As Object, e As EventArgs) Handles UiButton2.Click
        Using frm As New FrmMantAnexosContables
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub UiButton3_Click(sender As Object, e As EventArgs) Handles UiButton3.Click
        Using frm As New FrmMantActivoFijo
            frm.ShowDialog()
        End Using
    End Sub
End Class