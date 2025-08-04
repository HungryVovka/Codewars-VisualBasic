' -----------------------------------------------------------
' Consider the sequence U(n, x) = x + 2x**2 + 3x**3 + .. + nx**n where x is a real number and n a positive integer.
' 
' When n goes to infinity and x has a correct value (ie x is in its domain of convergence D), U(n, x) goes to a finite limit m depending on x.
' 
' Usually given x we try to find m. Here we will try to find x (x real, 0 < x < 1) when m is given (m real, m > 0).
' 
' Let us call solve the function solve(m) which returns x such as U(n, x) goes to m when n goes to infinity.
' 
' Examples:
' solve(2.0) returns 0.5 since U(n, 0.5) goes to 2 when n goes to infinity.
' 
' solve(8.0) returns 0.7034648345913732 since U(n, 0.7034648345913732) goes to 8 when n goes to infinity.
' 
' Note:
' You pass the tests if abs(actual - expected) <= 1e-12
' -----------------------------------------------------------

Public Module S    
    Public Function Solve(ByVal m As Double) As Double
        Dim sinistra As Double = 0.0
        Dim destra As Double = 1.0
        While destra - sinistra > 1e-12
            Dim mezzo As Double = (sinistra + destra) / 2
            Dim f As Double = mezzo / ((1 - mezzo) * (1 - mezzo))
            If f < m Then
                sinistra = mezzo
            Else
                destra = mezzo
            End If
        End While
        Return (sinistra + destra) / 2
    End Function
End Module

' or

Imports System.Math 

Public Module S    
    Public Function Solve(ByVal m As Double) As Double
        Return (1 + 2 * m - Math.Sqrt(1 + 4 * m)) / (2 * m)
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