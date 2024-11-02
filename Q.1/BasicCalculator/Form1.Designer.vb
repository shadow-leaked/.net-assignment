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
    Partial Class Form1
        Inherits System.Windows.Forms.Form

        Private components As System.ComponentModel.IContainer

        Private Sub InitializeComponent()
            Me.LabelNumber1 = New System.Windows.Forms.Label()
            Me.LabelNumber2 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.Labeloperator = New System.Windows.Forms.Label()
            Me.Result = New System.Windows.Forms.Label()
            Me.ButtonAdd = New System.Windows.Forms.Button()
            Me.ButtonSubtract = New System.Windows.Forms.Button()
            Me.ButtonMultiply = New System.Windows.Forms.Button()
            Me.ButtonDivide = New System.Windows.Forms.Button()
            Me.ButtonPower = New System.Windows.Forms.Button()
            Me.ButtonClear = New System.Windows.Forms.Button()
            Me.ButtonResult = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            ' LabelNumber1
            '
            Me.LabelNumber1.AutoSize = True
            Me.LabelNumber1.Location = New System.Drawing.Point(13, 13)
            Me.LabelNumber1.Name = "LabelNumber1"
            Me.LabelNumber1.Size = New System.Drawing.Size(53, 13)
            Me.LabelNumber1.Text = "Number 1"
            '
            ' LabelNumber2
            '
            Me.LabelNumber2.AutoSize = True
            Me.LabelNumber2.Location = New System.Drawing.Point(13, 39)
            Me.LabelNumber2.Name = "LabelNumber2"
            Me.LabelNumber2.Size = New System.Drawing.Size(53, 13)
            Me.LabelNumber2.Text = "Number 2"
            '
            ' TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(72, 10)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(100, 20)
            '
            ' TextBox2
            '
            Me.TextBox2.Location = New System.Drawing.Point(72, 36)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(100, 20)
            '
            ' Labeloperator
            '
            Me.Labeloperator.AutoSize = True
            Me.Labeloperator.Location = New System.Drawing.Point(13, 66)
            Me.Labeloperator.Name = "Labeloperator"
            Me.Labeloperator.Size = New System.Drawing.Size(0, 13)
            '
            ' Result
            '
            Me.Result.AutoSize = True
            Me.Result.Location = New System.Drawing.Point(13, 260)
            Me.Result.Name = "Result"
            Me.Result.Size = New System.Drawing.Size(37, 13)
            Me.Result.Text = "Result: "
            '
            ' ButtonAdd
            '
            Me.ButtonAdd.Location = New System.Drawing.Point(16, 100)
            Me.ButtonAdd.Name = "ButtonAdd"
            Me.ButtonAdd.Size = New System.Drawing.Size(45, 23)
            Me.ButtonAdd.Text = "+"
            '
            ' ButtonSubtract
            '
            Me.ButtonSubtract.Location = New System.Drawing.Point(67, 100)
            Me.ButtonSubtract.Name = "ButtonSubtract"
            Me.ButtonSubtract.Size = New System.Drawing.Size(45, 23)
            Me.ButtonSubtract.Text = "-"
            '
            ' ButtonMultiply
            '
            Me.ButtonMultiply.Location = New System.Drawing.Point(118, 100)
            Me.ButtonMultiply.Name = "ButtonMultiply"
            Me.ButtonMultiply.Size = New System.Drawing.Size(45, 23)
            Me.ButtonMultiply.Text = "*"
            '
            ' ButtonDivide
            '
            Me.ButtonDivide.Location = New System.Drawing.Point(169, 100)
            Me.ButtonDivide.Name = "ButtonDivide"
            Me.ButtonDivide.Size = New System.Drawing.Size(45, 23)
            Me.ButtonDivide.Text = "/"
            '
            ' ButtonPower
            '
            Me.ButtonPower.Location = New System.Drawing.Point(220, 100)
            Me.ButtonPower.Name = "ButtonPower"
            Me.ButtonPower.Size = New System.Drawing.Size(45, 23)
            Me.ButtonPower.Text = "^"
            '
            ' ButtonClear
            '
            Me.ButtonClear.Location = New System.Drawing.Point(271, 100)
            Me.ButtonClear.Name = "ButtonClear"
            Me.ButtonClear.Size = New System.Drawing.Size(45, 23)
            Me.ButtonClear.Text = "C"
            '
            ' ButtonResult
            '
            Me.ButtonResult.Location = New System.Drawing.Point(16, 130)
            Me.ButtonResult.Name = "ButtonResult"
            Me.ButtonResult.Size = New System.Drawing.Size(75, 23)
            Me.ButtonResult.Text = "="
            '
            ' Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(334, 311)
            Me.Controls.Add(Me.ButtonAdd)
            Me.Controls.Add(Me.ButtonSubtract)
            Me.Controls.Add(Me.ButtonMultiply)
            Me.Controls.Add(Me.ButtonDivide)
            Me.Controls.Add(Me.ButtonPower)
            Me.Controls.Add(Me.ButtonClear)
            Me.Controls.Add(Me.ButtonResult)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.TextBox2)
            Me.Controls.Add(Me.Labeloperator)
            Me.Controls.Add(Me.Result)
            Me.Controls.Add(Me.LabelNumber1)
            Me.Controls.Add(Me.LabelNumber2)
            Me.Name = "Form1"
            Me.Text = "Basic Calculator"
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Friend WithEvents LabelNumber1 As System.Windows.Forms.Label
        Friend WithEvents LabelNumber2 As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
        Friend WithEvents Labeloperator As System.Windows.Forms.Label
        Friend WithEvents Result As System.Windows.Forms.Label
        Friend WithEvents ButtonAdd As System.Windows.Forms.Button
        Friend WithEvents ButtonSubtract As System.Windows.Forms.Button
        Friend WithEvents ButtonMultiply As System.Windows.Forms.Button
        Friend WithEvents ButtonDivide As System.Windows.Forms.Button
        Friend WithEvents ButtonPower As System.Windows.Forms.Button
        Friend WithEvents ButtonClear As System.Windows.Forms.Button
        Friend WithEvents ButtonResult As System.Windows.Forms.Button
    End Class


    'Private Sub InitializeComponent()
    '    Label1 = New Label()
    '    Label2 = New Label()
    '    ButtonResult = New Button()
    '    TextBox1 = New TextBox()
    '    TextBox2 = New TextBox()
    '    ButtonAdd = New Button()
    '    ButtonSubtract = New Button()
    '    ButtonMultiply = New Button()
    '    ButtonDivide = New Button()
    '    ButtonPower = New Button()
    '    ButtonClear = New Button()
    '    LabelOperator = New Label()
    '    Label4 = New Label()
    '    TextBox4 = New TextBox()
    '    SuspendLayout()
    '    ' 
    '    ' Label1
    '    ' 
    '    Label1.AutoSize = True
    '    Label1.Location = New Point(50, 56)
    '    Label1.Name = "Label1"
    '    Label1.Size = New Size(60, 15)
    '    Label1.TabIndex = 0
    '    Label1.Text = "Number 1"
    '    ' 
    '    ' Label2
    '    ' 
    '    Label2.AutoSize = True
    '    Label2.Location = New Point(317, 60)
    '    Label2.Name = "Label2"
    '    Label2.RightToLeft = RightToLeft.No
    '    Label2.Size = New Size(60, 15)
    '    Label2.TabIndex = 0
    '    Label2.Text = "Number 2"
    '    ' 
    '    ' ButtonResult
    '    ' 
    '    ButtonResult.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
    '    ButtonResult.Location = New Point(89, 268)
    '    ButtonResult.Name = "ButtonResult"
    '    ButtonResult.Size = New Size(75, 23)
    '    ButtonResult.TabIndex = 1
    '    ButtonResult.Text = "="
    '    ButtonResult.UseVisualStyleBackColor = True
    '    ' 
    '    ' TextBox1
    '    ' 
    '    TextBox1.Location = New Point(51, 78)
    '    TextBox1.Name = "TextBox1"
    '    TextBox1.Size = New Size(100, 23)
    '    TextBox1.TabIndex = 2
    '    ' 
    '    ' TextBox2
    '    ' 
    '    TextBox2.Location = New Point(318, 78)
    '    TextBox2.Name = "TextBox2"
    '    TextBox2.Size = New Size(100, 23)
    '    TextBox2.TabIndex = 2
    '    ' 
    '    ' ButtonAdd
    '    ' 
    '    ButtonAdd.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
    '    ButtonAdd.Location = New Point(89, 183)
    '    ButtonAdd.Name = "ButtonAdd"
    '    ButtonAdd.Size = New Size(75, 23)
    '    ButtonAdd.TabIndex = 1
    '    ButtonAdd.Text = "+"
    '    ButtonAdd.UseVisualStyleBackColor = True
    '    ' 
    '    ' ButtonSubtract
    '    ' 
    '    ButtonSubtract.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
    '    ButtonSubtract.Location = New Point(170, 183)
    '    ButtonSubtract.Name = "ButtonSubtract"
    '    ButtonSubtract.Size = New Size(75, 23)
    '    ButtonSubtract.TabIndex = 1
    '    ButtonSubtract.Text = "-"
    '    ButtonSubtract.UseVisualStyleBackColor = True
    '    ' 
    '    ' ButtonMultiply
    '    ' 
    '    ButtonMultiply.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
    '    ButtonMultiply.Location = New Point(251, 183)
    '    ButtonMultiply.Name = "ButtonMultiply"
    '    ButtonMultiply.Size = New Size(75, 23)
    '    ButtonMultiply.TabIndex = 1
    '    ButtonMultiply.Text = "*"
    '    ButtonMultiply.UseVisualStyleBackColor = True
    '    ' 
    '    ' ButtonDivide
    '    ' 
    '    ButtonDivide.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
    '    ButtonDivide.Location = New Point(89, 212)
    '    ButtonDivide.Name = "ButtonDivide"
    '    ButtonDivide.Size = New Size(75, 23)
    '    ButtonDivide.TabIndex = 1
    '    ButtonDivide.Text = "/"
    '    ButtonDivide.UseVisualStyleBackColor = True
    '    ' 
    '    ' ButtonPower
    '    ' 
    '    ButtonPower.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
    '    ButtonPower.Location = New Point(170, 212)
    '    ButtonPower.Name = "ButtonPower"
    '    ButtonPower.Size = New Size(75, 23)
    '    ButtonPower.TabIndex = 1
    '    ButtonPower.Text = "^"
    '    ButtonPower.UseVisualStyleBackColor = True
    '    ' 
    '    ' ButtonClear
    '    ' 
    '    ButtonClear.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
    '    ButtonClear.Location = New Point(251, 212)
    '    ButtonClear.Name = "ButtonClear"
    '    ButtonClear.Size = New Size(75, 23)
    '    ButtonClear.TabIndex = 1
    '    ButtonClear.Text = "C"
    '    ButtonClear.UseVisualStyleBackColor = True
    '    ' 
    '    ' LabelOperator
    '    ' 
    '    LabelOperator.AutoSize = True
    '    LabelOperator.Location = New Point(88, 149)
    '    LabelOperator.Name = "LabelOperator"
    '    LabelOperator.Size = New Size(7, 15)
    '    LabelOperator.TabIndex = 0
    '    LabelOperator.Text = vbCrLf
    '    ' 
    '    ' Label4
    '    ' 
    '    Label4.AutoSize = True
    '    Label4.Location = New Point(448, 60)
    '    Label4.Name = "Label4"
    '    Label4.RightToLeft = RightToLeft.No
    '    Label4.Size = New Size(39, 15)
    '    Label4.TabIndex = 0
    '    Label4.Text = "Result"
    '    ' 
    '    ' TextBox4
    '    ' 
    '    TextBox4.Location = New Point(449, 78)
    '    TextBox4.Name = "TextBox4"
    '    TextBox4.Size = New Size(100, 23)
    '    TextBox4.TabIndex = 2
    '    ' 
    '    ' Form1
    '    ' 
    '    AutoScaleDimensions = New SizeF(7.0F, 15.0F)
    '    AutoScaleMode = AutoScaleMode.Font
    '    ClientSize = New Size(647, 319)
    '    Controls.Add(TextBox4)
    '    Controls.Add(TextBox2)
    '    Controls.Add(TextBox1)
    '    Controls.Add(ButtonClear)
    '    Controls.Add(ButtonPower)
    '    Controls.Add(ButtonDivide)
    '    Controls.Add(ButtonMultiply)
    '    Controls.Add(ButtonSubtract)
    '    Controls.Add(ButtonAdd)
    '    Controls.Add(Label4)
    '    Controls.Add(ButtonResult)
    '    Controls.Add(Label2)
    '    Controls.Add(LabelOperator)
    '    Controls.Add(Label1)
    '    Name = "Form1"
    '    Text = "Form1"
    '    ResumeLayout(False)
    '    PerformLayout()
    'End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonResult As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonSubtract As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivide As Button
    Friend WithEvents ButtonPower As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents LabelOperator As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox

End Class
