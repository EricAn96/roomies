Public Class Form1
    Private roomieList As New List(Of Roomie)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Chores tab init()
        Add_Roomie("Philip")
        Add_Roomie("Eric")
        Add_Roomie("Dharm")
        Add_Roomie("Iman")

        Dim ChoreTab As TabPage = TabControl1.TabPages(1)

        Dim scrollablePanel As New Panel()
        scrollablePanel.AutoScroll = True
        scrollablePanel.Location = New Point(0, 100)
        scrollablePanel.Size = New Size(ChoreTab.Width, ChoreTab.Height - 130)
        ChoreTab.Controls.Add(scrollablePanel)

        For i As Integer = 0 To roomieList.Count - 1
            Dim roomie As Roomie = roomieList(i)

            Dim dataGridView As New DataGridView()
            dataGridView.Size = New Size(ChoreTab.Width - 35, 400)
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Add_DataGridView_Column("Chore", dataGridView)
            Add_DataGridView_Column("Effort Rating", dataGridView)
            Add_DataGridView_Column("Due Date", dataGridView)

            Dim nameLabel As New Label()
            nameLabel.Text = roomie.Name
            nameLabel.Font = New Font(nameLabel.Font.FontFamily, 20, FontStyle.Regular)
            nameLabel.Height = 40

            nameLabel.Location = New Point(10, i * 470)
            dataGridView.Location = New Point(10, i * 470 + nameLabel.Height)

            scrollablePanel.Controls.Add(nameLabel)
            scrollablePanel.Controls.Add(dataGridView)
        Next

    End Sub

    Private Sub Add_Roomie(name As String)
        roomieList.Add(New Roomie(name))
    End Sub

    Private Sub Add_DataGridView_Column(name As String, DGV As DataGridView)
        Dim column As New DataGridViewTextBoxColumn()
        column.Name = name
        DGV.Columns.Add(column)
    End Sub
End Class