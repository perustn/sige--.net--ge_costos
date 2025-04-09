<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCierreAlmacenesPrimarios_ErrSecuencia
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
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.Panel2.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 16)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnImprimir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 340)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(785, 46)
        Me.Panel2.TabIndex = 1
        '
        'GridEX1
        '
        GridEX1_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><DataMember /><GroupCondition /><HeaderLines>2</Head" &
    "erLines></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 16)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(785, 324)
        Me.GridEX1.TabIndex = 2
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(679, 6)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnImprimir.Size = New System.Drawing.Size(94, 32)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'frmCierreAlmacenesPrimarios_ErrSecuencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 386)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCierreAlmacenesPrimarios_ErrSecuencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Secuencia Fechas"
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
End Class
