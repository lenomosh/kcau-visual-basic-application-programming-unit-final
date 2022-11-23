<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaySlip
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
        Me.txtHourlyRate = New System.Windows.Forms.TextBox()
        Me.lblHourlyRate = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblSlipResult = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.txtNSSF = New System.Windows.Forms.TextBox()
        Me.lblNssf = New System.Windows.Forms.Label()
        Me.txtNHIF = New System.Windows.Forms.TextBox()
        Me.lblNHIF = New System.Windows.Forms.Label()
        Me.txtPaye = New System.Windows.Forms.TextBox()
        Me.lblPAYE = New System.Windows.Forms.Label()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.lnlNetPay = New System.Windows.Forms.Label()
        Me.txtTaxableIncome = New System.Windows.Forms.TextBox()
        Me.lblTaxableIncome = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtHourlyRate
        '
        Me.txtHourlyRate.Location = New System.Drawing.Point(123, 40)
        Me.txtHourlyRate.Name = "txtHourlyRate"
        Me.txtHourlyRate.Size = New System.Drawing.Size(100, 23)
        Me.txtHourlyRate.TabIndex = 0
        '
        'lblHourlyRate
        '
        Me.lblHourlyRate.AutoSize = True
        Me.lblHourlyRate.Location = New System.Drawing.Point(48, 43)
        Me.lblHourlyRate.Name = "lblHourlyRate"
        Me.lblHourlyRate.Size = New System.Drawing.Size(69, 15)
        Me.lblHourlyRate.TabIndex = 1
        Me.lblHourlyRate.Text = "Hourly Rate"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(74, 83)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(132, 23)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate Slip"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblSlipResult
        '
        Me.lblSlipResult.AutoSize = True
        Me.lblSlipResult.Location = New System.Drawing.Point(578, 15)
        Me.lblSlipResult.Name = "lblSlipResult"
        Me.lblSlipResult.Size = New System.Drawing.Size(82, 15)
        Me.lblSlipResult.TabIndex = 3
        Me.lblSlipResult.Text = "Pay slip Result"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(525, 45)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(58, 15)
        Me.lbl.TabIndex = 3
        Me.lbl.Text = "Gross Pay"
        '
        'txtGross
        '
        Me.txtGross.Enabled = False
        Me.txtGross.Location = New System.Drawing.Point(640, 45)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(100, 23)
        Me.txtGross.TabIndex = 0
        '
        'txtNSSF
        '
        Me.txtNSSF.Enabled = False
        Me.txtNSSF.Location = New System.Drawing.Point(640, 112)
        Me.txtNSSF.Name = "txtNSSF"
        Me.txtNSSF.Size = New System.Drawing.Size(100, 23)
        Me.txtNSSF.TabIndex = 0
        '
        'lblNssf
        '
        Me.lblNssf.AutoSize = True
        Me.lblNssf.Location = New System.Drawing.Point(525, 112)
        Me.lblNssf.Name = "lblNssf"
        Me.lblNssf.Size = New System.Drawing.Size(34, 15)
        Me.lblNssf.TabIndex = 3
        Me.lblNssf.Text = "NSSF"
        '
        'txtNHIF
        '
        Me.txtNHIF.Enabled = False
        Me.txtNHIF.Location = New System.Drawing.Point(640, 141)
        Me.txtNHIF.Name = "txtNHIF"
        Me.txtNHIF.Size = New System.Drawing.Size(100, 23)
        Me.txtNHIF.TabIndex = 0
        '
        'lblNHIF
        '
        Me.lblNHIF.AutoSize = True
        Me.lblNHIF.Location = New System.Drawing.Point(525, 141)
        Me.lblNHIF.Name = "lblNHIF"
        Me.lblNHIF.Size = New System.Drawing.Size(34, 15)
        Me.lblNHIF.TabIndex = 3
        Me.lblNHIF.Text = "NHIF"
        '
        'txtPaye
        '
        Me.txtPaye.Enabled = False
        Me.txtPaye.Location = New System.Drawing.Point(640, 170)
        Me.txtPaye.Name = "txtPaye"
        Me.txtPaye.Size = New System.Drawing.Size(100, 23)
        Me.txtPaye.TabIndex = 0
        '
        'lblPAYE
        '
        Me.lblPAYE.AutoSize = True
        Me.lblPAYE.Location = New System.Drawing.Point(525, 170)
        Me.lblPAYE.Name = "lblPAYE"
        Me.lblPAYE.Size = New System.Drawing.Size(33, 15)
        Me.lblPAYE.TabIndex = 3
        Me.lblPAYE.Text = "PAYE"
        '
        'txtNetPay
        '
        Me.txtNetPay.Enabled = False
        Me.txtNetPay.Location = New System.Drawing.Point(640, 199)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.Size = New System.Drawing.Size(100, 23)
        Me.txtNetPay.TabIndex = 0
        '
        'lnlNetPay
        '
        Me.lnlNetPay.AutoSize = True
        Me.lnlNetPay.Location = New System.Drawing.Point(525, 199)
        Me.lnlNetPay.Name = "lnlNetPay"
        Me.lnlNetPay.Size = New System.Drawing.Size(48, 15)
        Me.lnlNetPay.TabIndex = 3
        Me.lnlNetPay.Text = "Net Pay"
        '
        'txtTaxableIncome
        '
        Me.txtTaxableIncome.Enabled = False
        Me.txtTaxableIncome.Location = New System.Drawing.Point(640, 80)
        Me.txtTaxableIncome.Name = "txtTaxableIncome"
        Me.txtTaxableIncome.Size = New System.Drawing.Size(100, 23)
        Me.txtTaxableIncome.TabIndex = 0
        '
        'lblTaxableIncome
        '
        Me.lblTaxableIncome.AutoSize = True
        Me.lblTaxableIncome.Location = New System.Drawing.Point(525, 80)
        Me.lblTaxableIncome.Name = "lblTaxableIncome"
        Me.lblTaxableIncome.Size = New System.Drawing.Size(89, 15)
        Me.lblTaxableIncome.TabIndex = 3
        Me.lblTaxableIncome.Text = "Taxable Income"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(48, 9)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(61, 15)
        Me.lblFullName.TabIndex = 1
        Me.lblFullName.Text = "Full Name"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(123, 6)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(100, 23)
        Me.txtFullName.TabIndex = 0
        '
        'frmPaySlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lnlNetPay)
        Me.Controls.Add(Me.lblPAYE)
        Me.Controls.Add(Me.lblNHIF)
        Me.Controls.Add(Me.lblNssf)
        Me.Controls.Add(Me.lblTaxableIncome)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblSlipResult)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblHourlyRate)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtPaye)
        Me.Controls.Add(Me.txtNHIF)
        Me.Controls.Add(Me.txtTaxableIncome)
        Me.Controls.Add(Me.txtNSSF)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.txtHourlyRate)
        Me.Name = "frmPaySlip"
        Me.Text = "frmPaySlip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHourlyRate As TextBox
    Friend WithEvents lblHourlyRate As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblSlipResult As Label
    Friend WithEvents lbl As Label
    Friend WithEvents txtGross As TextBox
    Friend WithEvents txtNSSF As TextBox
    Friend WithEvents lblNssf As Label
    Friend WithEvents txtNHIF As TextBox
    Friend WithEvents lblNHIF As Label
    Friend WithEvents txtPaye As TextBox
    Friend WithEvents lblPAYE As Label
    Friend WithEvents txtNetPay As TextBox
    Friend WithEvents lnlNetPay As Label
    Friend WithEvents txtTaxableIncome As TextBox
    Friend WithEvents lblTaxableIncome As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtFullName As TextBox
End Class
