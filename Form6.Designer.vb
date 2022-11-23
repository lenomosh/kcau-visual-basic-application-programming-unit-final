<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFunWithMaths
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
        Me.btnOpenArea = New System.Windows.Forms.Button()
        Me.btnOpenAreaCircle = New System.Windows.Forms.Button()
        Me.btnOpenPerimeterForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenArea
        '
        Me.btnOpenArea.Location = New System.Drawing.Point(12, 66)
        Me.btnOpenArea.Name = "btnOpenArea"
        Me.btnOpenArea.Size = New System.Drawing.Size(224, 80)
        Me.btnOpenArea.TabIndex = 0
        Me.btnOpenArea.Text = "Area Of a Rectangle"
        Me.btnOpenArea.UseVisualStyleBackColor = True
        '
        'btnOpenAreaCircle
        '
        Me.btnOpenAreaCircle.Location = New System.Drawing.Point(254, 66)
        Me.btnOpenAreaCircle.Name = "btnOpenAreaCircle"
        Me.btnOpenAreaCircle.Size = New System.Drawing.Size(224, 80)
        Me.btnOpenAreaCircle.TabIndex = 0
        Me.btnOpenAreaCircle.Text = "Area Of a Circle"
        Me.btnOpenAreaCircle.UseVisualStyleBackColor = True
        '
        'btnOpenPerimeterForm
        '
        Me.btnOpenPerimeterForm.Location = New System.Drawing.Point(508, 66)
        Me.btnOpenPerimeterForm.Name = "btnOpenPerimeterForm"
        Me.btnOpenPerimeterForm.Size = New System.Drawing.Size(224, 80)
        Me.btnOpenPerimeterForm.TabIndex = 0
        Me.btnOpenPerimeterForm.Text = "Perimeter"
        Me.btnOpenPerimeterForm.UseVisualStyleBackColor = True
        '
        'frmFunWithMaths
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnOpenPerimeterForm)
        Me.Controls.Add(Me.btnOpenAreaCircle)
        Me.Controls.Add(Me.btnOpenArea)
        Me.Name = "frmFunWithMaths"
        Me.Text = "Fun with Maths"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOpenArea As Button
    Friend WithEvents btnOpenAreaCircle As Button
    Friend WithEvents btnOpenPerimeterForm As Button
End Class
