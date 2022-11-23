Public Class frmDashboard
    Private Sub btnOpenFormSpecification_Click(sender As Object, e As EventArgs) Handles btnOpenFormSpecification.Click
        frmFormSpecification.ShowDialog()
    End Sub

    Private Sub btnOpenFunWithMaths_Click(sender As Object, e As EventArgs) Handles btnOpenFunWithMaths.Click
        frmFunWithMaths.Show()
    End Sub

    Private Sub btnOpenfrmPayslip_Click(sender As Object, e As EventArgs) Handles btnOpenfrmPayslip.Click
        frmPaySlip.Show()
    End Sub

    Private Sub ntnOpenGradeForm_Click(sender As Object, e As EventArgs) Handles ntnOpenGradeForm.Click
        frmGenerateResult.Show()
    End Sub
End Class
