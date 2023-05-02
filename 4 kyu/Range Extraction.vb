' -----------------------------------------------------------
' A format for expressing an ordered list of integers is to use a comma separated list of either
' 
' individual integers
' 
' or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. The range includes all integers in 
' the interval including both endpoints. It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"
' 
' Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.
' 
' Example:
' 
' solution([-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
' // returns "-10--8,-6,-3-1,3-5,7-11,14,15,17-20"
' 
' Courtesy of rosettacode.org
' -----------------------------------------------------------

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class RangeExtraction
    Public Shared Function Extract(ByVal args As Integer()) As String
        Dim answer As New StringBuilder()
        Dim i As Integer = 0
        While i < args.Length
            Dim start As Integer = args(i)
            Dim [end] As Integer = start
            While i < args.Length - 1 AndAlso args(i + 1) = [end] + 1
                [end] = args(i + 1)
                i += 1
            End While
            If start = [end] Then
                answer.AppendFormat("{0},", start)
            ElseIf [end] - start = 1 Then
                answer.AppendFormat("{0},{1},", start, [end])
            Else
                answer.AppendFormat("{0}-{1},", start, [end])
            End If
            i += 1
        End While
        Return answer.ToString().TrimEnd(",")
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