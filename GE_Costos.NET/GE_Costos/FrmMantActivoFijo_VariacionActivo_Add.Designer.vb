<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantActivoFijo_VariacionActivo_Add
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
        Me.fraDatos = New System.Windows.Forms.Panel()
        Me.txtTipo_Cambio = New System.Windows.Forms.TextBox()
        Me.TxtDes_CtaCont = New System.Windows.Forms.TextBox()
        Me.TxtCod_CtaCont = New System.Windows.Forms.TextBox()
        Me.TxtCod_Moneda = New System.Windows.Forms.TextBox()
        Me.TxtDes_TipVariacion = New System.Windows.Forms.TextBox()
        Me.TxtCod_TipVariacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.DTPFec_Operacion = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOtro_Tipo_Cambio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtImpSoles = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtImpDolares = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtImpOtros = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDes_TipoDiario = New System.Windows.Forms.TextBox()
        Me.TxtCod_TipoDiario = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtAnioReg = New System.Windows.Forms.TextBox()
        Me.TxtMesReg = New System.Windows.Forms.TextBox()
        Me.TxtNumReg = New System.Windows.Forms.TextBox()
        Me.TxtGlosa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtDes_Moneda = New System.Windows.Forms.TextBox()
        Me.Panel5.SuspendLayout()
        Me.fraDatos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Panel5.Size = New System.Drawing.Size(659, 27)
        Me.Panel5.TabIndex = 253
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
        Me.Label3.Size = New System.Drawing.Size(45, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "ACTIVO"
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
        'fraDatos
        '
        Me.fraDatos.BackColor = System.Drawing.Color.White
        Me.fraDatos.Controls.Add(Me.TxtDes_Moneda)
        Me.fraDatos.Controls.Add(Me.TxtGlosa)
        Me.fraDatos.Controls.Add(Me.TxtNumReg)
        Me.fraDatos.Controls.Add(Me.TxtMesReg)
        Me.fraDatos.Controls.Add(Me.TxtAnioReg)
        Me.fraDatos.Controls.Add(Me.TxtDes_TipoDiario)
        Me.fraDatos.Controls.Add(Me.TxtCod_TipoDiario)
        Me.fraDatos.Controls.Add(Me.TxtImpOtros)
        Me.fraDatos.Controls.Add(Me.TxtImpDolares)
        Me.fraDatos.Controls.Add(Me.TxtImpSoles)
        Me.fraDatos.Controls.Add(Me.txtOtro_Tipo_Cambio)
        Me.fraDatos.Controls.Add(Me.DTPFec_Operacion)
        Me.fraDatos.Controls.Add(Me.txtTipo_Cambio)
        Me.fraDatos.Controls.Add(Me.TxtDes_CtaCont)
        Me.fraDatos.Controls.Add(Me.TxtCod_CtaCont)
        Me.fraDatos.Controls.Add(Me.TxtCod_Moneda)
        Me.fraDatos.Controls.Add(Me.TxtDes_TipVariacion)
        Me.fraDatos.Controls.Add(Me.TxtCod_TipVariacion)
        Me.fraDatos.Controls.Add(Me.Label12)
        Me.fraDatos.Controls.Add(Me.Label11)
        Me.fraDatos.Controls.Add(Me.Label8)
        Me.fraDatos.Controls.Add(Me.Label6)
        Me.fraDatos.Controls.Add(Me.Label5)
        Me.fraDatos.Controls.Add(Me.Label2)
        Me.fraDatos.Controls.Add(Me.Label1)
        Me.fraDatos.Controls.Add(Me.Label4)
        Me.fraDatos.Controls.Add(Me.Label10)
        Me.fraDatos.Controls.Add(Me.Label9)
        Me.fraDatos.Controls.Add(Me.Label7)
        Me.fraDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fraDatos.Location = New System.Drawing.Point(0, 27)
        Me.fraDatos.Name = "fraDatos"
        Me.fraDatos.Size = New System.Drawing.Size(659, 296)
        Me.fraDatos.TabIndex = 255
        '
        'txtTipo_Cambio
        '
        Me.txtTipo_Cambio.AcceptsReturn = True
        Me.txtTipo_Cambio.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipo_Cambio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipo_Cambio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTipo_Cambio.Location = New System.Drawing.Point(142, 104)
        Me.txtTipo_Cambio.MaxLength = 100
        Me.txtTipo_Cambio.Name = "txtTipo_Cambio"
        Me.txtTipo_Cambio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipo_Cambio.Size = New System.Drawing.Size(74, 20)
        Me.txtTipo_Cambio.TabIndex = 118
        Me.txtTipo_Cambio.Text = "0"
        Me.txtTipo_Cambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDes_CtaCont
        '
        Me.TxtDes_CtaCont.AcceptsReturn = True
        Me.TxtDes_CtaCont.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDes_CtaCont.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDes_CtaCont.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtDes_CtaCont.Location = New System.Drawing.Point(218, 32)
        Me.TxtDes_CtaCont.MaxLength = 100
        Me.TxtDes_CtaCont.Name = "TxtDes_CtaCont"
        Me.TxtDes_CtaCont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDes_CtaCont.Size = New System.Drawing.Size(424, 20)
        Me.TxtDes_CtaCont.TabIndex = 116
        '
        'TxtCod_CtaCont
        '
        Me.TxtCod_CtaCont.AcceptsReturn = True
        Me.TxtCod_CtaCont.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCod_CtaCont.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCod_CtaCont.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCod_CtaCont.Location = New System.Drawing.Point(142, 32)
        Me.TxtCod_CtaCont.MaxLength = 100
        Me.TxtCod_CtaCont.Name = "TxtCod_CtaCont"
        Me.TxtCod_CtaCont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCod_CtaCont.Size = New System.Drawing.Size(74, 20)
        Me.TxtCod_CtaCont.TabIndex = 115
        '
        'TxtCod_Moneda
        '
        Me.TxtCod_Moneda.AcceptsReturn = True
        Me.TxtCod_Moneda.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCod_Moneda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCod_Moneda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCod_Moneda.Location = New System.Drawing.Point(142, 56)
        Me.TxtCod_Moneda.MaxLength = 100
        Me.TxtCod_Moneda.Name = "TxtCod_Moneda"
        Me.TxtCod_Moneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCod_Moneda.Size = New System.Drawing.Size(74, 20)
        Me.TxtCod_Moneda.TabIndex = 113
        Me.TxtCod_Moneda.Text = "SOL"
        '
        'TxtDes_TipVariacion
        '
        Me.TxtDes_TipVariacion.AcceptsReturn = True
        Me.TxtDes_TipVariacion.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDes_TipVariacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDes_TipVariacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtDes_TipVariacion.Location = New System.Drawing.Point(218, 8)
        Me.TxtDes_TipVariacion.MaxLength = 100
        Me.TxtDes_TipVariacion.Name = "TxtDes_TipVariacion"
        Me.TxtDes_TipVariacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDes_TipVariacion.Size = New System.Drawing.Size(424, 20)
        Me.TxtDes_TipVariacion.TabIndex = 103
        '
        'TxtCod_TipVariacion
        '
        Me.TxtCod_TipVariacion.AcceptsReturn = True
        Me.TxtCod_TipVariacion.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCod_TipVariacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCod_TipVariacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCod_TipVariacion.Location = New System.Drawing.Point(142, 8)
        Me.TxtCod_TipVariacion.MaxLength = 100
        Me.TxtCod_TipVariacion.Name = "TxtCod_TipVariacion"
        Me.TxtCod_TipVariacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCod_TipVariacion.Size = New System.Drawing.Size(74, 20)
        Me.TxtCod_TipVariacion.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(14, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Tipo Cambio ........................"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(14, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Cuenta Contable ..............."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(14, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Moneda .............................."
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
        Me.Label4.Size = New System.Drawing.Size(141, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Tipo Variación ....................."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 323)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(659, 30)
        Me.Panel2.TabIndex = 254
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(452, 0)
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
        'DTPFec_Operacion
        '
        Me.DTPFec_Operacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DTPFec_Operacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFec_Operacion.Location = New System.Drawing.Point(142, 80)
        Me.DTPFec_Operacion.Name = "DTPFec_Operacion"
        Me.DTPFec_Operacion.Size = New System.Drawing.Size(110, 20)
        Me.DTPFec_Operacion.TabIndex = 121
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(14, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(151, 13)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "Fecha Movimiento .................."
        '
        'txtOtro_Tipo_Cambio
        '
        Me.txtOtro_Tipo_Cambio.AcceptsReturn = True
        Me.txtOtro_Tipo_Cambio.BackColor = System.Drawing.SystemColors.Window
        Me.txtOtro_Tipo_Cambio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOtro_Tipo_Cambio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtOtro_Tipo_Cambio.Location = New System.Drawing.Point(369, 104)
        Me.txtOtro_Tipo_Cambio.MaxLength = 100
        Me.txtOtro_Tipo_Cambio.Name = "txtOtro_Tipo_Cambio"
        Me.txtOtro_Tipo_Cambio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOtro_Tipo_Cambio.Size = New System.Drawing.Size(74, 20)
        Me.txtOtro_Tipo_Cambio.TabIndex = 123
        Me.txtOtro_Tipo_Cambio.Text = "0"
        Me.txtOtro_Tipo_Cambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(261, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(164, 13)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Otro Tipo Cambio ........................"
        '
        'TxtImpSoles
        '
        Me.TxtImpSoles.AcceptsReturn = True
        Me.TxtImpSoles.BackColor = System.Drawing.SystemColors.Window
        Me.TxtImpSoles.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtImpSoles.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtImpSoles.Location = New System.Drawing.Point(142, 128)
        Me.TxtImpSoles.MaxLength = 100
        Me.TxtImpSoles.Name = "TxtImpSoles"
        Me.TxtImpSoles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtImpSoles.Size = New System.Drawing.Size(74, 20)
        Me.TxtImpSoles.TabIndex = 125
        Me.TxtImpSoles.Text = "0.00"
        Me.TxtImpSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(14, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(131, 13)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "Imp. Soles ........................"
        '
        'TxtImpDolares
        '
        Me.TxtImpDolares.AcceptsReturn = True
        Me.TxtImpDolares.BackColor = System.Drawing.SystemColors.Window
        Me.TxtImpDolares.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtImpDolares.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtImpDolares.Location = New System.Drawing.Point(369, 128)
        Me.TxtImpDolares.MaxLength = 100
        Me.TxtImpDolares.Name = "TxtImpDolares"
        Me.TxtImpDolares.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtImpDolares.Size = New System.Drawing.Size(74, 20)
        Me.TxtImpDolares.TabIndex = 127
        Me.TxtImpDolares.Text = "0.00"
        Me.TxtImpDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(261, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(141, 13)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Imp. Dolares ........................"
        '
        'TxtImpOtros
        '
        Me.TxtImpOtros.AcceptsReturn = True
        Me.TxtImpOtros.BackColor = System.Drawing.SystemColors.Window
        Me.TxtImpOtros.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtImpOtros.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtImpOtros.Location = New System.Drawing.Point(568, 128)
        Me.TxtImpOtros.MaxLength = 100
        Me.TxtImpOtros.Name = "TxtImpOtros"
        Me.TxtImpOtros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtImpOtros.Size = New System.Drawing.Size(74, 20)
        Me.TxtImpOtros.TabIndex = 129
        Me.TxtImpOtros.Text = "0.00"
        Me.TxtImpOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(460, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(130, 13)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Imp. Otros ........................"
        '
        'TxtDes_TipoDiario
        '
        Me.TxtDes_TipoDiario.AcceptsReturn = True
        Me.TxtDes_TipoDiario.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDes_TipoDiario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDes_TipoDiario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtDes_TipoDiario.Location = New System.Drawing.Point(176, 153)
        Me.TxtDes_TipoDiario.MaxLength = 100
        Me.TxtDes_TipoDiario.Name = "TxtDes_TipoDiario"
        Me.TxtDes_TipoDiario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDes_TipoDiario.Size = New System.Drawing.Size(281, 20)
        Me.TxtDes_TipoDiario.TabIndex = 132
        '
        'TxtCod_TipoDiario
        '
        Me.TxtCod_TipoDiario.AcceptsReturn = True
        Me.TxtCod_TipoDiario.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCod_TipoDiario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCod_TipoDiario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCod_TipoDiario.Location = New System.Drawing.Point(142, 153)
        Me.TxtCod_TipoDiario.MaxLength = 100
        Me.TxtCod_TipoDiario.Name = "TxtCod_TipoDiario"
        Me.TxtCod_TipoDiario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCod_TipoDiario.Size = New System.Drawing.Size(33, 20)
        Me.TxtCod_TipoDiario.TabIndex = 131
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(14, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(122, 32)
        Me.Label11.TabIndex = 130
        Me.Label11.Text = "SubDiario/Año/ Mes/ Nro Registro:"
        '
        'TxtAnioReg
        '
        Me.TxtAnioReg.AcceptsReturn = True
        Me.TxtAnioReg.BackColor = System.Drawing.SystemColors.Window
        Me.TxtAnioReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAnioReg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtAnioReg.Location = New System.Drawing.Point(459, 153)
        Me.TxtAnioReg.MaxLength = 100
        Me.TxtAnioReg.Name = "TxtAnioReg"
        Me.TxtAnioReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtAnioReg.Size = New System.Drawing.Size(56, 20)
        Me.TxtAnioReg.TabIndex = 133
        '
        'TxtMesReg
        '
        Me.TxtMesReg.AcceptsReturn = True
        Me.TxtMesReg.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMesReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMesReg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtMesReg.Location = New System.Drawing.Point(517, 153)
        Me.TxtMesReg.MaxLength = 100
        Me.TxtMesReg.Name = "TxtMesReg"
        Me.TxtMesReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMesReg.Size = New System.Drawing.Size(69, 20)
        Me.TxtMesReg.TabIndex = 134
        '
        'TxtNumReg
        '
        Me.TxtNumReg.AcceptsReturn = True
        Me.TxtNumReg.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNumReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNumReg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtNumReg.Location = New System.Drawing.Point(588, 153)
        Me.TxtNumReg.MaxLength = 100
        Me.TxtNumReg.Name = "TxtNumReg"
        Me.TxtNumReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNumReg.Size = New System.Drawing.Size(54, 20)
        Me.TxtNumReg.TabIndex = 135
        '
        'TxtGlosa
        '
        Me.TxtGlosa.AcceptsReturn = True
        Me.TxtGlosa.BackColor = System.Drawing.SystemColors.Window
        Me.TxtGlosa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGlosa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtGlosa.Location = New System.Drawing.Point(142, 190)
        Me.TxtGlosa.MaxLength = 100
        Me.TxtGlosa.Multiline = True
        Me.TxtGlosa.Name = "TxtGlosa"
        Me.TxtGlosa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtGlosa.Size = New System.Drawing.Size(500, 98)
        Me.TxtGlosa.TabIndex = 137
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(18, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(130, 13)
        Me.Label12.TabIndex = 136
        Me.Label12.Text = "Glosa ..............................."
        '
        'TxtDes_Moneda
        '
        Me.TxtDes_Moneda.AcceptsReturn = True
        Me.TxtDes_Moneda.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDes_Moneda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDes_Moneda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtDes_Moneda.Location = New System.Drawing.Point(218, 56)
        Me.TxtDes_Moneda.MaxLength = 100
        Me.TxtDes_Moneda.Name = "TxtDes_Moneda"
        Me.TxtDes_Moneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDes_Moneda.Size = New System.Drawing.Size(424, 20)
        Me.TxtDes_Moneda.TabIndex = 138
        Me.TxtDes_Moneda.Text = "SOLES"
        '
        'FrmMantActivoFijo_VariacionActivo_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.fraDatos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMantActivoFijo_VariacionActivo_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmMantActivoFijo_VariacionActivo_Add"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.fraDatos.ResumeLayout(False)
        Me.fraDatos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents fraDatos As System.Windows.Forms.Panel
    Public WithEvents txtTipo_Cambio As System.Windows.Forms.TextBox
    Public WithEvents TxtDes_CtaCont As System.Windows.Forms.TextBox
    Public WithEvents TxtCod_CtaCont As System.Windows.Forms.TextBox
    Public WithEvents TxtCod_Moneda As System.Windows.Forms.TextBox
    Public WithEvents TxtDes_TipVariacion As System.Windows.Forms.TextBox
    Public WithEvents TxtCod_TipVariacion As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Public WithEvents TxtGlosa As System.Windows.Forms.TextBox
    Public WithEvents TxtNumReg As System.Windows.Forms.TextBox
    Public WithEvents TxtMesReg As System.Windows.Forms.TextBox
    Public WithEvents TxtAnioReg As System.Windows.Forms.TextBox
    Public WithEvents TxtDes_TipoDiario As System.Windows.Forms.TextBox
    Public WithEvents TxtCod_TipoDiario As System.Windows.Forms.TextBox
    Public WithEvents TxtImpOtros As System.Windows.Forms.TextBox
    Public WithEvents TxtImpDolares As System.Windows.Forms.TextBox
    Public WithEvents TxtImpSoles As System.Windows.Forms.TextBox
    Public WithEvents txtOtro_Tipo_Cambio As System.Windows.Forms.TextBox
    Friend WithEvents DTPFec_Operacion As System.Windows.Forms.DateTimePicker
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents TxtDes_Moneda As System.Windows.Forms.TextBox
End Class
