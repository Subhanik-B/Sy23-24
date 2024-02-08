Public Class Clicker
    Public Property Count As Integer
    Public Property Increment As Integer = 1
    Public Sub Click()
        Count += Increment
    End Sub
    Public Sub Reset()
        Count = Increment
    End Sub
End Class
