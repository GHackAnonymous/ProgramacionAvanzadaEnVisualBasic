Module Module1

    Sub Main()
        System.Console.Write("Dame un numero: ")

        Dim numeroAnalizar As Integer = 0

        numeroAnalizar = System.Console.ReadLine()

        Dim resultado As Integer = numeroAnalizar Mod 2

        If resultado = 0 Then
            System.Console.WriteLine("El numero " & numeroAnalizar & " es par")
        Else
            System.Console.WriteLine("El numero " & numeroAnalizar & " es impar")
        End If

        System.Console.ReadLine()

    End Sub

End Module
