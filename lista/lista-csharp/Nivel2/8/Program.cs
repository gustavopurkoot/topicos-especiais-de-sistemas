using System;

class Program
{
    static void Main()
    {
        int numero;
        int soma = 0;

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        } while (numero != 0);

        Console.WriteLine($"A soma total dos numeros digitados foi: {soma}");
    }
}