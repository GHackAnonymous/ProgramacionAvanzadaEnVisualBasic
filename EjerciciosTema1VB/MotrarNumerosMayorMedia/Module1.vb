Module Module1

    Sub Main()
        Dim listaNumeros(10) As Integer

        For i = 0 To 9
            System.Console.Write("Dame el numero " & (i + 1) & ": ")
            listaNumeros(i) = System.Console.ReadLine()
        Next

        Dim media As Integer = 0
        For i = 0 To 9
            media = media + listaNumeros(i)
        Next

        media = media / 10

        System.Console.WriteLine()


        For i = 0 To 9
            If listaNumeros(i) > media Then
                System.Console.Write(listaNumeros(i) & " ")
            End If
        Next

        System.Console.ReadLine()
    End Sub

End Module
