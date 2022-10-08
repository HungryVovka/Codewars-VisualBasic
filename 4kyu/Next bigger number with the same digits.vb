' -----------------------------------------------------------
' Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits. For example:
' 
' 12 ==> 21
' 513 ==> 531
' 2017 ==> 2071
' 
' nextBigger(num: 12)   // returns 21
' nextBigger(num: 513)  // returns 531
' nextBigger(num: 2017) // returns 2071
' 
' If the digits can't be rearranged to form a bigger number, return -1 (or nil in Swift):
' 
' 9 ==> -1
' 111 ==> -1
' 531 ==> -1
' 
' nextBigger(num: 9)   // returns nil
' nextBigger(num: 111) // returns nil
' nextBigger(num: 531) // returns nil
' -----------------------------------------------------------

Public Class Kata
    Public Shared Function NextBiggerNumber(ByVal n As Long) As Long
        Dim digits = n.ToString().ToList()
        Dim x As Integer = digits.Count - 1
        Dim cannot As Integer = -1
        Dim to32 As Func(Of Char, Integer) = AddressOf Convert.ToInt32
        While x > 0
            If to32(digits(x)) > to32(digits(x - 1)) Then
                cannot = x - 1
                Exit While
            End If
            x -= 1
        End While
        If cannot < 0 Then
            Return cannot
        End If
        Dim picked = digits.Skip(cannot).OrderBy(Function(a) a).ToList()
        Dim bigger = digits.Take(cannot).ToList()
        x = String.Join("", picked).LastIndexOf(digits(cannot))
        bigger.Add(picked(x + 1))
        picked.RemoveAt(x + 1)
        Return Convert.ToInt64(String.Join("", bigger.Concat(picked).ToList()))
    End Function
End Class

' or

Public Class Kata
    Public Shared Function NextBiggerNumber(ByVal n As Long) As Long
        Dim digits = New List(Of Char)
        For Each i As Char In n.ToString
            digits.Add(i)
        Next
        Dim bigger = digits.Count
        For a = bigger - 2 To 0 Step -1
            For b = bigger - 1 To a Step -1
                If digits(a) < digits(b) Then
                    Dim dig = digits(a)
                    digits(a) = digits(b)
                    digits(b) = dig
                    Dim arr = New List(Of Char)
                    For c = a + 1 To bigger - 1
                        arr.Add(digits(c))
                    Next
                    arr.Sort
                    For c = a + 1 To bigger - 1
                        digits(c) = arr(c - a - 1)
                    Next
                    Return Convert.toInt64(String.Join("", digits))
                End If
            Next
        Next
        Return -1
    End Function
End Class