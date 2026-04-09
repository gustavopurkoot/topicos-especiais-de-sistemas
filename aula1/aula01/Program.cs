 Console.WriteLine("Hello, World!");

int idade = 18;
double altura = 1.5;
string nome = "maria";
bool ativo = true;

Console.WriteLine(idade);
Console.WriteLine(altura);
Console.WriteLine(nome);
Console.WriteLine(ativo);

Console.WriteLine($"nome: {nome}, idade: {idade}, altura: {altura}, ativo: {ativo}"); 

Console.Write("Digite seu nome: ");
string meu_nome = Console.ReadLine();

Console.WriteLine($"Seu nome é: {meu_nome}");

Console.Write("Digite sua idade: ");
int minha_idade = int.Parse( Console.ReadLine());

Console.WriteLine($"Sua idade é: {minha_idade}");

Console.Write("Digite sua altura: ");
double minha_altura = double.Parse(Console.ReadLine());

Console.WriteLine($"Sua altura é: {minha_altura}"); 

Console.Write("Qual seu genero (Digite 1 para Masculino e 0 para Feminino): ");
int generoNumero = int.Parse(Console.ReadLine());

bool genero = generoNumero == 1;

if (genero)
{
    Console.WriteLine("Masculino");
}
else
{
    Console.WriteLine("Feminino");
}