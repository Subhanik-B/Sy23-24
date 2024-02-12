Public Class Form1
    Dim WithEvents CS As New Coin_Slot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.Insert_Nickels()
        TextBox1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.Insert_Dimes()
        TextBox1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.Insert_Quarters()
        TextBox1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.Insert_Dollars()
        TextBox1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.Coin_Return()
        TextBox1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub CS_CoinReturnEvent(d As Integer, q As Integer, di As Integer, n As Integer) Handles CS.CoinReturnEvent
        If d > 0 Then
            PictureBox6.Visible = True
        Else
            PictureBox6.Visible = False
        End If
        If q > 0 Then
            PictureBox5.Visible = True
        Else
            PictureBox5.Visible = False
        End If
        If di > 0 Then
            PictureBox7.Visible = True
        Else
            PictureBox7.Visible = False
        End If
        If n > 0 Then
            PictureBox8.Visible = True
        Else
            PictureBox8.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case ID_TextBox.Text
            Case Product_Control1.ProductID
                Product_Control1.buy()
            Case Product_Control2.ProductID
                Product_Control2.buy
            Case Else

        End Select
        Product_Control1.buy()
    End Sub
End Class
