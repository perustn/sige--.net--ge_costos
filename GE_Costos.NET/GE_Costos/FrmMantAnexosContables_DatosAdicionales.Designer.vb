<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantAnexosContables_DatosAdicionales
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox()
        Me.OptSiEncuentra_Habido = New System.Windows.Forms.RadioButton()
        Me.OptNoEncuentra_Habido = New System.Windows.Forms.RadioButton()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.optSIConsiderado_Para_Retencion = New System.Windows.Forms.RadioButton()
        Me.optNOConsiderado_Para_Retencion = New System.Windows.Forms.RadioButton()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.optSIAgente_Percepcion = New System.Windows.Forms.RadioButton()
        Me.optNOAgente_Percepcion = New System.Windows.Forms.RadioButton()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.optSIAgenteRetencionIGV = New System.Windows.Forms.RadioButton()
        Me.optNOAgenteRetencionIGV = New System.Windows.Forms.RadioButton()
        Me.FraRango = New Janus.Windows.EditControls.UIGroupBox()
        Me.optSiBuenContribuyente = New System.Windows.Forms.RadioButton()
        Me.optNOBuenContribuyente = New System.Windows.Forms.RadioButton()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox4.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.FraRango, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraRango.SuspendLayout()
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
        Me.Panel5.Size = New System.Drawing.Size(537, 27)
        Me.Panel5.TabIndex = 241
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 224)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 30)
        Me.Panel1.TabIndex = 242
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnCancelar)
        Me.Panel2.Controls.Add(Me.BtnAceptar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(330, 0)
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.UiGroupBox4)
        Me.Panel3.Controls.Add(Me.UiGroupBox3)
        Me.Panel3.Controls.Add(Me.UiGroupBox2)
        Me.Panel3.Controls.Add(Me.UiGroupBox1)
        Me.Panel3.Controls.Add(Me.FraRango)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(537, 197)
        Me.Panel3.TabIndex = 249
        '
        'UiGroupBox4
        '
        Me.UiGroupBox4.Controls.Add(Me.OptSiEncuentra_Habido)
        Me.UiGroupBox4.Controls.Add(Me.OptNoEncuentra_Habido)
        Me.UiGroupBox4.Location = New System.Drawing.Point(243, 106)
        Me.UiGroupBox4.Name = "UiGroupBox4"
        Me.UiGroupBox4.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox4.Size = New System.Drawing.Size(156, 82)
        Me.UiGroupBox4.TabIndex = 105
        Me.UiGroupBox4.Text = "Se Encuentra no Habido"
        Me.UiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'OptSiEncuentra_Habido
        '
        Me.OptSiEncuentra_Habido.AutoSize = True
        Me.OptSiEncuentra_Habido.BackColor = System.Drawing.Color.Transparent
        Me.OptSiEncuentra_Habido.Checked = True
        Me.OptSiEncuentra_Habido.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptSiEncuentra_Habido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptSiEncuentra_Habido.ForeColor = System.Drawing.Color.Black
        Me.OptSiEncuentra_Habido.Location = New System.Drawing.Point(20, 23)
        Me.OptSiEncuentra_Habido.Name = "OptSiEncuentra_Habido"
        Me.OptSiEncuentra_Habido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptSiEncuentra_Habido.Size = New System.Drawing.Size(35, 17)
        Me.OptSiEncuentra_Habido.TabIndex = 103
        Me.OptSiEncuentra_Habido.TabStop = True
        Me.OptSiEncuentra_Habido.Tag = "8"
        Me.OptSiEncuentra_Habido.Text = "SI"
        Me.OptSiEncuentra_Habido.UseVisualStyleBackColor = False
        '
        'OptNoEncuentra_Habido
        '
        Me.OptNoEncuentra_Habido.AutoSize = True
        Me.OptNoEncuentra_Habido.BackColor = System.Drawing.Color.Transparent
        Me.OptNoEncuentra_Habido.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptNoEncuentra_Habido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptNoEncuentra_Habido.ForeColor = System.Drawing.Color.Black
        Me.OptNoEncuentra_Habido.Location = New System.Drawing.Point(20, 51)
        Me.OptNoEncuentra_Habido.Name = "OptNoEncuentra_Habido"
        Me.OptNoEncuentra_Habido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptNoEncuentra_Habido.Size = New System.Drawing.Size(40, 17)
        Me.OptNoEncuentra_Habido.TabIndex = 102
        Me.OptNoEncuentra_Habido.Tag = "9"
        Me.OptNoEncuentra_Habido.Text = "NO"
        Me.OptNoEncuentra_Habido.UseVisualStyleBackColor = False
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Controls.Add(Me.optSIConsiderado_Para_Retencion)
        Me.UiGroupBox3.Controls.Add(Me.optNOConsiderado_Para_Retencion)
        Me.UiGroupBox3.Location = New System.Drawing.Point(12, 106)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox3.Size = New System.Drawing.Size(208, 82)
        Me.UiGroupBox3.TabIndex = 104
        Me.UiGroupBox3.Text = "Es Considerado para Retención IGV"
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'optSIConsiderado_Para_Retencion
        '
        Me.optSIConsiderado_Para_Retencion.AutoSize = True
        Me.optSIConsiderado_Para_Retencion.BackColor = System.Drawing.Color.Transparent
        Me.optSIConsiderado_Para_Retencion.Checked = True
        Me.optSIConsiderado_Para_Retencion.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSIConsiderado_Para_Retencion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSIConsiderado_Para_Retencion.ForeColor = System.Drawing.Color.Black
        Me.optSIConsiderado_Para_Retencion.Location = New System.Drawing.Point(20, 23)
        Me.optSIConsiderado_Para_Retencion.Name = "optSIConsiderado_Para_Retencion"
        Me.optSIConsiderado_Para_Retencion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSIConsiderado_Para_Retencion.Size = New System.Drawing.Size(35, 17)
        Me.optSIConsiderado_Para_Retencion.TabIndex = 103
        Me.optSIConsiderado_Para_Retencion.TabStop = True
        Me.optSIConsiderado_Para_Retencion.Tag = "8"
        Me.optSIConsiderado_Para_Retencion.Text = "SI"
        Me.optSIConsiderado_Para_Retencion.UseVisualStyleBackColor = False
        '
        'optNOConsiderado_Para_Retencion
        '
        Me.optNOConsiderado_Para_Retencion.AutoSize = True
        Me.optNOConsiderado_Para_Retencion.BackColor = System.Drawing.Color.Transparent
        Me.optNOConsiderado_Para_Retencion.Cursor = System.Windows.Forms.Cursors.Default
        Me.optNOConsiderado_Para_Retencion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNOConsiderado_Para_Retencion.ForeColor = System.Drawing.Color.Black
        Me.optNOConsiderado_Para_Retencion.Location = New System.Drawing.Point(20, 51)
        Me.optNOConsiderado_Para_Retencion.Name = "optNOConsiderado_Para_Retencion"
        Me.optNOConsiderado_Para_Retencion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optNOConsiderado_Para_Retencion.Size = New System.Drawing.Size(40, 17)
        Me.optNOConsiderado_Para_Retencion.TabIndex = 102
        Me.optNOConsiderado_Para_Retencion.Tag = "9"
        Me.optNOConsiderado_Para_Retencion.Text = "NO"
        Me.optNOConsiderado_Para_Retencion.UseVisualStyleBackColor = False
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Controls.Add(Me.optSIAgente_Percepcion)
        Me.UiGroupBox2.Controls.Add(Me.optNOAgente_Percepcion)
        Me.UiGroupBox2.Location = New System.Drawing.Point(326, 9)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox2.Size = New System.Drawing.Size(128, 82)
        Me.UiGroupBox2.TabIndex = 103
        Me.UiGroupBox2.Text = "Agente de Percepción"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'optSIAgente_Percepcion
        '
        Me.optSIAgente_Percepcion.AutoSize = True
        Me.optSIAgente_Percepcion.BackColor = System.Drawing.Color.Transparent
        Me.optSIAgente_Percepcion.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSIAgente_Percepcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSIAgente_Percepcion.ForeColor = System.Drawing.Color.Black
        Me.optSIAgente_Percepcion.Location = New System.Drawing.Point(20, 23)
        Me.optSIAgente_Percepcion.Name = "optSIAgente_Percepcion"
        Me.optSIAgente_Percepcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSIAgente_Percepcion.Size = New System.Drawing.Size(35, 17)
        Me.optSIAgente_Percepcion.TabIndex = 103
        Me.optSIAgente_Percepcion.Tag = "8"
        Me.optSIAgente_Percepcion.Text = "SI"
        Me.optSIAgente_Percepcion.UseVisualStyleBackColor = False
        '
        'optNOAgente_Percepcion
        '
        Me.optNOAgente_Percepcion.AutoSize = True
        Me.optNOAgente_Percepcion.BackColor = System.Drawing.Color.Transparent
        Me.optNOAgente_Percepcion.Checked = True
        Me.optNOAgente_Percepcion.Cursor = System.Windows.Forms.Cursors.Default
        Me.optNOAgente_Percepcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNOAgente_Percepcion.ForeColor = System.Drawing.Color.Black
        Me.optNOAgente_Percepcion.Location = New System.Drawing.Point(20, 51)
        Me.optNOAgente_Percepcion.Name = "optNOAgente_Percepcion"
        Me.optNOAgente_Percepcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optNOAgente_Percepcion.Size = New System.Drawing.Size(40, 17)
        Me.optNOAgente_Percepcion.TabIndex = 102
        Me.optNOAgente_Percepcion.TabStop = True
        Me.optNOAgente_Percepcion.Tag = "9"
        Me.optNOAgente_Percepcion.Text = "NO"
        Me.optNOAgente_Percepcion.UseVisualStyleBackColor = False
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.optSIAgenteRetencionIGV)
        Me.UiGroupBox1.Controls.Add(Me.optNOAgenteRetencionIGV)
        Me.UiGroupBox1.Location = New System.Drawing.Point(160, 9)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(126, 82)
        Me.UiGroupBox1.TabIndex = 102
        Me.UiGroupBox1.Text = "Agente de Retención"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'optSIAgenteRetencionIGV
        '
        Me.optSIAgenteRetencionIGV.AutoSize = True
        Me.optSIAgenteRetencionIGV.BackColor = System.Drawing.Color.Transparent
        Me.optSIAgenteRetencionIGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSIAgenteRetencionIGV.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSIAgenteRetencionIGV.ForeColor = System.Drawing.Color.Black
        Me.optSIAgenteRetencionIGV.Location = New System.Drawing.Point(20, 23)
        Me.optSIAgenteRetencionIGV.Name = "optSIAgenteRetencionIGV"
        Me.optSIAgenteRetencionIGV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSIAgenteRetencionIGV.Size = New System.Drawing.Size(35, 17)
        Me.optSIAgenteRetencionIGV.TabIndex = 103
        Me.optSIAgenteRetencionIGV.Tag = "8"
        Me.optSIAgenteRetencionIGV.Text = "SI"
        Me.optSIAgenteRetencionIGV.UseVisualStyleBackColor = False
        '
        'optNOAgenteRetencionIGV
        '
        Me.optNOAgenteRetencionIGV.AutoSize = True
        Me.optNOAgenteRetencionIGV.BackColor = System.Drawing.Color.Transparent
        Me.optNOAgenteRetencionIGV.Checked = True
        Me.optNOAgenteRetencionIGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.optNOAgenteRetencionIGV.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNOAgenteRetencionIGV.ForeColor = System.Drawing.Color.Black
        Me.optNOAgenteRetencionIGV.Location = New System.Drawing.Point(20, 51)
        Me.optNOAgenteRetencionIGV.Name = "optNOAgenteRetencionIGV"
        Me.optNOAgenteRetencionIGV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optNOAgenteRetencionIGV.Size = New System.Drawing.Size(40, 17)
        Me.optNOAgenteRetencionIGV.TabIndex = 102
        Me.optNOAgenteRetencionIGV.TabStop = True
        Me.optNOAgenteRetencionIGV.Tag = "9"
        Me.optNOAgenteRetencionIGV.Text = "NO"
        Me.optNOAgenteRetencionIGV.UseVisualStyleBackColor = False
        '
        'FraRango
        '
        Me.FraRango.Controls.Add(Me.optSiBuenContribuyente)
        Me.FraRango.Controls.Add(Me.optNOBuenContribuyente)
        Me.FraRango.Location = New System.Drawing.Point(12, 9)
        Me.FraRango.Name = "FraRango"
        Me.FraRango.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.FraRango.Size = New System.Drawing.Size(126, 82)
        Me.FraRango.TabIndex = 101
        Me.FraRango.Text = "Buen Contribuyente"
        Me.FraRango.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'optSiBuenContribuyente
        '
        Me.optSiBuenContribuyente.AutoSize = True
        Me.optSiBuenContribuyente.BackColor = System.Drawing.Color.Transparent
        Me.optSiBuenContribuyente.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSiBuenContribuyente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSiBuenContribuyente.ForeColor = System.Drawing.Color.Black
        Me.optSiBuenContribuyente.Location = New System.Drawing.Point(20, 23)
        Me.optSiBuenContribuyente.Name = "optSiBuenContribuyente"
        Me.optSiBuenContribuyente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSiBuenContribuyente.Size = New System.Drawing.Size(35, 17)
        Me.optSiBuenContribuyente.TabIndex = 103
        Me.optSiBuenContribuyente.Tag = "8"
        Me.optSiBuenContribuyente.Text = "SI"
        Me.optSiBuenContribuyente.UseVisualStyleBackColor = False
        '
        'optNOBuenContribuyente
        '
        Me.optNOBuenContribuyente.AutoSize = True
        Me.optNOBuenContribuyente.BackColor = System.Drawing.Color.Transparent
        Me.optNOBuenContribuyente.Checked = True
        Me.optNOBuenContribuyente.Cursor = System.Windows.Forms.Cursors.Default
        Me.optNOBuenContribuyente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNOBuenContribuyente.ForeColor = System.Drawing.Color.Black
        Me.optNOBuenContribuyente.Location = New System.Drawing.Point(20, 51)
        Me.optNOBuenContribuyente.Name = "optNOBuenContribuyente"
        Me.optNOBuenContribuyente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optNOBuenContribuyente.Size = New System.Drawing.Size(40, 17)
        Me.optNOBuenContribuyente.TabIndex = 102
        Me.optNOBuenContribuyente.TabStop = True
        Me.optNOBuenContribuyente.Tag = "9"
        Me.optNOBuenContribuyente.Text = "NO"
        Me.optNOBuenContribuyente.UseVisualStyleBackColor = False
        '
        'FrmMantAnexosContables_DatosAdicionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMantAnexosContables_DatosAdicionales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos Adicionales Contribuyente"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox4.ResumeLayout(False)
        Me.UiGroupBox4.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.FraRango, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraRango.ResumeLayout(False)
        Me.FraRango.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents optSiBuenContribuyente As System.Windows.Forms.RadioButton
    Public WithEvents optNOBuenContribuyente As System.Windows.Forms.RadioButton
    Friend WithEvents FraRango As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents OptSiEncuentra_Habido As System.Windows.Forms.RadioButton
    Public WithEvents OptNoEncuentra_Habido As System.Windows.Forms.RadioButton
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents optSIConsiderado_Para_Retencion As System.Windows.Forms.RadioButton
    Public WithEvents optNOConsiderado_Para_Retencion As System.Windows.Forms.RadioButton
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents optSIAgente_Percepcion As System.Windows.Forms.RadioButton
    Public WithEvents optNOAgente_Percepcion As System.Windows.Forms.RadioButton
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents optSIAgenteRetencionIGV As System.Windows.Forms.RadioButton
    Public WithEvents optNOAgenteRetencionIGV As System.Windows.Forms.RadioButton
End Class
