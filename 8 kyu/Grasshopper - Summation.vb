' -----------------------------------------------------------
' Summation
' Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0.
' 
' For example:
' 
' summation(2) -> 3
' 1 + 2
' 
' summation(8) -> 36
' 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8
' -----------------------------------------------------------

Public Module Kata
    Public Function Summation(ByVal n As Integer) As Integer
        Return n * (n + 1) / 2
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