' -----------------------------------------------------------
' In this kata you have to correctly return who is the "survivor", ie: the last element of a Josephus permutation.
' 
' Basically you have to assume that n people are put into a circle and that they are eliminated in steps of k elements, like this:
' 
' n=7, k=3 => means 7 people in a circle
' one every 3 is eliminated until one remains
' [1,2,3,4,5,6,7] - initial sequence
' [1,2,4,5,6,7] => 3 is counted out
' [1,2,4,5,7] => 6 is counted out
' [1,4,5,7] => 2 is counted out
' [1,4,5] => 7 is counted out
' [1,4] => 5 is counted out
' [4] => 1 counted out, 4 is the last element - the survivor!
' 
' The above link about the "base" kata description will give you a more thorough insight about the origin of this kind of permutation, but basically 
' that's all that there is to know to solve this kata.
' 
' Notes and tips: using the solution to the other kata to check your function may be helpful, but as much larger numbers will be used, using an 
' array/list to compute the number of the survivor may be too slow; you may assume that both n and k will always be >=1.
' -----------------------------------------------------------

Public Module Kata
    Public Function JosephusSurvivor(ByVal n As Integer, ByVal k As Integer) As Integer
        Dim survivors As New List(Of Integer)
        For i As Integer = 1 To n
            survivors.Add(i)
        Next
        Dim j As Integer = 0
        While survivors.Count > 1
            j = (j + k - 1) Mod survivors.Count
            survivors.RemoveAt(j)
        End While
        Return survivors(0)
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