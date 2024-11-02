Public Class Form1
    Dim operation As String = ""

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        operation = "+"
        LabelOperator.Text = "+"
    End Sub

    Private Sub ButtonSubtract_Click(sender As Object, e As EventArgs) Handles ButtonSubtract.Click
        operation = "-"
        LabelOperator.Text = "-"
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        operation = "*"
        LabelOperator.Text = "*"
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        operation = "/"
        LabelOperator.Text = "/"
    End Sub

    Private Sub ButtonPower_Click(sender As Object, e As EventArgs) Handles ButtonPower.Click
        operation = "^"
        LabelOperator.Text = "^"
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        LabelOperator.Text = ""
        Result.Text = "Result: "
    End Sub

    Private Sub ButtonResult_Click(sender As Object, e As EventArgs) Handles ButtonResult.Click
        Try
            Dim num1 As Double = Double.Parse(TextBox1.Text)
            Dim num2 As Double = Double.Parse(TextBox2.Text)
            Dim resultValue As Double

            Select Case operation
                Case "+"
                    resultValue = num1 + num2
                Case "-"
                    resultValue = num1 - num2
                Case "*"
                    resultValue = num1 * num2
                Case "/"
                    If num2 <> 0 Then
                        resultValue = num1 / num2
                    Else
                        MessageBox.Show("Cannot divide by zero")
                        Return
                    End If
                Case "^"
                    resultValue = Math.Pow(num1, num2)
                Case Else
                    MessageBox.Show("Please select an operation")
                    Return
            End Select

            Result.Text = "Result: " & resultValue.ToString()

        Catch ex As Exception
            MessageBox.Show("Invalid input. Please enter numbers only.")
        End Try
    End Sub

End Class
