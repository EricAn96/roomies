Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class App
    Public Sub AddChoreList(chore As String, deadline As DateTime, effort As String, status As String)
        Dim choreInfo() As Object = {chore, deadline, effort, status}

        Me.HomeUserChoreList.Rows.Add(choreInfo)
    End Sub

    Public Sub AddExpenseList(expense As String, deadline As DateTime, cost As Decimal, status As String)
        Dim expenseInfo() As Object = {expense, deadline, cost, status}

        Me.HomeUserExpenseList.Rows.Add(expenseInfo)
    End Sub

    Public Sub AddChoreHistory(chore As String, completion As DateTime, deadline As DateTime, person As String)
        Dim choreInfo() As Object = {chore, completion, deadline, person}

        Me.HistoryChoreList.Rows.Add(choreInfo)
    End Sub

    Public Sub AddExpenseHistory(expense As String, cost As Decimal, expectedCost As Decimal, paid As DateTime, deadline As DateTime, person As String)
        Dim choreInfo() As Object = {expense, cost, expectedCost, paid, deadline, person}

        Me.HistoryExpenseList.Rows.Add(choreInfo)
    End Sub

End Class
