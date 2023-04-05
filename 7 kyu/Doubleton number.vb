' -----------------------------------------------------------
' We will call a natural number a "doubleton number" if it contains exactly two distinct digits. For example, 23, 35, 100, 12121 are doubleton 
' numbers, and 123 and 9980 are not.
' 
' For a given natural number n (from 1 to 1 000 000), you need to find the next doubleton number. If n itself is a doubleton, return the next bigger 
' than n.
' 
' Examples:
' Doubleton(120)  'returns 121
' Doubleton(1234) 'returns 1311
' Doubleton(10)   'returns 12
' -----------------------------------------------------------

Module Kata
    Function Doubleton(ByVal num As Integer) As Integer
        While True
            num += 1
            If num.ToString().ToList.Distinct.Count = 2 Then
                Return num
            End If
        End While
    End Function
End Module

' or

Module Kata
    Function Doubleton(ByVal num As Integer) As Integer
        Dim x As Integer = num + 1
        While x.ToString.Distinct.Count <> 2
            x += 1
        End While
        Return x
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