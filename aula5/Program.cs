using System;

class Livro
{
    public string Titulo;
    public double Preco;
}

class Carrinho
{
    Livro[] livros = new Livro[10];
    int quantidade = 0;

    public void AdicionarLivro(Livro l)
    {
        if (quantidade < livros.Length)
        {
            livros[quantidade] = l;
            quantidade++;
        }
    }

    public void RemoverLivro(int indice)
    {
        if (indice >= 0 && indice < quantidade)
        {
            for (int i = indice; i < quantidade - 1; i++)
            {
                livros[i] = livros[i + 1];
            }
            quantidade--;
        }
    }

    public void ExibirCarrinho()
    {
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"{i} - {livros[i].Titulo} - R$ {livros[i].Preco}");
        }
    }

    public double CalcularTotal()
    {
        double total = 0;

        for (int i = 0; i < quantidade; i++)
        {
            total += livros[i].Preco;
        }

        return total;
    }
}

class Program
{
    static void Main()
    {
        Carrinho carrinho = new Carrinho();
        int opcao;

        do
        {
            Console.WriteLine("\n1 - Adicionar livro");
            Console.WriteLine("2 - Remover livro");
            Console.WriteLine("3 - Exibir carrinho");
            Console.WriteLine("4 - Total");
            Console.WriteLine("0 - Sair");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Livro l = new Livro();

                Console.Write("Título: ");
                l.Titulo = Console.ReadLine();

                Console.Write("Preço: ");
                l.Preco = double.Parse(Console.ReadLine());

                carrinho.AdicionarLivro(l);
            }
            else if (opcao == 2)
            {
                Console.Write("Índice do livro: ");
                int i = int.Parse(Console.ReadLine());

                carrinho.RemoverLivro(i);
            }
            else if (opcao == 3)
            {
                carrinho.ExibirCarrinho();
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Total: R$ " + carrinho.CalcularTotal());
            }

        } while (opcao != 0);
    }
}
