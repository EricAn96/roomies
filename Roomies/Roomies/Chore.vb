Public Class Chore
    Public Property AssignedRoomie As String
    Public Property ChoreName As String
    Public Property EffortRating As Single
    Public Property ActionDate As Date
    Public Property DueDate As Date
    Public Sub New(assignedRoomie As String, choreName As String, dueDate As Date, effortRating As Single)
        Me.AssignedRoomie = assignedRoomie
        Me.ChoreName = choreName
        Me.DueDate = dueDate
        Me.EffortRating = effortRating
    End Sub
End Class