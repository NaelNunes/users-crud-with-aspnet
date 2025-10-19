using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoCadastroUsuarios.Migrations
{
    /// <inheritdoc />
    public partial class AddAdressAndPhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Clientes",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Clientes");
        }
    }
}
