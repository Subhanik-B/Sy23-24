Public Class DroneVendingMachine
    Public Property label As String
    Public Property price As Decimal
    Public Property count As Integer

    Private Sub Buy_Click(sender As Object, e As EventArgs) Handles Buy.Click
        If Me.Visible = True Then
            Form1.cost += price
            count += 1
        End If
    End Sub

    Private Sub DroneVendingMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = label
        Label2.Text = price.ToString("C2")
    End Sub
End Class
