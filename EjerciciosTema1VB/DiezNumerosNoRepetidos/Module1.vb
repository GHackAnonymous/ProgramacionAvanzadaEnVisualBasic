Module Module1

    Sub Main()
        Dim listaNumeros(10) As Integer

        Dim i As Integer = 0
        While i <> 10
            System.Console.Write("Dame el numero " & (i + 1) & ": ")
            Dim numero As Integer = System.Console.ReadLine()
            Dim esta As Boolean = False
            'Try
            For e = 0 To (listaNumeros.Length - 1)
                If listaNumeros.Length > 0 Then
                    If numero = listaNumeros(e) Then
                        esta = True
                        Exit For
                    End If
                End If
            Next

            If esta = False Then
                    listaNumeros(i) = numero
                    i = i + 1
                End If

            'Catch e As Exception
            '    listaNumeros(i) = numero
            '    i = i + 1
            'End Try

        End While

        For i = 0 To 9
            If listaNumeros(i) <> 0 Then
                System.Console.Write(listaNumeros(i) & " ")
            End If
        Next

        System.Console.ReadLine()

    End Sub

End Module
