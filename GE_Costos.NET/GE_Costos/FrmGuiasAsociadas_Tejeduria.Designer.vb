﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGuiasAsociadas_Tejeduria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGuiasAsociadas_Tejeduria))
        Dim ButtonBar1_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim gexCabecera_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelDolares = New System.Windows.Forms.Label()
        Me.LblFacturaSol = New System.Windows.Forms.TextBox()
        Me.LblMonto = New System.Windows.Forms.TextBox()
        Me.LblFacturaDol = New System.Windows.Forms.TextBox()
        Me.LabelFactura = New System.Windows.Forms.Label()
        Me.LblMontoDol = New System.Windows.Forms.TextBox()
        Me.LabelTotalVal = New System.Windows.Forms.Label()
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.Fa_Lectura_Electronica = New System.Windows.Forms.Panel()
        Me.grpColor = New Janus.Windows.EditControls.UIGroupBox()
        Me.TxtBarra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New Janus.Windows.EditControls.UIButton()
        Me.gexCabecera = New Janus.Windows.GridEX.GridEX()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.Fa_Lectura_Electronica.SuspendLayout()
        CType(Me.grpColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpColor.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.gexCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtNroCorrelativo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(867, 27)
        Me.Panel4.TabIndex = 253
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
        Me.TxtNroCorrelativo.Location = New System.Drawing.Point(127, 3)
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
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LabelDolares)
        Me.Panel1.Controls.Add(Me.LblFacturaSol)
        Me.Panel1.Controls.Add(Me.LblMonto)
        Me.Panel1.Controls.Add(Me.LblFacturaDol)
        Me.Panel1.Controls.Add(Me.LabelFactura)
        Me.Panel1.Controls.Add(Me.LblMontoDol)
        Me.Panel1.Controls.Add(Me.LabelTotalVal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 66)
        Me.Panel1.TabIndex = 254
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(790, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 12)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "SOLES"
        '
        'LabelDolares
        '
        Me.LabelDolares.AutoSize = True
        Me.LabelDolares.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.LabelDolares.ForeColor = System.Drawing.Color.Blue
        Me.LabelDolares.Location = New System.Drawing.Point(704, 3)
        Me.LabelDolares.Name = "LabelDolares"
        Me.LabelDolares.Size = New System.Drawing.Size(53, 12)
        Me.LabelDolares.TabIndex = 13
        Me.LabelDolares.Text = "DOLARES"
        '
        'LblFacturaSol
        '
        Me.LblFacturaSol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFacturaSol.Location = New System.Drawing.Point(776, 42)
        Me.LblFacturaSol.Name = "LblFacturaSol"
        Me.LblFacturaSol.ReadOnly = True
        Me.LblFacturaSol.Size = New System.Drawing.Size(86, 21)
        Me.LblFacturaSol.TabIndex = 12
        '
        'LblMonto
        '
        Me.LblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonto.Location = New System.Drawing.Point(776, 19)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.ReadOnly = True
        Me.LblMonto.Size = New System.Drawing.Size(86, 21)
        Me.LblMonto.TabIndex = 11
        '
        'LblFacturaDol
        '
        Me.LblFacturaDol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFacturaDol.Location = New System.Drawing.Point(685, 42)
        Me.LblFacturaDol.Name = "LblFacturaDol"
        Me.LblFacturaDol.ReadOnly = True
        Me.LblFacturaDol.Size = New System.Drawing.Size(86, 21)
        Me.LblFacturaDol.TabIndex = 10
        '
        'LabelFactura
        '
        Me.LabelFactura.AutoSize = True
        Me.LabelFactura.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.LabelFactura.ForeColor = System.Drawing.Color.Blue
        Me.LabelFactura.Location = New System.Drawing.Point(554, 47)
        Me.LabelFactura.Name = "LabelFactura"
        Me.LabelFactura.Size = New System.Drawing.Size(122, 12)
        Me.LabelFactura.TabIndex = 9
        Me.LabelFactura.Text = "FACTURA (GRAVABLE)"
        '
        'LblMontoDol
        '
        Me.LblMontoDol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoDol.Location = New System.Drawing.Point(685, 19)
        Me.LblMontoDol.Name = "LblMontoDol"
        Me.LblMontoDol.ReadOnly = True
        Me.LblMontoDol.Size = New System.Drawing.Size(86, 21)
        Me.LblMontoDol.TabIndex = 8
        '
        'LabelTotalVal
        '
        Me.LabelTotalVal.AutoSize = True
        Me.LabelTotalVal.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.LabelTotalVal.ForeColor = System.Drawing.Color.Blue
        Me.LabelTotalVal.Location = New System.Drawing.Point(554, 24)
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
        ButtonBar1_Item_0_0.Key = "ASIGNAR"
        ButtonBar1_Item_0_0.Text = "&Asignar Guía"
        ButtonBar1_Item_0_1.Image = CType(resources.GetObject("ButtonBar1_Item_0_1.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_1.Key = "DESASIGNAR"
        ButtonBar1_Item_0_1.Text = "&Desasignar Guía"
        ButtonBar1_Item_0_2.Image = CType(resources.GetObject("ButtonBar1_Item_0_2.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_2.Key = "VALORIZAR"
        ButtonBar1_Item_0_2.Text = "Valorizar"
        ButtonBar1_Item_0_3.Image = CType(resources.GetObject("ButtonBar1_Item_0_3.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_3.Key = "BARRA"
        ButtonBar1_Item_0_3.Text = "&Lectura Barra"
        ButtonBar1_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {ButtonBar1_Item_0_0, ButtonBar1_Item_0_1, ButtonBar1_Item_0_2, ButtonBar1_Item_0_3})
        ButtonBar1_Group_0.Key = "Group1"
        ButtonBar1_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        ButtonBar1_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.ButtonBar1.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar1_Group_0})
        Me.ButtonBar1.HeaderGroupVisible = False
        Me.ButtonBar1.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.ButtonBar1.Location = New System.Drawing.Point(0, 93)
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
        Me.UiGroupBox2.Controls.Add(Me.Fa_Lectura_Electronica)
        Me.UiGroupBox2.Controls.Add(Me.gexCabecera)
        Me.UiGroupBox2.ForeColor = System.Drawing.Color.White
        Me.UiGroupBox2.Location = New System.Drawing.Point(3, 113)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox2.Size = New System.Drawing.Size(860, 326)
        Me.UiGroupBox2.TabIndex = 259
        Me.UiGroupBox2.Tag = "3"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'Fa_Lectura_Electronica
        '
        Me.Fa_Lectura_Electronica.Controls.Add(Me.grpColor)
        Me.Fa_Lectura_Electronica.Controls.Add(Me.Panel6)
        Me.Fa_Lectura_Electronica.Location = New System.Drawing.Point(242, 59)
        Me.Fa_Lectura_Electronica.Name = "Fa_Lectura_Electronica"
        Me.Fa_Lectura_Electronica.Size = New System.Drawing.Size(294, 103)
        Me.Fa_Lectura_Electronica.TabIndex = 181
        Me.Fa_Lectura_Electronica.Visible = False
        '
        'grpColor
        '
        Me.grpColor.Controls.Add(Me.TxtBarra)
        Me.grpColor.Controls.Add(Me.Label9)
        Me.grpColor.ForeColor = System.Drawing.Color.White
        Me.grpColor.Location = New System.Drawing.Point(10, 5)
        Me.grpColor.Name = "grpColor"
        Me.grpColor.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.grpColor.Size = New System.Drawing.Size(274, 63)
        Me.grpColor.TabIndex = 255
        Me.grpColor.Tag = "3"
        Me.grpColor.Text = "Lectura Electrónica"
        Me.grpColor.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'TxtBarra
        '
        Me.TxtBarra.Location = New System.Drawing.Point(91, 25)
        Me.TxtBarra.Name = "TxtBarra"
        Me.TxtBarra.Size = New System.Drawing.Size(152, 20)
        Me.TxtBarra.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(17, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "CÓDIGO"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 73)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(294, 30)
        Me.Panel6.TabIndex = 254
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.BtnCerrar)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(101, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(193, 30)
        Me.Panel7.TabIndex = 0
        '
        'BtnCerrar
        '
        Me.BtnCerrar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnCerrar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCerrar.Location = New System.Drawing.Point(3, 3)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCerrar.Size = New System.Drawing.Size(98, 24)
        Me.BtnCerrar.TabIndex = 5
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
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
        Me.gexCabecera.Size = New System.Drawing.Size(854, 315)
        Me.gexCabecera.TabIndex = 180
        Me.gexCabecera.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'FrmGuiasAsociadas_Tejeduria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(867, 444)
        Me.Controls.Add(Me.ButtonBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.UiGroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGuiasAsociadas_Tejeduria"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignación Guías Tejeduría"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.Fa_Lectura_Electronica.ResumeLayout(False)
        CType(Me.grpColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpColor.ResumeLayout(False)
        Me.grpColor.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelDolares As System.Windows.Forms.Label
    Friend WithEvents LblFacturaSol As System.Windows.Forms.TextBox
    Friend WithEvents LblMonto As System.Windows.Forms.TextBox
    Friend WithEvents LblFacturaDol As System.Windows.Forms.TextBox
    Friend WithEvents LabelFactura As System.Windows.Forms.Label
    Friend WithEvents LblMontoDol As System.Windows.Forms.TextBox
    Friend WithEvents LabelTotalVal As System.Windows.Forms.Label
    Friend WithEvents Fa_Lectura_Electronica As System.Windows.Forms.Panel
    Friend WithEvents grpColor As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents TxtBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents BtnCerrar As Janus.Windows.EditControls.UIButton
End Class
