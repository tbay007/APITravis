using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repos.Migrations.CatReposMigrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalSchedule_AnimalSchedule_ScheduleId",
                table: "AnimalSchedule");

            migrationBuilder.DropIndex(
                name: "IX_AnimalSchedule_ScheduleId",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "UID",
                table: "AnimalSchedule");

            migrationBuilder.RenameColumn(
                name: "AnimalId",
                table: "AnimalSchedule",
                newName: "AnimalVaccinationId");

            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    UID = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnimalVaccinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimalId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: true),
                    ScheduleId = table.Column<int>(type: "INTEGER", nullable: false),
                    CatId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalVaccinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalVaccinations_AnimalSchedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "AnimalSchedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalVaccinations_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalVaccinations_CatId",
                table: "AnimalVaccinations",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalVaccinations_ScheduleId",
                table: "AnimalVaccinations",
                column: "ScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalVaccinations");

            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.RenameColumn(
                name: "AnimalVaccinationId",
                table: "AnimalSchedule",
                newName: "AnimalId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AnimalSchedule",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AnimalSchedule",
                type: "TEXT",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AnimalSchedule",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "AnimalSchedule",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "AnimalSchedule",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UID",
                table: "AnimalSchedule",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AnimalSchedule_ScheduleId",
                table: "AnimalSchedule",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalSchedule_AnimalSchedule_ScheduleId",
                table: "AnimalSchedule",
                column: "ScheduleId",
                principalTable: "AnimalSchedule",
                principalColumn: "Id");
        }
    }
}
