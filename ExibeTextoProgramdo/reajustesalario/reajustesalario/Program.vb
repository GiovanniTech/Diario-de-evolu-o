Imports System

Module Program
    Sub Main(args As String())
        'Vamos desenvolver um sistema para calcular o reajuste de sal�rio

        Dim funcionario As String
        Dim salario, reajuste, novosalario As Double

        Console.WriteLine("Digite o nome do Funcion�rio: ")
        funcionario = Console.ReadLine()

        Console.WriteLine("Digite o sal�rio atual: ")
        salario = Console.ReadLine()

        Console.WriteLine("Digite o percentual de reajuste: ")
        reajuste = Console.ReadLine()

        novosalario = salario + salario * reajuste / 100

        Console.WriteLine("A novo sal�rio do funcion�rio " & funcionario & " � de " & novosalario)



        Console.WriteLine("Hello World!")
    End Sub
End Module
