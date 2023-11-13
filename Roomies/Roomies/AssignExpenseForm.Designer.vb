<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignExpenseForm
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
        OK = New Button()
        Back = New Button()
        AssignExpenses = New ComboBox()
        RecordedExpense = New Label()
        RemoveExpense = New Label()
        Housemates = New ComboBox()
        AssignTo = New Label()
        SuspendLayout()
        ' 
        ' OK
        ' 
        OK.Location = New Point(260, 192)
        OK.Name = "OK"
        OK.Size = New Size(124, 31)
        OK.TabIndex = 23
        OK.Text = "OK"
        OK.UseVisualStyleBackColor = True
        ' 
        ' Back
        ' 
        Back.Location = New Point(107, 192)
        Back.Name = "Back"
        Back.Size = New Size(124, 31)
        Back.TabIndex = 22
        Back.Text = "Back"
        Back.UseVisualStyleBackColor = True
        ' 
        ' AssignExpenses
        ' 
        AssignExpenses.FormattingEnabled = True
        AssignExpenses.Location = New Point(98, 62)
        AssignExpenses.Name = "AssignExpenses"
        AssignExpenses.Size = New Size(376, 23)
        AssignExpenses.TabIndex = 21
        ' 
        ' RecordedExpense
        ' 
        RecordedExpense.AutoSize = True
        RecordedExpense.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RecordedExpense.Location = New Point(12, 64)
        RecordedExpense.Name = "RecordedExpense"
        RecordedExpense.Size = New Size(73, 21)
        RecordedExpense.TabIndex = 20
        RecordedExpense.Text = "Expense: "
        ' 
        ' RemoveExpense
        ' 
        RemoveExpense.AutoSize = True
        RemoveExpense.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        RemoveExpense.Location = New Point(12, 9)
        RemoveExpense.Name = "RemoveExpense"
        RemoveExpense.Size = New Size(257, 32)
        RemoveExpense.TabIndex = 19
        RemoveExpense.Text = "Assign an Expense"
        ' 
        ' Housemates
        ' 
        Housemates.FormattingEnabled = True
        Housemates.Location = New Point(98, 115)
        Housemates.Name = "Housemates"
        Housemates.Size = New Size(189, 23)
        Housemates.TabIndex = 25
        ' 
        ' AssignTo
        ' 
        AssignTo.AutoSize = True
        AssignTo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        AssignTo.Location = New Point(12, 117)
        AssignTo.Name = "AssignTo"
        AssignTo.Size = New Size(81, 21)
        AssignTo.TabIndex = 24
        AssignTo.Text = "Assign to: "
        ' 
        ' AssignExpenseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(515, 910)
        Controls.Add(Housemates)
        Controls.Add(AssignTo)
        Controls.Add(OK)
        Controls.Add(Back)
        Controls.Add(AssignExpenses)
        Controls.Add(RecordedExpense)
        Controls.Add(RemoveExpense)
        Name = "AssignExpenseForm"
        Text = "AssignExpenseForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OK As Button
    Friend WithEvents Back As Button
    Friend WithEvents AssignExpenses As ComboBox
    Friend WithEvents RecordedExpense As Label
    Friend WithEvents RemoveExpense As Label
    Friend WithEvents Housemates As ComboBox
    Friend WithEvents AssignTo As Label
End Class
