using System;

public class Carro
{
    public string Marca;
    public string Modelo;
    public int Ano;

    public void ExibirDados()
    {
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
    }
}

class Program
{
    static void Main()
    {
        Carro[] carros = new Carro[3];
        int quantidade = 0;
        int opcao;

        do
        {
            Console.WriteLine("1 - Adicionar carro");
            Console.WriteLine("2 - Remover carro");
            Console.WriteLine("3 - Listar carros");
            Console.WriteLine("4 - Escolher carro por índice");
            Console.WriteLine("0 - Sair");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1 && quantidade < 3)
            {
                carros[quantidade] = new Carro();

                Console.Write("Marca: ");
                carros[quantidade].Marca = Console.ReadLine();

                Console.Write("Modelo: ");
                carros[quantidade].Modelo = Console.ReadLine();

                Console.Write("Ano: ");
                carros[quantidade].Ano = int.Parse(Console.ReadLine());

                quantidade++;
            }
            else if (opcao == 2 && quantidade > 0)
            {
                quantidade--;
                carros[quantidade] = null;
            }
            else if (opcao == 3)
            {
                for (int i = 0; i < quantidade; i++)
                {
                    carros[i].ExibirDados();
                }
            }
            else if (opcao == 4)
            {
                Console.Write("Digite o índice: ");
                int i = int.Parse(Console.ReadLine());

                if (i >= 0 && i < quantidade)
                {
                    carros[i].ExibirDados();
                }
            }

        } while (opcao != 0);
    }
}