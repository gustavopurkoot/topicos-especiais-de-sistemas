var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var contatos = new List<Contato>();

app.MapGet("/", () => "API funcionando!");

app.MapPost("/adicionar", (Contato contato) =>
{
    contatos.Add(contato);
    return Results.Ok(contato);
});

app.MapGet("/listarTodos", () =>
{
    return contatos;
});

app.MapGet("/BuscarPorNome/{nome}", (string nome) =>
{
    foreach (Contato contato in contatos)
    {
        if (contato.Nome == nome)
        {
            return Results.Ok(contato);
        }
    }
    return Results.NotFound();
});

app.Run();

public class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
}
