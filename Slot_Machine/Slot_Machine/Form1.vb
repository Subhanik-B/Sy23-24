Imports System.Security.Cryptography
Imports System.Windows.Forms.ComponentModel.Com2Interop

Public Class Form1
    Public Property bankAccount As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bankAccount = 10
        TextBox1.Text = bankAccount.ToString("C2")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReelControl1.Spin()
        ReelControl2.Spin()
        ReelControl3.Spin()
        Label1.Text = ReelControl1.itemValue
        Label2.Text = ReelControl2.itemValue
        Label3.Text = ReelControl3.itemValue
        Load_Winnings()
    End Sub
    Public Sub Load_Winnings()
        If ReelControl1.itemValue = ReelControl2.itemValue And ReelControl1.itemValue = ReelControl3.itemValue And ReelControl2.itemValue = ReelControl3.itemValue Then
            bankAccount += 200
            TextBox1.Text = bankAccount.ToString("C2")
        Else
            bankAccount -= 1
            TextBox1.Text = bankAccount.ToString("C2")
        End If
    End Sub
End Class
