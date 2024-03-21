Public Class Form1
    Public Property cost As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ShoppingCart.Text = cost.ToString("C2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cost = 0

        If (DroneVendingMachine1.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text = " Thank you for your purchase! You have bought " + DroneVendingMachine1.count.ToString() + " " + DroneVendingMachine1.label
        End If
        If (DroneVendingMachine2.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine2.count.ToString() + " " + DroneVendingMachine2.label
        End If
        If (DroneVendingMachine3.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine3.count.ToString() + " " + DroneVendingMachine3.label
        End If
        If (DroneVendingMachine4.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine4.count.ToString() + " " + DroneVendingMachine4.label
        End If
        If (DroneVendingMachine5.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine5.count.ToString() + " " + DroneVendingMachine5.label
        End If
        If (DroneVendingMachine6.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine6.count.ToString() + " " + DroneVendingMachine6.label
        End If
        If (DroneVendingMachine7.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine7.count.ToString() + " " + DroneVendingMachine7.label
        End If
        If (DroneVendingMachine8.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine8.count.ToString() + " " + DroneVendingMachine8.label
        End If
        If (DroneVendingMachine9.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine9.count.ToString() + " " + DroneVendingMachine9.label
        End If
        If (DroneVendingMachine10.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine10.count.ToString() + " " + DroneVendingMachine10.label
        End If
        If (DroneVendingMachine11.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine11.count.ToString() + " " + DroneVendingMachine11.label
        End If
        If (DroneVendingMachine12.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine12.count.ToString() + " " + DroneVendingMachine12.label
        End If
        If (DroneVendingMachine13.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine13.count.ToString() + " " + DroneVendingMachine13.label
        End If
        If (DroneVendingMachine14.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine14.count.ToString() + " " + DroneVendingMachine14.label
        End If
        If (DroneVendingMachine15.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + DroneVendingMachine15.count.ToString() + " " + DroneVendingMachine15.label
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DroneVendingMachine1.Visible = False
        DroneVendingMachine2.Visible = False
        DroneVendingMachine3.Visible = False
        DroneVendingMachine4.Visible = False
        DroneVendingMachine5.Visible = False
        DroneVendingMachine11.Visible = False
        DroneVendingMachine12.Visible = False
        DroneVendingMachine13.Visible = False
        DroneVendingMachine14.Visible = False
        DroneVendingMachine15.Visible = False
        DroneVendingMachine6.Visible = True
        DroneVendingMachine7.Visible = True
        DroneVendingMachine8.Visible = True
        DroneVendingMachine9.Visible = True
        DroneVendingMachine10.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DroneVendingMachine6.Visible = False
        DroneVendingMachine7.Visible = False
        DroneVendingMachine8.Visible = False
        DroneVendingMachine9.Visible = False
        DroneVendingMachine10.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DroneVendingMachine1.Visible = True
        DroneVendingMachine2.Visible = True
        DroneVendingMachine3.Visible = True
        DroneVendingMachine4.Visible = True
        DroneVendingMachine5.Visible = True
        DroneVendingMachine6.Visible = False
        DroneVendingMachine7.Visible = False
        DroneVendingMachine8.Visible = False
        DroneVendingMachine9.Visible = False
        DroneVendingMachine10.Visible = False
        DroneVendingMachine11.Visible = False
        DroneVendingMachine12.Visible = False
        DroneVendingMachine13.Visible = False
        DroneVendingMachine14.Visible = False
        DroneVendingMachine15.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DroneVendingMachine1.Visible = False
        DroneVendingMachine2.Visible = False
        DroneVendingMachine3.Visible = False
        DroneVendingMachine4.Visible = False
        DroneVendingMachine5.Visible = False
        DroneVendingMachine6.Visible = False
        DroneVendingMachine7.Visible = False
        DroneVendingMachine8.Visible = False
        DroneVendingMachine9.Visible = False
        DroneVendingMachine10.Visible = False
        DroneVendingMachine11.Visible = True
        DroneVendingMachine12.Visible = True
        DroneVendingMachine13.Visible = True
        DroneVendingMachine14.Visible = True
        DroneVendingMachine15.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Visible = False
        TextBox1.Text = ""
        cost = 0
        DroneVendingMachine1.count = 0
        DroneVendingMachine2.count = 0
        DroneVendingMachine3.count = 0
        DroneVendingMachine4.count = 0
        DroneVendingMachine5.count = 0
        DroneVendingMachine6.count = 0
        DroneVendingMachine7.count = 0
        DroneVendingMachine8.count = 0
        DroneVendingMachine9.count = 0
        DroneVendingMachine10.count = 0
        DroneVendingMachine11.count = 0
        DroneVendingMachine12.count = 0
        DroneVendingMachine13.count = 0
        DroneVendingMachine14.count = 0
        DroneVendingMachine15.count = 0
    End Sub
End Class
