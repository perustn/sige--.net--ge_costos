<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantAnexosContables_Certificado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantAnexosContables_Certificado))
        Dim ButtonBar1_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.GrdDatos = New Janus.Windows.GridEX.GridEX()
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.BtnBuscar = New Janus.Windows.EditControls.UIButton()
        Me.txt_Ano = New System.Windows.Forms.TextBox()
        Me.txt_NumeroConstancia = New System.Windows.Forms.TextBox()
        Me.txt_TipAnexo = New System.Windows.Forms.TextBox()
        Me.txt_DesAnexo = New System.Windows.Forms.TextBox()
        Me.txt_CodAnexo = New System.Windows.Forms.TextBox()
        Me.OptNumero = New System.Windows.Forms.RadioButton()
        Me.OptAnexo = New System.Windows.Forms.RadioButton()
        Me.OptTodo = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
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
        Me.GrdDatos.Location = New System.Drawing.Point(0, 143)
        Me.GrdDatos.Name = "GrdDatos"
        Me.GrdDatos.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdDatos.RecordNavigator = True
        Me.GrdDatos.Size = New System.Drawing.Size(854, 315)
        Me.GrdDatos.TabIndex = 251
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
        Me.ButtonBar1.Location = New System.Drawing.Point(0, 121)
        Me.ButtonBar1.Name = "ButtonBar1"
        Me.ButtonBar1.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.ButtonBar1.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.ButtonBar1.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.ButtonBar1.ShadowOnHover = True
        Me.ButtonBar1.Size = New System.Drawing.Size(854, 22)
        Me.ButtonBar1.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.ButtonBar1.TabIndex = 250
        Me.ButtonBar1.Text = "ButtonBar2"
        Me.ButtonBar1.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Azure
        Me.Panel5.Controls.Add(Me.UiGroupBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(854, 121)
        Me.Panel5.TabIndex = 249
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.BtnBuscar)
        Me.UiGroupBox1.Controls.Add(Me.txt_Ano)
        Me.UiGroupBox1.Controls.Add(Me.txt_NumeroConstancia)
        Me.UiGroupBox1.Controls.Add(Me.txt_TipAnexo)
        Me.UiGroupBox1.Controls.Add(Me.txt_DesAnexo)
        Me.UiGroupBox1.Controls.Add(Me.txt_CodAnexo)
        Me.UiGroupBox1.Controls.Add(Me.OptNumero)
        Me.UiGroupBox1.Controls.Add(Me.OptAnexo)
        Me.UiGroupBox1.Controls.Add(Me.OptTodo)
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(841, 108)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "Filtro Búsqueda"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.GE_Costos.My.Resources.Resources.search01_16X16
        Me.BtnBuscar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnBuscar.Location = New System.Drawing.Point(718, 16)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnBuscar.Size = New System.Drawing.Size(117, 29)
        Me.BtnBuscar.TabIndex = 114
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Empty
        Me.BtnBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txt_Ano
        '
        Me.txt_Ano.AcceptsReturn = True
        Me.txt_Ano.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Ano.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Ano.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Ano.Location = New System.Drawing.Point(614, 51)
        Me.txt_Ano.MaxLength = 100
        Me.txt_Ano.Name = "txt_Ano"
        Me.txt_Ano.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Ano.Size = New System.Drawing.Size(68, 20)
        Me.txt_Ano.TabIndex = 113
        '
        'txt_NumeroConstancia
        '
        Me.txt_NumeroConstancia.AcceptsReturn = True
        Me.txt_NumeroConstancia.BackColor = System.Drawing.SystemColors.Window
        Me.txt_NumeroConstancia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_NumeroConstancia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_NumeroConstancia.Location = New System.Drawing.Point(197, 81)
        Me.txt_NumeroConstancia.MaxLength = 100
        Me.txt_NumeroConstancia.Name = "txt_NumeroConstancia"
        Me.txt_NumeroConstancia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_NumeroConstancia.Size = New System.Drawing.Size(152, 20)
        Me.txt_NumeroConstancia.TabIndex = 111
        '
        'txt_TipAnexo
        '
        Me.txt_TipAnexo.AcceptsReturn = True
        Me.txt_TipAnexo.BackColor = System.Drawing.SystemColors.Window
        Me.txt_TipAnexo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_TipAnexo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_TipAnexo.Location = New System.Drawing.Point(197, 51)
        Me.txt_TipAnexo.MaxLength = 100
        Me.txt_TipAnexo.Name = "txt_TipAnexo"
        Me.txt_TipAnexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TipAnexo.Size = New System.Drawing.Size(38, 20)
        Me.txt_TipAnexo.TabIndex = 110
        '
        'txt_DesAnexo
        '
        Me.txt_DesAnexo.AcceptsReturn = True
        Me.txt_DesAnexo.BackColor = System.Drawing.SystemColors.Window
        Me.txt_DesAnexo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_DesAnexo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_DesAnexo.Location = New System.Drawing.Point(313, 51)
        Me.txt_DesAnexo.MaxLength = 100
        Me.txt_DesAnexo.Name = "txt_DesAnexo"
        Me.txt_DesAnexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_DesAnexo.Size = New System.Drawing.Size(220, 20)
        Me.txt_DesAnexo.TabIndex = 109
        '
        'txt_CodAnexo
        '
        Me.txt_CodAnexo.AcceptsReturn = True
        Me.txt_CodAnexo.BackColor = System.Drawing.SystemColors.Window
        Me.txt_CodAnexo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_CodAnexo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_CodAnexo.Location = New System.Drawing.Point(237, 51)
        Me.txt_CodAnexo.MaxLength = 100
        Me.txt_CodAnexo.Name = "txt_CodAnexo"
        Me.txt_CodAnexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_CodAnexo.Size = New System.Drawing.Size(74, 20)
        Me.txt_CodAnexo.TabIndex = 108
        '
        'OptNumero
        '
        Me.OptNumero.AutoSize = True
        Me.OptNumero.BackColor = System.Drawing.Color.Transparent
        Me.OptNumero.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptNumero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptNumero.ForeColor = System.Drawing.Color.Black
        Me.OptNumero.Location = New System.Drawing.Point(12, 84)
        Me.OptNumero.Name = "OptNumero"
        Me.OptNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptNumero.Size = New System.Drawing.Size(118, 17)
        Me.OptNumero.TabIndex = 106
        Me.OptNumero.Tag = "9"
        Me.OptNumero.Text = "Número Constancia"
        Me.OptNumero.UseVisualStyleBackColor = False
        '
        'OptAnexo
        '
        Me.OptAnexo.AutoSize = True
        Me.OptAnexo.BackColor = System.Drawing.Color.Transparent
        Me.OptAnexo.Checked = True
        Me.OptAnexo.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptAnexo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptAnexo.ForeColor = System.Drawing.Color.Black
        Me.OptAnexo.Location = New System.Drawing.Point(12, 54)
        Me.OptAnexo.Name = "OptAnexo"
        Me.OptAnexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptAnexo.Size = New System.Drawing.Size(79, 17)
        Me.OptAnexo.TabIndex = 105
        Me.OptAnexo.TabStop = True
        Me.OptAnexo.Tag = "8"
        Me.OptAnexo.Text = "Anexo/Año"
        Me.OptAnexo.UseVisualStyleBackColor = False
        '
        'OptTodo
        '
        Me.OptTodo.AutoSize = True
        Me.OptTodo.BackColor = System.Drawing.Color.Transparent
        Me.OptTodo.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptTodo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTodo.ForeColor = System.Drawing.Color.Black
        Me.OptTodo.Location = New System.Drawing.Point(12, 25)
        Me.OptTodo.Name = "OptTodo"
        Me.OptTodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptTodo.Size = New System.Drawing.Size(49, 17)
        Me.OptTodo.TabIndex = 104
        Me.OptTodo.Tag = "9"
        Me.OptTodo.Text = "Todo"
        Me.OptTodo.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Azure
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(137, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Anexo ................"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Azure
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(565, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Año ................"
        '
        'FrmMantAnexosContables_Certificado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 458)
        Me.Controls.Add(Me.GrdDatos)
        Me.Controls.Add(Me.ButtonBar1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMantAnexosContables_Certificado"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Certificado 4ta Categoría"
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrdDatos As Janus.Windows.GridEX.GridEX
    Friend WithEvents ButtonBar1 As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents OptNumero As System.Windows.Forms.RadioButton
    Public WithEvents OptAnexo As System.Windows.Forms.RadioButton
    Public WithEvents OptTodo As System.Windows.Forms.RadioButton
    Public WithEvents txt_Ano As System.Windows.Forms.TextBox
    Public WithEvents txt_NumeroConstancia As System.Windows.Forms.TextBox
    Public WithEvents txt_TipAnexo As System.Windows.Forms.TextBox
    Public WithEvents txt_DesAnexo As System.Windows.Forms.TextBox
    Public WithEvents txt_CodAnexo As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As Janus.Windows.EditControls.UIButton
End Class
