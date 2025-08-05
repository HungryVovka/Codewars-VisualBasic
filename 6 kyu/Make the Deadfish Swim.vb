' -----------------------------------------------------------
' Create a parser to interpret and execute the Deadfish language.
' 
' Deadfish operates on a single value in memory, which is initially set to 0.
' 
' It uses four single-character commands:
' 
' i: Increment the value
' d: Decrement the value
' s: Square the value
' o: Output the value to a result array
' All other instructions are no-ops and have no effect.
' 
' Examples
' Program "iiisdoso" should return numbers [8, 64].
' Program "iiisdosodddddiso" should return numbers [8, 64, 3600].
' -----------------------------------------------------------

Public Module Deadfish
    Public Function Parse(ByVal data As String) As Integer()
        Dim valore As Integer = 0
        Dim risultato As New List(Of Integer)
        For Each comando As Char In data
            Select Case comando
                Case CChar("i")
                    valore += 1
                Case CChar("d")
                    valore -= 1
                Case CChar("s")
                    valore *= valore
                Case CChar("o")
                    risultato.Add(valore)
                Case Else
                    ' nulla
            End Select
        Next
        Return risultato.ToArray()
    End Function
End Module

' or

Public Module Deadfish
    Public Function Parse(ByVal data As String) As Integer()
        Dim valore As Integer = 0
        Dim risultato As New List(Of Integer)
        For Each comando As Char In data
            Select Case comando
                Case "i"c
                    valore += 1
                Case "d"c
                    valore -= 1
                Case "s"c
                    valore *= valore
                Case "o"c
                    risultato.Add(valore)
                Case Else
                    ' nulla
            End Select
        Next
        Return risultato.ToArray()
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