<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantAnexosContables_Notificacion
    'Inherits System.Windows.Forms.Form
    Inherits ProyectoBase.frmBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim BarraOpciones_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BarraOpciones_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantAnexosContables_Notificacion))
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim GrdMntTest_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.fraDatos = New System.Windows.Forms.Panel()
        Me.txtResolucionLevantamiento = New System.Windows.Forms.TextBox()
        Me.txtImpLevanEmb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFecLev = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFecNoct = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNroResolucionEmbargo = New System.Windows.Forms.TextBox()
        Me.txtMonEmbSales = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.GrdMntTest = New Janus.Windows.GridEX.GridEX()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDatos.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GrdMntTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraOpciones
        '
        Me.BarraOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        BarraOpciones_Item_0_0.Image = CType(resources.GetObject("BarraOpciones_Item_0_0.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_0.Key = "ADICIONAR"
        BarraOpciones_Item_0_0.SmallImageIndex = 42
        BarraOpciones_Item_0_0.Text = "&Adicionar"
        BarraOpciones_Item_0_1.Image = CType(resources.GetObject("BarraOpciones_Item_0_1.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_1.Key = "MODIFICAR"
        BarraOpciones_Item_0_1.SmallImageIndex = 40
        BarraOpciones_Item_0_1.Text = "&Modificar"
        BarraOpciones_Item_0_2.Image = CType(resources.GetObject("BarraOpciones_Item_0_2.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_2.Key = "ELIMINAR"
        BarraOpciones_Item_0_2.LargeImageIndex = 17
        BarraOpciones_Item_0_2.SmallImageIndex = 39
        BarraOpciones_Item_0_2.Text = "&Eliminar"
        BarraOpciones_Item_0_3.Image = CType(resources.GetObject("BarraOpciones_Item_0_3.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_3.Key = "GRABAR"
        BarraOpciones_Item_0_3.LargeImageIndex = 22
        BarraOpciones_Item_0_3.SmallImageIndex = 45
        BarraOpciones_Item_0_3.Text = "&Grabar"
        BarraOpciones_Item_0_4.Image = CType(resources.GetObject("BarraOpciones_Item_0_4.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_4.Key = "DESHACER"
        BarraOpciones_Item_0_4.LargeImageIndex = 21
        BarraOpciones_Item_0_4.SmallImageIndex = 44
        BarraOpciones_Item_0_4.Text = "&Deshacer"
        BarraOpciones_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BarraOpciones_Item_0_0, BarraOpciones_Item_0_1, BarraOpciones_Item_0_2, BarraOpciones_Item_0_3, BarraOpciones_Item_0_4})
        BarraOpciones_Group_0.Key = "Group1"
        BarraOpciones_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        BarraOpciones_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.BarraOpciones.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {BarraOpciones_Group_0})
        Me.BarraOpciones.HeaderGroupVisible = False
        Me.BarraOpciones.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 289)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(612, 25)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 32
        Me.BarraOpciones.Text = "ButtonBar2"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'fraDatos
        '
        Me.fraDatos.BackColor = System.Drawing.Color.White
        Me.fraDatos.Controls.Add(Me.txtResolucionLevantamiento)
        Me.fraDatos.Controls.Add(Me.txtImpLevanEmb)
        Me.fraDatos.Controls.Add(Me.Label4)
        Me.fraDatos.Controls.Add(Me.Label5)
        Me.fraDatos.Controls.Add(Me.txtFecLev)
        Me.fraDatos.Controls.Add(Me.Label1)
        Me.fraDatos.Controls.Add(Me.TxtFecNoct)
        Me.fraDatos.Controls.Add(Me.Label7)
        Me.fraDatos.Controls.Add(Me.txtNroResolucionEmbargo)
        Me.fraDatos.Controls.Add(Me.txtMonEmbSales)
        Me.fraDatos.Controls.Add(Me.Label2)
        Me.fraDatos.Controls.Add(Me.Label3)
        Me.fraDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.fraDatos.Location = New System.Drawing.Point(0, 314)
        Me.fraDatos.Name = "fraDatos"
        Me.fraDatos.Size = New System.Drawing.Size(612, 166)
        Me.fraDatos.TabIndex = 31
        '
        'txtResolucionLevantamiento
        '
        Me.txtResolucionLevantamiento.AcceptsReturn = True
        Me.txtResolucionLevantamiento.BackColor = System.Drawing.SystemColors.Window
        Me.txtResolucionLevantamiento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtResolucionLevantamiento.Enabled = False
        Me.txtResolucionLevantamiento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtResolucionLevantamiento.Location = New System.Drawing.Point(217, 109)
        Me.txtResolucionLevantamiento.MaxLength = 100
        Me.txtResolucionLevantamiento.Name = "txtResolucionLevantamiento"
        Me.txtResolucionLevantamiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtResolucionLevantamiento.Size = New System.Drawing.Size(334, 20)
        Me.txtResolucionLevantamiento.TabIndex = 303
        '
        'txtImpLevanEmb
        '
        Me.txtImpLevanEmb.AcceptsReturn = True
        Me.txtImpLevanEmb.BackColor = System.Drawing.SystemColors.Window
        Me.txtImpLevanEmb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImpLevanEmb.Enabled = False
        Me.txtImpLevanEmb.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtImpLevanEmb.Location = New System.Drawing.Point(217, 134)
        Me.txtImpLevanEmb.MaxLength = 100
        Me.txtImpLevanEmb.Name = "txtImpLevanEmb"
        Me.txtImpLevanEmb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImpLevanEmb.Size = New System.Drawing.Size(82, 20)
        Me.txtImpLevanEmb.TabIndex = 302
        Me.txtImpLevanEmb.Text = "0.00"
        Me.txtImpLevanEmb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(13, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(222, 13)
        Me.Label4.TabIndex = 305
        Me.Label4.Text = "Nro Resolucion Levantamiento ......................"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(13, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(244, 13)
        Me.Label5.TabIndex = 304
        Me.Label5.Text = "Importe  Levantamiento Embargo .........................."
        '
        'txtFecLev
        '
        Me.txtFecLev.Enabled = False
        Me.txtFecLev.Location = New System.Drawing.Point(217, 84)
        Me.txtFecLev.Mask = "00/00/0000"
        Me.txtFecLev.Name = "txtFecLev"
        Me.txtFecLev.Size = New System.Drawing.Size(82, 20)
        Me.txtFecLev.TabIndex = 301
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 13)
        Me.Label1.TabIndex = 300
        Me.Label1.Text = "Fecha de Levantamiento de Embargo .........."
        '
        'TxtFecNoct
        '
        Me.TxtFecNoct.Enabled = False
        Me.TxtFecNoct.Location = New System.Drawing.Point(217, 9)
        Me.TxtFecNoct.Mask = "00/00/0000"
        Me.TxtFecNoct.Name = "TxtFecNoct"
        Me.TxtFecNoct.Size = New System.Drawing.Size(82, 20)
        Me.TxtFecNoct.TabIndex = 299
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 13)
        Me.Label7.TabIndex = 298
        Me.Label7.Text = "Fecha Notificacion Embargo .........."
        '
        'txtNroResolucionEmbargo
        '
        Me.txtNroResolucionEmbargo.AcceptsReturn = True
        Me.txtNroResolucionEmbargo.BackColor = System.Drawing.SystemColors.Window
        Me.txtNroResolucionEmbargo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNroResolucionEmbargo.Enabled = False
        Me.txtNroResolucionEmbargo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNroResolucionEmbargo.Location = New System.Drawing.Point(217, 34)
        Me.txtNroResolucionEmbargo.MaxLength = 100
        Me.txtNroResolucionEmbargo.Name = "txtNroResolucionEmbargo"
        Me.txtNroResolucionEmbargo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNroResolucionEmbargo.Size = New System.Drawing.Size(334, 20)
        Me.txtNroResolucionEmbargo.TabIndex = 7
        '
        'txtMonEmbSales
        '
        Me.txtMonEmbSales.AcceptsReturn = True
        Me.txtMonEmbSales.BackColor = System.Drawing.SystemColors.Window
        Me.txtMonEmbSales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMonEmbSales.Enabled = False
        Me.txtMonEmbSales.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMonEmbSales.Location = New System.Drawing.Point(217, 59)
        Me.txtMonEmbSales.MaxLength = 100
        Me.txtMonEmbSales.Name = "txtMonEmbSales"
        Me.txtMonEmbSales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMonEmbSales.Size = New System.Drawing.Size(82, 20)
        Me.txtMonEmbSales.TabIndex = 1
        Me.txtMonEmbSales.Text = "0.00"
        Me.txtMonEmbSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(200, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nro Resolucion Embargo : ......................"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(13, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(192, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Monto Embargo Soles .........................."
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.TxtDescripcion)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.TxtCodigo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(612, 27)
        Me.Panel5.TabIndex = 242
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.AcceptsReturn = True
        Me.TxtDescripcion.BackColor = System.Drawing.Color.LightCyan
        Me.TxtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtDescripcion.Location = New System.Drawing.Point(160, 3)
        Me.TxtDescripcion.MaxLength = 0
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ReadOnly = True
        Me.TxtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDescripcion.Size = New System.Drawing.Size(368, 20)
        Me.TxtDescripcion.TabIndex = 122
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(10, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "ANEXO"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.AcceptsReturn = True
        Me.TxtCodigo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCodigo.Location = New System.Drawing.Point(64, 3)
        Me.TxtCodigo.MaxLength = 0
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCodigo.Size = New System.Drawing.Size(94, 20)
        Me.TxtCodigo.TabIndex = 121
        '
        'GrdMntTest
        '
        Me.GrdMntTest.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdMntTest.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GrdMntTest_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
        Me.GrdMntTest.DesignTimeLayout = GrdMntTest_DesignTimeLayout
        Me.GrdMntTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdMntTest.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GrdMntTest.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdMntTest.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GrdMntTest.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GrdMntTest.GroupByBoxVisible = False
        Me.GrdMntTest.Location = New System.Drawing.Point(0, 27)
        Me.GrdMntTest.Name = "GrdMntTest"
        Me.GrdMntTest.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdMntTest.RecordNavigator = True
        Me.GrdMntTest.Size = New System.Drawing.Size(612, 262)
        Me.GrdMntTest.TabIndex = 243
        Me.GrdMntTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'FrmMantAnexosContables_Notificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 480)
        Me.Controls.Add(Me.GrdMntTest)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.fraDatos)
        Me.Name = "FrmMantAnexosContables_Notificacion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Notificaciones SUNAT"
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDatos.ResumeLayout(False)
        Me.fraDatos.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.GrdMntTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents fraDatos As System.Windows.Forms.Panel
    Public WithEvents txtNroResolucionEmbargo As System.Windows.Forms.TextBox
    Public WithEvents txtMonEmbSales As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtResolucionLevantamiento As System.Windows.Forms.TextBox
    Public WithEvents txtImpLevanEmb As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtFecLev As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TxtFecNoct As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents GrdMntTest As Janus.Windows.GridEX.GridEX
End Class
