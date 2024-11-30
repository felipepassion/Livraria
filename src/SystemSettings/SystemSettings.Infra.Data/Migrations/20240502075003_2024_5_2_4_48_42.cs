using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Niu.Nutri.SystemSettings.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class _2024_5_2_4_48_42 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "SystemPanelSubItem",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrivate",
                table: "SystemPanelGroup",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SystemPanel",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "SystemPanelSubItem");

            migrationBuilder.DropColumn(
                name: "IsPrivate",
                table: "SystemPanelGroup");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SystemPanel");
        }
    }
}
