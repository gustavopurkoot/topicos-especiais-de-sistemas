using System;

public class Carro
{
    public string Marca;
    public string Modelo;
    public int ano;
}

class Program
{
    static void Main()
    {
        Carro carro1 = new Carro();

        Console.Write("digite a marca do carro: ");
        carro1.Marca = Console.ReadLine();

         Console.Write("digite o modelo do carro: ");
        carro1.Modelo = Console.ReadLine();

         Console.Write("digite o ano do carro: ");
        carro1.ano = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDados do Carro:");
        Console.WriteLine("Marca: " + carro1.Marca);
        Console.WriteLine("Modelo: " + carro1.Modelo);
        Console.WriteLine("Ano: " + carro1.ano);
    }
}