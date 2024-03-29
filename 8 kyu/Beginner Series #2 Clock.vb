' -----------------------------------------------------------
' Clock shows h hours, m minutes and s seconds after midnight.
' 
' Your task is to write a function which returns the time since midnight in milliseconds.
' 
' Example:
' h = 0
' m = 1
' s = 1
' 
' result = 61000
' 
' Input constraints:
' 0 <= h <= 23
' 0 <= m <= 59
' 0 <= s <= 59
' -----------------------------------------------------------

Public Module Kata
    Public Function Past(ByVal h As Integer, ByVal m As Integer, ByVal s As Integer) As Integer
        Return (h * 60 * 60 * 1000)  + (m * 60 * 1000) + (s * 1000)
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