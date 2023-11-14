<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        HomeUserExpenseList = New DataGridView()
        colHomeExpense = New DataGridViewTextBoxColumn()
        colHomeExpenseDeadline = New DataGridViewTextBoxColumn()
        colHomeExpenseCost = New DataGridViewTextBoxColumn()
        colHomeExpenseStatus = New DataGridViewTextBoxColumn()
        HomeUserChoreList = New DataGridView()
        colHomeChore = New DataGridViewTextBoxColumn()
        colHomeChoreDeadline = New DataGridViewTextBoxColumn()
        colHomeChoreRating = New DataGridViewTextBoxColumn()
        colHomeChoreStatus = New DataGridViewTextBoxColumn()
        TabPage2 = New TabPage()
        Button3 = New Button()
        Button1 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        TabPage3 = New TabPage()
        RemoveExpense = New Button()
        AssignExpense = New Button()
        CreateExpense = New Button()
        RecordExpense = New Button()
        TabPage4 = New TabPage()
        Label7 = New Label()
        Label5 = New Label()
        HistoryExpenseList = New DataGridView()
        colHistoryExpenseName = New DataGridViewTextBoxColumn()
        colHistoryExpenseCost = New DataGridViewTextBoxColumn()
        colHistoryExpectedCost = New DataGridViewTextBoxColumn()
        colHistoryExpensePaid = New DataGridViewTextBoxColumn()
        colHistoryExpenseDeadline = New DataGridViewTextBoxColumn()
        colHistoryExpensePerson = New DataGridViewTextBoxColumn()
        HistoryChoreList = New DataGridView()
        colHistoryChoreName = New DataGridViewTextBoxColumn()
        colHistoryChoreCompletion = New DataGridViewTextBoxColumn()
        colHistoryChoreDeadline = New DataGridViewTextBoxColumn()
        colHistoryChorePerson = New DataGridViewTextBoxColumn()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(HomeUserExpenseList, ComponentModel.ISupportInitialize).BeginInit()
        CType(HomeUserChoreList, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        CType(HistoryExpenseList, ComponentModel.ISupportInitialize).BeginInit()
        CType(HistoryChoreList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Location = New Point(9, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(502, 898)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(HomeUserExpenseList)
        TabPage1.Controls.Add(HomeUserChoreList)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(494, 870)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Home"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(28, 467)
        Label3.Name = "Label3"
        Label3.Size = New Size(447, 67)
        Label3.TabIndex = 9
        Label3.Text = "Your Expenses"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(28, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(447, 67)
        Label2.TabIndex = 8
        Label2.Text = "Your Chores"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 29.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(28, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(447, 67)
        Label1.TabIndex = 7
        Label1.Text = "Hello User!"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' HomeUserExpenseList
        ' 
        HomeUserExpenseList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        HomeUserExpenseList.Columns.AddRange(New DataGridViewColumn() {colHomeExpense, colHomeExpenseDeadline, colHomeExpenseCost, colHomeExpenseStatus})
        HomeUserExpenseList.Location = New Point(28, 538)
        HomeUserExpenseList.Name = "HomeUserExpenseList"
        HomeUserExpenseList.RowTemplate.Height = 25
        HomeUserExpenseList.ScrollBars = ScrollBars.Vertical
        HomeUserExpenseList.Size = New Size(447, 295)
        HomeUserExpenseList.TabIndex = 6
        ' 
        ' colHomeExpense
        ' 
        colHomeExpense.HeaderText = "Expense"
        colHomeExpense.Name = "colHomeExpense"
        ' 
        ' colHomeExpenseDeadline
        ' 
        colHomeExpenseDeadline.HeaderText = "Deadline"
        colHomeExpenseDeadline.Name = "colHomeExpenseDeadline"
        ' 
        ' colHomeExpenseCost
        ' 
        colHomeExpenseCost.HeaderText = "Cost"
        colHomeExpenseCost.Name = "colHomeExpenseCost"
        ' 
        ' colHomeExpenseStatus
        ' 
        colHomeExpenseStatus.HeaderText = "Status"
        colHomeExpenseStatus.Name = "colHomeExpenseStatus"
        ' 
        ' HomeUserChoreList
        ' 
        HomeUserChoreList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        HomeUserChoreList.Columns.AddRange(New DataGridViewColumn() {colHomeChore, colHomeChoreDeadline, colHomeChoreRating, colHomeChoreStatus})
        HomeUserChoreList.Location = New Point(28, 167)
        HomeUserChoreList.MultiSelect = False
        HomeUserChoreList.Name = "HomeUserChoreList"
        HomeUserChoreList.ReadOnly = True
        HomeUserChoreList.RowHeadersWidth = 30
        HomeUserChoreList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        HomeUserChoreList.RowTemplate.Height = 25
        HomeUserChoreList.ScrollBars = ScrollBars.Vertical
        HomeUserChoreList.Size = New Size(447, 295)
        HomeUserChoreList.TabIndex = 4
        ' 
        ' colHomeChore
        ' 
        colHomeChore.HeaderText = "Chore"
        colHomeChore.Name = "colHomeChore"
        ' 
        ' colHomeChoreDeadline
        ' 
        colHomeChoreDeadline.HeaderText = "Deadline"
        colHomeChoreDeadline.Name = "colHomeChoreDeadline"
        ' 
        ' colHomeChoreRating
        ' 
        colHomeChoreRating.HeaderText = "Effort Rating"
        colHomeChoreRating.Name = "colHomeChoreRating"
        ' 
        ' colHomeChoreStatus
        ' 
        colHomeChoreStatus.HeaderText = "Status"
        colHomeChoreStatus.Name = "colHomeChoreStatus"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Button3)
        TabPage2.Controls.Add(Button1)
        TabPage2.Controls.Add(Button8)
        TabPage2.Controls.Add(Button7)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(494, 870)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Chores"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(248, 22)
        Button3.Name = "Button3"
        Button3.Size = New Size(110, 49)
        Button3.TabIndex = 13
        Button3.Text = "Modify Chore"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(133, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 49)
        Button1.TabIndex = 12
        Button1.Text = "Delete Chore"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(362, 22)
        Button8.Name = "Button8"
        Button8.Size = New Size(110, 49)
        Button8.TabIndex = 11
        Button8.Text = "Assign Chore"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(22, 22)
        Button7.Name = "Button7"
        Button7.Size = New Size(110, 49)
        Button7.TabIndex = 10
        Button7.Text = "Create chore"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(RemoveExpense)
        TabPage3.Controls.Add(AssignExpense)
        TabPage3.Controls.Add(CreateExpense)
        TabPage3.Controls.Add(RecordExpense)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(494, 870)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Expenses"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' RemoveExpense
        ' 
        RemoveExpense.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        RemoveExpense.Location = New Point(134, 28)
        RemoveExpense.Name = "RemoveExpense"
        RemoveExpense.Size = New Size(113, 120)
        RemoveExpense.TabIndex = 5
        RemoveExpense.Text = "Remove expense"
        RemoveExpense.UseVisualStyleBackColor = True
        ' 
        ' AssignExpense
        ' 
        AssignExpense.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        AssignExpense.Location = New Point(250, 28)
        AssignExpense.Name = "AssignExpense"
        AssignExpense.Size = New Size(113, 120)
        AssignExpense.TabIndex = 4
        AssignExpense.Text = "Assign expense"
        AssignExpense.UseVisualStyleBackColor = True
        ' 
        ' CreateExpense
        ' 
        CreateExpense.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        CreateExpense.Location = New Point(18, 28)
        CreateExpense.Name = "CreateExpense"
        CreateExpense.Size = New Size(110, 120)
        CreateExpense.TabIndex = 3
        CreateExpense.Text = "Create expense"
        CreateExpense.UseVisualStyleBackColor = True
        ' 
        ' RecordExpense
        ' 
        RecordExpense.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        RecordExpense.Location = New Point(365, 28)
        RecordExpense.Name = "RecordExpense"
        RecordExpense.Size = New Size(113, 120)
        RecordExpense.TabIndex = 2
        RecordExpense.Text = "Record expense"
        RecordExpense.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Label7)
        TabPage4.Controls.Add(Label5)
        TabPage4.Controls.Add(HistoryExpenseList)
        TabPage4.Controls.Add(HistoryChoreList)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(494, 870)
        TabPage4.TabIndex = 3
        TabPage4.Text = "History"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(22, 441)
        Label7.Name = "Label7"
        Label7.Size = New Size(451, 42)
        Label7.TabIndex = 10
        Label7.Text = "Expenses"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(22, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(451, 42)
        Label5.TabIndex = 9
        Label5.Text = "Chore Overview"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' HistoryExpenseList
        ' 
        HistoryExpenseList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        HistoryExpenseList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        HistoryExpenseList.Columns.AddRange(New DataGridViewColumn() {colHistoryExpenseName, colHistoryExpenseCost, colHistoryExpectedCost, colHistoryExpensePaid, colHistoryExpenseDeadline, colHistoryExpensePerson})
        HistoryExpenseList.Location = New Point(22, 486)
        HistoryExpenseList.Name = "HistoryExpenseList"
        HistoryExpenseList.RowTemplate.Height = 25
        HistoryExpenseList.Size = New Size(451, 361)
        HistoryExpenseList.TabIndex = 3
        ' 
        ' colHistoryExpenseName
        ' 
        colHistoryExpenseName.HeaderText = "Expense"
        colHistoryExpenseName.Name = "colHistoryExpenseName"
        ' 
        ' colHistoryExpenseCost
        ' 
        colHistoryExpenseCost.HeaderText = "Cost"
        colHistoryExpenseCost.Name = "colHistoryExpenseCost"
        ' 
        ' colHistoryExpectedCost
        ' 
        colHistoryExpectedCost.HeaderText = "Expected Cost"
        colHistoryExpectedCost.Name = "colHistoryExpectedCost"
        ' 
        ' colHistoryExpensePaid
        ' 
        colHistoryExpensePaid.HeaderText = "Date Paid"
        colHistoryExpensePaid.Name = "colHistoryExpensePaid"
        ' 
        ' colHistoryExpenseDeadline
        ' 
        colHistoryExpenseDeadline.HeaderText = "Deadline"
        colHistoryExpenseDeadline.Name = "colHistoryExpenseDeadline"
        ' 
        ' colHistoryExpensePerson
        ' 
        colHistoryExpensePerson.HeaderText = "Person"
        colHistoryExpensePerson.Name = "colHistoryExpensePerson"
        ' 
        ' HistoryChoreList
        ' 
        HistoryChoreList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        HistoryChoreList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        HistoryChoreList.Columns.AddRange(New DataGridViewColumn() {colHistoryChoreName, colHistoryChoreCompletion, colHistoryChoreDeadline, colHistoryChorePerson})
        HistoryChoreList.Location = New Point(22, 71)
        HistoryChoreList.Name = "HistoryChoreList"
        HistoryChoreList.RowTemplate.Height = 25
        HistoryChoreList.Size = New Size(451, 367)
        HistoryChoreList.TabIndex = 2
        ' 
        ' colHistoryChoreName
        ' 
        colHistoryChoreName.HeaderText = "Chore"
        colHistoryChoreName.Name = "colHistoryChoreName"
        ' 
        ' colHistoryChoreCompletion
        ' 
        colHistoryChoreCompletion.HeaderText = "Completion Date"
        colHistoryChoreCompletion.Name = "colHistoryChoreCompletion"
        ' 
        ' colHistoryChoreDeadline
        ' 
        colHistoryChoreDeadline.HeaderText = "Deadline"
        colHistoryChoreDeadline.Name = "colHistoryChoreDeadline"
        ' 
        ' colHistoryChorePerson
        ' 
        colHistoryChorePerson.HeaderText = "Person"
        colHistoryChorePerson.Name = "colHistoryChorePerson"
        ' 
        ' App
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(515, 910)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "App"
        Text = "Roomies"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(HomeUserExpenseList, ComponentModel.ISupportInitialize).EndInit()
        CType(HomeUserChoreList, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        CType(HistoryExpenseList, ComponentModel.ISupportInitialize).EndInit()
        CType(HistoryChoreList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
End Class
