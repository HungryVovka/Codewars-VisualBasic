' -----------------------------------------------------------
' Very simple, given an integer or a floating-point number, find its opposite.
' 
' Examples:
' 
' 1: -1
' 14: -14
' -34: 34
' -----------------------------------------------------------

Public Module Opposite
    Public Function Number(ByVal num As Double)
        Return 0 - num
    End Function
End Module