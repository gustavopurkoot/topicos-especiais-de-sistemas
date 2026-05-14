using System;

class Program
{

    static bool EhPar(int n)
    {
        if(n % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(EhPar(n));
    }
}