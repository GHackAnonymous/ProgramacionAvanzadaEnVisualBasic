Module Module1

    Sub Main()
        Dim listaNumeros(10) As Integer

        For i = 0 To 9
            System.Console.Write("Dame el numero " & (i + 1) & ": ")
            listaNumeros(i) = System.Console.ReadLine()
        Next

        System.Console.WriteLine()


        Dim a As Integer = 9
        While a > -1
            System.Console.Write(listaNumeros(a) & " ")
            a = a - 1
        End While

        System.Console.ReadLine()

        'For i = 9 To 0
        '    System.Console.Write(listaNumeros(a) & " ")
        'Next

        'System.Console.ReadLine()

    End Sub

End Module
