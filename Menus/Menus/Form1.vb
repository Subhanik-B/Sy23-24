Imports System.IO

Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        TextBox1.Clear()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim Out_File As New IO.StreamWriter("Out.txt")
        Out_File.WriteLine(TextBox1.Text)
        Out_File.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If IO.File.Exists("Out.txt") Then
            Dim In_File As New IO.StreamReader("Out.txt")
            TextBox1.Text = In_File.ReadToEnd()
            In_File.Close()
        End If
    End Sub
End Class
