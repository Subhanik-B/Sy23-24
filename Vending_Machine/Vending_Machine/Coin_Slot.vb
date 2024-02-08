Public Class Coin_Slot

    Public Event CoinReturnEvent(d As Integer, q As Integer, di As Integer, n As Integer)

    Public ReadOnly Property Total As Decimal
        Get
            Return (Nickels * 0.05) + (Dimes * 0.1) + (Quarters * 0.25) + Dollars
        End Get
    End Property
    Public Property Dollars As Integer
    Public Property Quarters As Integer
    Public Property Dimes As Integer
    Public Property Nickels As Integer
    Public Sub Insert_Dollars()
        Dollars += 1
    End Sub
    Public Sub Insert_Quarters()
        Quarters += 1
    End Sub
    Public Sub Insert_Dimes()
        Dimes += 1
    End Sub
    Public Sub Insert_Nickels()
        Nickels += 1
    End Sub
    Public Sub Coin_Return()
        RaiseEvent CoinReturnEvent(Dollars, Quarters, Dimes, Nickels)
        Dollars = 0
        Quarters = 0
        Dimes = 0
        Nickels = 0
    End Sub
End Class
