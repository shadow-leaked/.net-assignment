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
        txtFirstNumber = New TextBox()
        btnAdd = New Button()
        Label1 = New Label()
        txtSecondNumber = New TextBox()
        Label2 = New Label()
        txtResult = New TextBox()
        Label3 = New Label()
        btnDivide = New Button()
        btnSubtract = New Button()
        btnPower = New Button()
        btnMultiply = New Button()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' txtFirstNumber
        ' 
        txtFirstNumber.Location = New Point(84, 114)
        txtFirstNumber.Name = "txtFirstNumber"
        txtFirstNumber.Size = New Size(100, 23)
        txtFirstNumber.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(96, 177)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 1
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(84, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 2
        Label1.Text = "First Number:"
        ' 
        ' txtSecondNumber
        ' 
        txtSecondNumber.Location = New Point(225, 114)
        txtSecondNumber.Name = "txtSecondNumber"
        txtSecondNumber.Size = New Size(100, 23)
        txtSecondNumber.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(225, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 2
        Label2.Text = "Second Number:"
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(386, 114)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(100, 23)
        txtResult.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(386, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 2
        Label3.Text = "Result:"
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(96, 206)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(75, 23)
        btnDivide.TabIndex = 1
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Location = New Point(177, 177)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(75, 23)
        btnSubtract.TabIndex = 1
        btnSubtract.Text = "-"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnPower
        ' 
        btnPower.Location = New Point(177, 206)
        btnPower.Name = "btnPower"
        btnPower.Size = New Size(75, 23)
        btnPower.TabIndex = 1
        btnPower.Text = "^"
        btnPower.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Location = New Point(258, 177)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(75, 23)
        btnMultiply.TabIndex = 1
        btnMultiply.Text = "*"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(258, 206)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(665, 324)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnClear)
        Controls.Add(btnMultiply)
        Controls.Add(btnPower)
        Controls.Add(btnSubtract)
        Controls.Add(btnDivide)
        Controls.Add(btnAdd)
        Controls.Add(txtResult)
        Controls.Add(txtSecondNumber)
        Controls.Add(txtFirstNumber)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstNumber As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSecondNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnClear As Button

End Class
