<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _FrmPrincipal

#Region "Código generado por el Diseñador de Windows Forms "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
    End Sub
    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UiButton2 = New Janus.Windows.EditControls.UIButton()
        Me.UiButton3 = New Janus.Windows.EditControls.UIButton()
        Me.SuspendLayout()
        '
        'UiButton2
        '
        Me.UiButton2.Location = New System.Drawing.Point(36, 25)
        Me.UiButton2.Name = "UiButton2"
        Me.UiButton2.Size = New System.Drawing.Size(193, 38)
        Me.UiButton2.TabIndex = 52
        Me.UiButton2.Text = "ANEXOS CONTABLES"
        '
        'UiButton3
        '
        Me.UiButton3.Location = New System.Drawing.Point(36, 69)
        Me.UiButton3.Name = "UiButton3"
        Me.UiButton3.Size = New System.Drawing.Size(193, 38)
        Me.UiButton3.TabIndex = 53
        Me.UiButton3.Text = "ACTIVO FIJO"
        '
        '_FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(299, 158)
        Me.Controls.Add(Me.UiButton3)
        Me.Controls.Add(Me.UiButton2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(12, 25)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_FrmPrincipal"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiButton2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton3 As Janus.Windows.EditControls.UIButton
#End Region

End Class