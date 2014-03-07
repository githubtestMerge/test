Public Class Leerling
    Public Property ID As Integer
    Public Property VoorNaam As String
    Public Property FamilieNaam As String
    Public Property GeboorteDatum As Date
    Public Property InschrijvingsDatum As Date
    Public Property OS_Ass As Boolean
    Public Property OS_ADHD As Boolean
    Public Property OS_GTS As Boolean
    Public Property LS_Dyslexie As Boolean
    Public Property LS_Dysorthografie As Boolean
    Public Property LS_Dyscalculie As Boolean
    Public Property LS_Andere As String
    Public Property Leervoorsprong As Boolean
    Public Property Pestdader As Boolean
    Public Property Pestslachtoffer As Boolean
    Public Property Anderstalig As Boolean
    Public Property Bisser As Boolean
    Public Property Actief As Integer

    Public Sub New(id As Integer, voornaam As String, familienaam As String, geboortedatum As Date, inschrijvingsdatum As Date)
        Me.ID = id
        Me.VoorNaam = voornaam
        Me.FamilieNaam = familienaam
        Me.GeboorteDatum = geboortedatum
        Me.InschrijvingsDatum = inschrijvingsdatum
    End Sub
    Public Shared Function updateOLEDB(ByRef leerling As Leerling) As OleDb.OleDbCommand

        Dim commandText As String = "UPDATE TBL_Leerling SET " & vbCrLf & _
                                    "Voornaam = @Voornaam, " & vbCrLf & "Familienaam = @Familienaam," & vbCrLf & "Geboortedatum = @Geboortedatum," & vbCrLf & "Inschrijvingsdatum = @Inschrijvingsdatum," & vbCrLf & _
                                    "OS_Ass = @OS_Ass," & vbCrLf & "OS_ADHD=@OS_ADHD," & vbCrLf & "OS_GTS = @OS_GTS," & vbCrLf & "" & _
                                    "LS_Dyslexie = @LS_Dyslexie," & vbCrLf & "LS_Dysorthografie = @LS_Dysorthografie," & vbCrLf & "LS_Dyscalculie= @LS_Dyscalculie," & vbCrLf & "LS_Andere = @LS_Andere," & vbCrLf & _
                                    "Leervoorsprong = @Leervoorsprong," & vbCrLf & "Pestdader = @Pestdader," & vbCrLf & "Pestslachtoffer = @Pestslachtoffer," & vbCrLf & "Anderstalig = @Anderstalig," & vbCrLf & "Bisser = @Bisser," & vbCrLf &
                                    "Actief= @Actief " & _
                                    "WHERE ID = @ID;"
        Dim command As New OleDb.OleDbCommand(commandText)

        With leerling

            command.Parameters.AddWithValue("@Voornaam", .VoorNaam)
            command.Parameters.AddWithValue("@Familienaam", .FamilieNaam)
            command.Parameters.AddWithValue("@Geboortedatum", .GeboorteDatum)
            command.Parameters.AddWithValue("@Inschrijvingsdatum", .InschrijvingsDatum)
            command.Parameters.AddWithValue("@OS_Ass", .OS_Ass)
            command.Parameters.AddWithValue("@OS_ADHD", .OS_ADHD)
            command.Parameters.AddWithValue("@OS_GTS", .OS_GTS)
            command.Parameters.AddWithValue("@LS_Dyslexie", .LS_Dyslexie)
            command.Parameters.AddWithValue("@LS_Dysorthografie", .LS_Dysorthografie)
            command.Parameters.AddWithValue("@LS_Dyscalculie", .LS_Dyscalculie)
            command.Parameters.AddWithValue("@LS_Andere", .LS_Andere)
            command.Parameters.AddWithValue("@Leervoorsprong", .Leervoorsprong)
            command.Parameters.AddWithValue("@Pestdader", .Pestdader)
            command.Parameters.AddWithValue("@Pestslachtoffer", .Pestslachtoffer)
            command.Parameters.AddWithValue("@Anderstalig", .Anderstalig)
            command.Parameters.AddWithValue("@Bisser", .Bisser)
            command.Parameters.AddWithValue("@Actief", .Actief)
            command.Parameters.AddWithValue("@ID", .ID)

        End With
        Return command
    End Function
    Public Shared Function insertOLEDB(ByRef leerling As Leerling) As OleDb.OleDbCommand
        Dim commandText As String

        commandText = "INSERT INTO TBL_Leerling " & _
        "(Voornaam,Familienaam,Geboortedatum,Inschrijvingsdatum, " & vbCrLf & _
        "OS_Ass, OS_ADHD, OS_GTS, " & vbCrLf & _
        "LS_Dyslexie, LS_Dysorthografie, LS_Dyscalculie, LS_Andere, " & vbCrLf & _
        "Leervoorsprong, Pestdader, Pestslachtoffer, Anderstalig, Bisser, Actief)" & vbCrLf & _
        " values " & vbCrLf & _
        "(@Voornaam,@Familienaam,@Geboortedatum,@Inschrijvingsdatum," & vbCrLf & _
        "@OS_Ass, @OS_ADHD, @OS_GTS," & vbCrLf & _
        "@LS_Dyslexie, @LS_Dysorthografie, @LS_Dyscalculie, @LS_Andere, " & vbCrLf & _
        "@Leervoorsprong, @Pestdader, @Pestslachtoffer, @Anderstalig, @Bisser, @Actief)"

        Dim command As New OleDb.OleDbCommand(commandText)

        With leerling
            command.Parameters.AddWithValue("@Voornaam", .VoorNaam)
            command.Parameters.AddWithValue("@Familienaam", .FamilieNaam)
            command.Parameters.AddWithValue("@Geboortedatum", .GeboorteDatum)
            command.Parameters.AddWithValue("@Inschrijvingsdatum", .InschrijvingsDatum)
            command.Parameters.AddWithValue("@OS_Ass", .OS_Ass)
            command.Parameters.AddWithValue("@OS_ADHD", .OS_ADHD)
            command.Parameters.AddWithValue("@OS_GTS", .OS_GTS)
            command.Parameters.AddWithValue("@LS_Dyslexie", .LS_Dyslexie)
            command.Parameters.AddWithValue("@LS_Dysorthografie", .LS_Dysorthografie)
            command.Parameters.AddWithValue("@LS_Dyscalculie", .LS_Dyscalculie)
            command.Parameters.AddWithValue("@LS_Andere", .LS_Andere)
            command.Parameters.AddWithValue("@Leervoorsprong", .Leervoorsprong)
            command.Parameters.AddWithValue("@Pestdader", .Pestdader)
            command.Parameters.AddWithValue("@Pestslachtoffer", .Pestslachtoffer)
            command.Parameters.AddWithValue("@Anderstalig", .Anderstalig)
            command.Parameters.AddWithValue("@Bisser", .Bisser)
            command.Parameters.AddWithValue("@Actief", .Actief)
        End With

        Return command
    End Function

End Class

