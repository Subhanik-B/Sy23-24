Imports Microsoft.Win32
Imports System.IO
Imports System.Windows.Threading

Class MainWindow
    Dim grad1 As Color
    Dim grad2 As Color
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
        If Shape_Label.Content = "Cheese" Then
            Dim myImageBrush As New ImageBrush(Cheese.Source)
            Dim myCanvas As New Canvas
            myCanvas.Width = Width_Slider.Value
            myCanvas.Height = Height_Slider.Value
            myCanvas.Background = myImageBrush
            Dim p As Point = Mouse.GetPosition(Drawing_Canvas)
            Canvas.SetLeft(myCanvas, p.X)
            Canvas.SetTop(myCanvas, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                Drawing_Canvas.Children.Add(myCanvas)
            End If
        End If
        If Shape_Label.Content = "Dog" Then
            Dim myImageBrush As New ImageBrush(DorgMgFlorg.Source)
            Dim myCanvas As New Canvas
            myCanvas.Width = Width_Slider.Value
            myCanvas.Height = Height_Slider.Value
            myCanvas.Background = myImageBrush
            Dim p As Point = Mouse.GetPosition(Drawing_Canvas)
            Canvas.SetLeft(myCanvas, p.X)
            Canvas.SetTop(myCanvas, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                Drawing_Canvas.Children.Add(myCanvas)
            End If
        End If
        If Shape_Label.Content = "Polygon" Then
            Dim r As New Polygon
            r.Fill = Color1.Fill
            r.Points.Add(New Point(0 * Width_Slider.Value, 7 * Width_Slider.Value))
            r.Points.Add(New Point(3 * Width_Slider.Value, 9 * Width_Slider.Value))
            r.Points.Add(New Point(6 * Width_Slider.Value, 5 * Width_Slider.Value))
            r.Points.Add(New Point(5 * Width_Slider.Value, 2 * Width_Slider.Value))
            r.Points.Add(New Point(3 * Width_Slider.Value, 5 * Width_Slider.Value))
            r.Points.Add(New Point(-3 * Width_Slider.Value, -3 * Width_Slider.Value))
            r.Points.Add(New Point(-6 * Width_Slider.Value, 4 * Width_Slider.Value))
            r.Points.Add(New Point(-4 * Width_Slider.Value, 8 * Width_Slider.Value))
            Dim p As Point = Mouse.GetPosition(Drawing_Canvas)
            Canvas.SetLeft(r, p.X)
            Canvas.SetTop(r, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                Drawing_Canvas.Children.Add(r)
            End If
        End If
        If Shape_Label.Content = "Custom" Then
            Dim r As New Polygon
            r.Fill = Color1.Fill
            Dim p As Point = Mouse.GetPosition(Drawing_Canvas)
            r.Points.Add(p)
            r.Points.Add(New Point(1 * Width_Slider.Value, 0))
            r.Points.Add(New Point(0, 1 * Width_Slider.Value))
            Canvas.SetLeft(r, p.X)
            Canvas.SetTop(r, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                Drawing_Canvas.Children.Add(r)
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
    Public Sub ExportToPng(ByVal surface As Canvas)
        Dim sfd As New SaveFileDialog
        sfd.ShowDialog()
        If sfd.FileName Is Nothing Then Return
        Dim transform As Transform = surface.LayoutTransform
        surface.LayoutTransform = Nothing
        Dim size As Size = New Size(surface.Width, surface.Height)
        surface.Measure(size)
        surface.Arrange(New Rect(size))
        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)
        renderBitmap.Render(surface)
        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)
            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()
            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))
            encoder.Save(outStream)
        End Using
        surface.LayoutTransform = transform
        Canvas.SetLeft(Drawing_Canvas, 147)
        Canvas.SetTop(Drawing_Canvas, 0)
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As RoutedEventArgs) Handles SaveButton.Click
        ExportToPng(Drawing_Canvas)
    End Sub
    Private Sub Rect1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Rect1.MouseDown
        grad1 = Color.FromRgb(Red.Value, Green.Value, Blue.Value)
        sender.fill = New SolidColorBrush(grad1)
    End Sub
    Private Sub Rect2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Rect2.MouseDown
        grad1 = Color.FromRgb(Red.Value, Green.Value, Blue.Value)
        sender.fill = New SolidColorBrush(grad1)
    End Sub
    Private Sub AngleSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles AngleSlider.ValueChanged
        Color1.Fill = New LinearGradientBrush(grad1, grad2, AngleSlider.Value)
    End Sub
    Private Sub Bowtie_Click(sender As Object, e As RoutedEventArgs) Handles Bowtie.Click
        Shape_Label.Content = "Cheese"
    End Sub
    Private Sub Bowtie2_Click(sender As Object, e As RoutedEventArgs) Handles Polygon.Click
        Shape_Label.Content = "Polygon"

    End Sub
    Private Sub Dorg_Click(sender As Object, e As RoutedEventArgs) Handles Dorg.Click
        Shape_Label.Content = "Dog"
    End Sub
    Private Sub Custom_Click(sender As Object, e As RoutedEventArgs) Handles Custom.Click
        Shape_Label.Content = "Custom"
    End Sub
    Private Sub Drawing_Canvas_Loaded(sender As Object, e As RoutedEventArgs) Handles Drawing_Canvas.Loaded
        Dim dt As DispatcherTimer = New DispatcherTimer()
        AddHandler dt.Tick, AddressOf DispatcherTimer_Tick

        dt.Interval = New TimeSpan(0, 0, 1)
        dt.Start()
    End Sub
    Public Sub DispatcherTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        For Each u In Drawing_Canvas.Children
            If u.name = "" Then
                Canvas.SetLeft(u, Canvas.GetLeft(u) + AngleSlider.Value)
            End If

        Next
    End Sub
End Class
