' -----------------------------------------------------------
' Write a function partlist that gives all the ways to divide a list (an array) of at least two elements into two non-empty parts.
' 
' Each two non empty parts will be in a pair (or an array for languages without tuples or a structin C - C: see Examples test Cases - )
' Each part will be in a string
' Elements of a pair must be in the same order as in the original array.
' 
' Examples of returns in different languages:
' a = ["az", "toto", "picaro", "zone", "kiwi"] -->
' [["az", "toto picaro zone kiwi"], ["az toto", "picaro zone kiwi"], ["az toto picaro", "zone kiwi"], ["az toto picaro zone", "kiwi"]] 
' or
'  a = {"az", "toto", "picaro", "zone", "kiwi"} -->
' {{"az", "toto picaro zone kiwi"}, {"az toto", "picaro zone kiwi"}, {"az toto picaro", "zone kiwi"}, {"az toto picaro zone", "kiwi"}}
' or
' a = ["az", "toto", "picaro", "zone", "kiwi"] -->
' [("az", "toto picaro zone kiwi"), ("az toto", "picaro zone kiwi"), ("az toto picaro", "zone kiwi"), ("az toto picaro zone", "kiwi")]
' or 
' a = [|"az", "toto", "picaro", "zone", "kiwi"|] -->
' [("az", "toto picaro zone kiwi"), ("az toto", "picaro zone kiwi"), ("az toto picaro", "zone kiwi"), ("az toto picaro zone", "kiwi")]
' or
' a = ["az", "toto", "picaro", "zone", "kiwi"] -->
' "(az, toto picaro zone kiwi)(az toto, picaro zone kiwi)(az toto picaro, zone kiwi)(az toto picaro zone, kiwi)"
' 
' Note
' You can see other examples for each language in "Your test cases"
' -----------------------------------------------------------

Imports System

Public Module PartList
    Public Function Partlist(ByVal arr As String()) As String()()
        Dim counter As Integer = arr.Length
        Dim answer(counter - 2)() As String
        Dim str1 As String = ""
        Dim str2 As String = ""
        For i = 0 To (counter - 2)
            str1 &= arr(i) & " "
            For j = (i + 1) To (counter - 1)
                str2 &= arr(j) & " "
            Next
            Dim parts(1) As String
            parts(0) = str1.TrimEnd
            parts(1) = str2.TrimEnd
            answer.SetValue(parts, i)
            str2 = ""
        Next
        Return answer
    End Function
End Module