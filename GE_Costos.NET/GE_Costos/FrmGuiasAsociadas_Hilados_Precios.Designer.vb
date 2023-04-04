<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGuiasAsociadas_Hilados_Precios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSecuencia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMovimiento = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPrecioFob = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCod_Moneda = New System.Windows.Forms.TextBox()
        Me.txtDes_Moneda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtImpOtraMoneda = New System.Windows.Forms.TextBox()
        Me.txtPre_Tot = New System.Windows.Forms.TextBox()
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
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.TxtSecuencia)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtMovimiento)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(422, 31)
        Me.Panel4.TabIndex = 254
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(220, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(23, 12)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "SEC"
        '
        'TxtSecuencia
        '
        Me.TxtSecuencia.AcceptsReturn = True
        Me.TxtSecuencia.BackColor = System.Drawing.Color.LightCyan
        Me.TxtSecuencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSecuencia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtSecuencia.Location = New System.Drawing.Point(253, 5)
        Me.TxtSecuencia.MaxLength = 0
        Me.TxtSecuencia.Name = "TxtSecuencia"
        Me.TxtSecuencia.ReadOnly = True
        Me.TxtSecuencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSecuencia.Size = New System.Drawing.Size(39, 20)
        Me.TxtSecuencia.TabIndex = 127
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(10, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(73, 12)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "MOVIMIENTO"
        '
        'TxtMovimiento
        '
        Me.TxtMovimiento.AcceptsReturn = True
        Me.TxtMovimiento.BackColor = System.Drawing.Color.LightCyan
        Me.TxtMovimiento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMovimiento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtMovimiento.Location = New System.Drawing.Point(89, 5)
        Me.TxtMovimiento.MaxLength = 0
        Me.TxtMovimiento.Name = "TxtMovimiento"
        Me.TxtMovimiento.ReadOnly = True
        Me.TxtMovimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMovimiento.Size = New System.Drawing.Size(72, 20)
        Me.TxtMovimiento.TabIndex = 125
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 148)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(422, 30)
        Me.Panel2.TabIndex = 255
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(215, 0)
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
        Me.Panel1.Controls.Add(Me.txtPrecioFob)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtCod_Moneda)
        Me.Panel1.Controls.Add(Me.txtDes_Moneda)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtImpOtraMoneda)
        Me.Panel1.Controls.Add(Me.txtPre_Tot)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 117)
        Me.Panel1.TabIndex = 256
        '
        'txtPrecioFob
        '
        Me.txtPrecioFob.AcceptsReturn = True
        Me.txtPrecioFob.BackColor = System.Drawing.Color.White
        Me.txtPrecioFob.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrecioFob.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPrecioFob.Location = New System.Drawing.Point(140, 82)
        Me.txtPrecioFob.MaxLength = 100
        Me.txtPrecioFob.Name = "txtPrecioFob"
        Me.txtPrecioFob.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrecioFob.Size = New System.Drawing.Size(90, 20)
        Me.txtPrecioFob.TabIndex = 117
        Me.txtPrecioFob.Text = "0.00"
        Me.txtPrecioFob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(15, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Precio FOB ..........................."
        '
        'txtCod_Moneda
        '
        Me.txtCod_Moneda.AcceptsReturn = True
        Me.txtCod_Moneda.BackColor = System.Drawing.Color.White
        Me.txtCod_Moneda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Moneda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCod_Moneda.Location = New System.Drawing.Point(140, 8)
        Me.txtCod_Moneda.MaxLength = 100
        Me.txtCod_Moneda.Name = "txtCod_Moneda"
        Me.txtCod_Moneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Moneda.Size = New System.Drawing.Size(49, 20)
        Me.txtCod_Moneda.TabIndex = 115
        '
        'txtDes_Moneda
        '
        Me.txtDes_Moneda.AcceptsReturn = True
        Me.txtDes_Moneda.BackColor = System.Drawing.Color.White
        Me.txtDes_Moneda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_Moneda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDes_Moneda.Location = New System.Drawing.Point(191, 8)
        Me.txtDes_Moneda.MaxLength = 100
        Me.txtDes_Moneda.Name = "txtDes_Moneda"
        Me.txtDes_Moneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_Moneda.Size = New System.Drawing.Size(205, 20)
        Me.txtDes_Moneda.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Moneda ............................."
        '
        'TxtImpOtraMoneda
        '
        Me.TxtImpOtraMoneda.AcceptsReturn = True
        Me.TxtImpOtraMoneda.BackColor = System.Drawing.Color.White
        Me.TxtImpOtraMoneda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtImpOtraMoneda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtImpOtraMoneda.Location = New System.Drawing.Point(140, 58)
        Me.TxtImpOtraMoneda.MaxLength = 100
        Me.TxtImpOtraMoneda.Name = "TxtImpOtraMoneda"
        Me.TxtImpOtraMoneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtImpOtraMoneda.Size = New System.Drawing.Size(90, 20)
        Me.TxtImpOtraMoneda.TabIndex = 112
        Me.TxtImpOtraMoneda.Text = "0.00"
        Me.TxtImpOtraMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPre_Tot
        '
        Me.txtPre_Tot.AcceptsReturn = True
        Me.txtPre_Tot.BackColor = System.Drawing.Color.White
        Me.txtPre_Tot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPre_Tot.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPre_Tot.Location = New System.Drawing.Point(140, 33)
        Me.txtPre_Tot.MaxLength = 100
        Me.txtPre_Tot.Name = "txtPre_Tot"
        Me.txtPre_Tot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPre_Tot.Size = New System.Drawing.Size(90, 20)
        Me.txtPre_Tot.TabIndex = 110
        Me.txtPre_Tot.Text = "0.00"
        Me.txtPre_Tot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(15, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(141, 13)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Importe Total ......................."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(15, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Importe Otra Moneda ..........."
        '
        'FrmGuiasAsociadas_Hilados_Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 178)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmGuiasAsociadas_Hilados_Precios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ingreso Precios"
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
    Public WithEvents TxtImpOtraMoneda As System.Windows.Forms.TextBox
    Public WithEvents txtPre_Tot As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TxtSecuencia As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtMovimiento As System.Windows.Forms.TextBox
    Public WithEvents txtPrecioFob As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtCod_Moneda As System.Windows.Forms.TextBox
    Public WithEvents txtDes_Moneda As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
End Class
