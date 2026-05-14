using System;

public class Carro
{
    public string Marca;
    public string Modelo;
    public int Ano;
}

class Program
{
    static void Main()
    {
        Carro[] carros = new Carro[3];

        for (int i = 0; i < 3; i++)
        {
            carros[i] = new Carro();

            Console.Write("Digite a marca: ");
            carros[i].Marca = Console.ReadLine();

            Console.Write("Digite o modelo: ");
            carros[i].Modelo = Console.ReadLine();

            Console.Write("Digite o ano: ");
            carros[i].Ano = int.Parse(Console.ReadLine());
        }
    }
}