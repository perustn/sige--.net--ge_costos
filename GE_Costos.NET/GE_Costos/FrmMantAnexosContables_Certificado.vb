Imports Janus.Windows.GridEX

Public Class FrmMantAnexosContables_Certificado
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Private Sub FrmMantAnexosContables_Certificado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
    End Sub

    Private Sub OpcionSeleccion(sender As Object, e As EventArgs) Handles OptTodo.Click, OptNumero.Click, OptAnexo.Click
        If OptTodo.Checked = True Then
            BtnBuscar.Focus()
        ElseIf OptNumero.Checked = True Then
            If txt_NumeroConstancia.Enabled = True Then
                txt_NumeroConstancia.Focus()
            End If
        ElseIf OptAnexo.Checked = True Then
            If txt_TipAnexo.Enabled = True Then
                txt_TipAnexo.Focus()
            End If
        End If
    End Sub

    Private Sub txt_TipAnexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TipAnexo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txt_CodAnexo.Focus()
        End If
    End Sub

    Private Sub txt_CodAnexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CodAnexo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Busca_Anexo(1)
            If txt_DesAnexo.Text = "" Then
                txt_DesAnexo.Focus()
                Exit Sub
            Else
                BtnBuscar.Focus()
            End If
        End If
    End Sub

    Private Sub txt_DesAnexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_DesAnexo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Busca_Anexo(2)
            If txt_DesAnexo.Text = "" Then
                txt_DesAnexo.Focus()
                Exit Sub
            Else
                txt_Ano.Focus()
            End If
        End If
    End Sub

    Sub Busca_Anexo(Tipo As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        If Tipo = 1 Then
            oTipo.sQuery = "SELECT Cod_TipAnEX TIPO, Cod_Anxo CODIGO, Des_Anexo DESCRIPCION FROM dbo.CN_AnexosContables WHERE Cod_TipAnEX ='" & Trim(txt_TipAnexo.Text) & "' and Cod_Anxo like '" & Trim(txt_CodAnexo.Text) & "%'"
        ElseIf Tipo = 2 Then
            oTipo.sQuery = "SELECT Cod_TipAnEX TIPO, Cod_Anxo CODIGO, Des_Anexo DESCRIPCION FROM dbo.CN_AnexosContables WHERE Des_Anexo like '%" & Trim(txt_DesAnexo.Text) & "%'"
        End If
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Tipo")
            Descripcion = oTipo.dtResultados.Rows(0)("CODIGO")
            TipoAdd = oTipo.dtResultados.Rows(0)("DESCRIPCION")
        End If

        If Codigo <> "" Then
            txt_TipAnexo.Text = Trim(Codigo)
            txt_CodAnexo.Text = Trim(Descripcion)
            txt_DesAnexo.Text = Trim(TipoAdd)
            txt_Ano.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txt_Ano_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Ano.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnBuscar.Focus()
        Else
            SoloNumeros(e)
        End If
    End Sub

    Private Sub txt_NumeroConstancia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NumeroConstancia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CARGA_GRID()
    End Sub

    Sub CARGA_GRID()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_SM_CERTIFICADO_CUARTA_CATEGORIA"
            strSQL &= vbNewLine & String.Format(" @opcion        = '{0}'", IIf(OptTodo.Checked = True, 1, IIf(OptAnexo.Checked = True, 2, 3)))
            strSQL &= vbNewLine & String.Format(",@Cod_TipAnex   = '{0}'", Trim(txt_TipAnexo.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Anxo      = '{0}'", Trim(txt_CodAnexo.Text))
            strSQL &= vbNewLine & String.Format(",@Ano           = '{0}'", Trim(txt_Ano.Text))
            strSQL &= vbNewLine & String.Format(",@Num_Constancia_Suspension      = '{0}'", Trim(txt_NumeroConstancia.Text))

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

                    .Columns("COD_TIPANEX").Width = 100
                    .Columns("COD_TIPANEX").Caption = "TIPO ANEXO"
                    .Columns("COD_TIPANEX").TextAlignment = TextAlignment.Center

                    .Columns("COD_ANXO").Width = 100
                    .Columns("COD_ANXO").Caption = "COD. ANEXO"
                    .Columns("COD_ANXO").TextAlignment = TextAlignment.Center

                    .Columns("DES_ANEXO").Width = 220
                    .Columns("DES_ANEXO").Caption = "DES. ANEXO"

                    .Columns("ANO").Width = 60
                    .Columns("ANO").Caption = "ANO"
                    .Columns("ANO").TextAlignment = TextAlignment.Center

                    .Columns("NUM_CONSTANCIA_SUSPENSION").Width = 190
                    .Columns("NUM_CONSTANCIA_SUSPENSION").Caption = "CONSTANCIA SUSPENSION"

                    .Columns("COD_USUARIO_CREACION").Width = 120
                    .Columns("COD_USUARIO_CREACION").Caption = "USUARIO"

                    .Columns("FEC_CREACION").Width = 120
                    .Columns("FEC_CREACION").Caption = "FEC. CREACIÓN"
                    .Columns("FEC_CREACION").TextAlignment = TextAlignment.Center

                End With
            End With
            GrdDatos.FrozenColumns = 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    Using oAdd As New FrmMantAnexosContables_Certificado_Mant
                        With oAdd
                            .oParent = Me
                            .sAccion = "I"
                            .Text = "Adicionar"
                            .txt_TipAnexo.Text = Trim(txt_TipAnexo.Text)
                            .txt_CodAnexo.Text = Trim(txt_CodAnexo.Text)
                            .txt_DesAnexo.Text = Trim(txt_DesAnexo.Text)
                            .txt_Ano.Text = Trim(txt_Ano.Text)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_GRID()
                            End If
                        End With
                    End Using

                Case "MODIFICAR"
                    If GrdDatos.RowCount = 0 Then
                        MessageBox.Show("No hay registros para modificar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    Using oMod As New FrmMantAnexosContables_Certificado_Mant
                        With oMod
                            .oParent = Me
                            .sAccion = "U"
                            .Text = "Modificar"
                            .txt_TipAnexo.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Cod_TipAnex").Index))
                            .txt_CodAnexo.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Cod_Anxo").Index))
                            .txt_DesAnexo.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Des_Anexo").Index))
                            .txt_Ano.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Ano").Index))
                            .txt_TipAnexo.Enabled = False
                            .txt_CodAnexo.Enabled = False
                            .txt_DesAnexo.Enabled = False
                            .txt_Ano.Enabled = False
                            .txt_NumeroConstancia.Text = Trim(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Num_Constancia_Suspension").Index))
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CARGA_GRID()
                            End If
                        End With
                    End Using
                   
                Case "ELIMINAR"
                    If GrdDatos.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC CN_MAN_CERTIFICADO_CUARTA_CATEGORIA"
                        strSQL &= vbNewLine & String.Format(" @ACCION            = '{0}'", "D")
                        strSQL &= vbNewLine & String.Format(",@Cod_TipAnex       = '{0}'", GrdDatos.GetValue(GrdDatos.RootTable.Columns("Cod_TipAnex").Index))
                        strSQL &= vbNewLine & String.Format(",@Cod_Anxo          = '{0}'", GrdDatos.GetValue(GrdDatos.RootTable.Columns("Cod_Anxo").Index))
                        strSQL &= vbNewLine & String.Format(",@Ano               = '{0}'", GrdDatos.GetValue(GrdDatos.RootTable.Columns("Ano").Index))
                        strSQL &= vbNewLine & String.Format(",@Num_Constancia_Suspension  = '{0}'", "")
                        strSQL &= vbNewLine & String.Format(",@Cod_Usuario_Creacion       = '{0}'", vusu)

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