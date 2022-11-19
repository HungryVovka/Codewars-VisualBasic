' -----------------------------------------------------------
' Friday 13th or Black Friday is considered as unlucky day. Calculate how many unlucky days are in the given year.
' 
' Find the number of Friday 13th in the given year.
' 
' Input: Year in Gregorian calendar as integer.
' 
' Output: Number of Black Fridays in the year as an integer.
' 
' Examples:
' 
' unluckyDays(2015) == 3
' unluckyDays(1986) == 1
' -----------------------------------------------------------

Public Module Kata
    Public Function UnluckyDays(ByVal Year As Integer) as Integer
        Dim friday13 As Integer = 0
        For month As Integer = 1 to 12
        Dim nowDate As New Date(Year, month, 13)
        if nowDate.DayOfWeek = 5
            friday13 += 1
            End if
        Next
    Return friday13
    End Function
End Module