Public Class frmMainMenu



    Private Sub btnLeerlingen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeerlingen.Click

        Dim frmleerlingen As New frmLeerlingen
        frmleerlingen.ShowDialog()

    End Sub
End Class