using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jornada.Migrations
{
    /// <inheritdoc />
    public partial class seis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 2,
                column: "destino_url",
                value: "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg.webp");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 3,
                column: "destino_url",
                value: "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/muito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro.jpeg.webp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 2,
                column: "destino_url",
                value: "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.melhoresdestinos.com.br%2Fwp-content%2Fuploads%2F2019%2F08%2Frio-de-janeiro-capa2019-01.jpg&tbnid=SdseD1cSfr9_eM&vet=12ahUKEwiokNmRp8aDAxUGh5UCHeH7AtsQMygAegQIARB0..i&imgrefurl=https%3A%2F%2Fwww.melhoresdestinos.com.br%2Fo-que-fazer-no-rio-de-janeiro.html&docid=i9puac04oLqJMM&w=1640&h=860&q=Rio%20de%20Janeiro&client=firefox-b-d&ved=2ahUKEwiokNmRp8aDAxUGh5UCHeH7AtsQMygAegQIARB0");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 3,
                column: "destino_url",
                value: "https://www.google.com/imgres?imgurl=https%3A%2F%2Fmeulugar.quintoandar.com.br%2Fwp-content%2Fuploads%2F2023%2F01%2FMorar-em-Belo-Horizonte-850x561.jpg&tbnid=SXJA5HkJseXAeM&vet=12ahUKEwj8m8O1r8aDAxVOvZUCHWnQBswQMygAegQIARB0..i&imgrefurl=https%3A%2F%2Fmeulugar.quintoandar.com.br%2Fmorar-em-belo-horizonte%2F&docid=Q2myHcKlHS0v_M&w=850&h=561&q=belo%20horizonte&client=firefox-b-d&ved=2ahUKEwj8m8O1r8aDAxVOvZUCHWnQBswQMygAegQIARB0");
        }
    }
}
