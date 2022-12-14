using Microsoft.EntityFrameworkCore;
using EventosApi.Models;

namespace EventosApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Balada> baladas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Balada>().HasData
            (
            new Balada() { Id = 1, Nome = "Start", Endereco = "Avenida JoaPaulo", Bebida = true, Entrada = 10 },
            new Balada() { Id = 2, Nome = "Red", Endereco = "Avenida Nova", Bebida = true, Entrada = 30 },
            new Balada() { Id = 3, Nome = "Lux", Endereco = "Avenida Engenheiro", Bebida = true, Entrada = 20 },
            new Balada() { Id = 4, Nome = "Barcelona", Endereco = "Avenida Nova", Bebida = true, Entrada = 10 },
            new Balada() { Id = 5, Nome = "Dubai", Endereco = "Avenida Cruzeiro", Bebida = true, Entrada = 60 },
            new Balada() { Id = 6, Nome = "Slim", Endereco = "Avenida Guilherme", Bebida = true, Entrada = 25 },
            new Balada() { Id = 1, Nome = "Robinho", Endereco = "Santana", Bebida = true, Entrada = 0 }
            );
        }
    }
}