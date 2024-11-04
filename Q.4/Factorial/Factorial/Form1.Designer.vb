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
        btnCalculate = New Button()
        txtResult = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(105, 91)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(100, 23)
        txtNumber.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(105, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter a number:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(105, 151)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 2
        btnCalculate.Text = "Calculate Factorial"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(292, 91)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(100, 23)
        txtResult.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(292, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 1
        Label2.Text = "Factorial:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(687, 326)
        Controls.Add(btnCalculate)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtResult)
        Controls.Add(txtNumber)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label2 As Label

End Class
