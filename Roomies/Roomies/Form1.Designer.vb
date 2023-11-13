<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Button9 = New Button()
        Button6 = New Button()
        TabPage2 = New TabPage()
        Modify_Chore_Button = New Button()
        Delete_Chore_Button = New Button()
        Assign_Chore_Button = New Button()
        Create_Chore_Button = New Button()
        TabPage3 = New TabPage()
        Expenese_Tab_DGV = New DataGridView()
        Label1 = New Label()
        TabPage4 = New TabPage()
        DataGridView5 = New DataGridView()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        DataGridView4 = New DataGridView()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Button17 = New Button()
        Button16 = New Button()
        Expenses_Tab_ExpenseName = New DataGridViewTextBoxColumn()
        Expeneses_Tab_Amount = New DataGridViewTextBoxColumn()
        Assign_Expense_Button = New Button()
        Delete_Expense_Button = New Button()
        Record_Expense_Button = New Button()
        Create_Expense_Button = New Button()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(Expenese_Tab_DGV, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        CType(DataGridView5, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView4, ComponentModel.ISupportInitialize).BeginInit()
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
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Controls.Add(Button9)
        TabPage1.Controls.Add(Button6)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(494, 870)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Home"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(28, 167)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(447, 666)
        DataGridView1.TabIndex = 4
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Chore"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "deadline"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "effort rating"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Status"
        Column4.Name = "Column4"
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point)
        Button9.Location = New Point(28, 17)
        Button9.Name = "Button9"
        Button9.Size = New Size(447, 67)
        Button9.TabIndex = 3
        Button9.Text = "Hello hihi"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Location = New Point(28, 106)
        Button6.Name = "Button6"
        Button6.Size = New Size(447, 55)
        Button6.TabIndex = 2
        Button6.Text = "Overview / Your List of chores and expenses"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Modify_Chore_Button)
        TabPage2.Controls.Add(Delete_Chore_Button)
        TabPage2.Controls.Add(Assign_Chore_Button)
        TabPage2.Controls.Add(Create_Chore_Button)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(494, 870)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Chores"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Modify_Chore_Button
        ' 
        Modify_Chore_Button.Location = New Point(252, 22)
        Modify_Chore_Button.Name = "Modify_Chore_Button"
        Modify_Chore_Button.Size = New Size(100, 50)
        Modify_Chore_Button.TabIndex = 13
        Modify_Chore_Button.Text = "Modify Chore"
        Modify_Chore_Button.UseVisualStyleBackColor = True
        ' 
        ' Delete_Chore_Button
        ' 
        Delete_Chore_Button.Location = New Point(138, 22)
        Delete_Chore_Button.Name = "Delete_Chore_Button"
        Delete_Chore_Button.Size = New Size(100, 50)
        Delete_Chore_Button.TabIndex = 12
        Delete_Chore_Button.Text = "Delete Chore"
        Delete_Chore_Button.UseVisualStyleBackColor = True
        ' 
        ' Assign_Chore_Button
        ' 
        Assign_Chore_Button.Location = New Point(367, 22)
        Assign_Chore_Button.Name = "Assign_Chore_Button"
        Assign_Chore_Button.Size = New Size(100, 50)
        Assign_Chore_Button.TabIndex = 11
        Assign_Chore_Button.Text = "Assign Chore"
        Assign_Chore_Button.UseVisualStyleBackColor = True
        ' 
        ' Create_Chore_Button
        ' 
        Create_Chore_Button.Location = New Point(27, 22)
        Create_Chore_Button.Name = "Create_Chore_Button"
        Create_Chore_Button.Size = New Size(100, 50)
        Create_Chore_Button.TabIndex = 10
        Create_Chore_Button.Text = "Create chore"
        Create_Chore_Button.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Assign_Expense_Button)
        TabPage3.Controls.Add(Delete_Expense_Button)
        TabPage3.Controls.Add(Record_Expense_Button)
        TabPage3.Controls.Add(Create_Expense_Button)
        TabPage3.Controls.Add(Expenese_Tab_DGV)
        TabPage3.Controls.Add(Label1)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(494, 870)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Expenses"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Expenese_Tab_DGV
        ' 
        Expenese_Tab_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Expenese_Tab_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Expenese_Tab_DGV.Columns.AddRange(New DataGridViewColumn() {Expenses_Tab_ExpenseName, Expeneses_Tab_Amount})
        Expenese_Tab_DGV.Location = New Point(18, 141)
        Expenese_Tab_DGV.Name = "Expenese_Tab_DGV"
        Expenese_Tab_DGV.RowTemplate.Height = 25
        Expenese_Tab_DGV.Size = New Size(458, 726)
        Expenese_Tab_DGV.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(216, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 6
        Label1.Text = "Budget: $0"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(DataGridView5)
        TabPage4.Controls.Add(DataGridView4)
        TabPage4.Controls.Add(Button17)
        TabPage4.Controls.Add(Button16)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(494, 870)
        TabPage4.TabIndex = 3
        TabPage4.Text = "History"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView5
        ' 
        DataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView5.Columns.AddRange(New DataGridViewColumn() {Column9, Column10, Column11, Column12, Column13, Column14})
        DataGridView5.Location = New Point(22, 486)
        DataGridView5.Name = "DataGridView5"
        DataGridView5.RowTemplate.Height = 25
        DataGridView5.Size = New Size(451, 333)
        DataGridView5.TabIndex = 3
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Expense"
        Column9.Name = "Column9"
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "actual amount"
        Column10.Name = "Column10"
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "expected amount"
        Column11.Name = "Column11"
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "paid date"
        Column12.Name = "Column12"
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "payment deadline"
        Column13.Name = "Column13"
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "Person"
        Column14.Name = "Column14"
        ' 
        ' DataGridView4
        ' 
        DataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView4.Columns.AddRange(New DataGridViewColumn() {Column5, Column6, Column7, Column8})
        DataGridView4.Location = New Point(22, 73)
        DataGridView4.Name = "DataGridView4"
        DataGridView4.RowTemplate.Height = 25
        DataGridView4.Size = New Size(451, 367)
        DataGridView4.TabIndex = 2
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Chore"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "finished date"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "deadline"
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Person"
        Column8.Name = "Column8"
        ' 
        ' Button17
        ' 
        Button17.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button17.Location = New Point(22, 446)
        Button17.Name = "Button17"
        Button17.Size = New Size(451, 34)
        Button17.TabIndex = 1
        Button17.Text = "Expenses"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button16.Location = New Point(22, 18)
        Button16.Name = "Button16"
        Button16.Size = New Size(451, 49)
        Button16.TabIndex = 0
        Button16.Text = "Overview of chores "
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Expenses_Tab_ExpenseName
        ' 
        Expenses_Tab_ExpenseName.HeaderText = "Expense name"
        Expenses_Tab_ExpenseName.Name = "Expenses_Tab_ExpenseName"
        ' 
        ' Expeneses_Tab_Amount
        ' 
        Expeneses_Tab_Amount.HeaderText = "Amount"
        Expeneses_Tab_Amount.Name = "Expeneses_Tab_Amount"
        ' 
        ' Assign_Expense_Button
        ' 
        Assign_Expense_Button.Location = New Point(252, 22)
        Assign_Expense_Button.Name = "Assign_Expense_Button"
        Assign_Expense_Button.Size = New Size(100, 50)
        Assign_Expense_Button.TabIndex = 17
        Assign_Expense_Button.Text = "Assign Expense"
        Assign_Expense_Button.UseVisualStyleBackColor = True
        ' 
        ' Delete_Expense_Button
        ' 
        Delete_Expense_Button.Location = New Point(138, 22)
        Delete_Expense_Button.Name = "Delete_Expense_Button"
        Delete_Expense_Button.Size = New Size(100, 50)
        Delete_Expense_Button.TabIndex = 16
        Delete_Expense_Button.Text = "Delete Expense"
        Delete_Expense_Button.UseVisualStyleBackColor = True
        ' 
        ' Record_Expense_Button
        ' 
        Record_Expense_Button.Location = New Point(367, 22)
        Record_Expense_Button.Name = "Record_Expense_Button"
        Record_Expense_Button.Size = New Size(100, 50)
        Record_Expense_Button.TabIndex = 15
        Record_Expense_Button.Text = "Record Expense"
        Record_Expense_Button.UseVisualStyleBackColor = True
        ' 
        ' Create_Expense_Button
        ' 
        Create_Expense_Button.Location = New Point(27, 22)
        Create_Expense_Button.Name = "Create_Expense_Button"
        Create_Expense_Button.Size = New Size(100, 50)
        Create_Expense_Button.TabIndex = 14
        Create_Expense_Button.Text = "Create Expense"
        Create_Expense_Button.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(515, 910)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(Expenese_Tab_DGV, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        CType(DataGridView5, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Assign_Chore_Button As Button
    Friend WithEvents Create_Chore_Button As Button
    Friend WithEvents Modify_Chore_Button As Button
    Friend WithEvents Delete_Chore_Button As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
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
    Friend WithEvents Expenese_Tab_DGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Assign_Expense_Button As Button
    Friend WithEvents Delete_Expense_Button As Button
    Friend WithEvents Record_Expense_Button As Button
    Friend WithEvents Create_Expense_Button As Button
    Friend WithEvents Expenses_Tab_ExpenseName As DataGridViewTextBoxColumn
    Friend WithEvents Expeneses_Tab_Amount As DataGridViewTextBoxColumn
End Class
