Imports System

Module Program
    Sub Main(args As String())
        'Vamos desenvolver um sistema para calcular o reajuste de salário

        Dim funcionario As String
        Dim salario, reajuste, novosalario As Double

        Console.WriteLine("Digite o nome do Funcionário: ")
        funcionario = Console.ReadLine()

        Console.WriteLine("Digite o salário atual: ")
        salario = Console.ReadLine()

        Console.WriteLine("Digite o percentual de reajuste: ")
        reajuste = Console.ReadLine()

        novosalario = salario + salario * reajuste / 100

        Console.WriteLine("A novo salário do funcionário " & funcionario & " é de " & novosalario)



        Console.WriteLine("Hello World!")
    End Sub
End Module
