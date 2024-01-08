using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jornada.Migrations
{
    /// <inheritdoc />
    public partial class sete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 1,
                column: "destino_url",
                value: "https://viagemeturismo.abril.com.br/wp-content/uploads/2017/12/istock-842960000.jpg?quality=90");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "price", "destino_url" },
                values: new object[] { 2500m, "https://emcasa.com/blog/wp-content/uploads/2022/06/Belo_Horizonte_2-768x512.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 1,
                column: "destino_url",
                value: "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg.webp");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "price", "destino_url" },
                values: new object[] { 3000m, "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg.webp" });
        }
    }
}
