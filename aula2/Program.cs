using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite um numero menor que 10: ");
        int tabuada = int.Parse(Console.ReadLine());

        if( tabuada > 10 || tabuada < 0)
        {
            Console.WriteLine("Numero invalido!");
        }
        else
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
            }
        }

        Console.Write("Digite um numero: ");
        double num = double.Parse(Console.ReadLine());

        int resultado = 1;

        for (int i = 0; i < num; i++)
        {
            resultado = resultado * 2;
        }

        Console.WriteLine($"2 elevado a {num} = {resultado}");

    int par_impar = 1;

        while (par_impar != 0){

        Console.Write("Informe um número: ");
        par_impar = int.Parse(Console.ReadLine());

        {
            if (par_impar % 2 == 0)
            {
                Console.WriteLine($"O numero: {par_impar} é par");
            }
            else
            {
                Console.WriteLine($"O numero: {par_impar} é impar");
            }
        }
        } 
    }
}