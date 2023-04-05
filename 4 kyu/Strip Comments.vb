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