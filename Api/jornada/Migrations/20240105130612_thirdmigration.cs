using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace jornada.Migrations
{
    /// <inheritdoc />
    public partial class thirdmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "destino_url",
                table: "destinos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "destinos",
                columns: new[] { "id", "city", "country", "price", "destino_url" },
                values: new object[,]
                {
                    { 1, "São Paulo", "Brasil", 1000m, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fvisitbrasil.com%2Fwp-content%2Fuploads%2F2021%2F06%2FGettyImages-1166728645-1.jpg&tbnid=jOGQ4zszgGumWM&vet=12ahUKEwiW44Ohp8aDAxX4h5UCHV8vDAcQMygAegQIARB0..i&imgrefurl=https%3A%2F%2Fvisitbrasil.com%2Fpt%2Fdestino-sao-paulo-sp-2%2F&docid=N_2L1wutvSALpM&w=2000&h=1499&q=S%C3%A3o%20Paulo&client=firefox-b-d&ved=2ahUKEwiW44Ohp8aDAxX4h5UCHV8vDAcQMygAegQIARB0" },
                    { 2, "Rio de Janeiro", "Brasil", 2000m, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.melhoresdestinos.com.br%2Fwp-content%2Fuploads%2F2019%2F08%2Frio-de-janeiro-capa2019-01.jpg&tbnid=SdseD1cSfr9_eM&vet=12ahUKEwiokNmRp8aDAxUGh5UCHeH7AtsQMygAegQIARB0..i&imgrefurl=https%3A%2F%2Fwww.melhoresdestinos.com.br%2Fo-que-fazer-no-rio-de-janeiro.html&docid=i9puac04oLqJMM&w=1640&h=860&q=Rio%20de%20Janeiro&client=firefox-b-d&ved=2ahUKEwiokNmRp8aDAxUGh5UCHeH7AtsQMygAegQIARB0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "destino_url",
                table: "destinos");
        }
    }
}
