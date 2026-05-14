using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite um número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Valores:");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }
    }
}