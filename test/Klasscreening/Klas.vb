Public Class Klas
    Public Property ID As Integer
    Public Property Naam As String
    Public Property Deelnemer As Integer
    Public Property Lokaal As Integer
    Public Property StartTijdStip As DateTime
    Public Property StopTijdStip As DateTime
    Public Sub New(id As Integer, naam As String, deelnemer As Integer, lokaal As Integer, starttijdstip As DateTime, stoptijdstip As DateTime)
        Me.ID = id
        Me.Naam = naam
        Me.Deelnemer = deelnemer
        Me.Lokaal = lokaal
        Me.StartTijdStip = starttijdstip
        Me.StopTijdStip = stoptijdstip
    End Sub
    Public Shared Function updateOLEDB(ByRef klas As Klas) As OleDb.OleDbCommand

        Dim commandText As String = "UPDATE TBL_Klas SET " & _
                                    "Naam = @Naam, " & _
                                    "Deelnemer = @Deelnemer, " & _
                                    "Lokaal = @Lokaal, " & _
                                    "Starttijdstip = @Starttijdstip, " & _
                                    "Stopttijdstip = @Stopttijdstip " & _
                                    "WHERE ID = @ID;"

        Dim command As New OleDb.OleDbCommand(commandText)

        With klas


            command.Parameters.AddWithValue("@Naam", .Naam)
            command.Parameters.AddWithValue("@Deelnemer", .Deelnemer)
            command.Parameters.AddWithValue("@Lokaal", .Lokaal)
            command.Parameters.AddWithValue("@Starttijdstip", .StartTijdStip)
            command.Parameters.AddWithValue("@Stopttijdstip", .StopTijdStip)
            command.Parameters.AddWithValue("@ID", .ID)

        End With
        Return command
    End Function
    Public Shared Function insertOLEDB(ByRef klas As Klas) As OleDb.OleDbCommand

        Dim commandText As String

        commandText = "INSERT INTO TBL_Klas " & _
        "(Naam,Deelnemer,Lokaal, " & vbCrLf & _
        "Starttijdstip, Stopttijdstip)" & vbCrLf & _
        " values " & vbCrLf & _
        "(@Naam,@Deelnemer,@Lokaal, " & vbCrLf & _
        "@Starttijdstip, @Stopttijdstip)"

        Dim command As New OleDb.OleDbCommand(commandText)

        With klas
            command.Parameters.AddWithValue("@Naam", .Naam)
            command.Parameters.AddWithValue("@Deelnemer", .Deelnemer)
            command.Parameters.AddWithValue("@Lokaal", .Lokaal)
            command.Parameters.AddWithValue("@Starttijdstip", .StartTijdStip)
            command.Parameters.AddWithValue("@Stopttijdstip", .StopTijdStip)
        End With

        Return command
    End Function
End Class
