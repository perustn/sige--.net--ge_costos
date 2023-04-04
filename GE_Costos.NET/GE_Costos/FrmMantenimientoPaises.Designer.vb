<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoPaises
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
        Dim GrdMntTest_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim BarraOpciones_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BarraOpciones_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoPaises))
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.GrdMntTest = New Janus.Windows.GridEX.GridEX()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.fraDatos = New System.Windows.Forms.Panel()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GrdMntTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDatos.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GrdMntTest.Location = New System.Drawing.Point(0, 0)
        Me.GrdMntTest.Name = "GrdMntTest"
        Me.GrdMntTest.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdMntTest.RecordNavigator = True
        Me.GrdMntTest.Size = New System.Drawing.Size(489, 343)
        Me.GrdMntTest.TabIndex = 33
        Me.GrdMntTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
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
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 343)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(489, 25)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 32
        Me.BarraOpciones.Text = "ButtonBar2"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'fraDatos
        '
        Me.fraDatos.BackColor = System.Drawing.Color.White
        Me.fraDatos.Controls.Add(Me.TxtID)
        Me.fraDatos.Controls.Add(Me.TxtDescripcion)
        Me.fraDatos.Controls.Add(Me.Label2)
        Me.fraDatos.Controls.Add(Me.Label3)
        Me.fraDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.fraDatos.Location = New System.Drawing.Point(0, 368)
        Me.fraDatos.Name = "fraDatos"
        Me.fraDatos.Size = New System.Drawing.Size(489, 73)
        Me.fraDatos.TabIndex = 31
        '
        'TxtID
        '
        Me.TxtID.AcceptsReturn = True
        Me.TxtID.BackColor = System.Drawing.SystemColors.Window
        Me.TxtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtID.Enabled = False
        Me.TxtID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtID.Location = New System.Drawing.Point(91, 7)
        Me.TxtID.MaxLength = 4
        Me.TxtID.Name = "TxtID"
        Me.TxtID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtID.Size = New System.Drawing.Size(43, 20)
        Me.TxtID.TabIndex = 7
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.AcceptsReturn = True
        Me.TxtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtDescripcion.Location = New System.Drawing.Point(91, 29)
        Me.TxtDescripcion.MaxLength = 100
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDescripcion.Size = New System.Drawing.Size(383, 38)
        Me.TxtDescripcion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Código : ......................"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(13, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Descripcion.........................."
        '
        'FrmMantenimientoPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 441)
        Me.Controls.Add(Me.GrdMntTest)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.fraDatos)
        Me.Name = "FrmMantenimientoPaises"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de Países"
        CType(Me.GrdMntTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDatos.ResumeLayout(False)
        Me.fraDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrdMntTest As Janus.Windows.GridEX.GridEX
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents fraDatos As System.Windows.Forms.Panel
    Public WithEvents TxtID As System.Windows.Forms.TextBox
    Public WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
End Class
