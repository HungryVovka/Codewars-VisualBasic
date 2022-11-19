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