using System;

class Program
{

    static int soma(int a, int b)
    {
        return a + b;
    }
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int b = int.Parse(Console.ReadLine());

        int resultado = soma(a, b);

        Console.WriteLine($"A soma de {a} + {b} = {resultado}");
        
    }
}