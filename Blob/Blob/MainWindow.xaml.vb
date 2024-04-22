Class MainWindow
    Private Sub Cheese(sender As Object, e As RoutedEventArgs)
        If CardNumber.Text Like "#### #### #### ####" And FirstName.Text Like "*" And LastName.Text Like "*" And Address.Text Like "#*" And ZipCode.Text Like "#####" Then
            Pay.IsEnabled = True
        Else
            Pay.IsEnabled = False
        End If
    End Sub


    Private Sub Clear_Click(sender As Object, e As RoutedEventArgs) Handles Clear.Click
        FirstName.Text = "[Type Here]"
        LastName.Text = "[Type Here]"
        ZipCode.Text = "[Type Here]"
        Address.Text = "[Type Here]"
        CardNumber.Text = "[Type Here]"
    End Sub

    Private Sub Pay_Click(sender As Object, e As RoutedEventArgs) Handles Pay.Click

    End Sub
End Class
