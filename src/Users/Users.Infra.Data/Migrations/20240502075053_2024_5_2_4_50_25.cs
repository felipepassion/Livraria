using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Niu.Nutri.Users.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class _2024_5_2_4_50_25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ShowSideBar",
                table: "UserProfile",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowSideBar",
                table: "UserProfile");
        }
    }
}
