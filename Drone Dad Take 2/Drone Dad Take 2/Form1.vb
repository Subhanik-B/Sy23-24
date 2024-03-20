Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Public Property cost As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ShoppingCart.Text = cost.ToString("C2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cost = 0

        If (UserControl1.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text = " Thank you for your purchase! You have bought " + UserControl1.count.ToString() + " " + UserControl1.label
        End If
        If (UserControl2.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + UserControl2.count.ToString() + " " + UserControl2.label
        End If
        If (UserControl3.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + UserControl3.count.ToString() + " " + UserControl3.label
        End If
        If (UserControl4.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + UserControl4.count.ToString() + " " + UserControl4.label
        End If
        If (UserControl5.count > 0) Then
            TextBox1.Visible = True
            TextBox1.Text += "
Thank you for your purchase! You have bought " + UserControl5.count.ToString() + " " + UserControl5.label
        End If
        If (UserControl6.count > 0) Then
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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DroneVendingMachine1.Visible = False
        DroneVendingMachine2.Visible = False
        DroneVendingMachine3.Visible = False
        DroneVendingMachine4.Visible = False
        DroneVendingMachine5.Visible = False
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
    End Sub
End Class
