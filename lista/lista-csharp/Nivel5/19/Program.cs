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

        int maior = numeros[0];

        for (int i = 1; i < 5; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }

        Console.WriteLine("Maior valor: " + maior);
    }
}