<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantAnexosContables_BajaProveedor_Mant
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
        Me.fraDatos = New System.Windows.Forms.Panel()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDesBaja = New System.Windows.Forms.TextBox()
        Me.txtCodBaja = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fraDatos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraDatos
        '
        Me.fraDatos.BackColor = System.Drawing.Color.White
        Me.fraDatos.Controls.Add(Me.txtDesBaja)
        Me.fraDatos.Controls.Add(Me.txtCodBaja)
        Me.fraDatos.Controls.Add(Me.Label1)
        Me.fraDatos.Controls.Add(Me.txtObservacion)
        Me.fraDatos.Controls.Add(Me.Label4)
        Me.fraDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fraDatos.Location = New System.Drawing.Point(0, 27)
        Me.fraDatos.Name = "fraDatos"
        Me.fraDatos.Size = New System.Drawing.Size(544, 139)
        Me.fraDatos.TabIndex = 255
        '
        'txtObservacion
        '
        Me.txtObservacion.AcceptsReturn = True
        Me.txtObservacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtObservacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtObservacion.Location = New System.Drawing.Point(123, 34)
        Me.txtObservacion.MaxLength = 300
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObservacion.Size = New System.Drawing.Size(406, 97)
        Me.txtObservacion.TabIndex = 102
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(15, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Observación ...................."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(544, 30)
        Me.Panel2.TabIndex = 254
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(337, 0)
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.TxtDescripcion)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.TxtCodigo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(544, 27)
        Me.Panel5.TabIndex = 253
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
        'txtDesBaja
        '
        Me.txtDesBaja.AcceptsReturn = True
        Me.txtDesBaja.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesBaja.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesBaja.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDesBaja.Location = New System.Drawing.Point(199, 9)
        Me.txtDesBaja.MaxLength = 100
        Me.txtDesBaja.Name = "txtDesBaja"
        Me.txtDesBaja.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDesBaja.Size = New System.Drawing.Size(330, 20)
        Me.txtDesBaja.TabIndex = 106
        '
        'txtCodBaja
        '
        Me.txtCodBaja.AcceptsReturn = True
        Me.txtCodBaja.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodBaja.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodBaja.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCodBaja.Location = New System.Drawing.Point(123, 9)
        Me.txtCodBaja.MaxLength = 100
        Me.txtCodBaja.Name = "txtCodBaja"
        Me.txtCodBaja.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodBaja.Size = New System.Drawing.Size(74, 20)
        Me.txtCodBaja.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Motivo Baja ..................."
        '
        'FrmMantAnexosContables_BajaProveedor_Mant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.fraDatos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMantAnexosContables_BajaProveedor_Mant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BajaProveedor"
        Me.fraDatos.ResumeLayout(False)
        Me.fraDatos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fraDatos As System.Windows.Forms.Panel
    Public WithEvents txtObservacion As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Public WithEvents txtDesBaja As System.Windows.Forms.TextBox
    Public WithEvents txtCodBaja As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
End Class
