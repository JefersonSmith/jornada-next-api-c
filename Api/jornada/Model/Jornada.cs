using System.ComponentModel.DataAnnotations.Schema;

namespace jornada.Model
{
    [Table("destinos")]
    public class Jornada
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("city")]
        public string City { get; set; } = string.Empty;

        [Column("country")]
        public string Country { get; set; } = string.Empty;

        [Column("price")]
        public decimal Price { get; set; }

        [Column("destino_url")]
        public string destinoURL { get; set; } = string.Empty;

    }
}