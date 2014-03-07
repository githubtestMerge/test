Public Class Klas
    Public Property ID As Integer
    Public Property Naam As String
    Public Property Deelnemer As Integer
    Public Property Lokaal As Integer
    Public Property StartTijdStip As Date
    Public Property StopTijdStip As Date
    Public Sub New(id As Integer, naam As String, deelnemer As Integer, lokaal As Integer, starttijdstip As Date, stoptijdstip As Date)
        Me.ID = id
        Me.Naam = naam
        Me.Deelnemer = deelnemer
        Me.Lokaal = lokaal
        Me.StartTijdStip = starttijdstip
        Me.StopTijdStip = stoptijdstip
    End Sub

End Class
