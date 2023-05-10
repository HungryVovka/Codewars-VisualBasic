' -----------------------------------------------------------
' 1, 246, 2, 123, 3, 82, 6, 41 are the divisors of number 246. Squaring these divisors we get: 1, 60516, 4, 15129, 9, 6724, 36, 1681. The 
' sum of these squares is 84100 which is 290 * 290.
' 
' Task
' Find all integers between m and n (m and n integers with 1 <= m <= n) such that the sum of their squared divisors is itself a square.
' 
' We will return an array of subarrays or of tuples (in C an array of Pair) or a string. The subarrays (or tuples or Pairs) will have two elements: first the 
' number the squared divisors of which is a square and then the sum of the squared divisors.
' 
' Example:
' list_squared(1, 250) --> [[1, 1], [42, 2500], [246, 84100]]
' list_squared(42, 250) --> [[42, 2500], [246, 84100]]
' 
' The form of the examples may change according to the language, see "Sample Tests".
' 
' Note
' In Fortran - as in any other language - the returned string is not permitted to contain any redundant trailing whitespace: you can use dynamically 
' allocated character strings.
' -----------------------------------------------------------

Imports System

Public Class SumSquaredDivisors
    Public Shared Function ListSquared(ByVal m As Long, ByVal n As Long) As String
        Dim answer As New List(Of List(Of Integer))
        Dim i As Long = m
        While i <= n
            Dim j As List(Of Integer) = SumSqDivisors(i)
            If j IsNot Nothing Then
                answer.Add(j)
            End If
            i += 1
        End While
        Dim answerString As String = "["
        For Each arr In answer
            answerString += "[" + arr(0).ToString() + ", " + arr(1).ToString() + "], "
        Next
        If answerString.Length > 1 Then
            answerString = answerString.Substring(0, answerString.Length - 2)
        End If
        Return answerString + "]"
    End Function
    
    Private Shared Function SquareDivisionCheck(ByVal n As Long, ByVal sqSumDiv As Long) As List(Of Integer)
        Dim arr As New List(Of Integer)
        If sqSumDiv <> Math.Pow(Math.Floor(Math.Sqrt(sqSumDiv)), 2) Then
            Return Nothing
        Else
            arr.Add(n)
            arr.Add(sqSumDiv)
            Return arr
        End if
    End Function

    Private Shared Function SumSqDivisors(ByVal n As Long) As List(Of Integer)
        Dim i As Long = 1
        Dim sqSumDiv As Long = 0
        While i <= Math.Floor(Math.Sqrt(n))
            If n Mod i = 0 Then
                sqSumDiv += Math.Pow(i, 2)
                Dim j As Long = n \ i
                If j <> i Then
                    sqSumDiv += Math.Pow(j, 2)
                End If
            End If
            i += 1
        End While
        Return SquareDivisionCheck(n, sqSumDiv)
    End Function
End Class

' or

Imports System
Imports System.Text

Public Class SumSquaredDivisors
    Public Shared Function ListSquared(ByVal m As Long, ByVal n As Long) As String
        Dim answer As New List(Of List(Of Integer))
        Dim i As Long = m
        While i <= n
            Dim j As List(Of Integer) = SumSqDivisors(i)
            If j IsNot Nothing Then
                answer.Add(j)
            End If
            i += 1
        End While
        Dim answerString As New StringBuilder("[")
        For Each arr In answer
            answerString.Append("[") _
                        .Append(arr(0).ToString()) _
                        .Append(", ") _
                        .Append(arr(1).ToString()) _
                        .Append("], ")
        Next
        If answerString.Length > 1 Then
            answerString.Remove(answerString.Length - 2, 2)
        End If
        answerString.Append("]")
        Return answerString.ToString()
    End Function
    
    Private Shared Function SquareDivisionCheck(ByVal n As Long, ByVal sqSumDiv As Long) As List(Of Integer)
        Dim arr As New List(Of Integer)
        If sqSumDiv <> Math.Pow(Math.Floor(Math.Sqrt(sqSumDiv)), 2) Then
            Return Nothing
        Else
            arr.Add(n)
            arr.Add(sqSumDiv)
            Return arr
        End if
    End Function

    Private Shared Function SumSqDivisors(ByVal n As Long) As List(Of Integer)
        Dim i As Long = 1
        Dim sqSumDiv As Long = 0
        While i <= Math.Floor(Math.Sqrt(n))
            If n Mod i = 0 Then
                sqSumDiv += Math.Pow(i, 2)
                Dim j As Long = n \ i
                If j <> i Then
                    sqSumDiv += Math.Pow(j, 2)
                End If
            End If
            i += 1
        End While
        Return SquareDivisionCheck(n, sqSumDiv)
    End Function
End Class

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