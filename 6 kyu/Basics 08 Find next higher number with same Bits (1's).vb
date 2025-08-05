' -----------------------------------------------------------
' Your task is to find the next higher number (int) with the same number of '1'- Bits.
' 
' I.e. as many 1 bits as before and output next higher than input. Input is always an int between 1 and 1<<30 (possibly inclusive). No bad cases or 
' special tricks...
' 
' Some easy examples:
' Input: 129  => Output: 130 (10000001 => 10000010)
' Input: 127 => Output: 191 (01111111 => 10111111)
' Input: 1 => Output: 2 (01 => 10)
' Input: 323423 => Output: 323439 (1001110111101011111 => 1001110111101101111)
' 
' First some static tests, later on many random tests too;-)!
' 
' Hope you have fun! :-)
' -----------------------------------------------------------

Public Module Kata
    Public Function NextHigher(ByVal n As Integer) As Integer
        Dim copia As Integer = n
        Dim zeriADestra As Integer = 0
        Dim uniADestra As Integer = 0
        While (copia And 1) = 0 AndAlso copia <> 0
            zeriADestra += 1
            copia >>= 1
        End While
        While (copia And 1) = 1
            uniADestra += 1
            copia >>= 1
        End While
        If zeriADestra + uniADestra = 31 OrElse zeriADestra + uniADestra = 0 Then
            Return - 1
        End If
        Dim posizioneCambio As Integer = zeriADestra + uniADestra
        n = n Or (1 << posizioneCambio)
        n = n And Not ((1 << posizioneCambio) - 1)
        n = n Or ((1 << (uniADestra - 1)) - 1)
        Return n
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
' Copyright (C) 2025 Vladimir Rukavishnikov
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