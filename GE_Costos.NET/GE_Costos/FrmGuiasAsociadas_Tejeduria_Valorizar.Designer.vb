<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGuiasAsociadas_Tejeduria_Valorizar
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMoneda = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkTodasGuias = New Janus.Windows.EditControls.UICheckBox()
        Me.chkPU = New Janus.Windows.EditControls.UICheckBox()
        Me.TxtSoles = New System.Windows.Forms.TextBox()
        Me.TxtDolares = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.TxtTipoCambio)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TxtMoneda)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(340, 56)
        Me.Panel4.TabIndex = 254
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(10, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(76, 12)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "TIPO CAMBIO"
        '
        'TxtTipoCambio
        '
        Me.TxtTipoCambio.AcceptsReturn = True
        Me.TxtTipoCambio.BackColor = System.Drawing.Color.LightCyan
        Me.TxtTipoCambio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTipoCambio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtTipoCambio.Location = New System.Drawing.Point(89, 28)
        Me.TxtTipoCambio.MaxLength = 0
        Me.TxtTipoCambio.Name = "TxtTipoCambio"
        Me.TxtTipoCambio.ReadOnly = True
        Me.TxtTipoCambio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtTipoCambio.Size = New System.Drawing.Size(210, 20)
        Me.TxtTipoCambio.TabIndex = 127
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
        Me.Label2.Size = New System.Drawing.Size(49, 12)
        Me.Label2.TabIndex = 124
        Me.Label2.Tag = ""
        Me.Label2.Text = "MONEDA"
        '
        'TxtMoneda
        '
        Me.TxtMoneda.AcceptsReturn = True
        Me.TxtMoneda.BackColor = System.Drawing.Color.LightCyan
        Me.TxtMoneda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMoneda.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtMoneda.Location = New System.Drawing.Point(89, 5)
        Me.TxtMoneda.MaxLength = 0
        Me.TxtMoneda.Name = "TxtMoneda"
        Me.TxtMoneda.ReadOnly = True
        Me.TxtMoneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMoneda.Size = New System.Drawing.Size(210, 20)
        Me.TxtMoneda.TabIndex = 125
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 198)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 30)
        Me.Panel2.TabIndex = 255
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(133, 0)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chkTodasGuias)
        Me.Panel1.Controls.Add(Me.chkPU)
        Me.Panel1.Controls.Add(Me.TxtSoles)
        Me.Panel1.Controls.Add(Me.TxtDolares)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 142)
        Me.Panel1.TabIndex = 256
        '
        'chkTodasGuias
        '
        Me.chkTodasGuias.AutoSize = True
        Me.chkTodasGuias.Location = New System.Drawing.Point(37, 109)
        Me.chkTodasGuias.Name = "chkTodasGuias"
        Me.chkTodasGuias.Size = New System.Drawing.Size(132, 17)
        Me.chkTodasGuias.TabIndex = 114
        Me.chkTodasGuias.Text = "Aplica a todas las guias"
        '
        'chkPU
        '
        Me.chkPU.AutoSize = True
        Me.chkPU.Location = New System.Drawing.Point(37, 79)
        Me.chkPU.Name = "chkPU"
        Me.chkPU.Size = New System.Drawing.Size(42, 17)
        Me.chkPU.TabIndex = 113
        Me.chkPU.Text = "P.U."
        '
        'TxtSoles
        '
        Me.TxtSoles.AcceptsReturn = True
        Me.TxtSoles.BackColor = System.Drawing.Color.White
        Me.TxtSoles.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSoles.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtSoles.Location = New System.Drawing.Point(203, 43)
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
        Me.TxtDolares.Location = New System.Drawing.Point(203, 14)
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
        Me.Label6.Location = New System.Drawing.Point(34, 21)
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
        Me.Label4.Location = New System.Drawing.Point(34, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(182, 13)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Importe Soles ...................................."
        '
        'FrmGuiasAsociadas_Tejeduria_Valorizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmGuiasAsociadas_Tejeduria_Valorizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Costo Materia Prima"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents TxtSoles As System.Windows.Forms.TextBox
    Public WithEvents TxtDolares As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents TxtTipoCambio As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents TxtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents chkPU As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkTodasGuias As Janus.Windows.EditControls.UICheckBox
End Class
