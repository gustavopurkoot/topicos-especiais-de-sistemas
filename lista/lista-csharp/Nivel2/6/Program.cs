using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}