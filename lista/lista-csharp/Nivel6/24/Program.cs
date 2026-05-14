using System;

public class Carro
{
    public int Ano;
}

class Program
{
    static void Main()
    {
        Carro[] carros = new Carro[3];
        int soma = 0;

        for (int i = 0; i < 3; i++)
        {
            carros[i] = new Carro();

            Console.Write("Digite o ano: ");
            carros[i].Ano = int.Parse(Console.ReadLine());
            soma += carros[i].Ano;
        }

        double media = (double)soma / 3;

        Console.WriteLine("Média dos anos: " + media);
    }
}