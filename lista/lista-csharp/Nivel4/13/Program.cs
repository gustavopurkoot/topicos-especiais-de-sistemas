using System;

public class Carro
{
    public string Marca;
    public string Modelo;
    public int ano;

    public void ExibirDados()
    {
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + ano);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Carro carro1 = new Carro();

        Console.Write("digite a marca do carro: ");
        carro1.Marca = Console.ReadLine();

         Console.Write("digite o modelo do carro: ");
        carro1.Modelo = Console.ReadLine();

         Console.Write("digite o ano do carro: ");
        carro1.ano = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDados do Carro:");
        carro1.ExibirDados();

    }
}