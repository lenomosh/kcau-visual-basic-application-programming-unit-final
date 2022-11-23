<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnOpenFormSpecification = New System.Windows.Forms.Button()
        Me.btnOpenFunWithMaths = New System.Windows.Forms.Button()
        Me.btnOpenfrmPayslip = New System.Windows.Forms.Button()
        Me.ntnOpenGradeForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenFormSpecification
        '
        Me.btnOpenFormSpecification.Location = New System.Drawing.Point(55, 79)
        Me.btnOpenFormSpecification.Name = "btnOpenFormSpecification"
        Me.btnOpenFormSpecification.Size = New System.Drawing.Size(138, 105)
        Me.btnOpenFormSpecification.TabIndex = 0
        Me.btnOpenFormSpecification.Text = "Open Form Specifications Form"
        Me.btnOpenFormSpecification.UseVisualStyleBackColor = True
        '
        'btnOpenFunWithMaths
        '
        Me.btnOpenFunWithMaths.Location = New System.Drawing.Point(246, 79)
        Me.btnOpenFunWithMaths.Name = "btnOpenFunWithMaths"
        Me.btnOpenFunWithMaths.Size = New System.Drawing.Size(138, 105)
        Me.btnOpenFunWithMaths.TabIndex = 0
        Me.btnOpenFunWithMaths.Text = "Fun with maths"
        Me.btnOpenFunWithMaths.UseVisualStyleBackColor = True
        '
        'btnOpenfrmPayslip
        '
        Me.btnOpenfrmPayslip.Location = New System.Drawing.Point(420, 79)
        Me.btnOpenfrmPayslip.Name = "btnOpenfrmPayslip"
        Me.btnOpenfrmPayslip.Size = New System.Drawing.Size(138, 105)
        Me.btnOpenfrmPayslip.TabIndex = 0
        Me.btnOpenfrmPayslip.Text = "Pay slip Calculator"
        Me.btnOpenfrmPayslip.UseVisualStyleBackColor = True
        '
        'ntnOpenGradeForm
        '
        Me.ntnOpenGradeForm.Location = New System.Drawing.Point(590, 79)
        Me.ntnOpenGradeForm.Name = "ntnOpenGradeForm"
        Me.ntnOpenGradeForm.Size = New System.Drawing.Size(138, 105)
        Me.ntnOpenGradeForm.TabIndex = 0
        Me.ntnOpenGradeForm.Text = "Grade Calculator"
        Me.ntnOpenGradeForm.UseVisualStyleBackColor = True
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ntnOpenGradeForm)
        Me.Controls.Add(Me.btnOpenfrmPayslip)
        Me.Controls.Add(Me.btnOpenFunWithMaths)
        Me.Controls.Add(Me.btnOpenFormSpecification)
        Me.Name = "frmDashboard"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOpenFormSpecification As Button
    Friend WithEvents btnOpenFunWithMaths As Button
    Friend WithEvents btnOpenfrmPayslip As Button
    Friend WithEvents ntnOpenGradeForm As Button
End Class
