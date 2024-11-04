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
        txtNumber = New TextBox()
        Label1 = New Label()
        btnGenerate = New Button()
        lstEvenNumbers = New ListBox()
        lstOddNumbers = New ListBox()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(54, 72)
        txtNumber.Multiline = True
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(109, 33)
        txtNumber.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter a number (n):"
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Location = New Point(54, 154)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(75, 23)
        btnGenerate.TabIndex = 2
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' lstEvenNumbers
        ' 
        lstEvenNumbers.FormattingEnabled = True
        lstEvenNumbers.ItemHeight = 15
        lstEvenNumbers.Location = New Point(283, 83)
        lstEvenNumbers.Name = "lstEvenNumbers"
        lstEvenNumbers.Size = New Size(120, 94)
        lstEvenNumbers.TabIndex = 3
        ' 
        ' lstOddNumbers
        ' 
        lstOddNumbers.FormattingEnabled = True
        lstOddNumbers.ItemHeight = 15
        lstOddNumbers.Location = New Point(481, 83)
        lstOddNumbers.Name = "lstOddNumbers"
        lstOddNumbers.Size = New Size(120, 94)
        lstOddNumbers.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(283, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 15)
        Label2.TabIndex = 1
        Label2.Text = "Even Numbers:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(481, 55)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 1
        Label3.Text = "Odd Numbers:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(665, 326)
        Controls.Add(lstOddNumbers)
        Controls.Add(lstEvenNumbers)
        Controls.Add(btnGenerate)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNumber)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lstEvenNumbers As ListBox
    Friend WithEvents lstOddNumbers As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
