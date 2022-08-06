Public Class Clock
    Dim hours, minutes As Integer
    Public Sub New(ByVal inHours As Integer, ByVal inMinutes As Integer)
        If inMinutes >= 60 Then
            inHours = inHours + Math.Floor(inMinutes / 60)
            minutes = inMinutes Mod 60
        ElseIf inMinutes < 0 Then
            inHours = inHours + Math.Floor(inMinutes / 60)
            minutes = -inMinutes Mod 60
        Else
            minutes = inMinutes
        End If
        hours = inHours Mod 24
        If hours < 0 Then
            hours = 24 + hours
        End If
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

    Public Shared Operator =(ByVal c1 As Clock, ByVal c2 As Clock) As String
        Return c1.hours = c2.hours And c1.minutes = c2.minutes
    End Operator
    Public Shared Operator <>(ByVal c1 As Clock, ByVal c2 As Clock) As String
        Return c1.hours <> c2.hours Or c1.minutes <> c2.minutes
    End Operator
End Class

