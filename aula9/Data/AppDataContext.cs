using Microsoft.EntityFrameworkCore;
using aula9.Models;
namespace aula9.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext>
        options)
        : base(options){}
        public DbSet<Produto> Produtos { get; set; }
    }
}