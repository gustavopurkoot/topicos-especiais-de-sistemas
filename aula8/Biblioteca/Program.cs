var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

List<Livro> livros = new List<Livro>();

app.MapPost("/adicionar", (Livro livro) =>
{
    livros.Add(livro);
    return Results.Ok(livro);
});

app.MapGet("/listarTodos", () => Results.Ok(livros));

app.MapGet("/BuscarPorTitulo/{titulo}", (string titulo) =>
{
    foreach (Livro livro in livros)
    {
        if (livro.Titulo == titulo)
        {
            return Results.Ok(livro);
        }
    }
    return Results.NotFound("Livro não encontrado.");
});

app.MapGet("/BuscarPorDisponiveis/{disponivel}", (bool disponivel) =>
{
    List<Livro> livrosDisponiveis = new List<Livro>();

    foreach (Livro livro in livros)
    {
        if (livro.Disponivel == disponivel)
        {
            livrosDisponiveis.Add(livro);
        }
    }
    return Results.Ok(livrosDisponiveis);
});

app.MapPut("/emprestar/{titulo}", (string titulo) =>
{
    foreach (Livro livro in livros)
    {
        if (livro.Titulo.ToLower() == (titulo.ToLower()))
        {
            livro.Emprestar();
            return Results.Ok(livro);
        }
    }

    return Results.NotFound("Livro não encontrado.");
});

app.MapPut("/devolver/{titulo}", (string titulo) =>
{
    foreach (Livro livro in livros)
    {
        if (livro.Titulo.ToLower() == (titulo.ToLower()))
        {
            livro.Devolver();
            return Results.Ok(livro);
        }
    }

    return Results.NotFound("Livro não encontrado.");
});

app.Run();

public class Livro
{
    public string Titulo { get; set; }
    public int Ano { get; set; }
    public bool Disponivel { get; set; }

    public void Emprestar()
    {
        if (Disponivel == true)
        {
            Disponivel = false;
        }
    }

    public void Devolver()
    {
        if (Disponivel == false)
        {
            Disponivel = true;
        }
    }
}
