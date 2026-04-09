using System;
using System.Security.Cryptography.X509Certificates;

public class Produto
    {
        public string nome;
        public double preco;

        public void Exibir() {

            Console.WriteLine($"Produto: {nome}, preço: {preco}");

        }

        public void Atualizar(double NovoPreco)
    {
        preco = NovoPreco;
    }

    //Construtor:
    public Produto(string NomeDoProduto)
    {
        nome = NomeDoProduto;
    }

    public Produto()
    {
        
    }
    }

class Program {
        static void Main()
    {
        Produto p1 = new Produto("Notebook");
        //p1.nome = "Notebook";
        p1.preco = 3500;
        //Console.WriteLine($"Produto: {p1.nome}, preço: {p1.preco}");
        //p1.Exibir();

        Produto p2 = new Produto("Mouse");
        //p2.nome = "Mouse";
        p2.preco = 50;
        //Console.WriteLine($"Produto: {p2.nome}, preço: {p2.preco}");
        //p2.Exibir();

        p1.Atualizar(3800);
        p1.Exibir();
        p2.Exibir();

        Produto p3 = new Produto();
        p3.nome = "garrafa térmica";
        p3.preco = 60;
        p3.Exibir();
    }
}