using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if(idade >= 18)
        {
            Console.WriteLine("Você é maior de idade!");
        }
        else
        {
            Console.WriteLine("Você é menor de idade!");
        }
    }
}