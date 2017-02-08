Module Module1

    Sub Main()
        System.Console.Write("Dame un numero para saver si es primo: ")
        Dim numeroAnalizar As Integer = System.Console.ReadLine()

        Dim resultado As Integer = 0
        Dim i As Integer = 2
        For i = 2 To (numeroAnalizar - 1)
            resultado = numeroAnalizar Mod i
            If resultado = 0 Then
                System.Console.WriteLine("No es primo")
                Exit For
            End If
        Next

        If i = numeroAnalizar Then
            System.Console.WriteLine("Es primo")
        End If
        System.Console.ReadLine()
    End Sub
End Module
