﻿Public Class Product_Control
    Public Property ProductName As String
    Public Property ProductID As String
    Public Property ProductPrice As Decimal
    Public Property ProductImage As Image
    Public Property PropertyCount As Integer
    Private Sub Product_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = ProductImage
        ID_Label.Text = ProductID
        Price_Label.Text = ProductPrice.ToString("C2")
    End Sub
End Class
