Imports System.IO
Public Class Form1
    Dim Records(50) As String
    Dim count As Integer
    Dim current As Integer
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Field1.Text = ""
        Field2.Text = ""
        Field3.Text = ""
        Field4.Text = ""
        Field5.Text = ""
        PictureBox1.Image = Nothing
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim r As String
        r += Field1.Text
        r += "|"
        r += Field2.Text
        r += "|"
        r += Field3.Text
        r += "|"
        r += Field4.Text
        r += "|"
        r += Field5.Text
        r += "|"
        r += PictureBox1.ImageLocation
        Records(current) = r
        SaveToFile()
    End Sub
    Sub SaveToFile()
        Dim outfile As New StreamWriter("Data.txt")
        For index = 0 To count - 1
            outfile.WriteLine(Records(index))
        Next
        outfile.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("Data.txt") Then
            Dim inFile As New StreamReader("Data.txt")
            While (Not inFile.EndOfStream)
                Records(count) = inFile.ReadLine()
                count = count + 1
            End While
            inFile.Close()
            ShowRecord(0)
        End If
    End Sub
    Public Sub ShowRecord(index As Integer)
        If Records(index) <> Nothing Then
            Dim fields() As String
            fields = Records(index).Split("|")
            Field1.Text = fields(0)
            Field2.Text = fields(1)
            Field3.Text = fields(2)
            Field4.Text = fields(3)
            Field5.Text = fields(4)
            If File.Exists(fields(5)) Then
                PictureBox1.Load(fields(5))
            End If
        End If
    End Sub

    Private Sub First_Click(sender As Object, e As EventArgs) Handles First.Click
        current = 0
        ShowRecord(current)
    End Sub

    Private Sub Last_Click(sender As Object, e As EventArgs) Handles Last.Click
        current = count - 1
        ShowRecord(current)
    End Sub

    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Previous.Click
        If current > 0 Then
            current = current - 1
        End If
        ShowRecord(current)
    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click
        If current < count - 1 Then
            current = current + 1
            ShowRecord(current)
        End If
    End Sub
End Class