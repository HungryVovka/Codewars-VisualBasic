' -----------------------------------------------------------
' Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
' -----------------------------------------------------------

Public Module SolutionClass
    Public Function EvenOrOdd(ByVal number As Integer) As String
        If number Mod 2 = 0 Then
            Return "Even"
        Else
            Return "Odd"
        End If
    End Function
End Module

' Or

Public Module SolutionClass
    Public Function EvenOrOdd(ByVal number As Integer) As String
        Return If(number Mod 2 = 0, "Even", "Odd")
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