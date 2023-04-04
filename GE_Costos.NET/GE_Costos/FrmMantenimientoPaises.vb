Imports Janus.Windows.GridEX

Public Class FrmMantenimientoPaises
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private OpcionMantenimiento As String

    Public oParent As Object

    Private Sub FrmMantenimientoPaises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGA_GRID()
    End Sub

    Private Sub CARGA_GRID()

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC CN_MAN_PAISES"
        strSQL &= vbNewLine & String.Format(" @accion        = '{0}'", "V")
        strSQL &= vbNewLine & String.Format(",@COD_PAIS      = '{0}'", "")
        strSQL &= vbNewLine & String.Format(",@DESCRIPCION   = '{0}'", "")

        oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
        GrdMntTest.DataSource = oDT
        CheckLayoutGridEx(GrdMntTest)

        With GrdMntTest
            With .RootTable
                .HeaderLines = 2
                .RowHeight = 30
                .PreviewRow = True
                .PreviewRowLines = 15
                .PreviewRowMember = "COMENTARIOS"

                For Each oGridEXColumn As GridEXColumn In .Columns
                    With oGridEXColumn
                        .WordWrap = True
                        .Visible = True
                        .FilterEditType = FilterEditType.Combo
                    End With
                Next

                With .Columns("codigo")
                    .Caption = "CODIGO"
                    .Width = 80
                    .TextAlignment = TextAlignment.Center
                End With

                With .Columns("descripcion")
                    .Caption = "DESCRIPCION"
                    .Width = 360
                End With
            End With
        End With

        If GrdMntTest.RowCount > 0 Then
            GrdMntTest.Enabled = True
        Else
            GrdMntTest.Enabled = False
        End If
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Dim Eliminar As Short
            Dim vRow As Integer
            Dim cRow As Integer
            Select Case e.Item.Key
                Case "ADICIONAR"
                    OpcionMantenimiento = "I"
                    Call LIMPIA_DATOS()
                    Call HABILITA_DATOS()
                    Me.TxtDescripcion.Focus()
                    With BarraOpciones.Groups(0)
                        .Items("MODIFICAR").Enabled = False
                        .Items("ELIMINAR").Enabled = False
                        .Items("GRABAR").Enabled = True
                        .Items("DESHACER").Enabled = True
                    End With

                Case "MODIFICAR"
                    OpcionMantenimiento = "U"
                    Call HABILITA_DATOS()
                    Me.TxtDescripcion.Focus()
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = False
                        .Items("ELIMINAR").Enabled = False
                        .Items("GRABAR").Enabled = True
                        .Items("DESHACER").Enabled = True
                    End With

                Case "ELIMINAR"
                    Eliminar = MsgBox("¿Esta usted seguro de eliminar el registro seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
                    If Eliminar = MsgBoxResult.Yes Then
                        OpcionMantenimiento = "D"
                        Call SALVAR_DATOS()
                        Call CARGA_GRID()
                        OpcionMantenimiento = ""
                    End If

                Case "GRABAR"
                    vRow = GrdMntTest.Row
                    cRow = GrdMntTest.RowCount
                    Call SALVAR_DATOS()
                    Call CARGA_GRID()
                    Call INHABILITA_DATOS()
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = True
                        .Items("MODIFICAR").Enabled = True
                        .Items("ELIMINAR").Enabled = True
                        .Items("GRABAR").Enabled = False
                        .Items("DESHACER").Enabled = False
                    End With

                    If OpcionMantenimiento = "U" Then
                        GrdMntTest.Row = vRow
                    Else
                        'GrdMntMedidas.Row = cRow
                    End If
                    OpcionMantenimiento = ""

                Case "DESHACER"
                    Call LIMPIA_DATOS()
                    Call Carga_Datos()
                    Call INHABILITA_DATOS()
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = True
                        .Items("MODIFICAR").Enabled = True
                        .Items("ELIMINAR").Enabled = True
                        .Items("GRABAR").Enabled = False
                        .Items("DESHACER").Enabled = False
                    End With
                    OpcionMantenimiento = ""
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub HABILITA_DATOS()
        TxtDescripcion.Enabled = True
    End Sub

    Public Sub INHABILITA_DATOS()
        TxtDescripcion.Enabled = False
    End Sub

    Public Sub LIMPIA_DATOS()
        TxtID.Text = String.Empty
        TxtDescripcion.Text = String.Empty
    End Sub

    Sub SALVAR_DATOS()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MAN_PAISES"
            strSQL &= vbNewLine & String.Format(" @accion       = '{0}'", OpcionMantenimiento)
            strSQL &= vbNewLine & String.Format(",@COD_PAIS     = '{0}'", TxtID.Text)
            strSQL &= vbNewLine & String.Format(",@DESCRIPCION  = '{0}'", Trim(TxtDescripcion.Text))
            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                CARGA_GRID()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub GrdMntTest_SelectionChanged(sender As Object, e As EventArgs) Handles GrdMntTest.SelectionChanged
        Call Me.Carga_Datos()
    End Sub

    Public Sub Carga_Datos()
        If Me.GrdMntTest.RowCount > 0 Then
            Dim dr As DataRow
            dr = ObtenerDr_DeGridEx(GrdMntTest)
            If Not dr Is Nothing Then
                Me.TxtID.Text = dr("CODIGO").ToString
                Me.TxtDescripcion.Text = dr("DESCRIPCION").ToString
            End If
        Else
            Call LIMPIA_DATOS()
        End If
    End Sub

    Private Sub FrmMantenimientoPaises_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'oParent.TxtCod_Pais = Me.TxtID.Text
        'oParent.TxtDes_Pais = Me.TxtDescripcion.Text
        'Me.Close()
    End Sub
End Class