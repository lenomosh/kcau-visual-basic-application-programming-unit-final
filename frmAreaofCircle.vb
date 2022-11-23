Public Class frmAreaofCircle
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCircleRadius.TextChanged
        Dim result As Decimal
        If Not IsNumeric(txtCircleRadius.Text) Then
            MessageBox.Show("Please enter a number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCircleRadius.Text = 1
        Else
            result = System.Math.PI * System.Math.Pow(txtCircleRadius.Text, 2)
            lblCircleAreaResult.Text = String.Format("Area is {0}", result)
        End If
    End Sub
End Class