using System;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        int[] n = new int[5];
        int total = 0;

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Digite o {i + 1}° número: ");
            n[i] = int.Parse(Console.ReadLine());
            total += n[i];
        }

        int media = total / 5;

        Console.WriteLine($"A soma total dos números é: {total}");
        Console.WriteLine($"A média dos números é: {media}");

    }
}