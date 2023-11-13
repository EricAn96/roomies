<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateExpenseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        ExpenseInput = New TextBox()
        ExpectedCost = New Label()
        CostInput = New TextBox()
        CompleteBy = New Label()
        MonthCalendar1 = New MonthCalendar()
        Back = New Button()
        OK = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 32)
        Label1.TabIndex = 0
        Label1.Text = "Create an Expense"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(13, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 21)
        Label2.TabIndex = 1
        Label2.Text = "Name of Expense: "
        ' 
        ' ExpenseInput
        ' 
        ExpenseInput.Location = New Point(147, 84)
        ExpenseInput.Name = "ExpenseInput"
        ExpenseInput.Size = New Size(323, 23)
        ExpenseInput.TabIndex = 2
        ' 
        ' ExpectedCost
        ' 
        ExpectedCost.AutoSize = True
        ExpectedCost.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ExpectedCost.Location = New Point(12, 125)
        ExpectedCost.Name = "ExpectedCost"
        ExpectedCost.Size = New Size(109, 21)
        ExpectedCost.TabIndex = 3
        ExpectedCost.Text = "Expected Cost:"
        ' 
        ' CostInput
        ' 
        CostInput.Location = New Point(132, 123)
        CostInput.Name = "CostInput"
        CostInput.Size = New Size(162, 23)
        CostInput.TabIndex = 4
        ' 
        ' CompleteBy
        ' 
        CompleteBy.AutoSize = True
        CompleteBy.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CompleteBy.Location = New Point(12, 174)
        CompleteBy.Name = "CompleteBy"
        CompleteBy.Size = New Size(105, 21)
        CompleteBy.TabIndex = 5
        CompleteBy.Text = "Complete by: "
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(132, 174)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 7
        ' 
        ' Back
        ' 
        Back.Location = New Point(93, 431)
        Back.Name = "Back"
        Back.Size = New Size(124, 31)
        Back.TabIndex = 11
        Back.Text = "Back"
        Back.UseVisualStyleBackColor = True
        ' 
        ' OK
        ' 
        OK.Location = New Point(246, 431)
        OK.Name = "OK"
        OK.Size = New Size(124, 31)
        OK.TabIndex = 12
        OK.Text = "OK"
        OK.UseVisualStyleBackColor = True
        ' 
        ' CreateExpenseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(515, 910)
        Controls.Add(OK)
        Controls.Add(Back)
        Controls.Add(MonthCalendar1)
        Controls.Add(CompleteBy)
        Controls.Add(CostInput)
        Controls.Add(ExpectedCost)
        Controls.Add(ExpenseInput)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "CreateExpenseForm"
        Text = "CreateExpenseForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ExpenseInput As TextBox
    Friend WithEvents ExpectedCost As Label
    Friend WithEvents CostInput As TextBox
    Friend WithEvents CompleteBy As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Back As Button
    Friend WithEvents OK As Button
End Class
