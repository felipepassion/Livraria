using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Niu.Nutri.Users.Identity.Migrations
{
    /// <inheritdoc />
    public partial class _2024_5_19_23_19_40 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NeedResetPassword",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NeedResetPassword",
                table: "AspNetUsers");
        }
    }
}
