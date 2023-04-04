<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentosPago_AsignarGuias
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
        Dim ButtonBar2_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim ButtonBar2_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentosPago_AsignarGuias))
        Dim ButtonBar2_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar2_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar2_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar2_Item_0_4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar2_Item_0_5 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar2_Item_0_6 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar2_Item_0_7 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar2_Item_0_8 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar2_Item_0_9 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.ButtonBar2 = New Janus.Windows.ButtonBar.ButtonBar()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.ButtonBar2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel4.Size = New System.Drawing.Size(258, 27)
        Me.Panel4.TabIndex = 252
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
        Me.Panel1.Controls.Add(Me.UiGroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 461)
        Me.Panel1.TabIndex = 253
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.ButtonBar2)
        Me.UiGroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(234, 441)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "Relación de Opciones para Asignar Guías"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'ButtonBar2
        '
        Me.ButtonBar2.Dock = System.Windows.Forms.DockStyle.Fill
        ButtonBar2_Group_0.ImageKey = "Opciones.jpg"
        ButtonBar2_Item_0_0.Image = CType(resources.GetObject("ButtonBar2_Item_0_0.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_0.Key = "CONFEC"
        ButtonBar2_Item_0_0.Text = "&Almacenes primarios"
        ButtonBar2_Item_0_1.Image = CType(resources.GetObject("ButtonBar2_Item_0_1.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_1.Key = "FARDOS"
        ButtonBar2_Item_0_1.Text = "Fardos"
        ButtonBar2_Item_0_2.Image = CType(resources.GetObject("ButtonBar2_Item_0_2.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_2.Key = "TEXTILTINTO"
        ButtonBar2_Item_0_2.Text = "Textil Tintorería"
        ButtonBar2_Item_0_3.Image = CType(resources.GetObject("ButtonBar2_Item_0_3.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_3.Key = "HILANDERIA"
        ButtonBar2_Item_0_3.Text = "Hilanderia / Repuestos"
        ButtonBar2_Item_0_3.Visible = False
        ButtonBar2_Item_0_4.Image = CType(resources.GetObject("ButtonBar2_Item_0_4.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_4.Key = "TEJEDURIA"
        ButtonBar2_Item_0_4.Text = "Tejeduría"
        ButtonBar2_Item_0_5.Image = CType(resources.GetObject("ButtonBar2_Item_0_5.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_5.Key = "HILADOS"
        ButtonBar2_Item_0_5.Text = "Hilanderia / Hilados"
        ButtonBar2_Item_0_5.Visible = False
        ButtonBar2_Item_0_6.Image = CType(resources.GetObject("ButtonBar2_Item_0_6.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_6.Key = "HILADOSNEW"
        ButtonBar2_Item_0_6.Text = "Hilados "
        ButtonBar2_Item_0_7.Image = CType(resources.GetObject("ButtonBar2_Item_0_7.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_7.Key = "PRETENIDO"
        ButtonBar2_Item_0_7.Text = "Pre-Teñido"
        ButtonBar2_Item_0_8.Image = CType(resources.GetObject("ButtonBar2_Item_0_8.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_8.Key = "POSTTEJIDO"
        ButtonBar2_Item_0_8.Text = "&Post-Tejido"
        ButtonBar2_Item_0_9.Image = CType(resources.GetObject("ButtonBar2_Item_0_9.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_9.Key = "CORTEPRENDAS"
        ButtonBar2_Item_0_9.Text = "&Corte Prendas"
        ButtonBar2_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {ButtonBar2_Item_0_0, ButtonBar2_Item_0_1, ButtonBar2_Item_0_2, ButtonBar2_Item_0_3, ButtonBar2_Item_0_4, ButtonBar2_Item_0_5, ButtonBar2_Item_0_6, ButtonBar2_Item_0_7, ButtonBar2_Item_0_8, ButtonBar2_Item_0_9})
        ButtonBar2_Group_0.Key = "Group1"
        ButtonBar2_Group_0.Text = "Opciones"
        Me.ButtonBar2.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar2_Group_0})
        Me.ButtonBar2.HeaderGroupVisible = False
        Me.ButtonBar2.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.ButtonBar2.LargeImageSize = New System.Drawing.Size(25, 25)
        Me.ButtonBar2.Location = New System.Drawing.Point(3, 16)
        Me.ButtonBar2.Name = "ButtonBar2"
        Me.ButtonBar2.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.ButtonBar2.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.ButtonBar2.ShadowOnHover = True
        Me.ButtonBar2.Size = New System.Drawing.Size(228, 422)
        Me.ButtonBar2.SmallImageSize = New System.Drawing.Size(25, 25)
        Me.ButtonBar2.TabIndex = 130
        Me.ButtonBar2.Text = "Opciones"
        Me.ButtonBar2.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'FrmDocumentosPago_AsignarGuias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 488)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentosPago_AsignarGuias"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar Guías"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.ButtonBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtNroCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents ButtonBar2 As Janus.Windows.ButtonBar.ButtonBar
End Class
