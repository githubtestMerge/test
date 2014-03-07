﻿Public Class Leerkracht
    Public Property ID As Integer
    Public Property VoorNaam As String
    Public Property FamilieNaam As String
    Public Property GeboorteDatum As Date
    Public Property InDienstTreding As Date
    Public Property Actief As Integer
    Public Sub New(id As Integer, voornaam As String, familienaam As String, geboortedatum As Date, indiensttreding As Date, actief As Integer)
        Me.ID = id
        Me.VoorNaam = voornaam
        Me.FamilieNaam = familienaam
        Me.GeboorteDatum = geboortedatum
        Me.InDienstTreding = indiensttreding
        Me.Actief = actief
    End Sub
    Public Shared Function updateOLEDB(ByRef leerkracht As Leerkracht) As OleDb.OleDbCommand

        Dim commandText As String = "UPDATE TBL_Leerkracht SET" & vbCrLf & _
                                    "Voornaam = @Voornaam," & vbCrLf & "Familienaam = @Familienaam," & vbCrLf & "Geboortedatum = @Geboortedatum," & vbCrLf & "InDiensttreding = @InDiensttreding," & _
                                     vbCrLf & "Actief= @Actief " & _
                                    "Where ID = @ID;"

        Dim command As New OleDb.OleDbCommand(commandText)

        With leerkracht

            command.Parameters.AddWithValue("@Voornaam", .Voornaam)
            command.Parameters.AddWithValue("@Familienaam", .FamilieNaam)
            command.Parameters.AddWithValue("@Geboortedatum", .GeboorteDatum)
            command.Parameters.AddWithValue("@InDiensttreding", .InDiensttreding)
            command.Parameters.AddWithValue("@Actief", .Actief)
            command.Parameters.AddWithValue("@ID", .ID)

        End With
        Dim tekst As String = command.CommandText
        Return command
    End Function
    Public Shared Function insertOLEDB(ByRef leerkracht As Leerkracht) As OleDb.OleDbCommand
        Dim commandText As String

        commandText = "INSERT INTO TBL_Leerkracht " & _
        "(Voornaam,Familienaam,Geboortedatum,InDienstTreding, " & vbCrLf & _
        "Actief)" & vbCrLf & _
        " values " & vbCrLf & _
        "(@Voornaam,@Familienaam,@Geboortedatum,@InDienstTreding," & vbCrLf & _
        "@Actief)"

        Dim command As New OleDb.OleDbCommand(commandText)

        With leerkracht
            command.Parameters.AddWithValue("@Voornaam", .VoorNaam)
            command.Parameters.AddWithValue("@Familienaam", .FamilieNaam)
            command.Parameters.AddWithValue("@Geboortedatum", .GeboorteDatum)
            command.Parameters.AddWithValue("@InDienstTreding", .InDiensttreding)
            command.Parameters.AddWithValue("@Actief", .Actief)
        End With

        Return command
    End Function
End Class
