Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ' Clear the ListBox controls
        lstEvenNumbers.Items.Clear()
        lstOddNumbers.Items.Clear()

        ' Parse the input number
        Dim n As Integer
        If Integer.TryParse(txtNumber.Text, n) Then
            ' Generate even and odd numbers
            Dim evenNumbers As New List(Of Integer)()
            Dim oddNumbers As New List(Of Integer)()

            For i As Integer = 1 To n
                If i Mod 2 = 0 Then
                    evenNumbers.Add(i)
                Else
                    oddNumbers.Add(i)
                End If
            Next

            ' Display the numbers in the ListBox controls
            lstEvenNumbers.DataSource = evenNumbers
            lstOddNumbers.DataSource = oddNumbers
        Else
            MessageBox.Show("Please enter a valid integer.")
        End If
    End Sub
End Class
