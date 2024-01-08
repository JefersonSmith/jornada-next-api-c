﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using jornada.Data;

#nullable disable

namespace jornada.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240105160040_seis")]
    partial class seis
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("jornada.Model.Jornada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("country");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.Property<string>("destinoURL")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("destino_url");

                    b.HasKey("Id");

                    b.ToTable("destinos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "São Paulo",
                            Country = "Brasil",
                            Price = 1000m,
                            destinoURL = "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg.webp"
                        },
                        new
                        {
                            Id = 2,
                            City = "Rio de Janeiro",
                            Country = "Brasil",
                            Price = 2000m,
                            destinoURL = "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg.webp"
                        },
                        new
                        {
                            Id = 3,
                            City = "Belo Horizonte",
                            Country = "Brasil",
                            Price = 3000m,
                            destinoURL = "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg.webp"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
