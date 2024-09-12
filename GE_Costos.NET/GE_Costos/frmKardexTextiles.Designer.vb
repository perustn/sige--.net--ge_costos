<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKardexTextiles
    Inherits ProyectoBase.frmBase

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
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.rdbTelaTenida = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbTelaCrudaPreTenido = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbTelaCrudaTejeduria = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbHiladoTenidoTintoreria = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbHiladoCrudoTintoreria = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbHiladoTenidoSaldos = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbHiladoTenido = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbHiladoCrudoSaldos = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbHiladoCrudo = New Janus.Windows.EditControls.UIRadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkSunat = New Janus.Windows.EditControls.UICheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpAnio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpMes = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.chkSoloCMT = New Janus.Windows.EditControls.UICheckBox()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 24)
        Me.Panel1.TabIndex = 0
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.chkSoloCMT)
        Me.UiGroupBox1.Controls.Add(Me.Panel3)
        Me.UiGroupBox1.Controls.Add(Me.rdbTelaTenida)
        Me.UiGroupBox1.Controls.Add(Me.rdbTelaCrudaPreTenido)
        Me.UiGroupBox1.Controls.Add(Me.rdbTelaCrudaTejeduria)
        Me.UiGroupBox1.Controls.Add(Me.rdbHiladoTenidoTintoreria)
        Me.UiGroupBox1.Controls.Add(Me.rdbHiladoCrudoTintoreria)
        Me.UiGroupBox1.Controls.Add(Me.rdbHiladoTenidoSaldos)
        Me.UiGroupBox1.Controls.Add(Me.rdbHiladoTenido)
        Me.UiGroupBox1.Controls.Add(Me.rdbHiladoCrudoSaldos)
        Me.UiGroupBox1.Controls.Add(Me.rdbHiladoCrudo)
        Me.UiGroupBox1.Location = New System.Drawing.Point(10, 59)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(364, 221)
        Me.UiGroupBox1.TabIndex = 1
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'rdbTelaTenida
        '
        Me.rdbTelaTenida.AutoSize = True
        Me.rdbTelaTenida.Location = New System.Drawing.Point(11, 190)
        Me.rdbTelaTenida.Name = "rdbTelaTenida"
        Me.rdbTelaTenida.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbTelaTenida.Size = New System.Drawing.Size(84, 19)
        Me.rdbTelaTenida.TabIndex = 8
        Me.rdbTelaTenida.Text = "Tela Teñida"
        Me.rdbTelaTenida.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbTelaCrudaPreTenido
        '
        Me.rdbTelaCrudaPreTenido.AutoSize = True
        Me.rdbTelaCrudaPreTenido.Location = New System.Drawing.Point(11, 168)
        Me.rdbTelaCrudaPreTenido.Name = "rdbTelaCrudaPreTenido"
        Me.rdbTelaCrudaPreTenido.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbTelaCrudaPreTenido.Size = New System.Drawing.Size(139, 19)
        Me.rdbTelaCrudaPreTenido.TabIndex = 7
        Me.rdbTelaCrudaPreTenido.Text = "Tela Cruda Pre-Teñido"
        Me.rdbTelaCrudaPreTenido.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbTelaCrudaTejeduria
        '
        Me.rdbTelaCrudaTejeduria.AutoSize = True
        Me.rdbTelaCrudaTejeduria.Location = New System.Drawing.Point(11, 146)
        Me.rdbTelaCrudaTejeduria.Name = "rdbTelaCrudaTejeduria"
        Me.rdbTelaCrudaTejeduria.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbTelaCrudaTejeduria.Size = New System.Drawing.Size(132, 19)
        Me.rdbTelaCrudaTejeduria.TabIndex = 6
        Me.rdbTelaCrudaTejeduria.Text = "Tela Cruda Tejeduria"
        Me.rdbTelaCrudaTejeduria.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbHiladoTenidoTintoreria
        '
        Me.rdbHiladoTenidoTintoreria.AutoSize = True
        Me.rdbHiladoTenidoTintoreria.Location = New System.Drawing.Point(11, 124)
        Me.rdbHiladoTenidoTintoreria.Name = "rdbHiladoTenidoTintoreria"
        Me.rdbHiladoTenidoTintoreria.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbHiladoTenidoTintoreria.Size = New System.Drawing.Size(187, 19)
        Me.rdbHiladoTenidoTintoreria.TabIndex = 5
        Me.rdbHiladoTenidoTintoreria.Text = "Hilo Teñido Tintoreria Hilados"
        Me.rdbHiladoTenidoTintoreria.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbHiladoCrudoTintoreria
        '
        Me.rdbHiladoCrudoTintoreria.AutoSize = True
        Me.rdbHiladoCrudoTintoreria.Location = New System.Drawing.Point(11, 102)
        Me.rdbHiladoCrudoTintoreria.Name = "rdbHiladoCrudoTintoreria"
        Me.rdbHiladoCrudoTintoreria.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbHiladoCrudoTintoreria.Size = New System.Drawing.Size(181, 19)
        Me.rdbHiladoCrudoTintoreria.TabIndex = 4
        Me.rdbHiladoCrudoTintoreria.Text = "Hilo Crudo Tintoreria Hilados"
        Me.rdbHiladoCrudoTintoreria.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbHiladoTenidoSaldos
        '
        Me.rdbHiladoTenidoSaldos.AutoSize = True
        Me.rdbHiladoTenidoSaldos.Location = New System.Drawing.Point(11, 80)
        Me.rdbHiladoTenidoSaldos.Name = "rdbHiladoTenidoSaldos"
        Me.rdbHiladoTenidoSaldos.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbHiladoTenidoSaldos.Size = New System.Drawing.Size(150, 19)
        Me.rdbHiladoTenidoSaldos.TabIndex = 3
        Me.rdbHiladoTenidoSaldos.Text = "Hilados Teñidos Saldos"
        Me.rdbHiladoTenidoSaldos.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbHiladoTenido
        '
        Me.rdbHiladoTenido.AutoSize = True
        Me.rdbHiladoTenido.Location = New System.Drawing.Point(11, 58)
        Me.rdbHiladoTenido.Name = "rdbHiladoTenido"
        Me.rdbHiladoTenido.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbHiladoTenido.Size = New System.Drawing.Size(110, 19)
        Me.rdbHiladoTenido.TabIndex = 2
        Me.rdbHiladoTenido.Text = "Hilados Teñidos"
        Me.rdbHiladoTenido.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbHiladoCrudoSaldos
        '
        Me.rdbHiladoCrudoSaldos.AutoSize = True
        Me.rdbHiladoCrudoSaldos.Location = New System.Drawing.Point(11, 36)
        Me.rdbHiladoCrudoSaldos.Name = "rdbHiladoCrudoSaldos"
        Me.rdbHiladoCrudoSaldos.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbHiladoCrudoSaldos.Size = New System.Drawing.Size(138, 19)
        Me.rdbHiladoCrudoSaldos.TabIndex = 1
        Me.rdbHiladoCrudoSaldos.Text = "Hilados Crudos Saldo"
        Me.rdbHiladoCrudoSaldos.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbHiladoCrudo
        '
        Me.rdbHiladoCrudo.AutoSize = True
        Me.rdbHiladoCrudo.Checked = True
        Me.rdbHiladoCrudo.Location = New System.Drawing.Point(11, 14)
        Me.rdbHiladoCrudo.Name = "rdbHiladoCrudo"
        Me.rdbHiladoCrudo.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbHiladoCrudo.Size = New System.Drawing.Size(104, 19)
        Me.rdbHiladoCrudo.TabIndex = 0
        Me.rdbHiladoCrudo.TabStop = True
        Me.rdbHiladoCrudo.Text = "Hilados Crudos"
        Me.rdbHiladoCrudo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kardex Textiles"
        '
        'chkSunat
        '
        Me.chkSunat.AutoSize = True
        Me.chkSunat.Location = New System.Drawing.Point(21, 287)
        Me.chkSunat.Name = "chkSunat"
        Me.chkSunat.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.chkSunat.Size = New System.Drawing.Size(103, 19)
        Me.chkSunat.TabIndex = 3
        Me.chkSunat.Text = "Formato SUNAT"
        Me.chkSunat.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnImprimir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 313)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(384, 43)
        Me.Panel2.TabIndex = 4
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(136, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnImprimir.Size = New System.Drawing.Size(94, 32)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtpMes)
        Me.Panel3.Controls.Add(Me.dtpAnio)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(204, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(143, 62)
        Me.Panel3.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Año"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mes"
        '
        'dtpAnio
        '
        Me.dtpAnio.CustomFormat = "yyyy"
        Me.dtpAnio.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpAnio.DropDownCalendar.OfficeColorScheme = Janus.Windows.CalendarCombo.OfficeColorScheme.Blue
        Me.dtpAnio.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2010
        Me.dtpAnio.Location = New System.Drawing.Point(47, 5)
        Me.dtpAnio.Name = "dtpAnio"
        Me.dtpAnio.OfficeColorScheme = Janus.Windows.CalendarCombo.OfficeColorScheme.Blue
        Me.dtpAnio.ShowDropDown = False
        Me.dtpAnio.ShowUpDown = True
        Me.dtpAnio.Size = New System.Drawing.Size(63, 22)
        Me.dtpAnio.TabIndex = 2
        Me.dtpAnio.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2010
        '
        'dtpMes
        '
        Me.dtpMes.CustomFormat = "MMM"
        Me.dtpMes.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpMes.DropDownCalendar.OfficeColorScheme = Janus.Windows.CalendarCombo.OfficeColorScheme.Blue
        Me.dtpMes.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2010
        Me.dtpMes.Location = New System.Drawing.Point(47, 32)
        Me.dtpMes.Name = "dtpMes"
        Me.dtpMes.OfficeColorScheme = Janus.Windows.CalendarCombo.OfficeColorScheme.Blue
        Me.dtpMes.ShowDropDown = False
        Me.dtpMes.ShowUpDown = True
        Me.dtpMes.Size = New System.Drawing.Size(63, 22)
        Me.dtpMes.TabIndex = 3
        Me.dtpMes.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2010
        '
        'chkSoloCMT
        '
        Me.chkSoloCMT.AutoSize = True
        Me.chkSoloCMT.Location = New System.Drawing.Point(204, 190)
        Me.chkSoloCMT.Name = "chkSoloCMT"
        Me.chkSoloCMT.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.chkSoloCMT.Size = New System.Drawing.Size(70, 19)
        Me.chkSoloCMT.TabIndex = 10
        Me.chkSoloCMT.Text = "Solo CMT"
        Me.chkSoloCMT.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'frmKardexTextiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(384, 356)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.chkSunat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmKardexTextiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kardex Textiles"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbTelaTenida As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbTelaCrudaPreTenido As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbTelaCrudaTejeduria As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbHiladoTenidoTintoreria As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbHiladoCrudoTintoreria As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbHiladoTenidoSaldos As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbHiladoTenido As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbHiladoCrudoSaldos As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbHiladoCrudo As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents chkSunat As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpMes As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpAnio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents chkSoloCMT As Janus.Windows.EditControls.UICheckBox
End Class
