Module Module1
    Sub Main()
        Dim listaNumeros(10) As Integer
        Dim listaNumerosGanador(10) As Integer

        For i = 0 To 9
            System.Console.Write("Dame el numero " & (i + 1) & " de tu bonoloto: ")
            listaNumeros(i) = System.Console.ReadLine()
        Next

        System.Console.WriteLine()

        For i = 0 To 9
            System.Console.Write("Dame el numero " & (i + 1) & " del ganador: ")
            listaNumerosGanador(i) = System.Console.ReadLine()
        Next

        System.Console.WriteLine()

        Dim numeroAciertos As Integer = 0
        For i = 0 To 9
            If listaNumeros(i) = listaNumerosGanador(i) Then
                System.Console.WriteLine("El numero " & listaNumeros(i) & " en la posicion " & i & " es ganador. ")
                numeroAciertos = numeroAciertos + 1
            End If
        Next

        System.Console.WriteLine()
        System.Console.Write("La cantidad de numeros acertados es: " & numeroAciertos)

        System.Console.ReadLine()

    End Sub

End Module

