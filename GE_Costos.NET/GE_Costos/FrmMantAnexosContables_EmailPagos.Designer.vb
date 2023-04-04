<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantAnexosContables_EmailPagos
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtContacto = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkSuspension = New Janus.Windows.EditControls.UICheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 30)
        Me.Panel1.TabIndex = 244
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnCancelar)
        Me.Panel2.Controls.Add(Me.BtnAceptar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(331, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(207, 30)
        Me.Panel2.TabIndex = 0
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.TxtDescripcion)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.TxtCodigo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(538, 27)
        Me.Panel5.TabIndex = 243
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
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "ANEXO"
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.ChkSuspension)
        Me.Panel3.Controls.Add(Me.TxtContacto)
        Me.Panel3.Controls.Add(Me.TxtMail)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(538, 88)
        Me.Panel3.TabIndex = 245
        '
        'TxtContacto
        '
        Me.TxtContacto.AcceptsReturn = True
        Me.TxtContacto.BackColor = System.Drawing.SystemColors.Window
        Me.TxtContacto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtContacto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtContacto.Location = New System.Drawing.Point(168, 30)
        Me.TxtContacto.MaxLength = 0
        Me.TxtContacto.Name = "TxtContacto"
        Me.TxtContacto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtContacto.Size = New System.Drawing.Size(338, 20)
        Me.TxtContacto.TabIndex = 75
        '
        'TxtMail
        '
        Me.TxtMail.AcceptsReturn = True
        Me.TxtMail.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtMail.Location = New System.Drawing.Point(168, 6)
        Me.TxtMail.MaxLength = 0
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMail.Size = New System.Drawing.Size(338, 20)
        Me.TxtMail.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(21, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Contacto Pago ........................."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(21, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(179, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Email Notificacion Pago ..................."
        '
        'ChkSuspension
        '
        Me.ChkSuspension.AutoSize = True
        Me.ChkSuspension.Checked = True
        Me.ChkSuspension.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkSuspension.Location = New System.Drawing.Point(355, 59)
        Me.ChkSuspension.Name = "ChkSuspension"
        Me.ChkSuspension.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.ChkSuspension.Size = New System.Drawing.Size(151, 17)
        Me.ChkSuspension.TabIndex = 210
        Me.ChkSuspension.Text = "Suspension Email Temporal"
        Me.ChkSuspension.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FrmMantAnexosContables_EmailPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 145)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMantAnexosContables_EmailPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dato Adicional"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents TxtContacto As System.Windows.Forms.TextBox
    Public WithEvents TxtMail As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkSuspension As Janus.Windows.EditControls.UICheckBox
End Class
