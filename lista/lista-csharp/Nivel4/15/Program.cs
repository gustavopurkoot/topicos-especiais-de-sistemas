using System;

public class Funcionario
{
    public string Nome;
    public double Salario;
    public string Cargo;
}

class Program
{
    static void Main()
    {
        Funcionario func = new Funcionario();

        Console.Write("Digite o nome: ");
        func.Nome = Console.ReadLine();

        Console.Write("Digite o salário: ");
        func.Salario = double.Parse(Console.ReadLine());

        Console.Write("Digite o cargo: ");
        func.Cargo = Console.ReadLine();

        Console.WriteLine("\n--- Dados do Funcionário ---");
        Console.WriteLine("Nome: " + func.Nome);
        Console.WriteLine("Salário: " + func.Salario);
        Console.WriteLine("Cargo: " + func.Cargo);
    }
}