<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsolidadosMensualMovConfecciones
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
        Me.cmbAnioMes = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cmbAlmacenes = New Janus.Windows.EditControls.UIComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.gbDetFam = New Janus.Windows.EditControls.UIGroupBox()
        Me.rdbDetalladoFam = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbResumidoFamilia = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbFormatoSunat = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbKardexSunatResumido = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbSinFormato = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbSaldoFinalDetallado = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbDolares = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbKardexFamilia = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbKardexValorizado = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbSaldoFinal = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbSoles = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbKilos = New Janus.Windows.EditControls.UIRadioButton()
        Me.gbOpt = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDesFamItem = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtCodFamItem = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdbDetallado = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbResumido = New Janus.Windows.EditControls.UIRadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.gbDetFam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetFam.SuspendLayout()
        CType(Me.gbOpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpt.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 33)
        Me.Panel1.TabIndex = 0
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.cmbAnioMes)
        Me.UiGroupBox1.Controls.Add(Me.cmbAlmacenes)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox1.Size = New System.Drawing.Size(623, 70)
        Me.UiGroupBox1.TabIndex = 1
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'cmbAnioMes
        '
        Me.cmbAnioMes.CustomFormat = "MMMM/yyyy"
        Me.cmbAnioMes.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.cmbAnioMes.DropDownCalendar.OfficeColorScheme = Janus.Windows.CalendarCombo.OfficeColorScheme.Blue
        Me.cmbAnioMes.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2010
        Me.cmbAnioMes.Location = New System.Drawing.Point(124, 38)
        Me.cmbAnioMes.Name = "cmbAnioMes"
        Me.cmbAnioMes.OfficeColorScheme = Janus.Windows.CalendarCombo.OfficeColorScheme.Blue
        Me.cmbAnioMes.ShowDropDown = False
        Me.cmbAnioMes.ShowUpDown = True
        Me.cmbAnioMes.Size = New System.Drawing.Size(130, 22)
        Me.cmbAnioMes.TabIndex = 3
        Me.cmbAnioMes.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2010
        '
        'cmbAlmacenes
        '
        Me.cmbAlmacenes.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cmbAlmacenes.Location = New System.Drawing.Point(124, 12)
        Me.cmbAlmacenes.Name = "cmbAlmacenes"
        Me.cmbAlmacenes.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.cmbAlmacenes.Size = New System.Drawing.Size(285, 22)
        Me.cmbAlmacenes.TabIndex = 2
        Me.cmbAlmacenes.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mes / Año"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Almacén Primario"
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Controls.Add(Me.gbDetFam)
        Me.UiGroupBox2.Controls.Add(Me.rdbFormatoSunat)
        Me.UiGroupBox2.Controls.Add(Me.rdbKardexSunatResumido)
        Me.UiGroupBox2.Controls.Add(Me.rdbSinFormato)
        Me.UiGroupBox2.Controls.Add(Me.rdbSaldoFinalDetallado)
        Me.UiGroupBox2.Controls.Add(Me.rdbDolares)
        Me.UiGroupBox2.Controls.Add(Me.rdbKardexFamilia)
        Me.UiGroupBox2.Controls.Add(Me.rdbKardexValorizado)
        Me.UiGroupBox2.Controls.Add(Me.rdbSaldoFinal)
        Me.UiGroupBox2.Controls.Add(Me.rdbSoles)
        Me.UiGroupBox2.Controls.Add(Me.rdbKilos)
        Me.UiGroupBox2.Controls.Add(Me.gbOpt)
        Me.UiGroupBox2.FormatStyle.FontBold = Janus.Windows.UI.TriState.[True]
        Me.UiGroupBox2.Location = New System.Drawing.Point(12, 110)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.UiGroupBox2.Size = New System.Drawing.Size(623, 143)
        Me.UiGroupBox2.TabIndex = 2
        Me.UiGroupBox2.Text = "Opciones"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'gbDetFam
        '
        Me.gbDetFam.Controls.Add(Me.rdbDetalladoFam)
        Me.gbDetFam.Controls.Add(Me.rdbResumidoFamilia)
        Me.gbDetFam.Location = New System.Drawing.Point(415, 13)
        Me.gbDetFam.Name = "gbDetFam"
        Me.gbDetFam.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.gbDetFam.Size = New System.Drawing.Size(202, 49)
        Me.gbDetFam.TabIndex = 11
        Me.gbDetFam.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'rdbDetalladoFam
        '
        Me.rdbDetalladoFam.AutoSize = True
        Me.rdbDetalladoFam.Checked = True
        Me.rdbDetalladoFam.Location = New System.Drawing.Point(7, 29)
        Me.rdbDetalladoFam.Name = "rdbDetalladoFam"
        Me.rdbDetalladoFam.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbDetalladoFam.Size = New System.Drawing.Size(76, 19)
        Me.rdbDetalladoFam.TabIndex = 1
        Me.rdbDetalladoFam.TabStop = True
        Me.rdbDetalladoFam.Text = "Detallado"
        Me.rdbDetalladoFam.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbResumidoFamilia
        '
        Me.rdbResumidoFamilia.AutoSize = True
        Me.rdbResumidoFamilia.Location = New System.Drawing.Point(7, 10)
        Me.rdbResumidoFamilia.Name = "rdbResumidoFamilia"
        Me.rdbResumidoFamilia.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbResumidoFamilia.Size = New System.Drawing.Size(138, 19)
        Me.rdbResumidoFamilia.TabIndex = 0
        Me.rdbResumidoFamilia.Text = "Resumen por Familia"
        Me.rdbResumidoFamilia.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbFormatoSunat
        '
        Me.rdbFormatoSunat.AutoSize = True
        Me.rdbFormatoSunat.Location = New System.Drawing.Point(119, 117)
        Me.rdbFormatoSunat.Name = "rdbFormatoSunat"
        Me.rdbFormatoSunat.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbFormatoSunat.Size = New System.Drawing.Size(140, 19)
        Me.rdbFormatoSunat.TabIndex = 10
        Me.rdbFormatoSunat.Text = "Kardex formato SUNAT"
        Me.rdbFormatoSunat.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbKardexSunatResumido
        '
        Me.rdbKardexSunatResumido.AutoSize = True
        Me.rdbKardexSunatResumido.Location = New System.Drawing.Point(456, 92)
        Me.rdbKardexSunatResumido.Name = "rdbKardexSunatResumido"
        Me.rdbKardexSunatResumido.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbKardexSunatResumido.Size = New System.Drawing.Size(149, 19)
        Me.rdbKardexSunatResumido.TabIndex = 9
        Me.rdbKardexSunatResumido.Text = "Kardex Sunat Resumido"
        Me.rdbKardexSunatResumido.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbSinFormato
        '
        Me.rdbSinFormato.AutoSize = True
        Me.rdbSinFormato.Location = New System.Drawing.Point(332, 92)
        Me.rdbSinFormato.Name = "rdbSinFormato"
        Me.rdbSinFormato.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbSinFormato.Size = New System.Drawing.Size(120, 19)
        Me.rdbSinFormato.TabIndex = 8
        Me.rdbSinFormato.Text = "Sunat Sin Formato"
        Me.rdbSinFormato.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbSaldoFinalDetallado
        '
        Me.rdbSaldoFinalDetallado.AutoSize = True
        Me.rdbSaldoFinalDetallado.Location = New System.Drawing.Point(187, 92)
        Me.rdbSaldoFinalDetallado.Name = "rdbSaldoFinalDetallado"
        Me.rdbSaldoFinalDetallado.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbSaldoFinalDetallado.Size = New System.Drawing.Size(141, 19)
        Me.rdbSaldoFinalDetallado.TabIndex = 7
        Me.rdbSaldoFinalDetallado.Text = "Saldo Final Detallado"
        Me.rdbSaldoFinalDetallado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbDolares
        '
        Me.rdbDolares.AutoSize = True
        Me.rdbDolares.Location = New System.Drawing.Point(119, 92)
        Me.rdbDolares.Name = "rdbDolares"
        Me.rdbDolares.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbDolares.Size = New System.Drawing.Size(64, 19)
        Me.rdbDolares.TabIndex = 6
        Me.rdbDolares.Text = "Dólares"
        Me.rdbDolares.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbKardexFamilia
        '
        Me.rdbKardexFamilia.AutoSize = True
        Me.rdbKardexFamilia.Location = New System.Drawing.Point(456, 67)
        Me.rdbKardexFamilia.Name = "rdbKardexFamilia"
        Me.rdbKardexFamilia.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbKardexFamilia.Size = New System.Drawing.Size(157, 19)
        Me.rdbKardexFamilia.TabIndex = 5
        Me.rdbKardexFamilia.Text = "Kardex Sunat por Familia"
        Me.rdbKardexFamilia.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbKardexValorizado
        '
        Me.rdbKardexValorizado.AutoSize = True
        Me.rdbKardexValorizado.Location = New System.Drawing.Point(332, 67)
        Me.rdbKardexValorizado.Name = "rdbKardexValorizado"
        Me.rdbKardexValorizado.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbKardexValorizado.Size = New System.Drawing.Size(118, 19)
        Me.rdbKardexValorizado.TabIndex = 4
        Me.rdbKardexValorizado.Text = "Kardex Valorizado"
        Me.rdbKardexValorizado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbSaldoFinal
        '
        Me.rdbSaldoFinal.AutoSize = True
        Me.rdbSaldoFinal.Location = New System.Drawing.Point(187, 67)
        Me.rdbSaldoFinal.Name = "rdbSaldoFinal"
        Me.rdbSaldoFinal.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbSaldoFinal.Size = New System.Drawing.Size(141, 19)
        Me.rdbSaldoFinal.TabIndex = 3
        Me.rdbSaldoFinal.Text = "Saldo Final Resumido"
        Me.rdbSaldoFinal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbSoles
        '
        Me.rdbSoles.AutoSize = True
        Me.rdbSoles.Location = New System.Drawing.Point(119, 67)
        Me.rdbSoles.Name = "rdbSoles"
        Me.rdbSoles.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbSoles.Size = New System.Drawing.Size(51, 19)
        Me.rdbSoles.TabIndex = 2
        Me.rdbSoles.Text = "Soles"
        Me.rdbSoles.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbKilos
        '
        Me.rdbKilos.AutoSize = True
        Me.rdbKilos.Checked = True
        Me.rdbKilos.Location = New System.Drawing.Point(13, 67)
        Me.rdbKilos.Name = "rdbKilos"
        Me.rdbKilos.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbKilos.Size = New System.Drawing.Size(106, 19)
        Me.rdbKilos.TabIndex = 1
        Me.rdbKilos.TabStop = True
        Me.rdbKilos.Text = "Kilos/Unidades"
        Me.rdbKilos.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'gbOpt
        '
        Me.gbOpt.Controls.Add(Me.txtDesFamItem)
        Me.gbOpt.Controls.Add(Me.txtCodFamItem)
        Me.gbOpt.Controls.Add(Me.Label3)
        Me.gbOpt.Controls.Add(Me.rdbDetallado)
        Me.gbOpt.Controls.Add(Me.rdbResumido)
        Me.gbOpt.Location = New System.Drawing.Point(13, 13)
        Me.gbOpt.Name = "gbOpt"
        Me.gbOpt.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.gbOpt.Size = New System.Drawing.Size(95, 49)
        Me.gbOpt.TabIndex = 0
        Me.gbOpt.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtDesFamItem
        '
        Me.txtDesFamItem.Location = New System.Drawing.Point(210, 16)
        Me.txtDesFamItem.Name = "txtDesFamItem"
        Me.txtDesFamItem.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.txtDesFamItem.Size = New System.Drawing.Size(180, 22)
        Me.txtDesFamItem.TabIndex = 4
        Me.txtDesFamItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtCodFamItem
        '
        Me.txtCodFamItem.Location = New System.Drawing.Point(170, 16)
        Me.txtCodFamItem.Name = "txtCodFamItem"
        Me.txtCodFamItem.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.txtCodFamItem.Size = New System.Drawing.Size(34, 22)
        Me.txtCodFamItem.TabIndex = 3
        Me.txtCodFamItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fam. Item"
        '
        'rdbDetallado
        '
        Me.rdbDetallado.AutoSize = True
        Me.rdbDetallado.Location = New System.Drawing.Point(7, 29)
        Me.rdbDetallado.Name = "rdbDetallado"
        Me.rdbDetallado.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbDetallado.Size = New System.Drawing.Size(76, 19)
        Me.rdbDetallado.TabIndex = 1
        Me.rdbDetallado.Text = "Detallado"
        Me.rdbDetallado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'rdbResumido
        '
        Me.rdbResumido.AutoSize = True
        Me.rdbResumido.Checked = True
        Me.rdbResumido.Location = New System.Drawing.Point(7, 10)
        Me.rdbResumido.Name = "rdbResumido"
        Me.rdbResumido.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.rdbResumido.Size = New System.Drawing.Size(76, 19)
        Me.rdbResumido.TabIndex = 0
        Me.rdbResumido.TabStop = True
        Me.rdbResumido.Text = "Resumido"
        Me.rdbResumido.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnImprimir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 259)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(641, 49)
        Me.Panel2.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(541, 8)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnImprimir.Size = New System.Drawing.Size(94, 32)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FrmConsolidadosMensualMovConfecciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(641, 308)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.UiGroupBox2)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(657, 347)
        Me.MinimumSize = New System.Drawing.Size(657, 347)
        Me.Name = "FrmConsolidadosMensualMovConfecciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolidados Mensuales Almacenes Primarios"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.gbDetFam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetFam.ResumeLayout(False)
        CType(Me.gbOpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpt.ResumeLayout(False)
        Me.gbOpt.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAnioMes As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cmbAlmacenes As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents gbOpt As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents rdbResumido As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbDetallado As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbKardexFamilia As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbKardexValorizado As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbSaldoFinal As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbSoles As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbKilos As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbKardexSunatResumido As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbSinFormato As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbSaldoFinalDetallado As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbDolares As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbFormatoSunat As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDesFamItem As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtCodFamItem As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gbDetFam As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents rdbDetalladoFam As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbResumidoFamilia As Janus.Windows.EditControls.UIRadioButton
End Class
