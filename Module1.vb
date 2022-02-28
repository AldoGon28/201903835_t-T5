Module Module1
    Sub Main(args As String())

        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        b = 1
        Console.WriteLine("Ingrese el Número a cálcular:")
        a = Console.ReadLine()
        For i = 1 To a
            b = b * i
        Next
        Console.WriteLine("El Factorial del Número es: " + b.ToString)
        For x = 0 To b
            If (x Mod 4) Then
                c = c + 1
            End If
        Next
        Console.WriteLine("Hay" + c.ToString + " numeros multiplos de 4 en " + b.ToString)
        Console.ReadKey()
    End Sub

End Module