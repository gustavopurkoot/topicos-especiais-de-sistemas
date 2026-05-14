using System;

    class Program
{
    static void Maior(int a, int b)
    {
        if (a == b)
        {
            Console.WriteLine("Dois números iguais!");
        }
        else if (a > b)
        {
            Console.WriteLine($"O maior número é: {a}");
        }
        else
        {
            Console.WriteLine($"O maior número é: {b}");
        }
    }

    
    static void Main()
    {
        Console.Write("Digite o 1° número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o 2° número: ");
        int b = int.Parse(Console.ReadLine());

        Maior(a, b);
    }
}