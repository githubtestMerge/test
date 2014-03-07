Imports Klasscreeningsklassen
Imports System.Data.OleDb

Public Class frmLeerlingToevoegen

    Inherits FrmLeerlingToevoegenWijzigen

    Public Sub New()

        InitializeComponent()

        Me.Text = "Toevoegen van een nieuwe leerling"
    End Sub



    Public Overrides Sub btnToevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim leerling As New Leerling(Convert.ToInt16(txtLeerlingId.Text), _
                                     txtLeerlingVoornaam.Text, _
                                     txtLeerlingNaam.Text, _
                                     dtpLeerlingGeboortedatum.Value.Date, _
                                    dtpLeerlingInschrijvingsdatum.Value.Date, _
                                     Convert.ToBoolean(chbOS_ASS), _
                                     Convert.ToBoolean(chbOS_ADHD), _
                                     Convert.ToBoolean(chbOS_GTS), _
                                     Convert.ToBoolean(chbLS_Dyslexie), _
                                     Convert.ToBoolean(chbLS_Dysorthografie), _
                                     Convert.ToBoolean(chbLS_Dyscalculie), _
                                     txtLS_Andere.Text, _
                                     Convert.ToBoolean(chbLeervoorsprong), _
                                     Convert.ToBoolean(chbPestdader), _
                                     Convert.ToBoolean(chbPestslachtoffer), _
                                     Convert.ToBoolean(chbAnderstalig), _
                                     Convert.ToBoolean(chbBisser), _
                                     1)
        ' Dim leerling As New Leerling(11111, "Sam", "Biesbrouck", New Date(1983, 3, 28, 10, 20, 0), New Date(1983, 3, 28, 10, 20, 0), False, True, True, True, True, True, "en nog veel andere dingen", True, True, True, True, True, 1)


        Dim insertleerling As New OleDbCommand
        insertleerling = leerling.insertOLEDB(leerling)

        Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & "C:\SMDBTool\Database\KlasScreening.accdb" + ";Persist Security Info=False;")

        Try
            conn.Open()
            insertleerling.Connection = conn
            insertleerling.ExecuteNonQuery()


        Catch ex As Exception

            MessageBox.Show(ex.Message, "Database Error tijdens schrijven naar leerlingentabel", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()
            insertleerling.Dispose()

        End Try


    End Sub

    Private Sub frmLeerlingToevoegen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        cboLeerlingActief.Text = "Actief"

    End Sub

End Class