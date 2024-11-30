using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Niu.Nutri.Livraria.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class _2024_11_21_16_4_49 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LivrariaAggSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    AutoSaveSettingsEnabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrariaAggSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivrariaAggSettings_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LivrariaHealthNote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Observations = table.Column<string>(type: "text", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: true),
                    CurrentStep = table.Column<int>(type: "integer", nullable: false),
                    RegisterDone = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrariaHealthNote", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivrariaMenstrualCycle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MenstrualCycleId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DurationDays = table.Column<int>(type: "integer", nullable: false),
                    Symptoms = table.Column<string>(type: "text", nullable: false),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrariaMenstrualCycle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivrariaWaterConsumption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WaterConsumptionId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LitersConsumed = table.Column<decimal>(type: "numeric", nullable: false),
                    ConsumptionGoal = table.Column<decimal>(type: "numeric", nullable: false),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrariaWaterConsumption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TacTableFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Kcal = table.Column<decimal>(type: "numeric", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: true),
                    CurrentStep = table.Column<int>(type: "integer", nullable: false),
                    RegisterDone = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacTableFood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivrariaExam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExamId = table.Column<int>(type: "integer", nullable: false),
                    HealthNoteId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Result = table.Column<string>(type: "text", nullable: false),
                    LivrariaHealthNoteId = table.Column<int>(type: "integer", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrariaExam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivrariaExam_LivrariaHealthNote_LivrariaHealthNoteId",
                        column: x => x.LivrariaHealthNoteId,
                        principalTable: "LivrariaHealthNote",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LivrariaMeal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LivrariaHealthNoteId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: true),
                    CurrentStep = table.Column<int>(type: "integer", nullable: false),
                    RegisterDone = table.Column<bool>(type: "boolean", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Time = table.Column<TimeOnly>(type: "time without time zone", nullable: true),
                    Calories = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrariaMeal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivrariaMeal_LivrariaHealthNote_LivrariaHealthNoteId",
                        column: x => x.LivrariaHealthNoteId,
                        principalTable: "LivrariaHealthNote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LivrariaSelfCare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SelfCareId = table.Column<int>(type: "integer", nullable: false),
                    HealthNoteId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    LivrariaHealthNoteId = table.Column<int>(type: "integer", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrariaSelfCare", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivrariaSelfCare_LivrariaHealthNote_LivrariaHealthNoteId",
                        column: x => x.LivrariaHealthNoteId,
                        principalTable: "LivrariaHealthNote",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LivrariaSymptom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SymptomId = table.Column<int>(type: "integer", nullable: false),
                    HealthNoteId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    LivrariaHealthNoteId = table.Column<int>(type: "integer", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrariaSymptom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivrariaSymptom_LivrariaHealthNote_LivrariaHealthNoteId",
                        column: x => x.LivrariaHealthNoteId,
                        principalTable: "LivrariaHealthNote",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LivrariaLiquid",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LivrariaHealthNoteId = table.Column<int>(type: "integer", nullable: false),
                    TacTableFoodId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: true),
                    QuantityType = table.Column<int>(type: "integer", nullable: true),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: true),
                    CurrentStep = table.Column<int>(type: "integer", nullable: false),
                    RegisterDone = table.Column<bool>(type: "boolean", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Time = table.Column<TimeOnly>(type: "time without time zone", nullable: true),
                    Calories = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrariaLiquid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivrariaLiquid_LivrariaHealthNote_LivrariaHealthNoteId",
                        column: x => x.LivrariaHealthNoteId,
                        principalTable: "LivrariaHealthNote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivrariaLiquid_TacTableFood_TacTableFoodId",
                        column: x => x.TacTableFoodId,
                        principalTable: "TacTableFood",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LivrariaMealFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LivrariaMealId = table.Column<int>(type: "integer", nullable: false),
                    TacTableFoodId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Calories = table.Column<decimal>(type: "numeric", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ExternalId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: true),
                    CurrentStep = table.Column<int>(type: "integer", nullable: false),
                    RegisterDone = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrariaMealFood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivrariaMealFood_LivrariaMeal_LivrariaMealId",
                        column: x => x.LivrariaMealId,
                        principalTable: "LivrariaMeal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivrariaMealFood_TacTableFood_TacTableFoodId",
                        column: x => x.TacTableFoodId,
                        principalTable: "TacTableFood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LivrariaAggSettings_UserId",
                table: "LivrariaAggSettings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LivrariaExam_LivrariaHealthNoteId",
                table: "LivrariaExam",
                column: "LivrariaHealthNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_LivrariaLiquid_LivrariaHealthNoteId",
                table: "LivrariaLiquid",
                column: "LivrariaHealthNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_LivrariaLiquid_TacTableFoodId",
                table: "LivrariaLiquid",
                column: "TacTableFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_LivrariaMeal_LivrariaHealthNoteId",
                table: "LivrariaMeal",
                column: "LivrariaHealthNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_LivrariaMealFood_LivrariaMealId",
                table: "LivrariaMealFood",
                column: "LivrariaMealId");

            migrationBuilder.CreateIndex(
                name: "IX_LivrariaMealFood_TacTableFoodId",
                table: "LivrariaMealFood",
                column: "TacTableFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_LivrariaSelfCare_LivrariaHealthNoteId",
                table: "LivrariaSelfCare",
                column: "LivrariaHealthNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_LivrariaSymptom_LivrariaHealthNoteId",
                table: "LivrariaSymptom",
                column: "LivrariaHealthNoteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivrariaAggSettings");

            migrationBuilder.DropTable(
                name: "LivrariaExam");

            migrationBuilder.DropTable(
                name: "LivrariaLiquid");

            migrationBuilder.DropTable(
                name: "LivrariaMealFood");

            migrationBuilder.DropTable(
                name: "LivrariaMenstrualCycle");

            migrationBuilder.DropTable(
                name: "LivrariaSelfCare");

            migrationBuilder.DropTable(
                name: "LivrariaSymptom");

            migrationBuilder.DropTable(
                name: "LivrariaWaterConsumption");

            migrationBuilder.DropTable(
                name: "LivrariaMeal");

            migrationBuilder.DropTable(
                name: "TacTableFood");

            migrationBuilder.DropTable(
                name: "LivrariaHealthNote");
        }
    }
}
