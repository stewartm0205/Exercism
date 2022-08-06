Imports System
Imports System.Collections.Generic

Public Module AllYourBase
    Public Function Rebase(ByVal inputBase As Integer, ByVal inputDigits As Integer(), ByVal outputBase As Integer) As Integer()
        Dim dec, mul Integer

        If inputBase <= 1 Then
            Throw New ArgumentException()
        End If
        If outputBase <= 1 Then
            Throw New ArgumentException()
        End If
        dec = 0
        mul = 1
        For i As Integer = inputDigits.Length() - 1 To 0 Step -1
            If inputDigits(i) < 0 Or inputDigits(i) >= inputBase Then
                Throw New ArgumentException()
            End If
            dec = dec + inputDigits(i) * outputBase
            mul = mul * outputBase
        Next

    End Function
End Module