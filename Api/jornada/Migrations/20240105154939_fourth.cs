using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jornada.Migrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 1,
                column: "destino_url",
                value: "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg.webp");

            migrationBuilder.InsertData(
                table: "destinos",
                columns: new[] { "id", "city", "country", "price", "destino_url" },
                values: new object[] { 3, "Belo Horizonte", "Brasil", 3000m, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fmeulugar.quintoandar.com.br%2Fwp-content%2Fuploads%2F2023%2F01%2FMorar-em-Belo-Horizonte-850x561.jpg&tbnid=SXJA5HkJseXAeM&vet=12ahUKEwj8m8O1r8aDAxVOvZUCHWnQBswQMygAegQIARB0..i&imgrefurl=https%3A%2F%2Fmeulugar.quintoandar.com.br%2Fmorar-em-belo-horizonte%2F&docid=Q2myHcKlHS0v_M&w=850&h=561&q=belo%20horizonte&client=firefox-b-d&ved=2ahUKEwj8m8O1r8aDAxVOvZUCHWnQBswQMygAegQIARB0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 1,
                column: "destino_url",
                value: "https://www.google.com/imgres?imgurl=https%3A%2F%2Fvisitbrasil.com%2Fwp-content%2Fuploads%2F2021%2F06%2FGettyImages-1166728645-1.jpg&tbnid=jOGQ4zszgGumWM&vet=12ahUKEwiW44Ohp8aDAxX4h5UCHV8vDAcQMygAegQIARB0..i&imgrefurl=https%3A%2F%2Fvisitbrasil.com%2Fpt%2Fdestino-sao-paulo-sp-2%2F&docid=N_2L1wutvSALpM&w=2000&h=1499&q=S%C3%A3o%20Paulo&client=firefox-b-d&ved=2ahUKEwiW44Ohp8aDAxX4h5UCHV8vDAcQMygAegQIARB0");
        }
    }
}
