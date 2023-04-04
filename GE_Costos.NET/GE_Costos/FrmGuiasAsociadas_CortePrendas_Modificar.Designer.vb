<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGuiasAsociadas_CortePrendas_Modificar
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtSoles = New System.Windows.Forms.TextBox()
        Me.TxtDolares = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSEc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtOP = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TxtSoles)
        Me.Panel1.Controls.Add(Me.TxtDolares)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 83)
        Me.Panel1.TabIndex = 259
        '
        'TxtSoles
        '
        Me.TxtSoles.AcceptsReturn = True
        Me.TxtSoles.BackColor = System.Drawing.Color.White
        Me.TxtSoles.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSoles.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtSoles.Location = New System.Drawing.Point(197, 17)
        Me.TxtSoles.MaxLength = 100
        Me.TxtSoles.Name = "TxtSoles"
        Me.TxtSoles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSoles.Size = New System.Drawing.Size(90, 20)
        Me.TxtSoles.TabIndex = 112
        '
        'TxtDolares
        '
        Me.TxtDolares.AcceptsReturn = True
        Me.TxtDolares.BackColor = System.Drawing.Color.White
        Me.TxtDolares.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDolares.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtDolares.Location = New System.Drawing.Point(197, 43)
        Me.TxtDolares.MaxLength = 100
        Me.TxtDolares.Name = "TxtDolares"
        Me.TxtDolares.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDolares.Size = New System.Drawing.Size(90, 20)
        Me.TxtDolares.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(28, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(180, 13)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Importe Dólares ................................"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(28, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(182, 13)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Importe Soles ...................................."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(313, 30)
        Me.Panel2.TabIndex = 258
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(106, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(207, 30)
        Me.Panel3.TabIndex = 0
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.TxtSEc)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TxtOP)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(313, 32)
        Me.Panel4.TabIndex = 257
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(162, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(23, 12)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "SEC"
        '
        'TxtSEc
        '
        Me.TxtSEc.AcceptsReturn = True
        Me.TxtSEc.BackColor = System.Drawing.Color.LightCyan
        Me.TxtSEc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSEc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtSEc.Location = New System.Drawing.Point(197, 5)
        Me.TxtSEc.MaxLength = 0
        Me.TxtSEc.Name = "TxtSEc"
        Me.TxtSEc.ReadOnly = True
        Me.TxtSEc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSEc.Size = New System.Drawing.Size(62, 20)
        Me.TxtSEc.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(10, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(20, 12)
        Me.Label2.TabIndex = 124
        Me.Label2.Tag = ""
        Me.Label2.Text = "OP"
        '
        'TxtOP
        '
        Me.TxtOP.AcceptsReturn = True
        Me.TxtOP.BackColor = System.Drawing.Color.LightCyan
        Me.TxtOP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtOP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtOP.Location = New System.Drawing.Point(45, 5)
        Me.TxtOP.MaxLength = 0
        Me.TxtOP.Name = "TxtOP"
        Me.TxtOP.ReadOnly = True
        Me.TxtOP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtOP.Size = New System.Drawing.Size(88, 20)
        Me.TxtOP.TabIndex = 125
        '
        'FrmGuiasAsociadas_CortePrendas_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 145)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmGuiasAsociadas_CortePrendas_Modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents TxtSoles As System.Windows.Forms.TextBox
    Public WithEvents TxtDolares As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents TxtSEc As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents TxtOP As System.Windows.Forms.TextBox
End Class
