' -----------------------------------------------------------
' Your task is to add up letters to one letter.
' 
' The function will be given a Char(), each one being a letter to add. Return a Char.
' 
' Notes:
' Letters will always be lowercase.
' Letters can overflow (see second to last example of the description)
' If no letters are given, the function should return 'z'
' 
' Examples:
' AddLetters(New Char() {"a"C, "b"C, "c"C}) = "f"C
' AddLetters(New Char() {"a"C, "b"C}) = "c"C
' AddLetters(New Char() {"z"C}) = "z"C
' AddLetters(New Char() {"z"C, "a"C}) = "a"C
' AddLetters(New Char() {"y"C, "c"C, "b"C}) = "d"C ' notice the letters overflowing
' AddLetters(New Char() {}) = "z"C
' -----------------------------------------------------------

Imports System

Public Module Kata
    Public Function AddLetters(ByVal letters As Char()) As Char
        Dim alphabet = "abcdefghijklmnopqrstuvwxyz"
        Dim letterscount = 25
        For Each i in letters
            letterscount += alphabet.IndexOf(i)
            letterscount += 1
        Next
        Return alphabet(letterscount mod 26)
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