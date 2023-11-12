Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddRowsToDataGridView(DataGridView4, 50)
    End Sub

    Private Sub AddRowsToDataGridView(dataGridView As DataGridView, numRows As Integer)
        For i As Integer = 1 To numRows
            dataGridView.Rows.Add($"Name{i}", $"Value{i}")
        Next
    End Sub

End Class
