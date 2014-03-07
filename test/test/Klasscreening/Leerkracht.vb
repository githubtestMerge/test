Public Class Leerkracht
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
End Class
