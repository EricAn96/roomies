Public Class Roomie
    Public Property Name As String
    Public Property Chores As New List(Of Chore)()
    Public Property Expenses As New List(Of Expense)()

    Public Sub New(name As String)
        Me.Name = name
    End Sub
End Class