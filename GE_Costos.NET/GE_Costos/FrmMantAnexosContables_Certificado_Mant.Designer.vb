<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantAnexosContables_Certificado_Mant
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
        Me.txt_Ano = New System.Windows.Forms.TextBox()
        Me.txt_NumeroConstancia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.txt_TipAnexo = New System.Windows.Forms.TextBox()
        Me.txt_DesAnexo = New System.Windows.Forms.TextBox()
        Me.txt_CodAnexo = New System.Windows.Forms.TextBox()
        Me.fraDatos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraDatos
        '
        Me.fraDatos.BackColor = System.Drawing.Color.White
        Me.fraDatos.Controls.Add(Me.txt_TipAnexo)
        Me.fraDatos.Controls.Add(Me.txt_DesAnexo)
        Me.fraDatos.Controls.Add(Me.txt_CodAnexo)
        Me.fraDatos.Controls.Add(Me.txt_Ano)
        Me.fraDatos.Controls.Add(Me.txt_NumeroConstancia)
        Me.fraDatos.Controls.Add(Me.Label2)
        Me.fraDatos.Controls.Add(Me.Label1)
        Me.fraDatos.Controls.Add(Me.Label4)
        Me.fraDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fraDatos.Location = New System.Drawing.Point(0, 10)
        Me.fraDatos.Name = "fraDatos"
        Me.fraDatos.Size = New System.Drawing.Size(490, 88)
        Me.fraDatos.TabIndex = 252
        '
        'txt_Ano
        '
        Me.txt_Ano.AcceptsReturn = True
        Me.txt_Ano.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Ano.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Ano.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Ano.Location = New System.Drawing.Point(135, 31)
        Me.txt_Ano.MaxLength = 100
        Me.txt_Ano.Name = "txt_Ano"
        Me.txt_Ano.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Ano.Size = New System.Drawing.Size(74, 20)
        Me.txt_Ano.TabIndex = 115
        '
        'txt_NumeroConstancia
        '
        Me.txt_NumeroConstancia.AcceptsReturn = True
        Me.txt_NumeroConstancia.BackColor = System.Drawing.SystemColors.Window
        Me.txt_NumeroConstancia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_NumeroConstancia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_NumeroConstancia.Location = New System.Drawing.Point(135, 54)
        Me.txt_NumeroConstancia.MaxLength = 100
        Me.txt_NumeroConstancia.Name = "txt_NumeroConstancia"
        Me.txt_NumeroConstancia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_NumeroConstancia.Size = New System.Drawing.Size(336, 20)
        Me.txt_NumeroConstancia.TabIndex = 113
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
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Año ................................."
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
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Número Constancia .................."
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
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Anexo ............................."
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(490, 10)
        Me.Panel5.TabIndex = 250
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(490, 30)
        Me.Panel2.TabIndex = 251
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(283, 0)
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
        'txt_TipAnexo
        '
        Me.txt_TipAnexo.AcceptsReturn = True
        Me.txt_TipAnexo.BackColor = System.Drawing.SystemColors.Window
        Me.txt_TipAnexo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_TipAnexo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_TipAnexo.Location = New System.Drawing.Point(135, 8)
        Me.txt_TipAnexo.MaxLength = 100
        Me.txt_TipAnexo.Name = "txt_TipAnexo"
        Me.txt_TipAnexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TipAnexo.Size = New System.Drawing.Size(38, 20)
        Me.txt_TipAnexo.TabIndex = 123
        '
        'txt_DesAnexo
        '
        Me.txt_DesAnexo.AcceptsReturn = True
        Me.txt_DesAnexo.BackColor = System.Drawing.SystemColors.Window
        Me.txt_DesAnexo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_DesAnexo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_DesAnexo.Location = New System.Drawing.Point(251, 8)
        Me.txt_DesAnexo.MaxLength = 100
        Me.txt_DesAnexo.Name = "txt_DesAnexo"
        Me.txt_DesAnexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_DesAnexo.Size = New System.Drawing.Size(220, 20)
        Me.txt_DesAnexo.TabIndex = 122
        '
        'txt_CodAnexo
        '
        Me.txt_CodAnexo.AcceptsReturn = True
        Me.txt_CodAnexo.BackColor = System.Drawing.SystemColors.Window
        Me.txt_CodAnexo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_CodAnexo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_CodAnexo.Location = New System.Drawing.Point(175, 8)
        Me.txt_CodAnexo.MaxLength = 100
        Me.txt_CodAnexo.Name = "txt_CodAnexo"
        Me.txt_CodAnexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_CodAnexo.Size = New System.Drawing.Size(74, 20)
        Me.txt_CodAnexo.TabIndex = 121
        '
        'FrmMantAnexosContables_Certificado_Mant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 128)
        Me.ControlBox = False
        Me.Controls.Add(Me.fraDatos)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMantAnexosContables_Certificado_Mant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmMantAnexosContables_Certificado_Mant"
        Me.fraDatos.ResumeLayout(False)
        Me.fraDatos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fraDatos As System.Windows.Forms.Panel
    Public WithEvents txt_Ano As System.Windows.Forms.TextBox
    Public WithEvents txt_NumeroConstancia As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Public WithEvents txt_TipAnexo As System.Windows.Forms.TextBox
    Public WithEvents txt_DesAnexo As System.Windows.Forms.TextBox
    Public WithEvents txt_CodAnexo As System.Windows.Forms.TextBox
End Class
