
Imports System.Text.RegularExpressions
Public Class Clock
    Dim hours, minutes As Integer
    Public Sub New(ByVal inHours As Integer, ByVal inMinutes As Integer)
        Console.WriteLine(inMinutes)
        If inMinutes >= 60 Then
            inHours = inHours + Math.Floor(inMinutes / 60)
            minutes = inMinutes Mod 60
        ElseIf inMinutes < 0 Then
            inHours = inHours + Math.Floor(inMinutes / 60)
            minutes = -inMinutes Mod 60
        Else
            minutes = inMinutes
        End If
        Console.WriteLine(inHours)
        hours = inHours Mod 24
        If hours < 0 Then
            hours = 24 + hours
        End If
        Console.WriteLine(hours)
    End Sub

    Public Function Add(ByVal minutesToAdd As Integer) As Clock
        Return New Clock(hours, minutes + minutesToAdd)
    End Function

    Public Function Subtract(ByVal minutesToSubtract As Integer) As Clock
        Return New Clock(hours, minutes - minutesToSubtract)
    End Function

    Public Overrides Function ToString() As String
        Return hours.ToString().PadLeft(2, "0") + ":" + minutes.ToString().PadLeft(2, "0")
    End Function

    Public Function Equal(ByVal c1 As Clock) As String
        Return hours = c1.hours And minutes = c1.minutes
    End Function
    Public Shared Operator =(ByVal c1 As Clock, ByVal c2 As Clock) As String
        Console.WriteLine(c1.ToString())
        Console.WriteLine(c2.ToString())
        Return c1.hours = c2.hours And c1.minutes = c2.minutes
    End Operator
    Public Shared Operator <>(ByVal c1 As Clock, ByVal c2 As Clock) As String
        Return c1.hours <> c2.hours Or c1.minutes <> c2.minutes
    End Operator
End Class

Module Module1
    Sub Main()
        Dim sut = New Clock(-31, 3)
        Dim sut2 = New Clock(17, 3)
        If sut = sut2 Then
            Console.WriteLine("Equal")
        End If

    End Sub
End Module

