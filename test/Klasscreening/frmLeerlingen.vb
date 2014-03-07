Public Class frmLeerlingen

    
    
    
    Private Sub btnLeerlingToevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeerlingToevoegen.Click

        Dim frmleerlingtoevoegen As New frmLeerlingToevoegen
        frmleerlingtoevoegen.ShowDialog()

    End Sub

    Private Sub btnAfsluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfsluiten.Click

        Me.Close()

    End Sub

    Private Sub btnLeerlingWijzigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeerlingWijzigen.Click

        Dim frmleerlingenwijzigen As New frmLeerlingWijzigen
        frmleerlingenwijzigen.ShowDialog()

    End Sub
End Class