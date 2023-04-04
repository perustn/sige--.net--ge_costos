<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantActivoFijo_VariacionActivo
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
        Dim GrdDatos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ButtonBar1_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim ButtonBar1_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantActivoFijo_VariacionActivo))
        Dim ButtonBar1_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.GrdDatos = New Janus.Windows.GridEX.GridEX()
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdDatos
        '
        Me.GrdDatos.AllowColumnDrag = False
        Me.GrdDatos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdDatos.AlternatingColors = True
        Me.GrdDatos.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GrdDatos.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GrdDatos_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" & _
    "Table></GridEXLayoutData>"
        Me.GrdDatos.DesignTimeLayout = GrdDatos_DesignTimeLayout
        Me.GrdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdDatos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GrdDatos.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDatos.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GrdDatos.GroupByBoxVisible = False
        Me.GrdDatos.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDatos.Location = New System.Drawing.Point(0, 49)
        Me.GrdDatos.Name = "GrdDatos"
        Me.GrdDatos.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdDatos.RecordNavigator = True
        Me.GrdDatos.Size = New System.Drawing.Size(762, 312)
        Me.GrdDatos.TabIndex = 254
        Me.GrdDatos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'ButtonBar1
        '
        Me.ButtonBar1.Dock = System.Windows.Forms.DockStyle.Top
        ButtonBar1_Group_0.ImageKey = "Opciones.jpg"
        ButtonBar1_Item_0_0.Image = CType(resources.GetObject("ButtonBar1_Item_0_0.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_0.Key = "ADICIONAR"
        ButtonBar1_Item_0_0.Text = "Adicionar"
        ButtonBar1_Item_0_1.Image = CType(resources.GetObject("ButtonBar1_Item_0_1.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_1.Key = "MODIFICAR"
        ButtonBar1_Item_0_1.Text = "Modificar"
        ButtonBar1_Item_0_2.Image = CType(resources.GetObject("ButtonBar1_Item_0_2.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_2.Key = "ELIMINAR"
        ButtonBar1_Item_0_2.Text = "Eliminar"
        ButtonBar1_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {ButtonBar1_Item_0_0, ButtonBar1_Item_0_1, ButtonBar1_Item_0_2})
        ButtonBar1_Group_0.Key = "Group1"
        ButtonBar1_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        ButtonBar1_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.ButtonBar1.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar1_Group_0})
        Me.ButtonBar1.HeaderGroupVisible = False
        Me.ButtonBar1.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.ButtonBar1.Location = New System.Drawing.Point(0, 27)
        Me.ButtonBar1.Name = "ButtonBar1"
        Me.ButtonBar1.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.ButtonBar1.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.ButtonBar1.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.ButtonBar1.ShadowOnHover = True
        Me.ButtonBar1.Size = New System.Drawing.Size(762, 22)
        Me.ButtonBar1.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.ButtonBar1.TabIndex = 253
        Me.ButtonBar1.Text = "ButtonBar2"
        Me.ButtonBar1.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.TxtDescripcion)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.TxtCodigo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(762, 27)
        Me.Panel5.TabIndex = 252
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(10, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(45, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "ACTIVO"
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
        'FrmMantActivoFijo_VariacionActivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 361)
        Me.Controls.Add(Me.GrdDatos)
        Me.Controls.Add(Me.ButtonBar1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMantActivoFijo_VariacionActivo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Variaciones del Activo Fijo"
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrdDatos As Janus.Windows.GridEX.GridEX
    Friend WithEvents ButtonBar1 As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtCodigo As System.Windows.Forms.TextBox
End Class
