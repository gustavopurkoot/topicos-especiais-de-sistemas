using System;

public class Funcionario
{
    public string Nome;
    public double Salario;
    public string Cargo;

    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Salário: " + Salario);
        Console.WriteLine("Cargo: " + Cargo);
    }

    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }
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
        func.ExibirDados();

        Console.WriteLine("Salário Anual: " + func.CalcularSalarioAnual());
    }
}