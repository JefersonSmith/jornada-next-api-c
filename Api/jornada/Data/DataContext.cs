using jornada.Model;
using Microsoft.EntityFrameworkCore;

namespace jornada.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Jornada> Jornadas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Jornada>().HasData(
                new Jornada { 
                    Id = 1, 
                    City = "São Paulo", 
                    Country = "Brasil", 
                    Price = 1000, 
                    destinoURL = "https://viagemeturismo.abril.com.br/wp-content/uploads/2017/12/istock-842960000.jpg?quality=90" },
                new Jornada { 
                    Id = 2, 
                    City = "Rio de Janeiro", 
                    Country = "Brasil", 
                    Price = 2000, 
                    destinoURL = "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg.webp" },
                new Jornada {
                    Id = 3, 
                    City = "Belo Horizonte", 
                    Country = "Brasil", 
                    Price = 2500, 
                    destinoURL = "https://emcasa.com/blog/wp-content/uploads/2022/06/Belo_Horizonte_2-768x512.jpg"}
                    
            );
        }

    }
}


