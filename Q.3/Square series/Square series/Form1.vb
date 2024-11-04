Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ' Clear the ListBox control
        lstSeries.Items.Clear()

        ' Parse the input number
        Dim n As Integer
        If Integer.TryParse(txtNumber.Text, n) Then
            ' Generate the series
            Dim series As New List(Of Integer)()

            For i As Integer = 1 To n
                series.Add(i * i)
            Next

            ' Display the series in the ListBox control
            lstSeries.DataSource = series
        Else
            MessageBox.Show("Please enter a valid integer.")
        End If
    End Sub
End Class
