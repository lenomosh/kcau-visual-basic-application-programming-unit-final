<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcArea
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
        Me.txtAreaLen = New System.Windows.Forms.TextBox()
        Me.lblMathLen = New System.Windows.Forms.Label()
        Me.txtAreaWidth = New System.Windows.Forms.TextBox()
        Me.lblAreaWidth = New System.Windows.Forms.Label()
        Me.btnAreaCalculate = New System.Windows.Forms.Button()
        Me.lblAreaCalcResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAreaLen
        '
        Me.txtAreaLen.Location = New System.Drawing.Point(88, 47)
        Me.txtAreaLen.Name = "txtAreaLen"
        Me.txtAreaLen.Size = New System.Drawing.Size(192, 23)
        Me.txtAreaLen.TabIndex = 0
        '
        'lblMathLen
        '
        Me.lblMathLen.AutoSize = True
        Me.lblMathLen.Location = New System.Drawing.Point(31, 52)
        Me.lblMathLen.Name = "lblMathLen"
        Me.lblMathLen.Size = New System.Drawing.Size(44, 15)
        Me.lblMathLen.TabIndex = 1
        Me.lblMathLen.Text = "Length"
        '
        'txtAreaWidth
        '
        Me.txtAreaWidth.Location = New System.Drawing.Point(88, 85)
        Me.txtAreaWidth.Name = "txtAreaWidth"
        Me.txtAreaWidth.Size = New System.Drawing.Size(192, 23)
        Me.txtAreaWidth.TabIndex = 0
        '
        'lblAreaWidth
        '
        Me.lblAreaWidth.AutoSize = True
        Me.lblAreaWidth.Location = New System.Drawing.Point(31, 88)
        Me.lblAreaWidth.Name = "lblAreaWidth"
        Me.lblAreaWidth.Size = New System.Drawing.Size(39, 15)
        Me.lblAreaWidth.TabIndex = 1
        Me.lblAreaWidth.Text = "Width"
        '
        'btnAreaCalculate
        '
        Me.btnAreaCalculate.Location = New System.Drawing.Point(118, 127)
        Me.btnAreaCalculate.Name = "btnAreaCalculate"
        Me.btnAreaCalculate.Size = New System.Drawing.Size(105, 47)
        Me.btnAreaCalculate.TabIndex = 2
        Me.btnAreaCalculate.Text = "Calculate"
        Me.btnAreaCalculate.UseVisualStyleBackColor = True
        '
        'lblAreaCalcResult
        '
        Me.lblAreaCalcResult.AutoSize = True
        Me.lblAreaCalcResult.Location = New System.Drawing.Point(147, 19)
        Me.lblAreaCalcResult.Name = "lblAreaCalcResult"
        Me.lblAreaCalcResult.Size = New System.Drawing.Size(0, 15)
        Me.lblAreaCalcResult.TabIndex = 3
        '
        'frmCalcArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAreaCalcResult)
        Me.Controls.Add(Me.btnAreaCalculate)
        Me.Controls.Add(Me.lblAreaWidth)
        Me.Controls.Add(Me.lblMathLen)
        Me.Controls.Add(Me.txtAreaWidth)
        Me.Controls.Add(Me.txtAreaLen)
        Me.Name = "frmCalcArea"
        Me.Text = "Calculate Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAreaLen As TextBox
    Friend WithEvents lblMathLen As Label
    Friend WithEvents txtAreaWidth As TextBox
    Friend WithEvents lblAreaWidth As Label
    Friend WithEvents btnAreaCalculate As Button
    Friend WithEvents lblAreaCalcResult As Label
End Class
