Public Class FrmMantAnexosContables_MantenimientoUbigeo
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo, Descripcion, TipoAdd, TipoAdd2, TipoAdd3, TipoAdd4 As String

    Public CodDistrito As String
    Public DesDistrito As String

    Private Sub FrmMantAnexosContables_MantenimientoUbigeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))

        Panel1.BackColor = colEmpresa
        Panel7.BackColor = colEmpresa

        Me.ActiveControl = TxtCodDepartamento
    End Sub

    Private Sub TxtCodDepartamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodDepartamento.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If TxtCodDepartamento.Text <> "" Then
                BUSCA_DEPARTAMENTO(1)
            Else
                BUSCA_DEPARTAMENTO(3)
            End If
        End If
    End Sub

    Private Sub TxtDesDepartamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDesDepartamento.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If TxtDesDepartamento.Text <> "" Then
                BUSCA_DEPARTAMENTO(2)
            Else
                BUSCA_DEPARTAMENTO(3)
            End If
        End If
    End Sub

    Private Sub BUSCA_DEPARTAMENTO(Tipo As Integer)
        Select Case Tipo
            Case 1
                strSQL = "SELECT descripcion as 'Descripción' FROM  tg_ubigeo WHERE substring(cod_ubigeo,3,6)='0000' and cod_departamento = '" & Trim(Me.TxtCodDepartamento.Text) & "'"
                Me.TxtDesDepartamento.Text = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                TxtCodProvincia.Focus()
            Case 2, 3
                Dim oTipo As New frmBusqGeneral6
                oTipo.oParent = Me
                If Tipo = 2 Then
                    oTipo.sQuery = "SELECT cod_departamento as 'Código', descripcion as 'Descripción' FROM tg_ubigeo WHERE substring(cod_ubigeo,3,6)='0000' and descripcion LIKE '%" & Trim(Me.TxtDesDepartamento.Text) & "%' ORDER BY cod_departamento"
                Else
                    oTipo.sQuery = "SELECT cod_departamento as 'Código', descripcion AS 'Descripción' FROM tg_ubigeo where substring(cod_ubigeo,3,6)='0000' ORDER BY cod_departamento"
                End If
                oTipo.Cargar_Datos()
                oTipo.ShowDialog()
                If Codigo <> "" Then
                    Me.TxtCodDepartamento.Text = Trim(Codigo)
                    Me.TxtDesDepartamento.Text = Trim(Descripcion)
                    Codigo = "" : Descripcion = "" : TipoAdd = ""
                    TxtCodProvincia.Focus()
                End If
                oTipo = Nothing
        End Select
    End Sub

    Private Sub TxtCodProvincia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodProvincia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If TxtCodDepartamento.Text = "" And TxtDesDepartamento.Text = "" Then
                MessageBox.Show("Debe seleccionar un Departamento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If TxtCodProvincia.Text <> "" Then
                    If TxtCodDistrito.Text = "" And TxtDesDistrito.Text = "" Then
                        BUSCA_PROVINCIA(1)
                    Else
                        BUSCA_PROVINCIA(11)
                    End If
                Else
                    If TxtCodDistrito.Text = "" And TxtDesDistrito.Text = "" Then
                        BUSCA_PROVINCIA(2)
                    Else
                        BUSCA_PROVINCIA(22)
                    End If
                End If
                TxtCodDistrito.Focus()
            End If
        End If
    End Sub

    Private Sub BUSCA_PROVINCIA(Tipo As Integer)
        Select Case Tipo
            Case 1
                strSQL = "SELECT descripcion as 'Descripción' FROM  tg_ubigeo WHERE substring(cod_ubigeo,5,6)='00'  and substring(cod_ubigeo,3,6)<>'0000' and cod_departamento= '" & Trim(Me.TxtCodDepartamento.Text) & "' and cod_provincia = '" & Trim(Me.TxtCodProvincia.Text) & "'"
                Me.TxtDesProvincia.Text = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                TxtCodDistrito.Focus()
            Case 11
                strSQL = "SELECT descripcion as 'Descripción' FROM  tg_ubigeo WHERE  cod_departamento= '" & Trim(Me.TxtCodDepartamento.Text) & "' and cod_ubigeo= '" & Trim(Me.TxtCodDistrito.Text) & "' and cod_provincia = '" & Trim(Me.TxtCodProvincia.Text) & "'"
                Me.TxtDesProvincia.Text = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                TxtCodDistrito.Focus()
            Case 2, 3
                Dim oTipo As New frmBusqGeneral6
                oTipo.oParent = Me
                If Tipo = 2 Then
                    oTipo.sQuery = "SELECT cod_provincia as 'Código', descripcion as 'Descripción' FROM tg_ubigeo WHERE substring(cod_ubigeo,5,6)='00'  and substring(cod_ubigeo,3,6)<>'0000' and cod_departamento='" & Trim(Me.TxtCodDepartamento.Text) & "' and descripcion LIKE '%" & Trim(Me.TxtDesProvincia.Text) & "%' ORDER BY cod_provincia"
                Else
                    oTipo.sQuery = "SELECT cod_provincia as 'Código', descripcion AS 'Descripción' FROM tg_ubigeo where substring(cod_ubigeo,5,6)='00'  and substring(cod_ubigeo,3,6)<>'0000' and cod_departamento='" & Trim(Me.TxtCodDepartamento.Text) & "' ORDER BY cod_provincia"
                End If
                oTipo.Cargar_Datos()
                oTipo.ShowDialog()
                If Codigo <> "" Then
                    Me.TxtCodProvincia.Text = Trim(Codigo)
                    Me.TxtDesProvincia.Text = Trim(Descripcion)
                    Codigo = "" : Descripcion = "" : TipoAdd = ""
                    TxtCodDistrito.Focus()
                End If
                oTipo = Nothing
            Case 22
                Dim oTipo1 As New frmBusqGeneral6
                oTipo1.oParent = Me
                If Tipo = 22 Then
                    oTipo1.sQuery = "SELECT cod_provincia as 'Código', descripcion as 'Descripción' FROM tg_ubigeo WHERE cod_departamento='" & Trim(Me.TxtCodDepartamento.Text) & "' and cod_ubigeo='" & Trim(Me.TxtCodDistrito.Text) & "' and descripcion LIKE '%" & Trim(Me.TxtDesProvincia.Text) & "%' ORDER BY cod_provincia"
                Else
                    oTipo1.sQuery = "SELECT cod_provincia as 'Código', descripcion AS 'Descripción' FROM tg_ubigeo where cod_ubigeo='" & Trim(Me.TxtCodDistrito.Text) & "' and cod_departamento='" & Trim(Me.TxtCodDepartamento.Text) & "' ORDER BY cod_provincia"
                End If
                oTipo1.Cargar_Datos()
                oTipo1.ShowDialog()
                If Codigo <> "" Then
                    Me.TxtCodProvincia.Text = Trim(Codigo)
                    Me.TxtDesProvincia.Text = Trim(Descripcion)
                    Codigo = "" : Descripcion = "" : TipoAdd = ""
                    TxtCodDistrito.Focus()
                End If
                oTipo1 = Nothing
        End Select
    End Sub

    Private Sub TxtCodDistrito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodDistrito.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If TxtCodDepartamento.Text = "" And TxtDesDepartamento.Text = "" Then
                MessageBox.Show("Debe seleccionar un Departamento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If TxtCodDistrito.Text <> "" Then
                    If TxtCodProvincia.Text = "" And TxtDesProvincia.Text = "" Then
                        BUSCA_DISTRITO(1)
                    Else
                        BUSCA_DISTRITO(11)
                    End If
                Else
                    If TxtCodProvincia.Text = "" And TxtDesProvincia.Text = "" Then
                        BUSCA_DISTRITO(2)
                    Else
                        BUSCA_DISTRITO(22)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BUSCA_DISTRITO(Tipo As Integer)
        Select Case Tipo
            Case 1
                strSQL = "SELECT descripcion as 'Descripción' FROM  tg_ubigeo WHERE substring(cod_ubigeo,5,6)<>'00'  and substring(cod_ubigeo,3,6)<>'0000' and cod_departamento= '" & Trim(Me.TxtCodDepartamento.Text) & "' and cod_ubigeo = '" & Trim(Me.TxtCodDistrito.Text) & "'"
                Me.TxtDesDistrito.Text = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                BtnAceptar.Focus()
            Case 11
                strSQL = "SELECT descripcion as 'Descripción' FROM  tg_ubigeo WHERE  cod_departamento= '" & Trim(Me.TxtCodDepartamento.Text) & "' and cod_provincia= '" & Trim(Me.TxtCodProvincia.Text) & "' and cod_ubigeo = '" & Trim(Me.TxtCodDistrito.Text) & "'"
                Me.TxtDesDistrito.Text = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                BtnAceptar.Focus()
            Case 2, 3
                Dim oTipo As New frmBusqGeneral6
                oTipo.oParent = Me
                If Tipo = 2 Then
                    oTipo.sQuery = "SELECT cod_ubigeo as 'Código', descripcion as 'Descripción' FROM tg_ubigeo WHERE substring(cod_ubigeo,5,6)<>'00'  and substring(cod_ubigeo,3,6)<>'0000' and cod_departamento='" & Trim(Me.TxtCodDepartamento.Text) & "' and descripcion LIKE '%" & Trim(Me.TxtDesDistrito.Text) & "%' ORDER BY cod_ubigeo"
                Else
                    oTipo.sQuery = "SELECT cod_ubigeo as 'Código', descripcion AS 'Descripción' FROM tg_ubigeo   substring(cod_ubigeo,5,6)<>'00'  and substring(cod_ubigeo,3,6)<>'0000' and cod_departamento='" & Trim(Me.TxtCodDepartamento.Text) & "' ORDER BY cod_ubigeo"
                End If
                oTipo.Cargar_Datos()
                oTipo.ShowDialog()
                If Codigo <> "" Then
                    Me.TxtCodDistrito.Text = Trim(Codigo)
                    Me.TxtDesDistrito.Text = Trim(Descripcion)
                    Codigo = "" : Descripcion = "" : TipoAdd = ""
                    BtnAceptar.Focus()
                End If
                oTipo = Nothing
            Case 22
                Dim oTipo1 As New frmBusqGeneral6
                oTipo1.oParent = Me
                If Tipo = 22 Then
                    oTipo1.sQuery = "SELECT cod_ubigeo as 'Código', descripcion as 'Descripción' FROM tg_ubigeo WHERE SUBSTRING(COD_UBIGEO,5,2) <>'00' AND cod_departamento='" & Trim(Me.TxtCodDepartamento.Text) & "' and cod_provincia='" & Trim(Me.TxtCodProvincia.Text) & "' and descripcion LIKE '%" & Trim(Me.TxtDesDistrito.Text) & "%' ORDER BY cod_ubigeo"
                Else
                    oTipo1.sQuery = "SELECT cod_ubigeo as 'Código', descripcion AS 'Descripción' FROM tg_ubigeo where cod_provincia='" & Trim(Me.TxtCodProvincia.Text) & "' and cod_departamento='" & Trim(Me.TxtCodDepartamento.Text) & "' ORDER BY cod_ubigeo"
                End If
                oTipo1.Cargar_Datos()
                oTipo1.ShowDialog()
                If Codigo <> "" Then
                    Me.TxtCodDistrito.Text = Trim(Codigo)
                    Me.TxtDesDistrito.Text = Trim(Descripcion)
                    Codigo = "" : Descripcion = "" : TipoAdd = ""
                    BtnAceptar.Focus()
                End If
                oTipo1 = Nothing
        End Select
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtCodDistrito.Text <> "" Then
            CodDistrito = TxtCodDistrito.Text
            DesDistrito = TxtDesDistrito.Text
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Debe seleccionar un distrito...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class