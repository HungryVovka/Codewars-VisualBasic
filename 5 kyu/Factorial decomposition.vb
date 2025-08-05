' -----------------------------------------------------------
' The aim of the kata is to decompose n! (factorial n) into its prime factors.
' 
' Examples:
' 
' n = 12; decomp(12) -> "2^10 * 3^5 * 5^2 * 7 * 11"
' since 12! is divisible by 2 ten times, by 3 five times, by 5 two times and by 7 and 11 only once.
' 
' n = 22; decomp(22) -> "2^19 * 3^9 * 5^4 * 7^3 * 11^2 * 13 * 17 * 19"
' 
' n = 25; decomp(25) -> 2^22 * 3^10 * 5^6 * 7^3 * 11^2 * 13 * 17 * 19 * 23
' 
' Prime numbers should be in increasing order. When the exponent of a prime is 1 don't put the exponent.
' 
' Notes
' 
' the function is decomp(n) and should return the decomposition of n! into its prime factors in increasing order of the primes, as a string.
' factorial can be a very big number (4000! has 12674 digits, n can go from 300 to 4000).
' In Fortran - as in any other language - the returned string is not permitted to contain any redundant trailing whitespace: you can use 
' dynamically allocated character strings.
' -----------------------------------------------------------

Imports System

Public Module FactDecomp
    Public Function Decomp(ByVal limite As Integer) As String
        Dim mappaFattori As New Dictionary(Of Integer, Integer)
        For numero As Integer = 2 To limite
            Dim divisore As Integer = 2
            Dim valoreDaScomporre As Integer = numero
            While valoreDaScomporre >= divisore * divisore
                While valoreDaScomporre Mod divisore = 0
                    If mappaFattori.ContainsKey(divisore) Then
                        mappaFattori(divisore) += 1
                    Else
                        mappaFattori(divisore) = 1
                    End If
                    valoreDaScomporre \= divisore
                End While
                divisore += 1
            End While
            If valoreDaScomporre > 1 Then
                If mappaFattori.ContainsKey(valoreDaScomporre) Then
                    mappaFattori(valoreDaScomporre) += 1
                Else
                    mappaFattori(valoreDaScomporre) = 1
                End If
            End If
        Next
        Dim listaRisultati As New List(Of String)
        For Each primo In mappaFattori.Keys.OrderBy(Function(x) x)
            Dim esponente As Integer = mappaFattori(primo)
            If esponente = 1 Then
                listaRisultati.Add(primo.ToString())
            Else
                listaRisultati.Add(primo.ToString() & "^" & esponente.ToString())
            End If
        Next
        Return String.Join(" * ", listaRisultati)
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