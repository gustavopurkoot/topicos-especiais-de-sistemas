var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var produtos = new List<Produto>();

app.MapGet("/", () => "API funcionando!");

app.MapPost("/produtos", (Produto p) =>
{
    produtos.Add(p);

    return "Produto adicionado!";
});

app.MapGet("/produtos", () =>
{
    return produtos;
});

app.MapGet("/produtos/MaisCaro", () =>
{
    Produto maisCaro = produtos[0];
    foreach (var p in produtos)
    {
        if (p.Preco > maisCaro.Preco)
        {
            maisCaro = p;
        }
    }
    return maisCaro;
});

app.Run();

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}