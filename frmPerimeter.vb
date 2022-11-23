Public Class frmPerimeter
    Private Sub TextBox1_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLength.KeyPress, txtWidth.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim result As Decimal
        result = (txtLength.Text * 2) + (txtWidth.Text * 2)
        lblResult.Text = String.Format("Perimeter = {0}", result)
    End Sub
End Class