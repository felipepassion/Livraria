using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Niu.Nutri.Chat.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class _2024_10_26_14_31_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Conversation",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentStep",
                table: "Conversation",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "RegisterDone",
                table: "Conversation",
                type: "boolean",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "CurrentStep",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "RegisterDone",
                table: "Conversation");
        }
    }
}
