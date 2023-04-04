<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantAnexosContables_CuentaCorriente_Mant
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.fraDatos = New System.Windows.Forms.Panel()
        Me.TxtCodCtaCte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBanco_Des = New System.Windows.Forms.TextBox()
        Me.txtBanco_Cod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCuenta_Des = New System.Windows.Forms.TextBox()
        Me.txtCuenta_Cod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDesTipCtaCte = New System.Windows.Forms.TextBox()
        Me.txtTipCtaCte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.fraDatos.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel5.Size = New System.Drawing.Size(615, 27)
        Me.Panel5.TabIndex = 245
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(615, 30)
        Me.Panel2.TabIndex = 248
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(408, 0)
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
        'fraDatos
        '
        Me.fraDatos.BackColor = System.Drawing.Color.White
        Me.fraDatos.Controls.Add(Me.TxtDesTipCtaCte)
        Me.fraDatos.Controls.Add(Me.txtTipCtaCte)
        Me.fraDatos.Controls.Add(Me.txtCuenta_Des)
        Me.fraDatos.Controls.Add(Me.txtCuenta_Cod)
        Me.fraDatos.Controls.Add(Me.TxtCodCtaCte)
        Me.fraDatos.Controls.Add(Me.txtBanco_Des)
        Me.fraDatos.Controls.Add(Me.txtBanco_Cod)
        Me.fraDatos.Controls.Add(Me.Label5)
        Me.fraDatos.Controls.Add(Me.Label2)
        Me.fraDatos.Controls.Add(Me.Label1)
        Me.fraDatos.Controls.Add(Me.Label4)
        Me.fraDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fraDatos.Location = New System.Drawing.Point(0, 27)
        Me.fraDatos.Name = "fraDatos"
        Me.fraDatos.Size = New System.Drawing.Size(615, 108)
        Me.fraDatos.TabIndex = 249
        '
        'TxtCodCtaCte
        '
        Me.TxtCodCtaCte.AcceptsReturn = True
        Me.TxtCodCtaCte.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCodCtaCte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodCtaCte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCodCtaCte.Location = New System.Drawing.Point(122, 54)
        Me.TxtCodCtaCte.MaxLength = 100
        Me.TxtCodCtaCte.Name = "TxtCodCtaCte"
        Me.TxtCodCtaCte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCodCtaCte.Size = New System.Drawing.Size(476, 20)
        Me.TxtCodCtaCte.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(14, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Cta. Corriente .................."
        '
        'txtBanco_Des
        '
        Me.txtBanco_Des.AcceptsReturn = True
        Me.txtBanco_Des.BackColor = System.Drawing.SystemColors.Window
        Me.txtBanco_Des.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBanco_Des.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBanco_Des.Location = New System.Drawing.Point(198, 8)
        Me.txtBanco_Des.MaxLength = 100
        Me.txtBanco_Des.Name = "txtBanco_Des"
        Me.txtBanco_Des.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBanco_Des.Size = New System.Drawing.Size(400, 20)
        Me.txtBanco_Des.TabIndex = 103
        '
        'txtBanco_Cod
        '
        Me.txtBanco_Cod.AcceptsReturn = True
        Me.txtBanco_Cod.BackColor = System.Drawing.SystemColors.Window
        Me.txtBanco_Cod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBanco_Cod.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBanco_Cod.Location = New System.Drawing.Point(122, 8)
        Me.txtBanco_Cod.MaxLength = 100
        Me.txtBanco_Cod.Name = "txtBanco_Cod"
        Me.txtBanco_Cod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBanco_Cod.Size = New System.Drawing.Size(74, 20)
        Me.txtBanco_Cod.TabIndex = 102
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(14, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Banco .........................."
        '
        'txtCuenta_Des
        '
        Me.txtCuenta_Des.AcceptsReturn = True
        Me.txtCuenta_Des.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuenta_Des.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuenta_Des.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCuenta_Des.Location = New System.Drawing.Point(198, 31)
        Me.txtCuenta_Des.MaxLength = 100
        Me.txtCuenta_Des.Name = "txtCuenta_Des"
        Me.txtCuenta_Des.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuenta_Des.Size = New System.Drawing.Size(400, 20)
        Me.txtCuenta_Des.TabIndex = 116
        '
        'txtCuenta_Cod
        '
        Me.txtCuenta_Cod.AcceptsReturn = True
        Me.txtCuenta_Cod.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuenta_Cod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuenta_Cod.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCuenta_Cod.Location = New System.Drawing.Point(122, 31)
        Me.txtCuenta_Cod.MaxLength = 100
        Me.txtCuenta_Cod.Name = "txtCuenta_Cod"
        Me.txtCuenta_Cod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuenta_Cod.Size = New System.Drawing.Size(74, 20)
        Me.txtCuenta_Cod.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(14, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Cuenta .........................."
        '
        'TxtDesTipCtaCte
        '
        Me.TxtDesTipCtaCte.AcceptsReturn = True
        Me.TxtDesTipCtaCte.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDesTipCtaCte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDesTipCtaCte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtDesTipCtaCte.Location = New System.Drawing.Point(198, 77)
        Me.TxtDesTipCtaCte.MaxLength = 100
        Me.TxtDesTipCtaCte.Name = "TxtDesTipCtaCte"
        Me.TxtDesTipCtaCte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDesTipCtaCte.Size = New System.Drawing.Size(400, 20)
        Me.TxtDesTipCtaCte.TabIndex = 119
        '
        'txtTipCtaCte
        '
        Me.txtTipCtaCte.AcceptsReturn = True
        Me.txtTipCtaCte.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipCtaCte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipCtaCte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTipCtaCte.Location = New System.Drawing.Point(122, 77)
        Me.txtTipCtaCte.MaxLength = 100
        Me.txtTipCtaCte.Name = "txtTipCtaCte"
        Me.txtTipCtaCte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipCtaCte.Size = New System.Drawing.Size(74, 20)
        Me.txtTipCtaCte.TabIndex = 118
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(14, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Tip Cta Cte .........................."
        '
        'FrmMantAnexosContables_CuentaCorriente_Mant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 165)
        Me.Controls.Add(Me.fraDatos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMantAnexosContables_CuentaCorriente_Mant"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CuentaCorriente"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.fraDatos.ResumeLayout(False)
        Me.fraDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents fraDatos As System.Windows.Forms.Panel
    Public WithEvents TxtCodCtaCte As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtBanco_Des As System.Windows.Forms.TextBox
    Public WithEvents txtBanco_Cod As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents TxtDesTipCtaCte As System.Windows.Forms.TextBox
    Public WithEvents txtTipCtaCte As System.Windows.Forms.TextBox
    Public WithEvents txtCuenta_Des As System.Windows.Forms.TextBox
    Public WithEvents txtCuenta_Cod As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
End Class
