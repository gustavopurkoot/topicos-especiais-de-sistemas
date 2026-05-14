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

    public void AumentarSalario(double percentual)
    {
        Salario += Salario * (percentual / 100);
    }

    public void DescontarSalario(double valor)
    {
        Salario -= valor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Funcionario func = new Funcionario();

        Console.Write("Digite o nome: ");
        func.Nome = Console.ReadLine();

        Console.Write("Digite o salário: ");
        func.Salario = double.Parse(Console.ReadLine());

        Console.Write("Digite o cargo: ");
        func.Cargo = Console.ReadLine();

        Console.WriteLine("\n--- Dados iniciais ---");
        func.ExibirDados();

        func.AumentarSalario(10);

        func.DescontarSalario(200);

        Console.WriteLine("\n--- Após alterações ---");
        func.ExibirDados();
    }
}