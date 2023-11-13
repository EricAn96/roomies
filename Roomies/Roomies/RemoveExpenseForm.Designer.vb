<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveExpenseForm
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
        RecordedExpense = New Label()
        RemoveExpense = New Label()
        ListOfExpenses = New ComboBox()
        OK = New Button()
        Back = New Button()
        ComboBox1 = New ComboBox()
        Roomie = New Label()
        SuspendLayout()
        ' 
        ' RecordedExpense
        ' 
        RecordedExpense.AutoSize = True
        RecordedExpense.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RecordedExpense.Location = New Point(21, 137)
        RecordedExpense.Name = "RecordedExpense"
        RecordedExpense.Size = New Size(73, 21)
        RecordedExpense.TabIndex = 9
        RecordedExpense.Text = "Expense: "
        ' 
        ' RemoveExpense
        ' 
        RemoveExpense.AutoSize = True
        RemoveExpense.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        RemoveExpense.Location = New Point(12, 9)
        RemoveExpense.Name = "RemoveExpense"
        RemoveExpense.Size = New Size(280, 32)
        RemoveExpense.TabIndex = 8
        RemoveExpense.Text = "Remove an Expense"
        ' 
        ' ListOfExpenses
        ' 
        ListOfExpenses.FormattingEnabled = True
        ListOfExpenses.Location = New Point(119, 135)
        ListOfExpenses.Name = "ListOfExpenses"
        ListOfExpenses.Size = New Size(364, 23)
        ListOfExpenses.TabIndex = 10
        ' 
        ' OK
        ' 
        OK.Location = New Point(260, 192)
        OK.Name = "OK"
        OK.Size = New Size(124, 31)
        OK.TabIndex = 18
        OK.Text = "OK"
        OK.UseVisualStyleBackColor = True
        ' 
        ' Back
        ' 
        Back.Location = New Point(107, 192)
        Back.Name = "Back"
        Back.Size = New Size(124, 31)
        Back.TabIndex = 17
        Back.Text = "Back"
        Back.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(119, 81)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(364, 23)
        ComboBox1.TabIndex = 20
        ' 
        ' Roomie
        ' 
        Roomie.AutoSize = True
        Roomie.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Roomie.Location = New Point(21, 83)
        Roomie.Name = "Roomie"
        Roomie.Size = New Size(92, 21)
        Roomie.TabIndex = 19
        Roomie.Text = "Housemate:"
        ' 
        ' RemoveExpenseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(515, 910)
        Controls.Add(ComboBox1)
        Controls.Add(Roomie)
        Controls.Add(OK)
        Controls.Add(Back)
        Controls.Add(ListOfExpenses)
        Controls.Add(RecordedExpense)
        Controls.Add(RemoveExpense)
        Name = "RemoveExpenseForm"
        Text = "RemoveExpenseForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RecordedExpense As Label
    Friend WithEvents RemoveExpense As Label
    Friend WithEvents ListOfExpenses As ComboBox
    Friend WithEvents OK As Button
    Friend WithEvents Back As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Roomie As Label
End Class
