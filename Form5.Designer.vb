<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCloseAll
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
        Me.btnCloseAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCloseAll
        '
        Me.btnCloseAll.Location = New System.Drawing.Point(244, 99)
        Me.btnCloseAll.Name = "btnCloseAll"
        Me.btnCloseAll.Size = New System.Drawing.Size(197, 130)
        Me.btnCloseAll.TabIndex = 0
        Me.btnCloseAll.Text = "Close All"
        Me.btnCloseAll.UseVisualStyleBackColor = True
        '
        'frmCloseAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCloseAll)
        Me.Name = "frmCloseAll"
        Me.Text = "Close All Forms"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCloseAll As Button
End Class
