Imports System.Security.Cryptography.X509Certificates
Public Class Mover
    Public Property Speed As Integer = 10
    Public Property Interval As Integer = 100
    Public Property Sprite As PictureBox
    Dim xdir As Integer = 1
    Dim ydir As Integer = 0
    Private Sub Mover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = Interval
        Timer1.Enabled = True
        If Not Sprite Is Nothing Then
            Sprite.Left = Me.Left
            Sprite.Top = Me.Top
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Sprite Is Nothing Then
            Sprite.Left += xdir * Speed
            Sprite.Top += ydir * Speed
            If Sprite.Left > Me.Left + Me.Width And xdir = 1 Then
                xdir = 0
                ydir = 1
            End If
            If Sprite.Right < Me.Left And xdir = -1 Then
                xdir = 0
                ydir = -1
            End If
            If Sprite.Top > Me.Top + Me.Height And ydir = 1 Then
                ydir = 0
                xdir = -1
            End If
            If Sprite.Top < Me.Top And ydir = -1 Then
                ydir = 0
                xdir = 1
            End If
        End If
    End Sub
End Class
