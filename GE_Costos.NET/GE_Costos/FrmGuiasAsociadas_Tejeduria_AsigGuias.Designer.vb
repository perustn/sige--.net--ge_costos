<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGuiasAsociadas_Tejeduria_AsigGuias
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
        Dim GridEX2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGuiasAsociadas_Tejeduria_AsigGuias))
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.BtnPasarGasto = New Janus.Windows.EditControls.UIButton()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.cmdDelAll = New Janus.Windows.EditControls.UIButton()
        Me.cmdAdd = New Janus.Windows.EditControls.UIButton()
        Me.cmdDel = New Janus.Windows.EditControls.UIButton()
        Me.cmdAddAll = New Janus.Windows.EditControls.UIButton()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel4.Size = New System.Drawing.Size(724, 27)
        Me.Panel4.TabIndex = 255
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 386)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 30)
        Me.Panel2.TabIndex = 256
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.BtnPasarGasto)
        Me.Panel11.Controls.Add(Me.BtnCancelar)
        Me.Panel11.Controls.Add(Me.BtnAceptar)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(412, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(312, 30)
        Me.Panel11.TabIndex = 0
        '
        'BtnPasarGasto
        '
        Me.BtnPasarGasto.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnPasarGasto.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnPasarGasto.Location = New System.Drawing.Point(209, 3)
        Me.BtnPasarGasto.Name = "BtnPasarGasto"
        Me.BtnPasarGasto.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnPasarGasto.Size = New System.Drawing.Size(98, 24)
        Me.BtnPasarGasto.TabIndex = 8
        Me.BtnPasarGasto.Text = "Pasar al Gasto"
        Me.BtnPasarGasto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCancelar.Location = New System.Drawing.Point(105, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 24)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'BtnAceptar
        '
        Me.BtnAceptar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnAceptar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnAceptar.Location = New System.Drawing.Point(3, 3)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnAceptar.Size = New System.Drawing.Size(98, 24)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.UiGroupBox3)
        Me.Panel1.Controls.Add(Me.UiGroupBox2)
        Me.Panel1.Controls.Add(Me.cmdDelAll)
        Me.Panel1.Controls.Add(Me.cmdAdd)
        Me.Panel1.Controls.Add(Me.cmdDel)
        Me.Panel1.Controls.Add(Me.cmdAddAll)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 359)
        Me.Panel1.TabIndex = 280
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Controls.Add(Me.GridEX2)
        Me.UiGroupBox3.Location = New System.Drawing.Point(393, 8)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox3.Size = New System.Drawing.Size(313, 334)
        Me.UiGroupBox3.TabIndex = 205
        Me.UiGroupBox3.Text = "Seleccionadas"
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'GridEX2
        '
        Me.GridEX2.AllowColumnDrag = False
        Me.GridEX2.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX2.AlternatingColors = True
        Me.GridEX2.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX2.CardCaptionFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX2.CardCaptionFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX2.CardWidth = 350
        Me.GridEX2.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GridEX2_DesignTimeLayout.LayoutString = resources.GetString("GridEX2_DesignTimeLayout.LayoutString")
        Me.GridEX2.DesignTimeLayout = GridEX2_DesignTimeLayout
        Me.GridEX2.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX2.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEX2.GroupByBoxFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX2.GroupByBoxFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.GroupRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX2.GroupRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX2.HeaderFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX2.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX2.Location = New System.Drawing.Point(6, 19)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX2.RecordNavigator = True
        Me.GridEX2.Size = New System.Drawing.Size(301, 309)
        Me.GridEX2.TabIndex = 203
        Me.GridEX2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Controls.Add(Me.GridEX1)
        Me.UiGroupBox2.Location = New System.Drawing.Point(9, 8)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox2.Size = New System.Drawing.Size(313, 334)
        Me.UiGroupBox2.TabIndex = 204
        Me.UiGroupBox2.Text = "Disponibles"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'GridEX1
        '
        Me.GridEX1.AllowColumnDrag = False
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.CardCaptionFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.CardCaptionFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.CardWidth = 350
        Me.GridEX1.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEX1.GroupByBoxFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.GroupByBoxFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.GroupRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.GroupRowFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.HeaderFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridEX1.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.GridEX1.Location = New System.Drawing.Point(6, 19)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(301, 309)
        Me.GridEX1.TabIndex = 203
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'cmdDelAll
        '
        Me.cmdDelAll.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.cmdDelAll.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdDelAll.Location = New System.Drawing.Point(337, 235)
        Me.cmdDelAll.Name = "cmdDelAll"
        Me.cmdDelAll.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.cmdDelAll.Size = New System.Drawing.Size(37, 37)
        Me.cmdDelAll.TabIndex = 16
        Me.cmdDelAll.Text = "<<"
        Me.cmdDelAll.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'cmdAdd
        '
        Me.cmdAdd.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.cmdAdd.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdAdd.Location = New System.Drawing.Point(337, 124)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.cmdAdd.Size = New System.Drawing.Size(37, 37)
        Me.cmdAdd.TabIndex = 15
        Me.cmdAdd.Text = ">"
        Me.cmdAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'cmdDel
        '
        Me.cmdDel.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.cmdDel.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdDel.Location = New System.Drawing.Point(337, 179)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.cmdDel.Size = New System.Drawing.Size(37, 37)
        Me.cmdDel.TabIndex = 14
        Me.cmdDel.Text = "<"
        Me.cmdDel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'cmdAddAll
        '
        Me.cmdAddAll.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.cmdAddAll.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdAddAll.Location = New System.Drawing.Point(337, 68)
        Me.cmdAddAll.Name = "cmdAddAll"
        Me.cmdAddAll.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.cmdAddAll.Size = New System.Drawing.Size(37, 37)
        Me.cmdAddAll.TabIndex = 13
        Me.cmdAddAll.Text = ">>"
        Me.cmdAddAll.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FrmGuiasAsociadas_Tejeduria_AsigGuias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmGuiasAsociadas_Tejeduria_AsigGuias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar Guías - Tejeduría"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtNroCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents cmdDelAll As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdAdd As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdDel As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdAddAll As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnPasarGasto As Janus.Windows.EditControls.UIButton
End Class
