<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreaofCircle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCircleRadius = New System.Windows.Forms.TextBox()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.lblCircleAreaResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCircleRadius
        '
        Me.txtCircleRadius.Location = New System.Drawing.Point(175, 52)
        Me.txtCircleRadius.Name = "txtCircleRadius"
        Me.txtCircleRadius.Size = New System.Drawing.Size(135, 23)
        Me.txtCircleRadius.TabIndex = 0
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Location = New System.Drawing.Point(121, 55)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(42, 15)
        Me.lblRadius.TabIndex = 1
        Me.lblRadius.Text = "Radius"
        '
        'lblCircleAreaResult
        '
        Me.lblCircleAreaResult.AutoSize = True
        Me.lblCircleAreaResult.Location = New System.Drawing.Point(343, 55)
        Me.lblCircleAreaResult.Name = "lblCircleAreaResult"
        Me.lblCircleAreaResult.Size = New System.Drawing.Size(0, 15)
        Me.lblCircleAreaResult.TabIndex = 2
        '
        'frmAreaofCircle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCircleAreaResult)
        Me.Controls.Add(Me.lblRadius)
        Me.Controls.Add(Me.txtCircleRadius)
        Me.Name = "frmAreaofCircle"
        Me.Text = "Area of a Circle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCircleRadius As TextBox
    Friend WithEvents lblRadius As Label
    Friend WithEvents lblCircleAreaResult As Label
End Class
