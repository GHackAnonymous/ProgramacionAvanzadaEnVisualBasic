Module Module1

    Sub Main()
        Dim resultado As Integer = 0
        For i = 0 To 10
            If (i Mod 2) = 0 Then
                REM System.Console.WriteLine(i)
                resultado = resultado + i
            End If
        Next
        System.Console.WriteLine("El resultado de la suma de los")
        System.Console.WriteLine("numeros pares del 1 al 10 es: " & resultado)
        System.Console.ReadLine()
    End Sub
End Module
