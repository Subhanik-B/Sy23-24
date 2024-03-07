Imports System.CodeDom

Public Class frm2dPlatformer
    Dim Ticks As Integer = 0
    Dim movespeed As Integer = 15
    Dim isJumping As Boolean
    Dim points As Integer = 0
    Dim pointsrm As Integer = 0
    Dim apples As Integer = 6
    Private Function frm2dPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If tmrGameLogic.Enabled = True Then
            Select Case e.KeyCode
                Case Keys.Right
                    TmrRight.Start()
                Case Keys.Left
                    tmrLeft.Start()
                Case Keys.Up
                    tmrUp.Start()
                    isJumping = True
            End Select
        End If
    End Function

    Private Sub TmrRight_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        picPlayer.Left += movespeed
    End Sub
    Private Sub frm2dPlatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyUp
        If tmrGameLogic.Enabled = True Then
            Select Case e.KeyCode
                Case Keys.Right
                    TmrRight.Stop()
                Case Keys.Left
                    tmrLeft.Stop()
                Case Keys.Up
                    tmrUp.Stop()
                    isJumping = False
            End Select
        End If
    End Sub
    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= movespeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= movespeed
    End Sub

    Private Sub frm2dPlatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
        Game_Timer.Start()
        pointsrm = 3
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        Else
            If isJumping = False Then
                tmrGravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
        Next
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "win_coin" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Visible = False
                        points += 1
                        pointsrm -= 1
                        b.Tag = ""
                        TextBox2.Text = points.ToString
                        If pointsrm = 0 Then
                            PictureBox9.Visible = True
                            PictureBox10.Visible = True
                            PictureBox11.Visible = True
                            PictureBox12.Visible = True
                            PictureBox13.Visible = True
                            PictureBox14.Visible = True
                        End If
                    End If
                End If
            End If
        Next
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "win" And b.Visible = True Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Visible = False
                        points += 1
                        apples -= 1
                        b.Tag = ""
                        TextBox2.Text = points.ToString
                        If apples = 0 Then
                            TextBox1.Visible = True
                            TextBox1.Text = "Congratulations you win! You had " + points.ToString() + " points"
                            tmrGameLogic.Stop()
                            tmrGravity.Stop()
                            tmrLeft.Stop()
                            tmrUp.Stop()
                            TmrRight.Stop()
                            Mover1.Timer1.Stop()
                            Mover2.Timer1.Stop()
                            Mover3.Timer1.Stop()
                            Mover4.Timer1.Stop()
                        End If
                    End If
                End If
            End If
        Next
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "enemy" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        TextBox1.Visible = True
                        TextBox1.Text = "You Lose, you had " + points.ToString() + " points"
                        tmrGameLogic.Stop()
                        tmrGravity.Stop()
                        tmrLeft.Stop()
                        tmrUp.Stop()
                        TmrRight.Stop()
                        Mover1.Timer1.Stop()
                        Mover2.Timer1.Stop()
                        Mover3.Timer1.Stop()
                        Mover4.Timer1.Stop()
                    End If
                End If
            End If
        Next

    End Sub
    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += movespeed
    End Sub

    Private Sub Spiky_Timer_Tick(sender As Object, e As EventArgs) Handles Spiky_Timer.Tick
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "L" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        points -= 1
                        TextBox2.Text = points.ToString()
                    End If
                End If
            End If
        Next
    End Sub
End Class
