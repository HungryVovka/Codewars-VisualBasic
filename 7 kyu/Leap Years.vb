' -----------------------------------------------------------
' In this kata you should simply determine, whether a given year is a leap year or not. In case you don't know the rules, here they are:
' 
' Years divisible by 4 are leap years,
' but years divisible by 100 are not leap years,
' but years divisible by 400 are leap years.
' 
' Tested years are in range 1600 ≤ year ≤ 4000.
' -----------------------------------------------------------

Module Kata
    Public Function IsLeapYear(year As Integer) As Boolean
        If year Mod 4 = 0 Then
            If year Mod 100 = 0 Then
                Return year Mod 400 = 0
            Else
                Return True
            End If
        End If
        Return False
    End Function
End Module

' -----------------------------------------------------------
' License
' Tasks are the property of Codewars (https://www.codewars.com/) 
' and users of this resource.
' 
' All solution code in this repository 
' is the personal property of Vladimir Rukavishnikov
' (vladimirrukavishnikovmail@gmail.com).
' 
' Copyright (C) 2025 Vladimir Rukavishnikov
' 
' This file is part of the HungryVovka/Codewars-VisualBasic
' (https://github.com/HungryVovka/Codewars-VisualBasic)
' 
' License is GNU General Public License v3.0
' (https://github.com/HungryVovka/Codewars-VisualBasic/blob/main/LICENSE)
' 
' You should have received a copy of the GNU General Public License v3.0
' along with this code. If not, see http://www.gnu.org/licenses/
' -----------------------------------------------------------