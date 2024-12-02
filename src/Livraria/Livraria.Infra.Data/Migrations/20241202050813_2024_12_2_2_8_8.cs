using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Niu.Nutri.Livraria.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class _2024_12_2_2_8_8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Livro_Autor_Livro_Codl",
                table: "Livro_Autor");

            migrationBuilder.DropIndex(
                name: "IX_Livro_Assunto_Livro_Codl",
                table: "Livro_Assunto");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Autor_Livro_Codl",
                table: "Livro_Autor",
                column: "Livro_Codl");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Assunto_Livro_Codl",
                table: "Livro_Assunto",
                column: "Livro_Codl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Livro_Autor_Livro_Codl",
                table: "Livro_Autor");

            migrationBuilder.DropIndex(
                name: "IX_Livro_Assunto_Livro_Codl",
                table: "Livro_Assunto");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Autor_Livro_Codl",
                table: "Livro_Autor",
                column: "Livro_Codl",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Assunto_Livro_Codl",
                table: "Livro_Assunto",
                column: "Livro_Codl",
                unique: true);
        }
    }
}
