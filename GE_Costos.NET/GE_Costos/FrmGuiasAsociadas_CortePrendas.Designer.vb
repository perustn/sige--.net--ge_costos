<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGuiasAsociadas_CortePrendas
    Inherits System.Windows.Forms.Form

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
        Dim ButtonBar1_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim ButtonBar1_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGuiasAsociadas_CortePrendas))
        Dim ButtonBar1_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim gexCabecera_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblMoneda = New System.Windows.Forms.Label()
        Me.TxtFactura = New System.Windows.Forms.TextBox()
        Me.LabelFactura = New System.Windows.Forms.Label()
        Me.TxtTotal_Valorizado = New System.Windows.Forms.TextBox()
        Me.LabelTotalVal = New System.Windows.Forms.Label()
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.gexCabecera = New Janus.Windows.GridEX.GridEX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFacturas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodAnexo = New System.Windows.Forms.TextBox()
        Me.TxtAnexo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.gexCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.TxtTipo)
        Me.Panel4.Controls.Add(Me.TxtAnexo)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TxtCodAnexo)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.TxtFacturas)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtNroCorrelativo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(867, 76)
        Me.Panel4.TabIndex = 253
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(10, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(104, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "NRO CORRELATIVO"
        '
        'TxtNroCorrelativo
        '
        Me.TxtNroCorrelativo.AcceptsReturn = True
        Me.TxtNroCorrelativo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtNroCorrelativo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNroCorrelativo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNroCorrelativo.Location = New System.Drawing.Point(127, 4)
        Me.TxtNroCorrelativo.MaxLength = 0
        Me.TxtNroCorrelativo.Name = "TxtNroCorrelativo"
        Me.TxtNroCorrelativo.ReadOnly = True
        Me.TxtNroCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroCorrelativo.Size = New System.Drawing.Size(96, 20)
        Me.TxtNroCorrelativo.TabIndex = 121
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LblMoneda)
        Me.Panel1.Controls.Add(Me.TxtFactura)
        Me.Panel1.Controls.Add(Me.LabelFactura)
        Me.Panel1.Controls.Add(Me.TxtTotal_Valorizado)
        Me.Panel1.Controls.Add(Me.LabelTotalVal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 66)
        Me.Panel1.TabIndex = 254
        '
        'LblMoneda
        '
        Me.LblMoneda.AutoSize = True
        Me.LblMoneda.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.LblMoneda.ForeColor = System.Drawing.Color.Blue
        Me.LblMoneda.Location = New System.Drawing.Point(775, 3)
        Me.LblMoneda.Name = "LblMoneda"
        Me.LblMoneda.Size = New System.Drawing.Size(49, 12)
        Me.LblMoneda.TabIndex = 13
        Me.LblMoneda.Text = "MONEDA"
        '
        'TxtFactura
        '
        Me.TxtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFactura.Location = New System.Drawing.Point(756, 42)
        Me.TxtFactura.Name = "TxtFactura"
        Me.TxtFactura.ReadOnly = True
        Me.TxtFactura.Size = New System.Drawing.Size(86, 21)
        Me.TxtFactura.TabIndex = 10
        '
        'LabelFactura
        '
        Me.LabelFactura.AutoSize = True
        Me.LabelFactura.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.LabelFactura.ForeColor = System.Drawing.Color.Blue
        Me.LabelFactura.Location = New System.Drawing.Point(625, 47)
        Me.LabelFactura.Name = "LabelFactura"
        Me.LabelFactura.Size = New System.Drawing.Size(122, 12)
        Me.LabelFactura.TabIndex = 9
        Me.LabelFactura.Text = "FACTURA (GRAVABLE)"
        '
        'TxtTotal_Valorizado
        '
        Me.TxtTotal_Valorizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal_Valorizado.Location = New System.Drawing.Point(756, 19)
        Me.TxtTotal_Valorizado.Name = "TxtTotal_Valorizado"
        Me.TxtTotal_Valorizado.ReadOnly = True
        Me.TxtTotal_Valorizado.Size = New System.Drawing.Size(86, 21)
        Me.TxtTotal_Valorizado.TabIndex = 8
        '
        'LabelTotalVal
        '
        Me.LabelTotalVal.AutoSize = True
        Me.LabelTotalVal.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.LabelTotalVal.ForeColor = System.Drawing.Color.Blue
        Me.LabelTotalVal.Location = New System.Drawing.Point(625, 24)
        Me.LabelTotalVal.Name = "LabelTotalVal"
        Me.LabelTotalVal.Size = New System.Drawing.Size(112, 12)
        Me.LabelTotalVal.TabIndex = 7
        Me.LabelTotalVal.Text = "TOTAL VALORIZADO"
        '
        'ButtonBar1
        '
        Me.ButtonBar1.Dock = System.Windows.Forms.DockStyle.Top
        ButtonBar1_Group_0.ImageKey = "Opciones.jpg"
        ButtonBar1_Item_0_0.Image = CType(resources.GetObject("ButtonBar1_Item_0_0.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_0.Key = "ADICIONARGUIA"
        ButtonBar1_Item_0_0.Text = "&Adicionar Guía"
        ButtonBar1_Item_0_1.Image = CType(resources.GetObject("ButtonBar1_Item_0_1.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_1.Key = "DESASIGNAR"
        ButtonBar1_Item_0_1.Text = "&Desasignar"
        ButtonBar1_Item_0_2.Image = CType(resources.GetObject("ButtonBar1_Item_0_2.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_2.Key = "MODIFICAR"
        ButtonBar1_Item_0_2.Text = "&Modificar"
        ButtonBar1_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {ButtonBar1_Item_0_0, ButtonBar1_Item_0_1, ButtonBar1_Item_0_2})
        ButtonBar1_Group_0.Key = "Group1"
        ButtonBar1_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        ButtonBar1_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.ButtonBar1.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar1_Group_0})
        Me.ButtonBar1.HeaderGroupVisible = False
        Me.ButtonBar1.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.ButtonBar1.Location = New System.Drawing.Point(0, 142)
        Me.ButtonBar1.Name = "ButtonBar1"
        Me.ButtonBar1.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.ButtonBar1.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.ButtonBar1.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.ButtonBar1.ShadowOnHover = True
        Me.ButtonBar1.Size = New System.Drawing.Size(867, 22)
        Me.ButtonBar1.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.ButtonBar1.TabIndex = 255
        Me.ButtonBar1.Text = "ButtonBar2"
        Me.ButtonBar1.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Controls.Add(Me.gexCabecera)
        Me.UiGroupBox2.ForeColor = System.Drawing.Color.White
        Me.UiGroupBox2.Location = New System.Drawing.Point(3, 163)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox2.Size = New System.Drawing.Size(860, 302)
        Me.UiGroupBox2.TabIndex = 259
        Me.UiGroupBox2.Tag = "3"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'gexCabecera
        '
        Me.gexCabecera.AllowColumnDrag = False
        Me.gexCabecera.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gexCabecera.AlternatingColors = True
        Me.gexCabecera.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.gexCabecera.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        gexCabecera_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" & _
    "Table></GridEXLayoutData>"
        Me.gexCabecera.DesignTimeLayout = gexCabecera_DesignTimeLayout
        Me.gexCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gexCabecera.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.gexCabecera.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.gexCabecera.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.gexCabecera.GroupByBoxVisible = False
        Me.gexCabecera.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.gexCabecera.Location = New System.Drawing.Point(3, 8)
        Me.gexCabecera.Name = "gexCabecera"
        Me.gexCabecera.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.gexCabecera.RecordNavigator = True
        Me.gexCabecera.Size = New System.Drawing.Size(854, 291)
        Me.gexCabecera.TabIndex = 180
        Me.gexCabecera.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "FACTURA"
        '
        'TxtFacturas
        '
        Me.TxtFacturas.AcceptsReturn = True
        Me.TxtFacturas.BackColor = System.Drawing.Color.LightCyan
        Me.TxtFacturas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFacturas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFacturas.Location = New System.Drawing.Point(127, 28)
        Me.TxtFacturas.MaxLength = 0
        Me.TxtFacturas.Name = "TxtFacturas"
        Me.TxtFacturas.ReadOnly = True
        Me.TxtFacturas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtFacturas.Size = New System.Drawing.Size(96, 20)
        Me.TxtFacturas.TabIndex = 123
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(10, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "ANEXO"
        '
        'TxtCodAnexo
        '
        Me.TxtCodAnexo.AcceptsReturn = True
        Me.TxtCodAnexo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtCodAnexo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodAnexo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCodAnexo.Location = New System.Drawing.Point(127, 52)
        Me.TxtCodAnexo.MaxLength = 0
        Me.TxtCodAnexo.Name = "TxtCodAnexo"
        Me.TxtCodAnexo.ReadOnly = True
        Me.TxtCodAnexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCodAnexo.Size = New System.Drawing.Size(96, 20)
        Me.TxtCodAnexo.TabIndex = 125
        '
        'TxtAnexo
        '
        Me.TxtAnexo.AcceptsReturn = True
        Me.TxtAnexo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtAnexo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAnexo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtAnexo.Location = New System.Drawing.Point(225, 52)
        Me.TxtAnexo.MaxLength = 0
        Me.TxtAnexo.Name = "TxtAnexo"
        Me.TxtAnexo.ReadOnly = True
        Me.TxtAnexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtAnexo.Size = New System.Drawing.Size(501, 20)
        Me.TxtAnexo.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(587, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(86, 12)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "TIPO DE ANEXO"
        '
        'TxtTipo
        '
        Me.TxtTipo.AcceptsReturn = True
        Me.TxtTipo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtTipo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtTipo.Location = New System.Drawing.Point(679, 28)
        Me.TxtTipo.MaxLength = 0
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtTipo.Size = New System.Drawing.Size(47, 20)
        Me.TxtTipo.TabIndex = 128
        '
        'FrmGuiasAsociadas_CortePrendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(867, 468)
        Me.Controls.Add(Me.ButtonBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.UiGroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGuiasAsociadas_CortePrendas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista de guías - Corte Factura"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.gexCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtNroCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonBar1 As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents gexCabecera As Janus.Windows.GridEX.GridEX
    Friend WithEvents LblMoneda As System.Windows.Forms.Label
    Friend WithEvents TxtFactura As System.Windows.Forms.TextBox
    Friend WithEvents LabelFactura As System.Windows.Forms.Label
    Friend WithEvents TxtTotal_Valorizado As System.Windows.Forms.TextBox
    Friend WithEvents LabelTotalVal As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents TxtTipo As System.Windows.Forms.TextBox
    Public WithEvents TxtAnexo As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents TxtCodAnexo As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TxtFacturas As System.Windows.Forms.TextBox
End Class
