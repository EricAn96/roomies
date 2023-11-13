Public Class Expense
    Public Property AssignedRoomie As String
    Public Property ExpenseName As String
    Public Property Amount As Single
    Public Property ActionDate As Date
    Public Property DueDate As Date


    Public Sub New(assignedRoomie As String, expenseName As String, amount As Single, dueDate As Date)
        Me.AssignedRoomie = assignedRoomie
        Me.ExpenseName = expenseName
        Me.Amount = amount
        Me.DueDate = dueDate
    End Sub
End Class
