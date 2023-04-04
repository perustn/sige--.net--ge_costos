<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGuiasAsociadas_CortePrendas_AsigGuias
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
        Dim GrdDatos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFactura = New System.Windows.Forms.TextBox()
        Me.TxtAnexo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodAnexo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.BtnCancelarProrrateo = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptarProrrateo = New Janus.Windows.EditControls.UIButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Frame1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.GrdDatos = New Janus.Windows.GridEX.GridEX()
        Me.Panel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.TxtFactura)
        Me.Panel4.Controls.Add(Me.TxtAnexo)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TxtCodAnexo)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.TxtTipo)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtNroCorrelativo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(743, 78)
        Me.Panel4.TabIndex = 254
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(571, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "FACTURA"
        '
        'TxtFactura
        '
        Me.TxtFactura.AcceptsReturn = True
        Me.TxtFactura.BackColor = System.Drawing.Color.LightCyan
        Me.TxtFactura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFactura.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFactura.Location = New System.Drawing.Point(630, 28)
        Me.TxtFactura.MaxLength = 0
        Me.TxtFactura.Name = "TxtFactura"
        Me.TxtFactura.ReadOnly = True
        Me.TxtFactura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtFactura.Size = New System.Drawing.Size(96, 20)
        Me.TxtFactura.TabIndex = 133
        '
        'TxtAnexo
        '
        Me.TxtAnexo.AcceptsReturn = True
        Me.TxtAnexo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtAnexo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAnexo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtAnexo.Location = New System.Drawing.Point(225, 52)
        Me.TxtAnexo.MaxLength = 0
        Me.TxtAnexo.Name = "TxtAnexo"
        Me.TxtAnexo.ReadOnly = True
        Me.TxtAnexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtAnexo.Size = New System.Drawing.Size(501, 20)
        Me.TxtAnexo.TabIndex = 131
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(10, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "ANEXO"
        '
        'TxtCodAnexo
        '
        Me.TxtCodAnexo.AcceptsReturn = True
        Me.TxtCodAnexo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtCodAnexo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodAnexo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCodAnexo.Location = New System.Drawing.Point(127, 52)
        Me.TxtCodAnexo.MaxLength = 0
        Me.TxtCodAnexo.Name = "TxtCodAnexo"
        Me.TxtCodAnexo.ReadOnly = True
        Me.TxtCodAnexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCodAnexo.Size = New System.Drawing.Size(96, 20)
        Me.TxtCodAnexo.TabIndex = 130
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(86, 12)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "TIPO DE ANEXO"
        '
        'TxtTipo
        '
        Me.TxtTipo.AcceptsReturn = True
        Me.TxtTipo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtTipo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtTipo.Location = New System.Drawing.Point(127, 28)
        Me.TxtTipo.MaxLength = 0
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtTipo.Size = New System.Drawing.Size(96, 20)
        Me.TxtTipo.TabIndex = 128
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(10, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(104, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "NRO CORRELATIVO"
        '
        'TxtNroCorrelativo
        '
        Me.TxtNroCorrelativo.AcceptsReturn = True
        Me.TxtNroCorrelativo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtNroCorrelativo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNroCorrelativo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNroCorrelativo.Location = New System.Drawing.Point(127, 4)
        Me.TxtNroCorrelativo.MaxLength = 0
        Me.TxtNroCorrelativo.Name = "TxtNroCorrelativo"
        Me.TxtNroCorrelativo.ReadOnly = True
        Me.TxtNroCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroCorrelativo.Size = New System.Drawing.Size(96, 20)
        Me.TxtNroCorrelativo.TabIndex = 121
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 456)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(743, 30)
        Me.Panel10.TabIndex = 255
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.BtnCancelarProrrateo)
        Me.Panel11.Controls.Add(Me.BtnAceptarProrrateo)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(531, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(212, 30)
        Me.Panel11.TabIndex = 0
        '
        'BtnCancelarProrrateo
        '
        Me.BtnCancelarProrrateo.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnCancelarProrrateo.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCancelarProrrateo.Location = New System.Drawing.Point(105, 3)
        Me.BtnCancelarProrrateo.Name = "BtnCancelarProrrateo"
        Me.BtnCancelarProrrateo.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCancelarProrrateo.Size = New System.Drawing.Size(98, 24)
        Me.BtnCancelarProrrateo.TabIndex = 6
        Me.BtnCancelarProrrateo.Text = "&Cancelar"
        Me.BtnCancelarProrrateo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'BtnAceptarProrrateo
        '
        Me.BtnAceptarProrrateo.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnAceptarProrrateo.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnAceptarProrrateo.Location = New System.Drawing.Point(3, 3)
        Me.BtnAceptarProrrateo.Name = "BtnAceptarProrrateo"
        Me.BtnAceptarProrrateo.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnAceptarProrrateo.Size = New System.Drawing.Size(98, 24)
        Me.BtnAceptarProrrateo.TabIndex = 5
        Me.BtnAceptarProrrateo.Text = "&Asignar"
        Me.BtnAceptarProrrateo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Frame1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 378)
        Me.Panel1.TabIndex = 256
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.GrdDatos)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.ForeColor = System.Drawing.Color.White
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.Frame1.Size = New System.Drawing.Size(743, 378)
        Me.Frame1.TabIndex = 260
        Me.Frame1.Tag = "3"
        Me.Frame1.Text = "Seleccionar en la columna ""SEL"" los registros a Asociar a la Factura :"
        Me.Frame1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'GrdDatos
        '
        Me.GrdDatos.AllowColumnDrag = False
        Me.GrdDatos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdDatos.AlternatingColors = True
        Me.GrdDatos.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GrdDatos.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GrdDatos_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" & _
    "Table></GridEXLayoutData>"
        Me.GrdDatos.DesignTimeLayout = GrdDatos_DesignTimeLayout
        Me.GrdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdDatos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GrdDatos.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDatos.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GrdDatos.GroupByBoxVisible = False
        Me.GrdDatos.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDatos.Location = New System.Drawing.Point(3, 16)
        Me.GrdDatos.Name = "GrdDatos"
        Me.GrdDatos.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdDatos.RecordNavigator = True
        Me.GrdDatos.Size = New System.Drawing.Size(737, 359)
        Me.GrdDatos.TabIndex = 180
        Me.GrdDatos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'FrmGuiasAsociadas_CortePrendas_AsigGuias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmGuiasAsociadas_CortePrendas_AsigGuias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar Guías - Corte Prendas"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtNroCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelarProrrateo As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptarProrrateo As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Frame1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents GrdDatos As Janus.Windows.GridEX.GridEX
    Public WithEvents TxtAnexo As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents TxtCodAnexo As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TxtTipo As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents TxtFactura As System.Windows.Forms.TextBox
End Class
