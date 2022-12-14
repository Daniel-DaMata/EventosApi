﻿// <auto-generated />
using EventosApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventosApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventosApi.Models.Balada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Bebida")
                        .HasColumnType("bit");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Entrada")
                        .HasColumnType("real");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("baladas");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Bebida = true,
                            Endereco = "Avenida Nova",
                            Entrada = 30f,
                            Nome = "Red"
                        },
                        new
                        {
                            Id = 3,
                            Bebida = true,
                            Endereco = "Avenida Engenheiro",
                            Entrada = 20f,
                            Nome = "Lux"
                        },
                        new
                        {
                            Id = 4,
                            Bebida = true,
                            Endereco = "Avenida Nova",
                            Entrada = 10f,
                            Nome = "Barcelona"
                        },
                        new
                        {
                            Id = 5,
                            Bebida = true,
                            Endereco = "Avenida Cruzeiro",
                            Entrada = 60f,
                            Nome = "Dubai"
                        },
                        new
                        {
                            Id = 6,
                            Bebida = true,
                            Endereco = "Avenida Guilherme",
                            Entrada = 25f,
                            Nome = "Slim"
                        },
                        new
                        {
                            Id = 1,
                            Bebida = true,
                            Endereco = "Santana",
                            Entrada = 0f,
                            Nome = "Robinho"
                        });
                });

            modelBuilder.Entity("EventosApi.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Bebida")
                        .HasColumnType("bit");

                    b.Property<string>("DataFim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataInicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Entrada")
                        .HasColumnType("real");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("eventos");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Bebida = true,
                            DataFim = "2009-01-20",
                            DataInicio = "2009-01-20",
                            Endereco = "Santana",
                            Entrada = 0f,
                            Nome = "Batalha da Norte"
                        },
                        new
                        {
                            Id = 3,
                            Bebida = true,
                            DataFim = "2009-01-20",
                            DataInicio = "2009-01-20",
                            Endereco = "Centro",
                            Entrada = 0f,
                            Nome = "Show no Ibirapuera"
                        },
                        new
                        {
                            Id = 4,
                            Bebida = true,
                            DataFim = "2009-01-20",
                            DataInicio = "2009-01-20",
                            Endereco = "SP-ZS",
                            Entrada = 0f,
                            Nome = "Batalha do Santa Cruz"
                        },
                        new
                        {
                            Id = 5,
                            Bebida = true,
                            DataFim = "2009-01-20",
                            DataInicio = "2009-01-20",
                            Endereco = "Centro",
                            Entrada = 0f,
                            Nome = "Batalha da Aldeia"
                        },
                        new
                        {
                            Id = 6,
                            Bebida = true,
                            DataFim = "2009-01-20",
                            DataInicio = "2009-01-20",
                            Endereco = "Centro",
                            Entrada = 0f,
                            Nome = "Show do igor guilerme"
                        },
                        new
                        {
                            Id = 7,
                            Bebida = false,
                            DataFim = "2200-01-20",
                            DataInicio = "2100-04-01",
                            Endereco = "Onde Judas Perdeu as Botas",
                            Entrada = 0f,
                            Nome = "Mundial do Palmeiras"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}