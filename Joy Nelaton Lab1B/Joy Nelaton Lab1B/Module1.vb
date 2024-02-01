Module Module1
    Dim n1 As Integer

    Sub Main()

        Console.Write("Ingrese un numero: ")
        n1 = Console.ReadLine()

        Calculo(n1)

    End Sub

    Sub Calculo(ByVal num)
        Dim cuadrado, cubo, sum As Integer
        Dim msj As String
        cuadrado = Math.Pow(num, 2)
        cubo = Math.Pow(num, 3)

        sum = cuadrado + cubo

        If (sum Mod 2 = 0) Then
            msj = "Numero par detectado"
        Else
            msj = "Numero impar detectado"
        End If

        Console.WriteLine("{0} al Cuadrado = {1}", num, cuadrado)
        Console.WriteLine("{0} al Cubo = {1}", num, cubo)
        Console.WriteLine("{0} + {1} = {2}", cuadrado, cubo, sum)
        Console.WriteLine("Resultados del numero {0}:", sum)
        Console.Write(msj)
        Console.ReadLine()





    End Sub

End Module
