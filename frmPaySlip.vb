Imports System.Text.RegularExpressions
Imports System.Threading

Public Class frmPaySlip
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim nssf As Decimal
        Dim nhif As Decimal
        Dim taxableIncome As Decimal
        Dim paye As Decimal
        Dim netPay As Decimal
        Dim gross As Decimal

        gross = txtHourlyRate.Text * 160

        nssf = 1080
        nhif = 1200
        taxableIncome = gross - nssf - nhif
        paye = 0.15 * taxableIncome

        netPay = taxableIncome - paye

        txtGross.Text = gross.ToString("C")
        txtNHIF.Text = nhif.ToString("C")
        txtNSSF.Text = nssf.ToString("C")
        txtPaye.Text = paye.ToString("C")
        txtNetPay.Text = netPay.ToString("C")
        txtTaxableIncome.Text = taxableIncome.ToString("C")
        lblSlipResult.Text = "Pay slip for " & txtFullName.Text



    End Sub

    Private Sub frmPaySlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newCulture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CurrentUICulture.Clone()
        newCulture.NumberFormat.CurrencySymbol = "KES "
        newCulture.NumberFormat.CurrencyDecimalDigits = 2

        newCulture.NumberFormat.CurrencyGroupSeparator = String.Empty
        newCulture.NumberFormat.CurrencyDecimalSeparator = "."
        Thread.CurrentThread.CurrentCulture = newCulture
    End Sub
End Class