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
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
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
        Button3.Location = New Point(247, 22)
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
        RemoveExpense.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        RemoveExpense.Location = New Point(134, 28)
        RemoveExpense.Name = "RemoveExpense"
        RemoveExpense.Size = New Size(113, 120)
        RemoveExpense.TabIndex = 5
        RemoveExpense.Text = "Remove expense"
        RemoveExpense.UseVisualStyleBackColor = True
        ' 
        ' AssignExpense
        ' 
        AssignExpense.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        AssignExpense.Location = New Point(250, 28)
        AssignExpense.Name = "AssignExpense"
        AssignExpense.Size = New Size(113, 120)
        AssignExpense.TabIndex = 4
        AssignExpense.Text = "Assign expense"
        AssignExpense.UseVisualStyleBackColor = True
        ' 
        ' CreateExpense
        ' 
        CreateExpense.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        CreateExpense.Location = New Point(18, 28)
        CreateExpense.Name = "CreateExpense"
        CreateExpense.Size = New Size(110, 120)
        CreateExpense.TabIndex = 3
        CreateExpense.Text = "Create expense"
        CreateExpense.UseVisualStyleBackColor = True
        ' 
        ' RecordExpense
        ' 
        RecordExpense.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RecordExpense.Location = New Point(365, 28)
        RecordExpense.Name = "RecordExpense"
        RecordExpense.Size = New Size(113, 120)
        RecordExpense.TabIndex = 2
        RecordExpense.Text = "Record expense"
        RecordExpense.UseVisualStyleBackColor = True
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
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents RecordExpense As Button
    Friend WithEvents RemoveExpense As Button
    Friend WithEvents AssignExpense As Button
    Friend WithEvents CreateExpense As Button
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
End Class
