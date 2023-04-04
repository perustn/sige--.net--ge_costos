<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGuiasAsociadas_AlmacenesPrimarios_Prorrateo
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.BtnRevertir = New Janus.Windows.EditControls.UIButton()
        Me.BtnFinalizar = New Janus.Windows.EditControls.UIButton()
        Me.GrdDatos = New Janus.Windows.GridEX.GridEX()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtNroCorrelativo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(820, 27)
        Me.Panel4.TabIndex = 255
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
        Me.TxtNroCorrelativo.Location = New System.Drawing.Point(127, 3)
        Me.TxtNroCorrelativo.MaxLength = 0
        Me.TxtNroCorrelativo.Name = "TxtNroCorrelativo"
        Me.TxtNroCorrelativo.ReadOnly = True
        Me.TxtNroCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroCorrelativo.Size = New System.Drawing.Size(96, 20)
        Me.TxtNroCorrelativo.TabIndex = 121
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 303)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(820, 30)
        Me.Panel2.TabIndex = 256
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.BtnRevertir)
        Me.Panel11.Controls.Add(Me.BtnFinalizar)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(251, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(569, 30)
        Me.Panel11.TabIndex = 0
        '
        'BtnRevertir
        '
        Me.BtnRevertir.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnRevertir.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnRevertir.Location = New System.Drawing.Point(168, 3)
        Me.BtnRevertir.Name = "BtnRevertir"
        Me.BtnRevertir.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnRevertir.Size = New System.Drawing.Size(149, 24)
        Me.BtnRevertir.TabIndex = 6
        Me.BtnRevertir.Text = "&Revertir Prorrateo"
        Me.BtnRevertir.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnFinalizar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnFinalizar.Location = New System.Drawing.Point(3, 3)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnFinalizar.Size = New System.Drawing.Size(149, 24)
        Me.BtnFinalizar.TabIndex = 5
        Me.BtnFinalizar.Text = "&Finalizar Prorrateo"
        Me.BtnFinalizar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'GrdDatos
        '
        Me.GrdDatos.AllowColumnDrag = False
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
        Me.GrdDatos.Location = New System.Drawing.Point(0, 27)
        Me.GrdDatos.Name = "GrdDatos"
        Me.GrdDatos.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdDatos.RecordNavigator = True
        Me.GrdDatos.Size = New System.Drawing.Size(820, 276)
        Me.GrdDatos.TabIndex = 257
        Me.GrdDatos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'FrmGuiasAsociadas_AlmacenesPrimarios_Prorrateo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 333)
        Me.Controls.Add(Me.GrdDatos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGuiasAsociadas_AlmacenesPrimarios_Prorrateo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle Factura"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.GrdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtNroCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents BtnRevertir As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnFinalizar As Janus.Windows.EditControls.UIButton
    Friend WithEvents GrdDatos As Janus.Windows.GridEX.GridEX
End Class
