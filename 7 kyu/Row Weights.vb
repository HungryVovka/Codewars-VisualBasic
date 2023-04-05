' -----------------------------------------------------------
' Scenario
' Several people are standing in a row divided into two teams.
' The first person goes into team 1, the second goes into team 2, the third goes into team 1, and so on.
' 
' Task
' Given an array of positive integers (the weights of the people), return a new array/tuple of two integers, where the first one is the total weight of 
' team 1, and the second one is the total weight of team 2.
' 
' Notes
' Array size is at least 1.
' All numbers will be positive.
' 
' Input >> Output Examples
' rowWeights([13, 27, 49])  ==>  return (62, 27)
' 
' Explanation:
' The first element 62 is the total weight of team 1, and the second element 27 is the total weight of team 2.
' 
' rowWeights([50, 60, 70, 80])  ==>  return (120, 140)
' 
' Explanation:
' The first element 120 is the total weight of team 1, and the second element 140 is the total weight of team 2.
' 
' rowWeights([80])  ==>  return (80, 0)
' 
' Explanation:
' The first element 80 is the total weight of team 1, and the second element 0 is the total weight of team 2.
' -----------------------------------------------------------

Public Module Kata
  Public Function RowWeights(ByVal array As Integer()) As Integer()
        Dim team1 As Integer = 0
        Dim team2 As Integer = 0
        For i = 0 To array.Length - 1
            If i Mod 2 = 0 Then
                team1 += array(i)
            Else
                team2 += array(i)
            End If
        Next
        Return {team1, team2}
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