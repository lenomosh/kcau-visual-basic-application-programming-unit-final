Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class frmGenerateResult
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim ooad As Decimal
        Dim ap As Decimal
        Dim dd As Decimal

        Dim apGrade As String
        Dim ddGrade As String
        Dim ooadGrad As String
        Dim overralGrade As String


        ooad = txtOOAD.Text
        ap = txtAP.Text
        dd = txtDDD.Text

        apGrade = getGrade(ap)
        ddGrade = getGrade(dd)
        ooadGrad = getGrade(ooad)
        overralGrade = getGrade((ap + ooad + dd) / 3)

        lblap.Text = apGrade
        lbldd.Text = ddGrade
        lblooad.Text = ooadGrad







    End Sub

    Private Function getGrade(ByVal value As Integer) As String
        Dim txtGrade As String

        Select Case Convert.ToInt32(value)
            Case 75 To 100
                txtGrade = "Distinction"
            Case 65 To 74
                txtGrade = "Credit"
            Case 50 To 64
                txtGrade = "Pass"
            Case 0 To 49
                txtGrade = "Fail"
            Case Else
                txtGrade = "Invalid"

        End Select

        Return txtGrade
    End Function

End Class