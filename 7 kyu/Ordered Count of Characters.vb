' -----------------------------------------------------------
' Count the number of occurrences of each character and return it as a list of tuples in order of appearance. For empty output return an empty list.
' 
' Example:
' 
' Kata.OrderedCount("abracadabra") == new List(Of Tuple(Of Char, Integer)) () From {
'   new Tuple(char, int)("a"c, 5),
'   new Tuple(char, int)("b"c, 2),
'   new Tuple(char, int)("r"c, 2), 
'   new Tuple(char, int)("c"c, 1),
'   new Tuple(char, int)("d"c, 1)
' }
' -----------------------------------------------------------

Imports System.Collections.Generic

Public Module Kata 
    Public Function OrderedCount(input as String) As List(Of Tuple(Of Char, Integer))
        Dim ordercount As New List(Of Tuple(Of Char, Integer))
        For Each i As Char In input
            ordercount.Add(Tuple.Create(i, input.Split(i).Length - 1))
        Next
        Return ordercount.Distinct().ToList()
    End Function
End Module