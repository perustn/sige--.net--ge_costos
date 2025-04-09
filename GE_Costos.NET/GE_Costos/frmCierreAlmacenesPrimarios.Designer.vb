<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCierreAlmacenesPrimarios
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
        Dim ButtonBar1_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim ButtonBar1_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCierreAlmacenesPrimarios))
        Dim ButtonBar1_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar2_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim ButtonBar2_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar2_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar2_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar2_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar()
        Me.ButtonBar2 = New Janus.Windows.ButtonBar.ButtonBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAlmacen = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUltCierre = New System.Windows.Forms.Label()
        Me.cmbTipoCierre = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.panelCarga = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCarga.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 34)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 213)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(771, 42)
        Me.Panel2.TabIndex = 1
        '
        'ButtonBar1
        '
        Me.ButtonBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonBar1.DragStyle = Janus.Windows.ButtonBar.DragStyle.InvertedRect
        ButtonBar1_Item_0_0.Image = CType(resources.GetObject("ButtonBar1_Item_0_0.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_0.Key = "IMPAVISVAL"
        ButtonBar1_Item_0_0.Text = "Hilos Ingresados Avíos Sin Valor"
        ButtonBar1_Item_0_1.Image = CType(resources.GetObject("ButtonBar1_Item_0_1.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_1.Key = "VALORIZACION"
        ButtonBar1_Item_0_1.Text = "Valorización Segun Orden Compra"
        ButtonBar1_Item_0_2.Image = CType(resources.GetObject("ButtonBar1_Item_0_2.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_2.Key = "AVIOSERRADOS"
        ButtonBar1_Item_0_2.Text = "Ver Avíos Errados"
        ButtonBar1_Item_0_3.Image = CType(resources.GetObject("ButtonBar1_Item_0_3.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_3.Key = "AVDES"
        ButtonBar1_Item_0_3.Text = "Ver Avíos Descuadrados"
        ButtonBar1_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {ButtonBar1_Item_0_0, ButtonBar1_Item_0_1, ButtonBar1_Item_0_2, ButtonBar1_Item_0_3})
        ButtonBar1_Group_0.Key = "Group1"
        ButtonBar1_Group_0.Text = "New Group"
        ButtonBar1_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        ButtonBar1_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.ButtonBar1.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar1_Group_0})
        Me.ButtonBar1.HeaderGroupVisible = False
        Me.ButtonBar1.Location = New System.Drawing.Point(0, 185)
        Me.ButtonBar1.Name = "ButtonBar1"
        Me.ButtonBar1.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.ButtonBar1.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.ButtonBar1.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.ButtonBar1.Size = New System.Drawing.Size(771, 28)
        Me.ButtonBar1.TabIndex = 2
        Me.ButtonBar1.Text = "ButtonBar1"
        Me.ButtonBar1.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'ButtonBar2
        '
        Me.ButtonBar2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonBar2.DragStyle = Janus.Windows.ButtonBar.DragStyle.InvertedRect
        ButtonBar2_Item_0_0.Image = CType(resources.GetObject("ButtonBar2_Item_0_0.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_0.Key = "CERRAR"
        ButtonBar2_Item_0_0.Text = "Cerrar"
        ButtonBar2_Item_0_1.Image = CType(resources.GetObject("ButtonBar2_Item_0_1.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_1.Key = "ERRORES"
        ButtonBar2_Item_0_1.Text = "Err Secuencia Fechas"
        ButtonBar2_Item_0_2.Image = CType(resources.GetObject("ButtonBar2_Item_0_2.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_2.Key = "ERRORVAL"
        ButtonBar2_Item_0_2.Text = "Error Valorización"
        ButtonBar2_Item_0_3.Image = CType(resources.GetObject("ButtonBar2_Item_0_3.Image"), System.Drawing.Image)
        ButtonBar2_Item_0_3.Key = "VARETINTO"
        ButtonBar2_Item_0_3.Text = "Valorizado Reproceso Tintorería"
        ButtonBar2_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {ButtonBar2_Item_0_0, ButtonBar2_Item_0_1, ButtonBar2_Item_0_2, ButtonBar2_Item_0_3})
        ButtonBar2_Group_0.Key = "Group1"
        ButtonBar2_Group_0.Text = "New Group"
        ButtonBar2_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        ButtonBar2_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.ButtonBar2.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar2_Group_0})
        Me.ButtonBar2.HeaderGroupVisible = False
        Me.ButtonBar2.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.ButtonBar2.Location = New System.Drawing.Point(0, 157)
        Me.ButtonBar2.Name = "ButtonBar2"
        Me.ButtonBar2.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.ButtonBar2.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.ButtonBar2.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.ButtonBar2.Size = New System.Drawing.Size(771, 28)
        Me.ButtonBar2.TabIndex = 3
        Me.ButtonBar2.Text = "ButtonBar2"
        Me.ButtonBar2.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Almacén"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Último Cierre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Periodo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo de Cierre"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cmbAlmacen.Location = New System.Drawing.Point(119, 42)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.cmbAlmacen.Size = New System.Drawing.Size(283, 22)
        Me.cmbAlmacen.TabIndex = 8
        Me.cmbAlmacen.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'lblUltCierre
        '
        Me.lblUltCierre.AutoSize = True
        Me.lblUltCierre.Location = New System.Drawing.Point(116, 75)
        Me.lblUltCierre.Name = "lblUltCierre"
        Me.lblUltCierre.Size = New System.Drawing.Size(43, 14)
        Me.lblUltCierre.TabIndex = 9
        Me.lblUltCierre.Text = "Label5"
        '
        'cmbTipoCierre
        '
        Me.cmbTipoCierre.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "Temporal"
        UiComboBoxItem1.Value = "T"
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "Definitivo"
        UiComboBoxItem2.Value = "D"
        Me.cmbTipoCierre.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cmbTipoCierre.Location = New System.Drawing.Point(119, 126)
        Me.cmbTipoCierre.Name = "cmbTipoCierre"
        Me.cmbTipoCierre.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.cmbTipoCierre.Size = New System.Drawing.Size(171, 22)
        Me.cmbTipoCierre.TabIndex = 11
        Me.cmbTipoCierre.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "MMM/yyyy"
        Me.dtpFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpFecha.DropDownCalendar.OfficeColorScheme = Janus.Windows.CalendarCombo.OfficeColorScheme.Blue
        Me.dtpFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2010
        Me.dtpFecha.Location = New System.Drawing.Point(119, 97)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.OfficeColorScheme = Janus.Windows.CalendarCombo.OfficeColorScheme.Blue
        Me.dtpFecha.ShowDropDown = False
        Me.dtpFecha.ShowUpDown = True
        Me.dtpFecha.Size = New System.Drawing.Size(106, 22)
        Me.dtpFecha.TabIndex = 10
        Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2010
        '
        'BackgroundWorker1
        '
        '
        'panelCarga
        '
        Me.panelCarga.Controls.Add(Me.ProgressBar1)
        Me.panelCarga.Controls.Add(Me.Label6)
        Me.panelCarga.Controls.Add(Me.Label5)
        Me.panelCarga.Location = New System.Drawing.Point(23, 38)
        Me.panelCarga.Name = "panelCarga"
        Me.panelCarga.Size = New System.Drawing.Size(399, 110)
        Me.panelCarga.TabIndex = 12
        Me.panelCarga.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Por Favor espere ..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 14)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Los datos se están procesando ..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(17, 54)
        Me.ProgressBar1.MarqueeAnimationSpeed = 20
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(259, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 2
        '
        'frmCierreAlmacenesPrimarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(771, 255)
        Me.Controls.Add(Me.panelCarga)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cmbTipoCierre)
        Me.Controls.Add(Me.lblUltCierre)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonBar2)
        Me.Controls.Add(Me.ButtonBar1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCierreAlmacenesPrimarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre Mensual Almacenes Primarios"
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCarga.ResumeLayout(False)
        Me.panelCarga.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonBar1 As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents ButtonBar2 As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbAlmacen As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUltCierre As Label
    Friend WithEvents cmbTipoCierre As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents panelCarga As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
