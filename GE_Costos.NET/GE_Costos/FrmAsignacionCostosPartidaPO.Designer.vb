<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignacionCostosPartidaPO
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
        Dim BarraOpciones_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BarraOpciones_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignacionCostosPartidaPO))
        Dim GrdLista_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.PanelGuia = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtPartida = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New Janus.Windows.EditControls.UIButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbtContraer = New System.Windows.Forms.RadioButton()
        Me.rbtExpandir = New System.Windows.Forms.RadioButton()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.GrdLista = New Janus.Windows.GridEX.GridEX()
        Me.PanelGuia.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelGuia
        '
        Me.PanelGuia.Controls.Add(Me.GrdLista)
        Me.PanelGuia.Controls.Add(Me.BarraOpciones)
        Me.PanelGuia.Controls.Add(Me.Panel2)
        Me.PanelGuia.Controls.Add(Me.Panel1)
        Me.PanelGuia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGuia.Location = New System.Drawing.Point(0, 0)
        Me.PanelGuia.Name = "PanelGuia"
        Me.PanelGuia.Size = New System.Drawing.Size(1113, 691)
        Me.PanelGuia.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TxtPartida)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 691)
        Me.Panel1.TabIndex = 2
        '
        'TxtPartida
        '
        Me.TxtPartida.AcceptsReturn = True
        Me.TxtPartida.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPartida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPartida.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtPartida.Location = New System.Drawing.Point(8, 230)
        Me.TxtPartida.MaxLength = 0
        Me.TxtPartida.Name = "TxtPartida"
        Me.TxtPartida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPartida.Size = New System.Drawing.Size(165, 20)
        Me.TxtPartida.TabIndex = 62
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.GE_Costos.My.Resources.Resources.search01_16X16
        Me.BtnBuscar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnBuscar.Location = New System.Drawing.Point(8, 290)
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
        Me.PictureBox1.Location = New System.Drawing.Point(5, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 151
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(6, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "PARTIDA"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(199, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(914, 27)
        Me.Panel2.TabIndex = 126
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbtContraer)
        Me.Panel4.Controls.Add(Me.rbtExpandir)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(627, 0)
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
        'BarraOpciones
        '
        Me.BarraOpciones.Dock = System.Windows.Forms.DockStyle.Top
        BarraOpciones_Item_0_0.Image = CType(resources.GetObject("BarraOpciones_Item_0_0.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_0.Key = "IMPRIMIR"
        BarraOpciones_Item_0_0.Text = "Exportar Datos"
        BarraOpciones_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BarraOpciones_Item_0_0})
        BarraOpciones_Group_0.Key = "Group1"
        BarraOpciones_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        BarraOpciones_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.BarraOpciones.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {BarraOpciones_Group_0})
        Me.BarraOpciones.HeaderGroupVisible = False
        Me.BarraOpciones.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.BarraOpciones.Location = New System.Drawing.Point(199, 27)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(914, 25)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 250
        Me.BarraOpciones.Text = "ButtonBar2"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'GrdLista
        '
        Me.GrdLista.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdLista.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GrdLista_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" &
    "Table></GridEXLayoutData>"
        Me.GrdLista.DesignTimeLayout = GrdLista_DesignTimeLayout
        Me.GrdLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdLista.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GrdLista.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdLista.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GrdLista.GroupByBoxVisible = False
        Me.GrdLista.Location = New System.Drawing.Point(199, 52)
        Me.GrdLista.Name = "GrdLista"
        Me.GrdLista.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdLista.RecordNavigator = True
        Me.GrdLista.Size = New System.Drawing.Size(914, 639)
        Me.GrdLista.TabIndex = 251
        Me.GrdLista.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'FrmAsignacionCostosPartidaPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 691)
        Me.Controls.Add(Me.PanelGuia)
        Me.Name = "FrmAsignacionCostosPartidaPO"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignación de Costos Partida po PO/Saldos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelGuia.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelGuia As Panel
    Friend WithEvents Panel1 As Panel
    Public WithEvents TxtPartida As TextBox
    Friend WithEvents BtnBuscar As Janus.Windows.EditControls.UIButton
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rbtContraer As RadioButton
    Friend WithEvents rbtExpandir As RadioButton
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents GrdLista As Janus.Windows.GridEX.GridEX
End Class
