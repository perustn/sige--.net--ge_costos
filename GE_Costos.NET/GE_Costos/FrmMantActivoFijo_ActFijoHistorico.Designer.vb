<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantActivoFijo_ActFijoHistorico
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
        Me.grpRelacion = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lstOps = New System.Windows.Forms.ListBox()
        Me.TxtCta = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txt_DesActivo = New System.Windows.Forms.TextBox()
        Me.txtCod_Activo = New System.Windows.Forms.TextBox()
        Me.TxtDes_CtaCont = New System.Windows.Forms.TextBox()
        Me.TxtCod_CtaCont = New System.Windows.Forms.TextBox()
        Me.optActivo = New System.Windows.Forms.RadioButton()
        Me.optRelCta = New System.Windows.Forms.RadioButton()
        Me.optCta = New System.Windows.Forms.RadioButton()
        Me.TxtDes_Moneda = New System.Windows.Forms.TextBox()
        Me.TxtMes = New System.Windows.Forms.TextBox()
        Me.TxtCod_Moneda = New System.Windows.Forms.TextBox()
        Me.TxtAno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.fraDatos.SuspendLayout()
        CType(Me.grpRelacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRelacion.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraDatos
        '
        Me.fraDatos.BackColor = System.Drawing.Color.White
        Me.fraDatos.Controls.Add(Me.grpRelacion)
        Me.fraDatos.Controls.Add(Me.Txt_DesActivo)
        Me.fraDatos.Controls.Add(Me.txtCod_Activo)
        Me.fraDatos.Controls.Add(Me.TxtDes_CtaCont)
        Me.fraDatos.Controls.Add(Me.TxtCod_CtaCont)
        Me.fraDatos.Controls.Add(Me.optActivo)
        Me.fraDatos.Controls.Add(Me.optRelCta)
        Me.fraDatos.Controls.Add(Me.optCta)
        Me.fraDatos.Controls.Add(Me.TxtDes_Moneda)
        Me.fraDatos.Controls.Add(Me.TxtMes)
        Me.fraDatos.Controls.Add(Me.TxtCod_Moneda)
        Me.fraDatos.Controls.Add(Me.TxtAno)
        Me.fraDatos.Controls.Add(Me.Label2)
        Me.fraDatos.Controls.Add(Me.Label1)
        Me.fraDatos.Controls.Add(Me.Label4)
        Me.fraDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fraDatos.Location = New System.Drawing.Point(0, 10)
        Me.fraDatos.Name = "fraDatos"
        Me.fraDatos.Size = New System.Drawing.Size(640, 303)
        Me.fraDatos.TabIndex = 258
        '
        'grpRelacion
        '
        Me.grpRelacion.Controls.Add(Me.Label14)
        Me.grpRelacion.Controls.Add(Me.lstOps)
        Me.grpRelacion.Controls.Add(Me.TxtCta)
        Me.grpRelacion.Controls.Add(Me.Label15)
        Me.grpRelacion.Controls.Add(Me.Label16)
        Me.grpRelacion.FrameStyle = Janus.Windows.EditControls.FrameStyle.Top
        Me.grpRelacion.Location = New System.Drawing.Point(207, 114)
        Me.grpRelacion.Name = "grpRelacion"
        Me.grpRelacion.Size = New System.Drawing.Size(416, 146)
        Me.grpRelacion.TabIndex = 162
        Me.grpRelacion.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Info
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(13, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(298, 24)
        Me.Label14.TabIndex = 172
        Me.Label14.Text = "(Doble Click en Cta Contable para sacar de Lista)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstOps
        '
        Me.lstOps.FormattingEnabled = True
        Me.lstOps.Location = New System.Drawing.Point(175, 29)
        Me.lstOps.Name = "lstOps"
        Me.lstOps.Size = New System.Drawing.Size(232, 82)
        Me.lstOps.TabIndex = 171
        '
        'TxtCta
        '
        Me.TxtCta.AcceptsReturn = True
        Me.TxtCta.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCta.Location = New System.Drawing.Point(11, 29)
        Me.TxtCta.MaxLength = 0
        Me.TxtCta.Name = "TxtCta"
        Me.TxtCta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCta.Size = New System.Drawing.Size(125, 20)
        Me.TxtCta.TabIndex = 169
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(7, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 13)
        Me.Label15.TabIndex = 168
        Me.Label15.Text = "Cta. contable"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(172, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 13)
        Me.Label16.TabIndex = 170
        Me.Label16.Text = "SELECCIONADOS"
        '
        'Txt_DesActivo
        '
        Me.Txt_DesActivo.AcceptsReturn = True
        Me.Txt_DesActivo.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_DesActivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_DesActivo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Txt_DesActivo.Location = New System.Drawing.Point(283, 272)
        Me.Txt_DesActivo.MaxLength = 100
        Me.Txt_DesActivo.Name = "Txt_DesActivo"
        Me.Txt_DesActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_DesActivo.Size = New System.Drawing.Size(331, 20)
        Me.Txt_DesActivo.TabIndex = 145
        '
        'txtCod_Activo
        '
        Me.txtCod_Activo.AcceptsReturn = True
        Me.txtCod_Activo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_Activo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Activo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCod_Activo.Location = New System.Drawing.Point(207, 272)
        Me.txtCod_Activo.MaxLength = 100
        Me.txtCod_Activo.Name = "txtCod_Activo"
        Me.txtCod_Activo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Activo.Size = New System.Drawing.Size(74, 20)
        Me.txtCod_Activo.TabIndex = 144
        '
        'TxtDes_CtaCont
        '
        Me.TxtDes_CtaCont.AcceptsReturn = True
        Me.TxtDes_CtaCont.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDes_CtaCont.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDes_CtaCont.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtDes_CtaCont.Location = New System.Drawing.Point(283, 78)
        Me.TxtDes_CtaCont.MaxLength = 100
        Me.TxtDes_CtaCont.Name = "TxtDes_CtaCont"
        Me.TxtDes_CtaCont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDes_CtaCont.Size = New System.Drawing.Size(340, 20)
        Me.TxtDes_CtaCont.TabIndex = 143
        '
        'TxtCod_CtaCont
        '
        Me.TxtCod_CtaCont.AcceptsReturn = True
        Me.TxtCod_CtaCont.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCod_CtaCont.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCod_CtaCont.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCod_CtaCont.Location = New System.Drawing.Point(207, 78)
        Me.TxtCod_CtaCont.MaxLength = 100
        Me.TxtCod_CtaCont.Name = "TxtCod_CtaCont"
        Me.TxtCod_CtaCont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCod_CtaCont.Size = New System.Drawing.Size(74, 20)
        Me.TxtCod_CtaCont.TabIndex = 142
        '
        'optActivo
        '
        Me.optActivo.AutoSize = True
        Me.optActivo.BackColor = System.Drawing.Color.Transparent
        Me.optActivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.optActivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optActivo.ForeColor = System.Drawing.Color.Black
        Me.optActivo.Location = New System.Drawing.Point(19, 275)
        Me.optActivo.Name = "optActivo"
        Me.optActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optActivo.Size = New System.Drawing.Size(74, 17)
        Me.optActivo.TabIndex = 141
        Me.optActivo.Tag = "9"
        Me.optActivo.Text = "Por Activo"
        Me.optActivo.UseVisualStyleBackColor = False
        '
        'optRelCta
        '
        Me.optRelCta.AutoSize = True
        Me.optRelCta.BackColor = System.Drawing.Color.Transparent
        Me.optRelCta.Cursor = System.Windows.Forms.Cursors.Default
        Me.optRelCta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRelCta.ForeColor = System.Drawing.Color.Black
        Me.optRelCta.Location = New System.Drawing.Point(19, 114)
        Me.optRelCta.Name = "optRelCta"
        Me.optRelCta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optRelCta.Size = New System.Drawing.Size(146, 17)
        Me.optRelCta.TabIndex = 140
        Me.optRelCta.Tag = "8"
        Me.optRelCta.Text = "Relacion de Cta Contable"
        Me.optRelCta.UseVisualStyleBackColor = False
        '
        'optCta
        '
        Me.optCta.AutoSize = True
        Me.optCta.BackColor = System.Drawing.Color.Transparent
        Me.optCta.Checked = True
        Me.optCta.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCta.ForeColor = System.Drawing.Color.Black
        Me.optCta.Location = New System.Drawing.Point(19, 81)
        Me.optCta.Name = "optCta"
        Me.optCta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCta.Size = New System.Drawing.Size(88, 17)
        Me.optCta.TabIndex = 139
        Me.optCta.TabStop = True
        Me.optCta.Tag = "9"
        Me.optCta.Text = "Cta Contable"
        Me.optCta.UseVisualStyleBackColor = False
        '
        'TxtDes_Moneda
        '
        Me.TxtDes_Moneda.AcceptsReturn = True
        Me.TxtDes_Moneda.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDes_Moneda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDes_Moneda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtDes_Moneda.Location = New System.Drawing.Point(163, 34)
        Me.TxtDes_Moneda.MaxLength = 100
        Me.TxtDes_Moneda.Name = "TxtDes_Moneda"
        Me.TxtDes_Moneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDes_Moneda.Size = New System.Drawing.Size(460, 20)
        Me.TxtDes_Moneda.TabIndex = 138
        Me.TxtDes_Moneda.Text = "SOLES"
        '
        'TxtMes
        '
        Me.TxtMes.AcceptsReturn = True
        Me.TxtMes.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtMes.Location = New System.Drawing.Point(257, 8)
        Me.TxtMes.MaxLength = 100
        Me.TxtMes.Name = "TxtMes"
        Me.TxtMes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMes.Size = New System.Drawing.Size(74, 20)
        Me.TxtMes.TabIndex = 115
        '
        'TxtCod_Moneda
        '
        Me.TxtCod_Moneda.AcceptsReturn = True
        Me.TxtCod_Moneda.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCod_Moneda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCod_Moneda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCod_Moneda.Location = New System.Drawing.Point(87, 34)
        Me.TxtCod_Moneda.MaxLength = 100
        Me.TxtCod_Moneda.Name = "TxtCod_Moneda"
        Me.TxtCod_Moneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCod_Moneda.Size = New System.Drawing.Size(74, 20)
        Me.TxtCod_Moneda.TabIndex = 113
        Me.TxtCod_Moneda.Text = "SOL"
        '
        'TxtAno
        '
        Me.TxtAno.AcceptsReturn = True
        Me.TxtAno.BackColor = System.Drawing.SystemColors.Window
        Me.TxtAno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtAno.Location = New System.Drawing.Point(87, 8)
        Me.TxtAno.MaxLength = 100
        Me.TxtAno.Name = "TxtAno"
        Me.TxtAno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtAno.Size = New System.Drawing.Size(74, 20)
        Me.TxtAno.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(189, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Mes ..............."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(14, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Moneda ................."
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
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Año ..................."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 313)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 30)
        Me.Panel2.TabIndex = 257
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(433, 0)
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
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(640, 10)
        Me.Panel5.TabIndex = 256
        '
        'FrmMantActivoFijo_ActFijoHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 343)
        Me.ControlBox = False
        Me.Controls.Add(Me.fraDatos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMantActivoFijo_ActFijoHistorico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Activo Fijo a Valores Historicos"
        Me.fraDatos.ResumeLayout(False)
        Me.fraDatos.PerformLayout()
        CType(Me.grpRelacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRelacion.ResumeLayout(False)
        Me.grpRelacion.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fraDatos As System.Windows.Forms.Panel
    Public WithEvents TxtDes_Moneda As System.Windows.Forms.TextBox
    Public WithEvents TxtMes As System.Windows.Forms.TextBox
    Public WithEvents TxtCod_Moneda As System.Windows.Forms.TextBox
    Public WithEvents TxtAno As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents optActivo As System.Windows.Forms.RadioButton
    Public WithEvents optRelCta As System.Windows.Forms.RadioButton
    Public WithEvents optCta As System.Windows.Forms.RadioButton
    Public WithEvents Txt_DesActivo As System.Windows.Forms.TextBox
    Public WithEvents txtCod_Activo As System.Windows.Forms.TextBox
    Public WithEvents TxtDes_CtaCont As System.Windows.Forms.TextBox
    Public WithEvents TxtCod_CtaCont As System.Windows.Forms.TextBox
    Friend WithEvents grpRelacion As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lstOps As System.Windows.Forms.ListBox
    Public WithEvents TxtCta As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
