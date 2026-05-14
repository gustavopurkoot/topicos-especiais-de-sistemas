using System;

class Program
{

    static double media(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }
    static void Main(){
    Console.Write("Digite o 1° número: ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("Digite o 2° número: ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("Digite o 3° número: ");
    double c = double.Parse(Console.ReadLine());

    double resultado = media(a, b, c);

    Console.WriteLine("Média: " + resultado);
    }
}