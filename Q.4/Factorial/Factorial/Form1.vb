Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Parse the input number
        Dim number As Integer
        If Integer.TryParse(txtNumber.Text, number) Then
            ' Calculate the factorial
            Dim factorial As Integer = 1
            For i As Integer = 1 To number
                factorial *= i
            Next

            ' Display the result
            txtResult.Text = factorial.ToString()
        Else
            MessageBox.Show("Please enter a valid integer.")
        End If
    End Sub
End Class
