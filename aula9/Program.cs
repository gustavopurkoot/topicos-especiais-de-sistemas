using aula9.Data;
using aula9.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDataContext>(options =>
options.UseSqlite("Data Source=produtos.db"));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/produtos", (AppDataContext context) =>
{
    return context.Produtos.ToList();
});

app.MapPost("/produtos", (Produto produto, AppDataContext
context) =>
{
    context.Produtos.Add(produto);
    context.SaveChanges();
    return Results.Created($"/produtos/{produto.Id}",
    produto);
});

app.MapGet("/produtos/{id}", (int id, AppDataContext context) =>
{
    Produto produto = context.Produtos.Find(id);
    if (produto == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(produto);
});


app.MapDelete("/produtos/{id}", (int id, AppDataContext
context) =>
{
    Produto produto = context.Produtos.Find(id);
    if (produto == null)
    {
        return Results.NotFound();
    }
    context.Produtos.Remove(produto);
    context.SaveChanges();
    return Results.Ok();
});


app.Run();
