using Microsoft.EntityFrameworkCore;
using EventosApi.Models;

namespace EventosApi.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        /*public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory,
            IOptions<ConfigSettingsBase>
            IEnqueuelog enqueuelog)
        {
            this.LogConfig(loggerFactory);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {}
        }*/
        //metodo deu erro, mas veio junto ao OnConfigurin, e serve para proteger informações do usuario.
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Balada> baladas { get; set; }

        public DbSet<Evento> eventos { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Balada>().HasData
            (
            new Balada() { Id = 2, Nome = "Red", Endereco = "Avenida Nova", Bebida = true, Entrada = 30 },
            new Balada() { Id = 3, Nome = "Lux", Endereco = "Avenida Engenheiro", Bebida = true, Entrada = 20 },
            new Balada() { Id = 4, Nome = "Barcelona", Endereco = "Avenida Nova", Bebida = true, Entrada = 10 },
            new Balada() { Id = 5, Nome = "Dubai", Endereco = "Avenida Cruzeiro", Bebida = true, Entrada = 60 },
            new Balada() { Id = 6, Nome = "Slim", Endereco = "Avenida Guilherme", Bebida = true, Entrada = 25 },
            new Balada() { Id = 1, Nome = "Robinho", Endereco = "Santana", Bebida = true, Entrada = 0 }
            );
            modelBuilder.Entity<Evento>().HasData
            (
                new Evento() { Id = 2, Nome = "Batalha da Norte", Endereco = "Santana", Bebida = true, Entrada = 0, DataInicio =  "2009-01-20", DataFim = "2009-01-20"  },
                new Evento() { Id = 3, Nome = "Show no Ibirapuera", Endereco = "Centro", Bebida = true, Entrada = 0, DataInicio =  "2009-01-20", DataFim = "2009-01-20"  },
                new Evento() { Id = 4, Nome = "Batalha do Santa Cruz", Endereco = "SP-ZS", Bebida = true, Entrada = 0, DataInicio =  "2009-01-20", DataFim = "2009-01-20"  },
                new Evento() { Id = 5, Nome = "Batalha da Aldeia", Endereco = "Centro", Bebida = true, Entrada = 0, DataInicio =  "2009-01-20", DataFim = "2009-01-20"  },
                new Evento() { Id = 6, Nome = "Show do igor guilerme", Endereco = "Centro", Bebida = true, Entrada = 0, DataInicio =  "2009-01-20", DataFim = "2009-01-20"  },
                new Evento() { Id = 7, Nome = "Mundial do Palmeiras", Endereco = "Onde Judas Perdeu as Botas", Bebida = false, Entrada = 0, DataInicio =  "2100-04-01", DataFim = "2200-01-20"  }
            );
        }
    }
}