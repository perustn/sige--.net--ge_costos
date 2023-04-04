Imports Janus.Windows.GridEX

Public Class FrmGuiasAsociadas_PreTenido_AsigGuias
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private oDt As New DataTable
    Private colEmpresa As Color
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String, TipoAdd3 As String, TipoAdd4 As String

    Public Opcion_guias As Integer
    Public vNum_Impor As String
    Public vCod_Anexo As String
    Public vCod_AnexoAsociado As String
    Public vCod_TipAnexo As String

    'VARIABLES PARA PASAR DATOS DE UN GRID AL OTRO
    Private oDT_GridEx1 As New DataTable
    Private oDT_GridEx2 As New DataTable
    Public sRowIndex As Integer

    Private Sub FrmGuiasAsociadas_Fardos_AsigGuias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa
    End Sub

    Sub CARGA_MOVIMIENTOS()
        Try

            strSQL = "EXEC SM_MUESTRA_GUIAS_POR_FACTURAR_TX_MOVISTK_PRE_TENIDO"
            strSQL &= vbNewLine & String.Format(" @COD_TIPANEX      = '{0}'", vCod_TipAnexo)
            strSQL &= vbNewLine & String.Format(",@COD_ANXO         = '{0}'", vCod_Anexo)
            strSQL &= vbNewLine & String.Format(",@COD_ANXOASOCIADO = '{0}'", vCod_AnexoAsociado)
            GridEX1.DataSource = oHP.DevuelveDatos(strSQL, cCONNECT)

            strSQL = "EXEC SM_MUESTRA_GUIAS_POR_FACTURAR_TX_MOVISTK_PRE_TENIDO"
            strSQL &= vbNewLine & String.Format(" @COD_TIPANEX      = '{0}'", "")
            strSQL &= vbNewLine & String.Format(",@COD_ANXO         = '{0}'", "")
            strSQL &= vbNewLine & String.Format(",@COD_ANXOASOCIADO = '{0}'", "")
            GridEX2.DataSource = oHP.DevuelveDatos(strSQL, cCONNECT)

            CheckLayoutGridEx(GridEX1)
            CheckLayoutGridEx(GridEX2)

            GridEX1.RootTable.Columns("cod_almacen").Visible = False
            GridEX1.RootTable.Columns("Movimiento").Width = 70
            GridEX1.RootTable.Columns("Guia").Width = 120

            GridEX2.RootTable.Columns("cod_almacen").Visible = False
            GridEX2.RootTable.Columns("Movimiento").Width = 70
            GridEX2.RootTable.Columns("Guia").Width = 120
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdAddAll_Click(sender As Object, e As EventArgs) Handles cmdAddAll.Click
        Dim i As Integer
        For i = 0 To GridEX1.RecordCount - 1
            GridEX_To_GridEX(GridEX1, GridEX2, oDT_GridEx1, oDT_GridEx2)
        Next
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        GridEX_To_GridEX(GridEX1, GridEX2, oDT_GridEx1, oDT_GridEx2)
    End Sub

    Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
        GridEX_To_GridEX(GridEX2, GridEX1, oDT_GridEx2, oDT_GridEx1)
    End Sub

    Private Sub cmdDelAll_Click(sender As Object, e As EventArgs) Handles cmdDelAll.Click
        Dim i As Integer
        For i = 0 To GridEX2.RecordCount - 1
            GridEX_To_GridEX(GridEX2, GridEX1, oDT_GridEx2, oDT_GridEx1)
        Next
    End Sub

    Private Sub GridEX_To_GridEX(GridExOrigen As GridEX, GridExDestino As GridEX, oDT_GridEx_Origen As DataTable, oDT_GridEx_Destino As DataTable)
        'INICIO DE LA FUNCION PASAR DATOS DE UN GRID A OTRO GRID ALEX HUAMAN PACHAS
        If GridExOrigen.RowCount > 0 Then
            Dim sRegistrosAPasar As DataRow

            sRowIndex = GridExOrigen.CurrentRow.RowIndex 'CAPTURAMOS LA POSICION PARA ELIMINAR EL REGISTRO SEGUN EL INDICE

            'CAPTURAMOS EL REGISTRO ACTUAL
            sRegistrosAPasar = ObtenerDr_DeGridEx(GridExOrigen)

            'PASAMOS LOS DATOS DEL REGISTRO ACTUAL AL DATATABLE DESTINO
            oDT_GridEx_Destino.Rows.Add(sRegistrosAPasar("COD_ALMACEN").ToString(), sRegistrosAPasar("Movimiento").ToString(), sRegistrosAPasar("Almacen").ToString(), sRegistrosAPasar("Guia").ToString(), sRegistrosAPasar("Fec.Mov.").ToString(), sRegistrosAPasar("Observaciones").ToString())
            oDT_GridEx_Destino.AcceptChanges() 'ACEPTAMOS LOS CAMBIOS
            GridExDestino.DataSource = oDT_GridEx_Destino 'LLENAMOS LA NUEVA DATA A LA GRILLA
            CheckLayoutGridEx(GridExDestino)

            'txtTotalPrendas.Text = sTotal_Prendas
            oDT_GridEx_Origen.Rows.RemoveAt(sRowIndex) 'ELIMINAMOS LA DATA DEL DT ORIGIN            
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim GuardaReg As Boolean
            GuardaReg = False
            Dim oDtOPs As DataTable = CType(GridEX2.DataSource, DataTable)
            If oDtOPs.Rows.Count > 0 Then

                For Each dtrow As DataRow In oDtOPs.Rows
                    strSQL = "EXEC UP_ASIGNA_GUIA_FACTURA_PRE_TENIDO"
                    strSQL &= vbNewLine & String.Format(" @num_corre        = '{0}'", TxtNroCorrelativo.Text)
                    strSQL &= vbNewLine & String.Format(",@COD_ALMACEN      = '{0}'", dtrow("cod_almacen"))
                    strSQL &= vbNewLine & String.Format(",@NUM_MOVSTK       = '{0}'", dtrow("Movimiento"))

                    oHP.EjecutaOperacion(strSQL, cCONNECT)
                    GuardaReg = True
                Next
                If GuardaReg = True Then
                    MessageBox.Show("Proceso realizado correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                MessageBox.Show("No ha seleccionado ningún movimiento. Sirvase verificar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class