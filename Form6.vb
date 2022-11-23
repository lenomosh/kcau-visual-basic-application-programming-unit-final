Public Class frmFunWithMaths
    Private Sub btnOpenArea_Click(sender As Object, e As EventArgs) Handles btnOpenArea.Click
        frmCalcArea.Show()
    End Sub

    Private Sub btnOpenAreaCircle_Click(sender As Object, e As EventArgs) Handles btnOpenAreaCircle.Click
        frmAreaofCircle.Show()
    End Sub

    Private Sub btnOpenPerimeterForm_Click(sender As Object, e As EventArgs) Handles btnOpenPerimeterForm.Click
        frmPerimeter.Show()
    End Sub
End Class