Class MainWindow
    Dim j As Decimal
    Private Sub Pesos_Click(sender As Object, e As RoutedEventArgs) Handles Pesos.Click
        Decimal.TryParse(USD.Text, j)
        j = j * 16.96
        Eeper.Text = j.ToString("C2")
        LabelChange.Content = "Pesos"
    End Sub
    Private Sub Rupees_Click(sender As Object, e As RoutedEventArgs) Handles Rupees.Click
        Decimal.TryParse(USD.Text, j)
        j = j * 83.28
        Eeper.Text = j
        LabelChange.Content = "Rupees"
    End Sub
    Private Sub Euros_Click(sender As Object, e As RoutedEventArgs) Handles Euros.Click
        Decimal.TryParse(USD.Text, j)
        j = j * 1.07
        Eeper.Text = j
        LabelChange.Content = "Euros"
    End Sub
    Private Sub Yuan_Click(sender As Object, e As RoutedEventArgs) Handles Yuan.Click
        Decimal.TryParse(USD.Text, j)
        j = j * 7.25
        Eeper.Text = j
        LabelChange.Content = "Yuan"
    End Sub
    Private Sub Australian_Dollar_Click(sender As Object, e As RoutedEventArgs) Handles Australian_Dollar.Click
        Decimal.TryParse(USD.Text, j)
        j = j * 1.54
        Eeper.Text = j
        LabelChange.Content = "ASD"
    End Sub
    Private Sub Pounds_Click(sender As Object, e As RoutedEventArgs) Handles Pounds.Click
        Decimal.TryParse(USD.Text, j)
        j = j * 0.8
        Eeper.Text = j
        LabelChange.Content = "Pounds"
    End Sub
    Private Sub Clear_Click(sender As Object, e As RoutedEventArgs) Handles Clear.Click
        j = 0
        Eeper.Text = "0"
        USD.Text = "0"
        LabelChange.Content = ""
    End Sub
End Class
