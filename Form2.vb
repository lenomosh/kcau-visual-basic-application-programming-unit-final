Public Class frmFormSpecification
    Private Sub btnOpenExitForm_Click(sender As Object, e As EventArgs) Handles btnOpenExitForm.Click
        frmExit.ShowDialog()

    End Sub

    Private Sub btnOpenMaximizeForm_Click(sender As Object, e As EventArgs) Handles btnOpenMaximizeForm.Click

        frmMaximize.ShowDialog()
    End Sub

    Private Sub btnCloseAll_Click(sender As Object, e As EventArgs) Handles btnCloseAll.Click
        frmCloseAll.ShowDialog()
    End Sub
End Class