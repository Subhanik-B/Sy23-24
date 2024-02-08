Public Class Form1
    Dim CS As New Coin_Slot
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
End Class
