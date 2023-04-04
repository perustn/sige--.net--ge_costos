<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantAnexosContables_Impresion
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
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FraRango = New Janus.Windows.EditControls.UIGroupBox()
        Me.OptConProblemas = New System.Windows.Forms.RadioButton()
        Me.OptConLevantamiento = New System.Windows.Forms.RadioButton()
        Me.DTPInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.FraRango, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraRango.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 30)
        Me.Panel1.TabIndex = 171
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnCancelar)
        Me.Panel2.Controls.Add(Me.BtnAceptar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(244, 0)
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
        Me.BtnAceptar.Text = "&Imprimir"
        Me.BtnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(451, 10)
        Me.Panel7.TabIndex = 172
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.OptConProblemas)
        Me.Panel3.Controls.Add(Me.OptConLevantamiento)
        Me.Panel3.Controls.Add(Me.FraRango)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(451, 104)
        Me.Panel3.TabIndex = 248
        '
        'FraRango
        '
        Me.FraRango.Controls.Add(Me.DTPFin)
        Me.FraRango.Controls.Add(Me.DTPInicio)
        Me.FraRango.Controls.Add(Me.Label2)
        Me.FraRango.Controls.Add(Me.Label1)
        Me.FraRango.Location = New System.Drawing.Point(6, 46)
        Me.FraRango.Name = "FraRango"
        Me.FraRango.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.FraRango.Size = New System.Drawing.Size(439, 50)
        Me.FraRango.TabIndex = 101
        Me.FraRango.Text = "Fecha Levantamiento"
        Me.FraRango.Visible = False
        Me.FraRango.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'OptConProblemas
        '
        Me.OptConProblemas.AutoSize = True
        Me.OptConProblemas.BackColor = System.Drawing.Color.Transparent
        Me.OptConProblemas.Checked = True
        Me.OptConProblemas.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptConProblemas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptConProblemas.ForeColor = System.Drawing.Color.Black
        Me.OptConProblemas.Location = New System.Drawing.Point(48, 16)
        Me.OptConProblemas.Name = "OptConProblemas"
        Me.OptConProblemas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptConProblemas.Size = New System.Drawing.Size(127, 17)
        Me.OptConProblemas.TabIndex = 103
        Me.OptConProblemas.TabStop = True
        Me.OptConProblemas.Tag = "8"
        Me.OptConProblemas.Text = "Con Problemas Sunat"
        Me.OptConProblemas.UseVisualStyleBackColor = False
        '
        'OptConLevantamiento
        '
        Me.OptConLevantamiento.AutoSize = True
        Me.OptConLevantamiento.BackColor = System.Drawing.Color.Transparent
        Me.OptConLevantamiento.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptConLevantamiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptConLevantamiento.ForeColor = System.Drawing.Color.Black
        Me.OptConLevantamiento.Location = New System.Drawing.Point(232, 16)
        Me.OptConLevantamiento.Name = "OptConLevantamiento"
        Me.OptConLevantamiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptConLevantamiento.Size = New System.Drawing.Size(184, 17)
        Me.OptConLevantamiento.TabIndex = 102
        Me.OptConLevantamiento.Tag = "9"
        Me.OptConLevantamiento.Text = "Con Resolucion de levantamiento"
        Me.OptConLevantamiento.UseVisualStyleBackColor = False
        '
        'DTPInicio
        '
        Me.DTPInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DTPInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPInicio.Location = New System.Drawing.Point(109, 21)
        Me.DTPInicio.Name = "DTPInicio"
        Me.DTPInicio.Size = New System.Drawing.Size(95, 20)
        Me.DTPInicio.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(36, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Inicio ............."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(243, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Fin ................."
        '
        'DTPFin
        '
        Me.DTPFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DTPFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFin.Location = New System.Drawing.Point(316, 21)
        Me.DTPFin.Name = "DTPFin"
        Me.DTPFin.Size = New System.Drawing.Size(95, 20)
        Me.DTPFin.TabIndex = 73
        '
        'FrmMantAnexosContables_Impresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 144)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMantAnexosContables_Impresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte de Impresión"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.FraRango, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraRango.ResumeLayout(False)
        Me.FraRango.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents FraRango As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents OptConProblemas As System.Windows.Forms.RadioButton
    Public WithEvents OptConLevantamiento As System.Windows.Forms.RadioButton
    Friend WithEvents DTPInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFin As System.Windows.Forms.DateTimePicker
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
End Class
