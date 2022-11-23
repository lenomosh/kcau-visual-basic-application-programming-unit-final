<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerateResult
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
        Me.lblAdmNo = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtAP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDDD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOOAD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblap = New System.Windows.Forms.Label()
        Me.lbldd = New System.Windows.Forms.Label()
        Me.lblooad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAdmNo
        '
        Me.lblAdmNo.AutoSize = True
        Me.lblAdmNo.Location = New System.Drawing.Point(12, 9)
        Me.lblAdmNo.Name = "lblAdmNo"
        Me.lblAdmNo.Size = New System.Drawing.Size(85, 15)
        Me.lblAdmNo.TabIndex = 3
        Me.lblAdmNo.Text = "Admission No."
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(146, 9)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(100, 23)
        Me.txtFullName.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(146, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 2
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(12, 40)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(44, 15)
        Me.lblCourse.TabIndex = 3
        Me.lblCourse.Text = "Course"
        '
        'txtAP
        '
        Me.txtAP.Location = New System.Drawing.Point(462, 12)
        Me.txtAP.Name = "txtAP"
        Me.txtAP.Size = New System.Drawing.Size(100, 23)
        Me.txtAP.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(328, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "App Programming"
        '
        'txtDDD
        '
        Me.txtDDD.Location = New System.Drawing.Point(462, 41)
        Me.txtDDD.Name = "txtDDD"
        Me.txtDDD.Size = New System.Drawing.Size(100, 23)
        Me.txtDDD.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Database Design"
        '
        'txtOOAD
        '
        Me.txtOOAD.Location = New System.Drawing.Point(462, 70)
        Me.txtOOAD.Name = "txtOOAD"
        Me.txtOOAD.Size = New System.Drawing.Size(100, 23)
        Me.txtOOAD.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "OOAD"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(641, 32)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(114, 23)
        Me.btnGenerate.TabIndex = 4
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblap
        '
        Me.lblap.AutoSize = True
        Me.lblap.Location = New System.Drawing.Point(573, 19)
        Me.lblap.Name = "lblap"
        Me.lblap.Size = New System.Drawing.Size(0, 15)
        Me.lblap.TabIndex = 5
        '
        'lbldd
        '
        Me.lbldd.AutoSize = True
        Me.lbldd.Location = New System.Drawing.Point(568, 44)
        Me.lbldd.Name = "lbldd"
        Me.lbldd.Size = New System.Drawing.Size(0, 15)
        Me.lbldd.TabIndex = 6
        '
        'lblooad
        '
        Me.lblooad.AutoSize = True
        Me.lblooad.Location = New System.Drawing.Point(570, 75)
        Me.lblooad.Name = "lblooad"
        Me.lblooad.Size = New System.Drawing.Size(0, 15)
        Me.lblooad.TabIndex = 7
        '
        'frmGenerateResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblooad)
        Me.Controls.Add(Me.lbldd)
        Me.Controls.Add(Me.lblap)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOOAD)
        Me.Controls.Add(Me.txtDDD)
        Me.Controls.Add(Me.txtAP)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblAdmNo)
        Me.Controls.Add(Me.txtFullName)
        Me.Name = "frmGenerateResult"
        Me.Text = "frmGenerateResult"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdmNo As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtAP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDDD As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOOAD As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblap As Label
    Friend WithEvents lbldd As Label
    Friend WithEvents lblooad As Label
End Class
