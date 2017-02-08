Module Module1

    Sub Main()
        For i = 0 To 10
            If (i Mod 2) <> 0 Then
                System.Console.WriteLine("El numero " & i & " es impar")
            End If
        Next
        System.Console.ReadLine()
    End Sub

End Module
