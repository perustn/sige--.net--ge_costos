<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantActivoFijo
    'Inherits System.Windows.Forms.Form
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
        Dim GrdLista_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ButtonBar1_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim ButtonBar1_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantActivoFijo))
        Dim ButtonBar1_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_5 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBar1_Item_0_6 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.PanelGuia = New System.Windows.Forms.Panel()
        Me.GrdLista = New Janus.Windows.GridEX.GridEX()
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbtContraer = New System.Windows.Forms.RadioButton()
        Me.rbtExpandir = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grbImportacion = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtnum_imp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grbAreaFamilia = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDes_Familia = New System.Windows.Forms.TextBox()
        Me.txtCod_Familia = New System.Windows.Forms.TextBox()
        Me.txtDesArea = New System.Windows.Forms.TextBox()
        Me.TxtCodArea = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grbCuenteContable = New Janus.Windows.EditControls.UIGroupBox()
        Me.TxtDes_CtaCont = New System.Windows.Forms.TextBox()
        Me.TxtCod_CtaCont = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grbSubsidiario = New Janus.Windows.EditControls.UIGroupBox()
        Me.TxtDes_TipoDiario = New System.Windows.Forms.TextBox()
        Me.TxtMesReg = New System.Windows.Forms.TextBox()
        Me.TxtAnioReg = New System.Windows.Forms.TextBox()
        Me.TxtNumReg = New System.Windows.Forms.TextBox()
        Me.TxtCod_TipoDiario = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grbFechaAdquisicion = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grbActivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.Txt_DesActivo = New System.Windows.Forms.TextBox()
        Me.txtCod_Activo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New Janus.Windows.EditControls.UIButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.optnum_imp = New System.Windows.Forms.RadioButton()
        Me.OptAMN = New System.Windows.Forms.RadioButton()
        Me.optCuentaContable = New System.Windows.Forms.RadioButton()
        Me.opt_Familia = New System.Windows.Forms.RadioButton()
        Me.optFecAdquisicion = New System.Windows.Forms.RadioButton()
        Me.optActivoFijo = New System.Windows.Forms.RadioButton()
        Me.PanelGuia.SuspendLayout()
        CType(Me.GrdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grbImportacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbImportacion.SuspendLayout()
        CType(Me.grbAreaFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbAreaFamilia.SuspendLayout()
        CType(Me.grbCuenteContable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCuenteContable.SuspendLayout()
        CType(Me.grbSubsidiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbSubsidiario.SuspendLayout()
        CType(Me.grbFechaAdquisicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFechaAdquisicion.SuspendLayout()
        CType(Me.grbActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbActivo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelGuia
        '
        Me.PanelGuia.Controls.Add(Me.GrdLista)
        Me.PanelGuia.Controls.Add(Me.ButtonBar1)
        Me.PanelGuia.Controls.Add(Me.Panel2)
        Me.PanelGuia.Controls.Add(Me.Panel1)
        Me.PanelGuia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGuia.Location = New System.Drawing.Point(0, 0)
        Me.PanelGuia.Name = "PanelGuia"
        Me.PanelGuia.Size = New System.Drawing.Size(904, 677)
        Me.PanelGuia.TabIndex = 0
        '
        'GrdLista
        '
        Me.GrdLista.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdLista.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GrdLista_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" & _
    "Table></GridEXLayoutData>"
        Me.GrdLista.DesignTimeLayout = GrdLista_DesignTimeLayout
        Me.GrdLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdLista.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GrdLista.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdLista.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GrdLista.GroupByBoxVisible = False
        Me.GrdLista.Location = New System.Drawing.Point(205, 27)
        Me.GrdLista.Name = "GrdLista"
        Me.GrdLista.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdLista.RecordNavigator = True
        Me.GrdLista.Size = New System.Drawing.Size(568, 650)
        Me.GrdLista.TabIndex = 130
        Me.GrdLista.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'ButtonBar1
        '
        Me.ButtonBar1.Dock = System.Windows.Forms.DockStyle.Right
        ButtonBar1_Group_0.ImageKey = "Opciones.jpg"
        ButtonBar1_Item_0_0.Image = CType(resources.GetObject("ButtonBar1_Item_0_0.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_0.Key = "ADICIONAR"
        ButtonBar1_Item_0_0.Text = "Adicionar"
        ButtonBar1_Item_0_1.Image = CType(resources.GetObject("ButtonBar1_Item_0_1.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_1.Key = "MODIFICAR"
        ButtonBar1_Item_0_1.Text = "Modificar"
        ButtonBar1_Item_0_2.Image = CType(resources.GetObject("ButtonBar1_Item_0_2.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_2.Key = "ELIMINAR"
        ButtonBar1_Item_0_2.Text = "Eliminar"
        ButtonBar1_Item_0_3.Image = CType(resources.GetObject("ButtonBar1_Item_0_3.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_3.Key = "VARACTFIJO"
        ButtonBar1_Item_0_3.Text = "Variaciones del Activo Fijo"
        ButtonBar1_Item_0_4.Image = CType(resources.GetObject("ButtonBar1_Item_0_4.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_4.Key = "CALCDEPRE"
        ButtonBar1_Item_0_4.Text = "Calculo Depreciacion"
        ButtonBar1_Item_0_5.Image = CType(resources.GetObject("ButtonBar1_Item_0_5.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_5.Key = "HISTORICO"
        ButtonBar1_Item_0_5.Text = "Activo Fijo a Valores Historicos"
        ButtonBar1_Item_0_6.Image = CType(resources.GetObject("ButtonBar1_Item_0_6.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_6.Key = "MODFECHA"
        ButtonBar1_Item_0_6.Text = "Modificar Fechas Activo Fijo"
        ButtonBar1_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {ButtonBar1_Item_0_0, ButtonBar1_Item_0_1, ButtonBar1_Item_0_2, ButtonBar1_Item_0_3, ButtonBar1_Item_0_4, ButtonBar1_Item_0_5, ButtonBar1_Item_0_6})
        ButtonBar1_Group_0.Key = "Group1"
        ButtonBar1_Group_0.Text = "Opciones"
        Me.ButtonBar1.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar1_Group_0})
        Me.ButtonBar1.HeaderGroupVisible = False
        Me.ButtonBar1.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.ButtonBar1.LargeImageSize = New System.Drawing.Size(25, 25)
        Me.ButtonBar1.Location = New System.Drawing.Point(773, 27)
        Me.ButtonBar1.Name = "ButtonBar1"
        Me.ButtonBar1.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.ButtonBar1.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.ButtonBar1.ShadowOnHover = True
        Me.ButtonBar1.Size = New System.Drawing.Size(131, 650)
        Me.ButtonBar1.SmallImageSize = New System.Drawing.Size(25, 25)
        Me.ButtonBar1.TabIndex = 129
        Me.ButtonBar1.Text = "Opciones"
        Me.ButtonBar1.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(205, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(699, 27)
        Me.Panel2.TabIndex = 125
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbtContraer)
        Me.Panel4.Controls.Add(Me.rbtExpandir)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(412, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(287, 27)
        Me.Panel4.TabIndex = 35
        Me.Panel4.Visible = False
        '
        'rbtContraer
        '
        Me.rbtContraer.AutoSize = True
        Me.rbtContraer.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtContraer.ForeColor = System.Drawing.Color.Black
        Me.rbtContraer.Location = New System.Drawing.Point(6, 4)
        Me.rbtContraer.Name = "rbtContraer"
        Me.rbtContraer.Size = New System.Drawing.Size(130, 20)
        Me.rbtContraer.TabIndex = 89
        Me.rbtContraer.Text = "Contraer Consulta"
        Me.rbtContraer.UseVisualStyleBackColor = True
        '
        'rbtExpandir
        '
        Me.rbtExpandir.AutoSize = True
        Me.rbtExpandir.Checked = True
        Me.rbtExpandir.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtExpandir.ForeColor = System.Drawing.Color.Black
        Me.rbtExpandir.Location = New System.Drawing.Point(143, 4)
        Me.rbtExpandir.Name = "rbtExpandir"
        Me.rbtExpandir.Size = New System.Drawing.Size(130, 20)
        Me.rbtExpandir.TabIndex = 90
        Me.rbtExpandir.TabStop = True
        Me.rbtExpandir.Text = "Expandir Consulta"
        Me.rbtExpandir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.grbImportacion)
        Me.Panel1.Controls.Add(Me.grbAreaFamilia)
        Me.Panel1.Controls.Add(Me.grbCuenteContable)
        Me.Panel1.Controls.Add(Me.grbSubsidiario)
        Me.Panel1.Controls.Add(Me.grbFechaAdquisicion)
        Me.Panel1.Controls.Add(Me.grbActivo)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.optnum_imp)
        Me.Panel1.Controls.Add(Me.OptAMN)
        Me.Panel1.Controls.Add(Me.optCuentaContable)
        Me.Panel1.Controls.Add(Me.opt_Familia)
        Me.Panel1.Controls.Add(Me.optFecAdquisicion)
        Me.Panel1.Controls.Add(Me.optActivoFijo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 677)
        Me.Panel1.TabIndex = 1
        '
        'grbImportacion
        '
        Me.grbImportacion.Controls.Add(Me.txtnum_imp)
        Me.grbImportacion.Controls.Add(Me.Label7)
        Me.grbImportacion.ForeColor = System.Drawing.Color.White
        Me.grbImportacion.Location = New System.Drawing.Point(4, 345)
        Me.grbImportacion.Name = "grbImportacion"
        Me.grbImportacion.Size = New System.Drawing.Size(196, 60)
        Me.grbImportacion.TabIndex = 160
        Me.grbImportacion.Visible = False
        Me.grbImportacion.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtnum_imp
        '
        Me.txtnum_imp.AcceptsReturn = True
        Me.txtnum_imp.BackColor = System.Drawing.SystemColors.Window
        Me.txtnum_imp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnum_imp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtnum_imp.Location = New System.Drawing.Point(6, 32)
        Me.txtnum_imp.MaxLength = 0
        Me.txtnum_imp.Name = "txtnum_imp"
        Me.txtnum_imp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnum_imp.Size = New System.Drawing.Size(183, 20)
        Me.txtnum_imp.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(125, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Número Importación"
        '
        'grbAreaFamilia
        '
        Me.grbAreaFamilia.Controls.Add(Me.txtDes_Familia)
        Me.grbAreaFamilia.Controls.Add(Me.txtCod_Familia)
        Me.grbAreaFamilia.Controls.Add(Me.txtDesArea)
        Me.grbAreaFamilia.Controls.Add(Me.TxtCodArea)
        Me.grbAreaFamilia.Controls.Add(Me.Label6)
        Me.grbAreaFamilia.Controls.Add(Me.Label5)
        Me.grbAreaFamilia.ForeColor = System.Drawing.Color.White
        Me.grbAreaFamilia.Location = New System.Drawing.Point(4, 345)
        Me.grbAreaFamilia.Name = "grbAreaFamilia"
        Me.grbAreaFamilia.Size = New System.Drawing.Size(196, 107)
        Me.grbAreaFamilia.TabIndex = 159
        Me.grbAreaFamilia.Visible = False
        Me.grbAreaFamilia.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtDes_Familia
        '
        Me.txtDes_Familia.AcceptsReturn = True
        Me.txtDes_Familia.BackColor = System.Drawing.SystemColors.Window
        Me.txtDes_Familia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_Familia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDes_Familia.Location = New System.Drawing.Point(53, 76)
        Me.txtDes_Familia.MaxLength = 0
        Me.txtDes_Familia.Name = "txtDes_Familia"
        Me.txtDes_Familia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_Familia.Size = New System.Drawing.Size(137, 20)
        Me.txtDes_Familia.TabIndex = 76
        '
        'txtCod_Familia
        '
        Me.txtCod_Familia.AcceptsReturn = True
        Me.txtCod_Familia.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_Familia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Familia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCod_Familia.Location = New System.Drawing.Point(6, 76)
        Me.txtCod_Familia.MaxLength = 0
        Me.txtCod_Familia.Name = "txtCod_Familia"
        Me.txtCod_Familia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Familia.Size = New System.Drawing.Size(45, 20)
        Me.txtCod_Familia.TabIndex = 75
        '
        'txtDesArea
        '
        Me.txtDesArea.AcceptsReturn = True
        Me.txtDesArea.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesArea.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesArea.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDesArea.Location = New System.Drawing.Point(53, 32)
        Me.txtDesArea.MaxLength = 0
        Me.txtDesArea.Name = "txtDesArea"
        Me.txtDesArea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDesArea.Size = New System.Drawing.Size(137, 20)
        Me.txtDesArea.TabIndex = 73
        '
        'TxtCodArea
        '
        Me.TxtCodArea.AcceptsReturn = True
        Me.TxtCodArea.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCodArea.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodArea.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCodArea.Location = New System.Drawing.Point(6, 32)
        Me.TxtCodArea.MaxLength = 0
        Me.TxtCodArea.Name = "TxtCodArea"
        Me.TxtCodArea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCodArea.Size = New System.Drawing.Size(45, 20)
        Me.TxtCodArea.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Familia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Área"
        '
        'grbCuenteContable
        '
        Me.grbCuenteContable.Controls.Add(Me.TxtDes_CtaCont)
        Me.grbCuenteContable.Controls.Add(Me.TxtCod_CtaCont)
        Me.grbCuenteContable.Controls.Add(Me.Label4)
        Me.grbCuenteContable.ForeColor = System.Drawing.Color.White
        Me.grbCuenteContable.Location = New System.Drawing.Point(4, 345)
        Me.grbCuenteContable.Name = "grbCuenteContable"
        Me.grbCuenteContable.Size = New System.Drawing.Size(196, 60)
        Me.grbCuenteContable.TabIndex = 158
        Me.grbCuenteContable.Visible = False
        Me.grbCuenteContable.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'TxtDes_CtaCont
        '
        Me.TxtDes_CtaCont.AcceptsReturn = True
        Me.TxtDes_CtaCont.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDes_CtaCont.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDes_CtaCont.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtDes_CtaCont.Location = New System.Drawing.Point(53, 32)
        Me.TxtDes_CtaCont.MaxLength = 0
        Me.TxtDes_CtaCont.Name = "TxtDes_CtaCont"
        Me.TxtDes_CtaCont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDes_CtaCont.Size = New System.Drawing.Size(137, 20)
        Me.TxtDes_CtaCont.TabIndex = 73
        '
        'TxtCod_CtaCont
        '
        Me.TxtCod_CtaCont.AcceptsReturn = True
        Me.TxtCod_CtaCont.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCod_CtaCont.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCod_CtaCont.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCod_CtaCont.Location = New System.Drawing.Point(6, 32)
        Me.TxtCod_CtaCont.MaxLength = 0
        Me.TxtCod_CtaCont.Name = "TxtCod_CtaCont"
        Me.TxtCod_CtaCont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCod_CtaCont.Size = New System.Drawing.Size(45, 20)
        Me.TxtCod_CtaCont.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cuenta Contable"
        '
        'grbSubsidiario
        '
        Me.grbSubsidiario.Controls.Add(Me.TxtDes_TipoDiario)
        Me.grbSubsidiario.Controls.Add(Me.TxtMesReg)
        Me.grbSubsidiario.Controls.Add(Me.TxtAnioReg)
        Me.grbSubsidiario.Controls.Add(Me.TxtNumReg)
        Me.grbSubsidiario.Controls.Add(Me.TxtCod_TipoDiario)
        Me.grbSubsidiario.Controls.Add(Me.Label14)
        Me.grbSubsidiario.Controls.Add(Me.Label13)
        Me.grbSubsidiario.ForeColor = System.Drawing.Color.White
        Me.grbSubsidiario.Location = New System.Drawing.Point(4, 345)
        Me.grbSubsidiario.Name = "grbSubsidiario"
        Me.grbSubsidiario.Size = New System.Drawing.Size(196, 110)
        Me.grbSubsidiario.TabIndex = 157
        Me.grbSubsidiario.Visible = False
        Me.grbSubsidiario.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'TxtDes_TipoDiario
        '
        Me.TxtDes_TipoDiario.AcceptsReturn = True
        Me.TxtDes_TipoDiario.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDes_TipoDiario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDes_TipoDiario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtDes_TipoDiario.Location = New System.Drawing.Point(64, 32)
        Me.TxtDes_TipoDiario.MaxLength = 0
        Me.TxtDes_TipoDiario.Name = "TxtDes_TipoDiario"
        Me.TxtDes_TipoDiario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDes_TipoDiario.Size = New System.Drawing.Size(126, 20)
        Me.TxtDes_TipoDiario.TabIndex = 57
        '
        'TxtMesReg
        '
        Me.TxtMesReg.AcceptsReturn = True
        Me.TxtMesReg.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMesReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMesReg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtMesReg.Location = New System.Drawing.Point(64, 81)
        Me.TxtMesReg.MaxLength = 0
        Me.TxtMesReg.Name = "TxtMesReg"
        Me.TxtMesReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMesReg.Size = New System.Drawing.Size(29, 20)
        Me.TxtMesReg.TabIndex = 68
        '
        'TxtAnioReg
        '
        Me.TxtAnioReg.AcceptsReturn = True
        Me.TxtAnioReg.BackColor = System.Drawing.SystemColors.Window
        Me.TxtAnioReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAnioReg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtAnioReg.Location = New System.Drawing.Point(7, 81)
        Me.TxtAnioReg.MaxLength = 0
        Me.TxtAnioReg.Name = "TxtAnioReg"
        Me.TxtAnioReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtAnioReg.Size = New System.Drawing.Size(55, 20)
        Me.TxtAnioReg.TabIndex = 69
        '
        'TxtNumReg
        '
        Me.TxtNumReg.AcceptsReturn = True
        Me.TxtNumReg.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNumReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNumReg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNumReg.Location = New System.Drawing.Point(95, 81)
        Me.TxtNumReg.MaxLength = 0
        Me.TxtNumReg.Name = "TxtNumReg"
        Me.TxtNumReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNumReg.Size = New System.Drawing.Size(95, 20)
        Me.TxtNumReg.TabIndex = 70
        '
        'TxtCod_TipoDiario
        '
        Me.TxtCod_TipoDiario.AcceptsReturn = True
        Me.TxtCod_TipoDiario.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCod_TipoDiario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCod_TipoDiario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCod_TipoDiario.Location = New System.Drawing.Point(7, 32)
        Me.TxtCod_TipoDiario.MaxLength = 0
        Me.TxtCod_TipoDiario.Name = "TxtCod_TipoDiario"
        Me.TxtCod_TipoDiario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCod_TipoDiario.Size = New System.Drawing.Size(55, 20)
        Me.TxtCod_TipoDiario.TabIndex = 58
        Me.TxtCod_TipoDiario.Text = "30"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(8, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(168, 13)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Año/Mes/Num.  de  Registro"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(8, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Tipo Diario"
        '
        'grbFechaAdquisicion
        '
        Me.grbFechaAdquisicion.Controls.Add(Me.dtpFecha)
        Me.grbFechaAdquisicion.Controls.Add(Me.Label12)
        Me.grbFechaAdquisicion.ForeColor = System.Drawing.Color.White
        Me.grbFechaAdquisicion.Location = New System.Drawing.Point(4, 345)
        Me.grbFechaAdquisicion.Name = "grbFechaAdquisicion"
        Me.grbFechaAdquisicion.Size = New System.Drawing.Size(196, 60)
        Me.grbFechaAdquisicion.TabIndex = 156
        Me.grbFechaAdquisicion.Visible = False
        Me.grbFechaAdquisicion.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "yyyy"
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(27, 34)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecha.TabIndex = 64
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Fecha Adquisición"
        '
        'grbActivo
        '
        Me.grbActivo.Controls.Add(Me.Txt_DesActivo)
        Me.grbActivo.Controls.Add(Me.txtCod_Activo)
        Me.grbActivo.Controls.Add(Me.Label11)
        Me.grbActivo.ForeColor = System.Drawing.Color.White
        Me.grbActivo.Location = New System.Drawing.Point(4, 345)
        Me.grbActivo.Name = "grbActivo"
        Me.grbActivo.Size = New System.Drawing.Size(196, 60)
        Me.grbActivo.TabIndex = 155
        Me.grbActivo.Visible = False
        Me.grbActivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'Txt_DesActivo
        '
        Me.Txt_DesActivo.AcceptsReturn = True
        Me.Txt_DesActivo.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_DesActivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_DesActivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_DesActivo.Location = New System.Drawing.Point(53, 32)
        Me.Txt_DesActivo.MaxLength = 0
        Me.Txt_DesActivo.Name = "Txt_DesActivo"
        Me.Txt_DesActivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_DesActivo.Size = New System.Drawing.Size(137, 20)
        Me.Txt_DesActivo.TabIndex = 73
        '
        'txtCod_Activo
        '
        Me.txtCod_Activo.AcceptsReturn = True
        Me.txtCod_Activo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_Activo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Activo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCod_Activo.Location = New System.Drawing.Point(6, 32)
        Me.txtCod_Activo.MaxLength = 0
        Me.txtCod_Activo.Name = "txtCod_Activo"
        Me.txtCod_Activo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Activo.Size = New System.Drawing.Size(45, 20)
        Me.txtCod_Activo.TabIndex = 72
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(8, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Activo"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.GE_Costos.My.Resources.Resources.search01_16X16
        Me.BtnBuscar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnBuscar.Location = New System.Drawing.Point(15, 492)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnBuscar.Size = New System.Drawing.Size(182, 29)
        Me.BtnBuscar.TabIndex = 16
        Me.BtnBuscar.Text = "Realizar Búsqueda"
        Me.BtnBuscar.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Empty
        Me.BtnBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GE_Costos.My.Resources.Resources.search_02_128x128
        Me.PictureBox1.Location = New System.Drawing.Point(4, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 151
        Me.PictureBox1.TabStop = False
        '
        'optnum_imp
        '
        Me.optnum_imp.AutoSize = True
        Me.optnum_imp.BackColor = System.Drawing.Color.Transparent
        Me.optnum_imp.Cursor = System.Windows.Forms.Cursors.Default
        Me.optnum_imp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.optnum_imp.ForeColor = System.Drawing.Color.Black
        Me.optnum_imp.Image = CType(resources.GetObject("optnum_imp.Image"), System.Drawing.Image)
        Me.optnum_imp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optnum_imp.Location = New System.Drawing.Point(9, 315)
        Me.optnum_imp.Name = "optnum_imp"
        Me.optnum_imp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optnum_imp.Size = New System.Drawing.Size(185, 19)
        Me.optnum_imp.TabIndex = 6
        Me.optnum_imp.Tag = "6"
        Me.optnum_imp.Text = "       Por Número Importación"
        Me.optnum_imp.UseVisualStyleBackColor = False
        '
        'OptAMN
        '
        Me.OptAMN.AutoSize = True
        Me.OptAMN.BackColor = System.Drawing.Color.Transparent
        Me.OptAMN.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptAMN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.OptAMN.ForeColor = System.Drawing.Color.Black
        Me.OptAMN.Image = CType(resources.GetObject("OptAMN.Image"), System.Drawing.Image)
        Me.OptAMN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OptAMN.Location = New System.Drawing.Point(9, 288)
        Me.OptAMN.Name = "OptAMN"
        Me.OptAMN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptAMN.Size = New System.Drawing.Size(179, 19)
        Me.OptAMN.TabIndex = 4
        Me.OptAMN.Tag = "5"
        Me.OptAMN.Text = "       SubDiario/ Nro Registro"
        Me.OptAMN.UseVisualStyleBackColor = False
        '
        'optCuentaContable
        '
        Me.optCuentaContable.AutoSize = True
        Me.optCuentaContable.BackColor = System.Drawing.Color.Transparent
        Me.optCuentaContable.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCuentaContable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.optCuentaContable.ForeColor = System.Drawing.Color.Black
        Me.optCuentaContable.Image = CType(resources.GetObject("optCuentaContable.Image"), System.Drawing.Image)
        Me.optCuentaContable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optCuentaContable.Location = New System.Drawing.Point(9, 234)
        Me.optCuentaContable.Name = "optCuentaContable"
        Me.optCuentaContable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCuentaContable.Size = New System.Drawing.Size(159, 19)
        Me.optCuentaContable.TabIndex = 3
        Me.optCuentaContable.Tag = "3"
        Me.optCuentaContable.Text = "       Por Cuenta Contable"
        Me.optCuentaContable.UseVisualStyleBackColor = False
        '
        'opt_Familia
        '
        Me.opt_Familia.AutoSize = True
        Me.opt_Familia.BackColor = System.Drawing.Color.Transparent
        Me.opt_Familia.Cursor = System.Windows.Forms.Cursors.Default
        Me.opt_Familia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.opt_Familia.ForeColor = System.Drawing.Color.Black
        Me.opt_Familia.Image = CType(resources.GetObject("opt_Familia.Image"), System.Drawing.Image)
        Me.opt_Familia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.opt_Familia.Location = New System.Drawing.Point(9, 261)
        Me.opt_Familia.Name = "opt_Familia"
        Me.opt_Familia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.opt_Familia.Size = New System.Drawing.Size(175, 19)
        Me.opt_Familia.TabIndex = 5
        Me.opt_Familia.Tag = "4"
        Me.opt_Familia.Text = "       Por Area Familia Equipo"
        Me.opt_Familia.UseVisualStyleBackColor = False
        '
        'optFecAdquisicion
        '
        Me.optFecAdquisicion.AutoSize = True
        Me.optFecAdquisicion.BackColor = System.Drawing.Color.Transparent
        Me.optFecAdquisicion.Checked = True
        Me.optFecAdquisicion.Cursor = System.Windows.Forms.Cursors.Default
        Me.optFecAdquisicion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.optFecAdquisicion.ForeColor = System.Drawing.Color.Black
        Me.optFecAdquisicion.Image = CType(resources.GetObject("optFecAdquisicion.Image"), System.Drawing.Image)
        Me.optFecAdquisicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optFecAdquisicion.Location = New System.Drawing.Point(9, 207)
        Me.optFecAdquisicion.Name = "optFecAdquisicion"
        Me.optFecAdquisicion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optFecAdquisicion.Size = New System.Drawing.Size(183, 19)
        Me.optFecAdquisicion.TabIndex = 2
        Me.optFecAdquisicion.TabStop = True
        Me.optFecAdquisicion.Tag = "2"
        Me.optFecAdquisicion.Text = "       Por Fecha de Adquisición"
        Me.optFecAdquisicion.UseVisualStyleBackColor = False
        '
        'optActivoFijo
        '
        Me.optActivoFijo.AutoSize = True
        Me.optActivoFijo.BackColor = System.Drawing.Color.Transparent
        Me.optActivoFijo.Cursor = System.Windows.Forms.Cursors.Default
        Me.optActivoFijo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.optActivoFijo.ForeColor = System.Drawing.Color.Black
        Me.optActivoFijo.Image = CType(resources.GetObject("optActivoFijo.Image"), System.Drawing.Image)
        Me.optActivoFijo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optActivoFijo.Location = New System.Drawing.Point(9, 180)
        Me.optActivoFijo.Name = "optActivoFijo"
        Me.optActivoFijo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optActivoFijo.Size = New System.Drawing.Size(104, 19)
        Me.optActivoFijo.TabIndex = 1
        Me.optActivoFijo.Tag = "1"
        Me.optActivoFijo.Text = "       Por Activo"
        Me.optActivoFijo.UseVisualStyleBackColor = False
        '
        'FrmMantActivoFijo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 677)
        Me.Controls.Add(Me.PanelGuia)
        Me.Name = "FrmMantActivoFijo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de Activo Fijo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelGuia.ResumeLayout(False)
        CType(Me.GrdLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grbImportacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbImportacion.ResumeLayout(False)
        Me.grbImportacion.PerformLayout()
        CType(Me.grbAreaFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbAreaFamilia.ResumeLayout(False)
        Me.grbAreaFamilia.PerformLayout()
        CType(Me.grbCuenteContable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCuenteContable.ResumeLayout(False)
        Me.grbCuenteContable.PerformLayout()
        CType(Me.grbSubsidiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbSubsidiario.ResumeLayout(False)
        Me.grbSubsidiario.PerformLayout()
        CType(Me.grbFechaAdquisicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFechaAdquisicion.ResumeLayout(False)
        Me.grbFechaAdquisicion.PerformLayout()
        CType(Me.grbActivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbActivo.ResumeLayout(False)
        Me.grbActivo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelGuia As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grbSubsidiario As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents TxtDes_TipoDiario As System.Windows.Forms.TextBox
    Public WithEvents TxtMesReg As System.Windows.Forms.TextBox
    Public WithEvents TxtAnioReg As System.Windows.Forms.TextBox
    Public WithEvents TxtNumReg As System.Windows.Forms.TextBox
    Public WithEvents TxtCod_TipoDiario As System.Windows.Forms.TextBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents grbFechaAdquisicion As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grbActivo As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Txt_DesActivo As System.Windows.Forms.TextBox
    Public WithEvents txtCod_Activo As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As Janus.Windows.EditControls.UIButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents optnum_imp As System.Windows.Forms.RadioButton
    Public WithEvents OptAMN As System.Windows.Forms.RadioButton
    Public WithEvents optCuentaContable As System.Windows.Forms.RadioButton
    Public WithEvents opt_Familia As System.Windows.Forms.RadioButton
    Public WithEvents optFecAdquisicion As System.Windows.Forms.RadioButton
    Public WithEvents optActivoFijo As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rbtContraer As System.Windows.Forms.RadioButton
    Friend WithEvents rbtExpandir As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonBar1 As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents GrdLista As Janus.Windows.GridEX.GridEX
    Friend WithEvents grbImportacion As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents txtnum_imp As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grbAreaFamilia As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents txtDes_Familia As System.Windows.Forms.TextBox
    Public WithEvents txtCod_Familia As System.Windows.Forms.TextBox
    Public WithEvents txtDesArea As System.Windows.Forms.TextBox
    Public WithEvents TxtCodArea As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grbCuenteContable As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents TxtDes_CtaCont As System.Windows.Forms.TextBox
    Public WithEvents TxtCod_CtaCont As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
End Class
