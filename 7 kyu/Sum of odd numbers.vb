' -----------------------------------------------------------
' Given the triangle of consecutive odd numbers:
' 
'              1
'           3     5
'        7     9    11
'    13    15    17    19
' 21    23    25    27    29
' ...
' 
' Calculate the sum of the numbers in the nth row of this triangle (starting at index 1) e.g.: (Input --> Output)
' 
' 1 -->  1
' 2 --> 3 + 5 = 8
' -----------------------------------------------------------

Public Module Kata
    Public Function RowSumOddNumbers(ByVal n As Integer) As Integer
        Return n * n * n
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