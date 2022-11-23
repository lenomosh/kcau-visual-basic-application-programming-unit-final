Public Class frmCloseAll
    Private Sub btnCloseAll_Click(sender As Object, e As EventArgs) Handles btnCloseAll.Click
        My.Application.OpenForms.Cast(Of Form)() _
            .Except({Me}) _
            .ToList() _
            .ForEach(Sub(form) form.Close())
    End Sub
End Class