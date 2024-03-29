' -----------------------------------------------------------
' In this kata you have to create all permutations of a non empty input string and remove duplicates, if present. This means, you have to shuffle all 
' letters from the input in all possible orders.
' 
' Examples:
' 
' * With input 'a'
' * Your function should return: ['a']
' * With input 'ab'
' * Your function should return ['ab', 'ba']
' * With input 'aabb'
' * Your function should return ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa']
' 
' The order of the permutations doesn't matter.
' -----------------------------------------------------------

Class Permutations
    Public Shared Function SinglePermutations(ByVal s As String) As List(Of String)
        Dim arr1, arr2 As New List(Of String)
        If s.Length > 1 Then
            For Each i In s
                If Not arr1.Contains(i) Then
                    arr1.Add(i)
                End If
            Next
            For Each j In arr1
                Dim str1 = s.Substring(0, s.Length)
                Dim str2 = str1.Remove(str1.IndexOf(j), 1)
                Dim perm = SinglePermutations(str2)
                For Each k In perm
                    arr2.Add(j & k)
                Next
            Next
            Return arr2
        End If
        arr2.Add(s)
        Return arr2
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