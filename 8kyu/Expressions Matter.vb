' -----------------------------------------------------------
' Task
' Given three integers a ,b ,c, return the largest number obtained after inserting the following operators and brackets: +, *, ()
' In other words , try every combination of a,b,c with [*+()] , and return the Maximum Obtained (Read the notes for more detail about it)
' 
' Example
' With the numbers are 1, 2 and 3 , here are some ways of placing signs and brackets:
' 
' 1 * (2 + 3) = 5
' 1 * 2 * 3 = 6
' 1 + 2 * 3 = 7
' (1 + 2) * 3 = 9
' So the maximum value that you can obtain is 9.
' 
' Notes
' The numbers are always positive.
' The numbers are in the range (1  ≤  a, b, c  ≤  10).
' You can use the same operation more than once.
' It's not necessary to place all the signs and brackets.
' Repetition in numbers may occur .
' You cannot swap the operands. For instance, in the given example you cannot get expression (1 + 3) * 2 = 8.
' 
' Input >> Output Examples:
' expressionsMatter(1,2,3)  ==>  return 9
' 
' Explanation:
' After placing signs and brackets, the Maximum value obtained from the expression (1+2) * 3 = 9.
' 
' expressionsMatter(1,1,1)  ==>  return 3
' 
' Explanation:
' After placing signs, the Maximum value obtained from the expression is 1 + 1 + 1 = 3.
' 
' expressionsMatter(9,1,1)  ==>  return 18
' 
' Explanation:
' After placing signs and brackets, the Maximum value obtained from the expression is 9 * (1+1) = 18. ___# Task
' 
' Given three integers a ,b ,c, return the largest number obtained after inserting the following operators and brackets: +, *, ()
' In other words , try every combination of a,b,c with [*+()] , and return the Maximum Obtained
' 
' Example
' With the numbers are 1, 2 and 3 , here are some ways of placing signs and brackets:
' 
' 1 * (2 + 3) = 5
' 1 * 2 * 3 = 6
' 1 + 2 * 3 = 7
' (1 + 2) * 3 = 9
' So the maximum value that you can obtain is 9.
' 
' Notes
' The numbers are always positive.
' The numbers are in the range (1  ≤  a, b, c  ≤  10).
' You can use the same operation more than once.
' It's not necessary to place all the signs and brackets.
' Repetition in numbers may occur .
' You cannot swap the operands. For instance, in the given example you cannot get expression (1 + 3) * 2 = 8.
' 
' Input >> Output Examples:
' expressionsMatter(1,2,3)  ==>  return 9
' 
' Explanation:
' After placing signs and brackets, the Maximum value obtained from the expression (1+2) * 3 = 9.
' 
' expressionsMatter(1,1,1)  ==>  return 3
' -----------------------------------------------------------

Public Module Kata
    Public Function ExpressionMatter(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Dim output1 As Integer = a * (b + c)
        Dim output2 As Integer = a * b * c
        Dim output3 As Integer = a + b * c
        Dim output4 As Integer = (a + b) * c
        Dim output5 As Integer = a + b + c
        Dim output6 As Integer = a * b + c
        Dim answer As Integer = output1
        If answer < output2 Then answer = output2
        If answer < output3 Then answer = output3
        If answer < output4 Then answer = output4
        If answer < output5 Then answer = output5
        If answer < output6 Then answer = output6
        Return answer
    End Function
End Module

' or

Public Module Kata
    Public Function ExpressionMatter(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Return (New Integer(){
                a + b + c,
                a * (b + c), 
                a * b * c, 
                a + b * c, 
                (a + b) * c,
                a * b + c}).Max()
    End Function
End Module