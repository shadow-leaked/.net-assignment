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
        btnGenerate = New Button()
        lstSeries = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(77, 82)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(100, 23)
        txtNumber.TabIndex = 0
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Location = New Point(77, 179)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(75, 23)
        btnGenerate.TabIndex = 1
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' lstSeries
        ' 
        lstSeries.FormattingEnabled = True
        lstSeries.ItemHeight = 15
        lstSeries.Location = New Point(289, 97)
        lstSeries.Name = "lstSeries"
        lstSeries.Size = New Size(120, 94)
        lstSeries.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(77, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 15)
        Label1.TabIndex = 3
        Label1.Text = "Enter a number (n):"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(289, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 3
        Label2.Text = "Series"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(687, 327)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lstSeries)
        Controls.Add(btnGenerate)
        Controls.Add(txtNumber)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lstSeries As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
