' -----------------------------------------------------------
' Your task in order to complete this Kata is to write a function which formats a duration, given as a number of seconds, in a human-friendly way.
' 
' The function must accept a non-negative integer. If it is zero, it just returns "now". Otherwise, the duration is expressed as a combination of years, 
' days, hours, minutes and seconds.
' 
' It is much easier to understand with an example:
' 
' * For seconds = 62, your function should return 
'     "1 minute and 2 seconds"
' * For seconds = 3662, your function should return
'     "1 hour, 1 minute and 2 seconds"
' 
' For the purpose of this Kata, a year is 365 days and a day is 24 hours.
' 
' Note that spaces are important.
' 
' Detailed rules
' The resulting expression is made of components like 4 seconds, 1 year, etc. In general, a positive integer and one of the valid units of time, 
' separated by a space. The unit of time is used in plural if the integer is greater than 1.
' 
' The components are separated by a comma and a space (", "). Except the last component, which is separated by " and ", just like it would be 
' written in English.
' 
' A more significant units of time will occur before than a least significant one. Therefore, 1 second and 1 year is not correct, but 
' 1 year and 1 second is.
' 
' Different components have different unit of times. So there is not repeated units like in 5 seconds and 1 second.
' 
' A component will not appear at all if its value happens to be zero. Hence, 1 minute and 0 seconds is not valid, but it should be just 1 minute.
' 
' A unit of time must be used "as much as possible". It means that the function should not return 61 seconds, but 1 minute and 1 second instead. 
' Formally, the duration specified by of a component must not be greater than any valid more significant unit of time.
' -----------------------------------------------------------

Public Class HumanTimeFormat
    Public Shared Function formatDuration(ByVal seconds As Integer) As String
        If seconds = 0 Then
            Return "now"
        End If
        Dim clock(4) As Integer
        clock(0) = Math.Floor(Math.Floor(Math.Floor( _
                    Math.Floor(seconds / 60) / 60) / 24) / 365)
        clock(1) = Math.Floor(Math.Floor(Math.Floor( _
                    seconds / 60) / 60) / 24) Mod 365
        clock(2) = Math.Floor(Math.Floor(seconds / 60) / 60) Mod 24
        clock(3) = Math.Floor(seconds / 60) Mod 60
        clock(4) = seconds Mod 60
        Dim timeNumbers As Integer = 0
        For i As Integer = 0 To clock.Length - 1
            If clock(i) > 0 Then
                timeNumbers += 1
            End If
        Next i
        System.Console.WriteLine(timeNumbers)
        Dim clockface As String = ""
        For i As Integer = 0 To clock.Length - 1
            Dim clockadd As String = ""
            System.Console.WriteLine(i)
            System.Console.WriteLine(clockface)
            If clock(i) > 0 Then
                If clockface.Length <> 0 Then
                    clockadd += ", "
                End If
                clockadd += CStr(clock(i))
                If i = 0 Then
                    If clock(i) = 1 Then
                        clockadd += " year"
                    Else
                        clockadd += " years"
                    End If
                ElseIf i = 1 Then
                    If clock(i) = 1 Then
                        clockadd += " day"
                    Else
                        clockadd += " days"
                    End If
                ElseIf i = 2 Then
                    If clock(i) = 1 Then
                        clockadd += " hour"
                    Else
                        clockadd += " hours"
                    End If
                ElseIf i = 3 Then
                    If clock(i) = 1 Then
                        clockadd += " minute"
                    Else
                        clockadd += " minutes"
                    End If
                ElseIf i = 4 Then
                    If clock(i) = 1 Then
                        clockadd += " second"
                    Else
                        clockadd += " seconds"
                    End If
                End If
            End If
            clockface += clockadd
        Next i
        If timeNumbers > 1 Then
            Dim clockfaceSplit = clockface.Split(",")
            clockface = String.Join(",", clockfaceSplit.Take(timeNumbers - 1))
            clockface += " and" + clockfaceSplit.Last()
        End If
        Return clockface
    End Function
End Class