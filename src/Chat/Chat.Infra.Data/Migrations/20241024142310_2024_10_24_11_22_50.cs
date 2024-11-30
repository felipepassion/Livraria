using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Niu.Nutri.Chat.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class _2024_10_24_11_22_50 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Message",
                table: "ConversationMessage",
                newName: "Text");

            migrationBuilder.AddColumn<int>(
                name: "FromId",
                table: "ConversationMessage",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ConversationMessage",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ConversationMessage_FromId",
                table: "ConversationMessage",
                column: "FromId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConversationMessage_User_FromId",
                table: "ConversationMessage",
                column: "FromId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConversationMessage_User_FromId",
                table: "ConversationMessage");

            migrationBuilder.DropIndex(
                name: "IX_ConversationMessage_FromId",
                table: "ConversationMessage");

            migrationBuilder.DropColumn(
                name: "FromId",
                table: "ConversationMessage");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ConversationMessage");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "ConversationMessage",
                newName: "Message");
        }
    }
}
