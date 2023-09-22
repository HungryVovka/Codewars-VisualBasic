' -----------------------------------------------------------
' A natural number is called k-prime if it has exactly k prime factors, counted with multiplicity. For example:
' 
' k = 2  -->  4, 6, 9, 10, 14, 15, 21, 22, ...
' k = 3  -->  8, 12, 18, 20, 27, 28, 30, ...
' k = 5  -->  32, 48, 72, 80, 108, 112, ...
' 
' A natural number is thus prime if and only if it is 1-prime.
' 
' Task:
' Complete the function count_Kprimes (or countKprimes, count-K-primes, kPrimes) which is given parameters k, start, end (or nd) and 
' returns an array (or a list or a string depending on the language - see "Solution" and "Sample Tests") of the k-primes between start (inclusive) 
' and end (inclusive).
' 
' Example:
' countKprimes(5, 500, 600) --> [500, 520, 552, 567, 588, 592, 594]
' 
' Notes:
' 
' The first function would have been better named: findKprimes or kPrimes :-)
' In C some helper functions are given (see declarations in 'Solution').
' For Go: nil slice is expected when there are no k-primes between start and end.
' Second Task: puzzle (not for Shell)
' Given a positive integer s, find the total number of solutions of the equation a + b + c = s, where a is 1-prime, b is 3-prime, and c is 7-prime.
' 
' Call this function puzzle(s).
' 
' Examples:
' puzzle(138)  -->  1  because [2 + 8 + 128] is the only solution
' puzzle(143)  -->  2  because [3 + 12 + 128] and [7 + 8 + 128] are the solutions
' -----------------------------------------------------------

Imports System

Public Module KPrimes
    
    Public Function KFactor(n As Integer) As Integer
        Dim answer As Integer = 0
        Dim i As Integer = 2
        While i * i <= n
            While n Mod i = 0
                n \= i
                answer += 1
            End While
            i += 1
        End While
        If n > 1 Then
            answer += 1
        End If
        Return answer
    End Function
    
    Public Function CountKprimes(ByVal k As Integer, ByVal start As Long, ByVal nd As Long) As Long()
        Dim tempResult(nd - start) As Long
        Dim index As Integer = 0
        For n As Long = start To nd
            If KFactor(n) = k Then
                tempResult(index) = n
                index += 1
            End If
        Next
        Dim result(index - 1) As Long
        Array.Copy(tempResult, result, index)
        Return result
    End Function

    Public Function Puzzle(ByVal s As Integer) As Integer
        Dim p() As Long = CountKprimes(1, 0, s)
        Dim u() As Long = CountKprimes(3, 0, s)
        Dim z() As Long = CountKprimes(7, 0, s)
        Dim count As Integer = 0
        For Each a In p
            For Each b In u
                For Each c In z
                    If a + b + c = s Then
                        count += 1
                    End If
                Next
            Next
        Next
        Return count
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