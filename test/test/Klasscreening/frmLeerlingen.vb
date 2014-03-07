Imports System.Data.OleDb
Imports Klasscreeningsklassen

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

    Private Sub frmLeerlingen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UpdateLeerlingenTabel()

    End Sub

    Public Sub UpdateLeerlingenTabel()

        Dim selectFromTblCommand As New OleDbCommand("SELECT * FROM TBL_Leerling", GlobalVariables.conn)

        Try
            Dim leerlingtabel As New DataTable

            GlobalVariables.conn.Open()

            Dim adpleerlingen As New OleDbDataAdapter(selectFromTblCommand)
            adpleerlingen.Fill(leerlingtabel)
            dgvLeerlingen.DataSource = leerlingtabel

            GlobalVariables.conn.Dispose()
            GlobalVariables.conn.Close()

        Catch ex As Exception

            MsgBox(ex)

        End Try

    End Sub


    Private Sub frmLeerlingen_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        UpdateLeerlingenTabel()

    End Sub
End Class