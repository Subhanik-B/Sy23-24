Class MainWindow
    Private Sub Buton_Click(sender As Object, e As RoutedEventArgs) Handles Buton.Click
        Dim m As Integer
        Dim d As Integer
        m = Calendar.SelectedDate.Value.Month
        d = Calendar.SelectedDate.Value.Day
        If (m = 1 And d >= 20 Or m = 2 And d <= 18) Then
            Display.Content = "Aquarius"
            Aquarius.Visibility = IsVisible
        End If
        If (m = 2 And d >= 19 Or m = 3 And d <= 20) Then
            Display.Content = "Pisces"
            Pisces.Visibility = IsVisible
        End If
        If (m = 3 And d >= 21 Or m = 4 And d <= 19) Then
            Display.Content = "Aries"
            Aries.Visibility = IsVisible
        End If
        If (m = 4 And d >= 20 Or m = 5 And d <= 20) Then
            Display.Content = "Taurus"
            Taurus.Visibility = IsVisible
        End If
        If (m = 5 And d >= 21 Or m = 6 And d <= 21) Then
            Display.Content = "Gemini"
            Gemini.Visibility = IsVisible
        End If
        If (m = 6 And d >= 22 Or m = 7 And d <= 22) Then
            Display.Content = "Cancer"
            Cancer.Visibility = IsVisible
        End If
        If (m = 7 And d >= 23 Or m = 8 And d <= 22) Then
            Display.Content = "Leo"
            Leo.Visibility = IsVisible
        End If
        If (m = 8 And d >= 23 Or m = 9 And d <= 22) Then
            Display.Content = "Virgo"
            Virgo.Visibility = IsVisible
        End If
        If (m = 9 And d >= 23 Or m = 10 And d <= 22) Then
            Display.Content = "Libra"
            Libra.Visibility = IsVisible
        End If
        If (m = 10 And d >= 23 Or m = 11 And d <= 21) Then
            Display.Content = "Scorpio"
            Scorpio.Visibility = IsVisible
        End If
        If (m = 11 And d >= 22 Or m = 12 And d <= 21) Then
            Display.Content = "Sagittarius"
            Sagittarius.Visibility = IsVisible
        End If '
        If (m = 12 And d >= 22 Or m = 1 And d <= 19) Then
            Display.Content = "Capricorn"
            Capricorn.Visibility = IsVisible
        End If
        'Display.Content = Calendar.SelectedDate.Value
    End Sub
End Class
