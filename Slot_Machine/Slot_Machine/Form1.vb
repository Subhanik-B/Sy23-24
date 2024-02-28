Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.ComponentModel.Com2Interop

Public Class Form1

    Dim WithEvents CS As New CS

    Public Property bankAccount As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bankAccount = 0
        TextBox1.Text = bankAccount.ToString("C2")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If bankAccount >= 1 Then
            bankAccount -= 1
            TextBox1.Text = bankAccount.ToString("C2")
            Label5.Text = ""
            ReelControl1.Spin()
            ReelControl2.Spin()
            ReelControl3.Spin()
            Timer1.Enabled = True
        Else
            Label5.Text = "Sorry, but you don't have enough money"
        End If
    End Sub
    Public Sub Load_Winnings()
        If ReelControl1.itemValue = ReelControl2.itemValue And ReelControl1.itemValue = ReelControl3.itemValue And ReelControl2.itemValue = ReelControl3.itemValue Then
            bankAccount += 200
            TextBox1.Text = bankAccount.ToString("C2")

        ElseIf ReelControl1.itemValue = 1 And ReelControl2.itemValue = 1 Then
            bankAccount += 100
            TextBox1.Text = bankAccount.ToString("C2")
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = ReelControl1.itemValue
        Label2.Text = ReelControl2.itemValue
        Label3.Text = ReelControl3.itemValue
        Load_Winnings()
        Timer1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.Insert_Nickels()
        bankAccount = CS.Total
        TextBox1.Text = bankAccount.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.Insert_Dimes()
        bankAccount = CS.Total
        TextBox1.Text = bankAccount.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.Insert_Quarters()
        bankAccount = CS.Total
        TextBox1.Text = bankAccount.ToString("C2")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.Insert_Dollars()
        bankAccount = CS.Total
        TextBox1.Text = bankAccount.ToString("C2")
    End Sub
End Class
