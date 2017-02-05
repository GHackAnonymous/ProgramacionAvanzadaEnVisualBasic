Module Module1

    Sub Main()

        Dim fecha As Date

        System.Console.Write("Dame una fecha (Ejem: 02/03/2014): ")
        Try
            fecha = (System.Console.ReadLine())
            System.Console.WriteLine("La fecha introducida es: " & fecha)
        Catch e As InvalidCastException
            System.Console.WriteLine("Error: fecha no valida")
        End Try

        System.Console.ReadLine()

    End Sub

End Module
