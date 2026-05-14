using System;

class Program{

    static void Main()
    {
        Console.Write("Digite um numero: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"O dobro de {n} é: {n * 2}");
    }
}
