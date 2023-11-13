<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordExpenseForm
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
        AmountPaidInput = New TextBox()
        AmountPaid = New Label()
        RecordedExpense = New Label()
        RecordExpense = New Label()
        CompletedExpense = New Label()
        Yes = New RadioButton()
        No = New RadioButton()
        OK = New Button()
        Back = New Button()
        ComboBox1 = New ComboBox()
        MonthCalendar1 = New MonthCalendar()
        CompletedOn = New Label()
        SuspendLayout()
        ' 
        ' AmountPaidInput
        ' 
        AmountPaidInput.Location = New Point(133, 179)
        AmountPaidInput.Name = "AmountPaidInput"
        AmountPaidInput.Size = New Size(162, 23)
        AmountPaidInput.TabIndex = 9
        ' 
        ' AmountPaid
        ' 
        AmountPaid.AutoSize = True
        AmountPaid.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        AmountPaid.Location = New Point(13, 181)
        AmountPaid.Name = "AmountPaid"
        AmountPaid.Size = New Size(106, 21)
        AmountPaid.TabIndex = 8
        AmountPaid.Text = "Amount Paid: "
        ' 
        ' RecordedExpense
        ' 
        RecordedExpense.AutoSize = True
        RecordedExpense.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RecordedExpense.Location = New Point(13, 81)
        RecordedExpense.Name = "RecordedExpense"
        RecordedExpense.Size = New Size(73, 21)
        RecordedExpense.TabIndex = 6
        RecordedExpense.Text = "Expense: "
        ' 
        ' RecordExpense
        ' 
        RecordExpense.AutoSize = True
        RecordExpense.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        RecordExpense.Location = New Point(12, 18)
        RecordExpense.Name = "RecordExpense"
        RecordExpense.Size = New Size(267, 32)
        RecordExpense.TabIndex = 5
        RecordExpense.Text = "Record an Expense"
        ' 
        ' CompletedExpense
        ' 
        CompletedExpense.AutoSize = True
        CompletedExpense.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedExpense.Location = New Point(12, 132)
        CompletedExpense.Name = "CompletedExpense"
        CompletedExpense.Size = New Size(153, 21)
        CompletedExpense.TabIndex = 10
        CompletedExpense.Text = "Completed Expense?"
        ' 
        ' Yes
        ' 
        Yes.AutoSize = True
        Yes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Yes.Location = New Point(188, 131)
        Yes.Name = "Yes"
        Yes.Size = New Size(51, 25)
        Yes.TabIndex = 11
        Yes.TabStop = True
        Yes.Text = "Yes"
        Yes.UseVisualStyleBackColor = True
        ' 
        ' No
        ' 
        No.AutoSize = True
        No.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        No.Location = New Point(255, 132)
        No.Name = "No"
        No.Size = New Size(49, 25)
        No.TabIndex = 12
        No.TabStop = True
        No.Text = "No"
        No.UseVisualStyleBackColor = True
        ' 
        ' OK
        ' 
        OK.Location = New Point(255, 477)
        OK.Name = "OK"
        OK.Size = New Size(124, 31)
        OK.TabIndex = 16
        OK.Text = "OK"
        OK.UseVisualStyleBackColor = True
        ' 
        ' Back
        ' 
        Back.Location = New Point(102, 477)
        Back.Name = "Back"
        Back.Size = New Size(124, 31)
        Back.TabIndex = 15
        Back.Text = "Back"
        Back.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(92, 83)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(384, 23)
        ComboBox1.TabIndex = 17
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(133, 234)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 19
        ' 
        ' CompletedOn
        ' 
        CompletedOn.AutoSize = True
        CompletedOn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CompletedOn.Location = New Point(13, 234)
        CompletedOn.Name = "CompletedOn"
        CompletedOn.Size = New Size(115, 21)
        CompletedOn.TabIndex = 18
        CompletedOn.Text = "Completed on: "
        ' 
        ' RecordExpenseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(515, 910)
        Controls.Add(MonthCalendar1)
        Controls.Add(CompletedOn)
        Controls.Add(ComboBox1)
        Controls.Add(OK)
        Controls.Add(Back)
        Controls.Add(No)
        Controls.Add(Yes)
        Controls.Add(CompletedExpense)
        Controls.Add(AmountPaidInput)
        Controls.Add(AmountPaid)
        Controls.Add(RecordedExpense)
        Controls.Add(RecordExpense)
        Name = "RecordExpenseForm"
        Text = "RecordExpenseForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AmountPaidInput As TextBox
    Friend WithEvents AmountPaid As Label
    Friend WithEvents RecordedExpense As Label
    Friend WithEvents RecordExpense As Label
    Friend WithEvents CompletedExpense As Label
    Friend WithEvents Yes As RadioButton
    Friend WithEvents No As RadioButton
    Friend WithEvents OK As Button
    Friend WithEvents Back As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents CompletedOn As Label
End Class
