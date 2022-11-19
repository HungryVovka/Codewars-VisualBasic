' -----------------------------------------------------------
' Complete the solution so that it strips all text that follows any of a set of comment markers passed in. Any whitespace at the end of the line should 
' also be stripped out.
' 
' Example:
' 
' Given an input string of:
' 
' apples, pears # and bananas
' grapes
' bananas !apples
' 
' The output expected would be:
' 
' apples, pears
' grapes
' bananas
' 
' The code would be called like so:
' 
' var result = solution("apples, pears # and bananas\ngrapes\nbananas !apples", ["#", "!"])
' // result should == "apples, pears\ngrapes\nbananas"
' -----------------------------------------------------------

Public Class StripCommentsSolution
    Public Shared Function StripComments(ByVal text As String, ByVal markers As String()) As String
        Dim i As String() = text.Split(vbLf)
        i = i.Select(Function(j) j.Split(markers, StringSplitOptions.None).First().TrimEnd()).ToArray()
        Return String.Join(vbLf, i)
    End Function
End Class