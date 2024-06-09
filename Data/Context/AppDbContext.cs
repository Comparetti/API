using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProdutorModel> Produtores { get; set; }
        public DbSet<ConsumidorModel> Consumidores { get; set; }
    }
}
