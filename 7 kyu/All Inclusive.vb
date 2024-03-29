' -----------------------------------------------------------
' Input:
' 
' a string strng
' an array of strings arr
' 
' Output of function contain_all_rots(strng, arr) (or containAllRots or contain-all-rots):
' 
' a boolean true if all rotations of strng are included in arr
' false otherwise
' 
' Examples:
' 
' contain_all_rots(
'   "bsjq", ["bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs"]) -> true
' 
' contain_all_rots(
'   "Ajylvpy", ["Ajylvpy", "ylvpyAj", "jylvpyA", "lvpyAjy", "pyAjylv", "vpyAjyl", "ipywee"]) -> false)
' 
' Note:
' 
' Though not correct in a mathematical sense
' 
' we will consider that there are no rotations of strng == ""
' and for any array arr: contain_all_rots("", arr) --> true
' 
' Ref: https://en.wikipedia.org/wiki/String_(computer_science)#Rotations
' -----------------------------------------------------------

Imports System
Imports System.Collections.Generic

Public Module Rotations
    Public Function ContainAllRots(ByVal s As String, ByVal arr As List(Of String)) As Boolean
        Dim inclusive As String
        For i = 0 to s.Length
            inclusive = s.Substring(i) & s.Substring(0, i)
        If Not arr.Contains(inclusive) Then 
            Return False
        End If
        Next
        Return True
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