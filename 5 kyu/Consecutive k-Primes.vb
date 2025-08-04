' -----------------------------------------------------------
' A natural number is called k-prime if it has exactly k prime factors, counted with multiplicity. A natural number is thus prime if and only if it is 
' 1-prime.
' 
' Examples:
' k = 2 -> 4, 6, 9, 10, 14, 15, 21, 22, …
' k = 3 -> 8, 12, 18, 20, 27, 28, 30, …
' k = 5 -> 32, 48, 72, 80, 108, 112, …
' 
' Task:
' Given an integer k and a list arr of positive integers the function consec_kprimes (or its variants in other languages) returns how many 
' times in the sequence arr numbers come up twice in a row with exactly k prime factors?
' 
' Examples:
' arr = [10005, 10030, 10026, 10008, 10016, 10028, 10004]
' consec_kprimes(4, arr) => 3 because 10005 and 10030 are consecutive 4-primes, 10030 and 10026 too as well as 10028 and 10004 but 10008 and 10016 are 'primes.
' 
' consec_kprimes(4, [10175, 10185, 10180, 10197]) => 3 because 10175-10185 and 10185- 10180 and 10180-10197 are all consecutive 4-primes.
' 
' Note:
' It could be interesting to begin with: https://www.codewars.com/kata/k-primes
' -----------------------------------------------------------

Imports System

Public Module PrimeConsec
    Public Function ConsecKprimes(ByVal k As Integer, ByVal arr As Long()) As Integer
        Dim conteggio As Integer
        For i = 0 To arr.Length - 2
            Dim a As Integer = ContaFattoriPrimi(arr(i))
            Dim b As Integer = ContaFattoriPrimi(arr(i + 1))
            If a = k AndAlso b = k Then
                conteggio += 1
            End If
        Next
        Return conteggio
    End Function
    
    Private Function ContaFattoriPrimi(ByVal numero As Long) As Integer
        Dim conta As Integer = 0
        Dim divisore As Long = 2
        While numero > 1 AndAlso numero >= divisore * divisore
            While numero Mod divisore = 0
                conta += 1
                numero \= divisore
            End While
            divisore += 1
        End While
        If numero > 1 Then conta += 1
        Return conta
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