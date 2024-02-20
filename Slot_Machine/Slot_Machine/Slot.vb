Public Class Slot
    Public Sub Spin()
        Dim Rand As New Random
        Dim r As Integer
        r = Rand.Next(ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(r)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Spin()
    End Sub
End Class
