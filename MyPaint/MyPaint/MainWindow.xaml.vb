Class MainWindow
    Private Sub Drawing_Canvas_MouseMove(sender As Object, e As MouseEventArgs) Handles Drawing_Canvas.MouseMove
        If Shape_Label.Content = "Ellipse" Then
            Dim el As New Ellipse
            el.Width = Width_Slider.Value
            el.Height = Height_Slider.Value
            el.Fill = Color1.Fill
            Dim p As Point = Mouse.GetPosition(Drawing_Canvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                Drawing_Canvas.Children.Add(el)
            End If
        End If
        If Shape_Label.Content = "Rectangle" Then
            Dim el As New Rectangle
            el.Width = Width_Slider.Value
            el.Height = Height_Slider.Value
            el.Fill = Color1.Fill
            Dim p As Point = Mouse.GetPosition(Drawing_Canvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                Drawing_Canvas.Children.Add(el)
            End If
        End If
    End Sub
    'Color Changer
    Private Sub Color1_Copy_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Color1_Copy.MouseLeftButtonDown
        Color1.Fill = Color1_Copy.Fill
    End Sub
    Private Sub Color1_Copy1_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Color1_Copy1.MouseLeftButtonDown
        Color1.Fill = Color1_Copy1.Fill
    End Sub
    Private Sub Color1_Copy2_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Color1_Copy2.MouseLeftButtonDown
        Color1.Fill = Color1_Copy2.Fill
    End Sub
    Private Sub Color1_Copy3_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Color1_Copy3.MouseLeftButtonDown
        Color1.Fill = Color1_Copy3.Fill
    End Sub

    Private Sub Color1_Copy4_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Color1_Copy4.MouseLeftButtonDown
        Color1.Fill = Color1_Copy4.Fill
    End Sub
    Private Sub Color1_Copy5_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Color1_Copy5.MouseLeftButtonDown
        Color1.Fill = Color1_Copy5.Fill
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Drawing_Canvas.Children.RemoveRange(1, Drawing_Canvas.Children.Count - 1)
    End Sub
    Private Sub Undo_Click(sender As Object, e As RoutedEventArgs) Handles Undo.Click
        If Drawing_Canvas.Children.Count - 1 > 0 Then
            Drawing_Canvas.Children.RemoveAt(Drawing_Canvas.Children.Count - 1)
        End If
    End Sub
    Private Sub Eraser_Click(sender As Object, e As RoutedEventArgs) Handles Eraser.Click
        Color1.Fill = Eraser_Tangle.Fill
        Width_Slider.Value = 50
        Height_Slider.Value = 50
    End Sub
    Private Sub Ellipse_Click(sender As Object, e As RoutedEventArgs) Handles Ellipse.Click
        Shape_Label.Content = sender.Content
    End Sub
    Private Sub Rectangle_Click(sender As Object, e As RoutedEventArgs) Handles Rectangle.Click
        Shape_Label.Content = sender.Content
    End Sub
End Class
