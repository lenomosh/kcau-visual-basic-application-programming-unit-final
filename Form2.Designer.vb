<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormSpecification
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
        Me.btnOpenExitForm = New System.Windows.Forms.Button()
        Me.btnOpenMaximizeForm = New System.Windows.Forms.Button()
        Me.btnCloseAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenExitForm
        '
        Me.btnOpenExitForm.Location = New System.Drawing.Point(58, 70)
        Me.btnOpenExitForm.Name = "btnOpenExitForm"
        Me.btnOpenExitForm.Size = New System.Drawing.Size(169, 129)
        Me.btnOpenExitForm.TabIndex = 0
        Me.btnOpenExitForm.Text = "Exit Form"
        Me.btnOpenExitForm.UseVisualStyleBackColor = True
        '
        'btnOpenMaximizeForm
        '
        Me.btnOpenMaximizeForm.Location = New System.Drawing.Point(300, 70)
        Me.btnOpenMaximizeForm.Name = "btnOpenMaximizeForm"
        Me.btnOpenMaximizeForm.Size = New System.Drawing.Size(169, 129)
        Me.btnOpenMaximizeForm.TabIndex = 0
        Me.btnOpenMaximizeForm.Text = "Maximize Form"
        Me.btnOpenMaximizeForm.UseVisualStyleBackColor = True
        '
        'btnCloseAll
        '
        Me.btnCloseAll.Location = New System.Drawing.Point(533, 70)
        Me.btnCloseAll.Name = "btnCloseAll"
        Me.btnCloseAll.Size = New System.Drawing.Size(169, 129)
        Me.btnCloseAll.TabIndex = 0
        Me.btnCloseAll.Text = "Close All Forms"
        Me.btnCloseAll.UseVisualStyleBackColor = True
        '
        'frmFormSpecification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCloseAll)
        Me.Controls.Add(Me.btnOpenMaximizeForm)
        Me.Controls.Add(Me.btnOpenExitForm)
        Me.Name = "frmFormSpecification"
        Me.Text = "Form Specification"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOpenExitForm As Button
    Friend WithEvents btnOpenMaximizeForm As Button
    Friend WithEvents btnCloseAll As Button
End Class
