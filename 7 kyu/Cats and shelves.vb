' -----------------------------------------------------------
' Description
' An infinite number of shelves are arranged one above the other in a staggered fashion.
' The cat can jump either one or three shelves at a time: from shelf i to shelf i+1 or i+3 (the cat cannot climb on the shelf directly above its head), 
' according to the illustration:
' 
'                  ┌────────┐
'                  │-6------│
'                  └────────┘
' ┌────────┐       
' │------5-│        
' └────────┘  ┌─────► OK!
'             │    ┌────────┐
'             │    │-4------│
'             │    └────────┘
' ┌────────┐  │
' │------3-│  │     
' BANG!────┘  ├─────► OK! 
'   ▲  |\_/|  │    ┌────────┐
'   │ ("^-^)  │    │-2------│
'   │ )   (   │    └────────┘
' ┌─┴─┴───┴┬──┘
' │------1-│
' └────────┘
' 
' Input
' Start and finish shelf numbers (always positive integers, finish no smaller than start)
' 
' Task
' Find the minimum number of jumps to go from start to finish
' 
' Example
' Start 1, finish 5, then answer is 2 (1 => 4 => 5 or 1 => 2 => 5)
' -----------------------------------------------------------

Public Module Kata
    Public Function Cats(ByVal start As Integer, ByVal finish As Integer) As Integer
        Dim kittyJump As Integer = finish - start
        Return Math.Floor(kittyJump / 3) + kittyJump Mod 3
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