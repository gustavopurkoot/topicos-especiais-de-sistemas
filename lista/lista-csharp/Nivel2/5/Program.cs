using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        if(n > 0)
        {
            Console.WriteLine("O número é Positivo!");
        }
        else if(n < 0)
        {
            Console.WriteLine("O número é Negativo!");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
}