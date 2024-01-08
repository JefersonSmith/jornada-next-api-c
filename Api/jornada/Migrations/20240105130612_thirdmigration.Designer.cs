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
    [Migration("20240105130612_thirdmigration")]
    partial class thirdmigration
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
                            destinoURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fvisitbrasil.com%2Fwp-content%2Fuploads%2F2021%2F06%2FGettyImages-1166728645-1.jpg&tbnid=jOGQ4zszgGumWM&vet=12ahUKEwiW44Ohp8aDAxX4h5UCHV8vDAcQMygAegQIARB0..i&imgrefurl=https%3A%2F%2Fvisitbrasil.com%2Fpt%2Fdestino-sao-paulo-sp-2%2F&docid=N_2L1wutvSALpM&w=2000&h=1499&q=S%C3%A3o%20Paulo&client=firefox-b-d&ved=2ahUKEwiW44Ohp8aDAxX4h5UCHV8vDAcQMygAegQIARB0"
                        },
                        new
                        {
                            Id = 2,
                            City = "Rio de Janeiro",
                            Country = "Brasil",
                            Price = 2000m,
                            destinoURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.melhoresdestinos.com.br%2Fwp-content%2Fuploads%2F2019%2F08%2Frio-de-janeiro-capa2019-01.jpg&tbnid=SdseD1cSfr9_eM&vet=12ahUKEwiokNmRp8aDAxUGh5UCHeH7AtsQMygAegQIARB0..i&imgrefurl=https%3A%2F%2Fwww.melhoresdestinos.com.br%2Fo-que-fazer-no-rio-de-janeiro.html&docid=i9puac04oLqJMM&w=1640&h=860&q=Rio%20de%20Janeiro&client=firefox-b-d&ved=2ahUKEwiokNmRp8aDAxUGh5UCHeH7AtsQMygAegQIARB0"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}