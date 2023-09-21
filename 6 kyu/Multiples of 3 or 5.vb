' -----------------------------------------------------------
' If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
' 
' Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
' 
' Additionally, if the number is negative, return 0.
' 
' Note: If the number is a multiple of both 3 and 5, only count it once.
' 
' Courtesy of projecteuler.net (Problem 1)(https://projecteuler.net/problem=1)
' -----------------------------------------------------------

Module Kata
    Function Solution(ByVal value As Integer) As Integer
        Dim mult As Integer = 0
        For i As Integer = 0 To value - 1
            If i Mod 3 = 0 Then
                mult += i
                Continue For
            ElseIf i Mod 5 = 0 Then
                mult += i
                Continue For
            Else
                Continue For
            End If
        Next
        Return mult
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
' Copyright (C) 2022 Vladimir Rukavishnikov
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