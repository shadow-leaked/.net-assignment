Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Calculate("+")
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Calculate("-")
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Calculate("*")
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Calculate("/")
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        Calculate("^")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstNumber.Clear()
        txtSecondNumber.Clear()
        txtResult.Clear()
    End Sub

    Private Sub Calculate(operation As String)
        Dim firstNumber As Double = Double.Parse(txtFirstNumber.Text)
        Dim secondNumber As Double = Double.Parse(txtSecondNumber.Text)
        Dim result As Double

        Select Case operation
            Case "+"
                result = firstNumber + secondNumber
            Case "-"
                result = firstNumber - secondNumber
            Case "*"
                result = firstNumber * secondNumber
            Case "/"
                result = firstNumber / secondNumber
            Case "^"
                result = Math.Pow(firstNumber, secondNumber)
        End Select

        txtResult.Text = result.ToString()
    End Sub
End Class
