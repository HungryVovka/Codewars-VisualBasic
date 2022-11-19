' -----------------------------------------------------------
' Find the total sum of internal angles (in degrees) in an n-sided simple polygon. N will be greater than 2.
' -----------------------------------------------------------

Public Module Kata
    Public Function Angle(ByVal n As Integer) As Integer
        Return (n - 2) * 180
    End Function
End Module