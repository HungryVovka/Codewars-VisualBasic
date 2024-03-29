' -----------------------------------------------------------
' All we eat is water and dry matter.
' 
' Let us begin with an example:
' 
' John bought potatoes: their weight is 100 kilograms. Potatoes contain water and dry matter. The water content is 99 percent of the total weight. He 
' thinks they are too wet and puts them in an oven - at low temperature - for them to lose some water.
' 
' At the output the water content is only 98%.
' 
' What is the total weight in kilograms (water content plus dry matter) coming out of the oven?
' 
' He finds 50 kilograms and he thinks he made a mistake: "So much weight lost for such a small change in water content!"
' 
' Can you help him?
' 
' Task
' Write function potatoes with
' 
' int parameter p0 - initial percent of water-
' int parameter w0 - initial weight -
' int parameter p1 - final percent of water -
' 
' potatoesshould return the final weight coming out of the oven w1 truncated as an int.
' 
' Example:
' potatoes(99, 100, 98) --> 50
' -----------------------------------------------------------

Imports System

Public Module DryPotatoes
    Public Function Potatoes(ByVal p0 As Integer, ByVal w0 As Integer, ByVal p1 As Integer) As Integer
        Return w0 * (100 - p0) \ (100 - p1)
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