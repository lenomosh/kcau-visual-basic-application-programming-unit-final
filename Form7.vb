Public Class frmCalcArea
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtAreaLen.TextChanged, txtAreaWidth.TextChanged

    End Sub

    Private Sub btnAreaCalculate_Click(sender As Object, e As EventArgs) Handles btnAreaCalculate.Click
        Dim result As Decimal
        If Not IsNumeric(txtAreaLen.Text) Or Not IsNumeric(txtAreaWidth.Text) Then
            MessageBox.Show("You must provide both length and width", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            result = txtAreaLen.Text * txtAreaWidth.Text
            lblAreaCalcResult.Text = String.Format("{0} {1}", "The area is ", result)
        End If
    End Sub
End Class