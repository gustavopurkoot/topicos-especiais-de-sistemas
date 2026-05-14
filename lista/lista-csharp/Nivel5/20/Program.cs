using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        int soma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite um número: ");
            numeros[i] = int.Parse(Console.ReadLine());
            soma += numeros[i];
        }

        double media = (double)soma / 5;

        Console.WriteLine("Média: " + media);
    }
}