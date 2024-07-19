using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repos.Migrations.CatReposMigrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalVaccinations_AnimalSchedule_ScheduleId",
                table: "AnimalVaccinations");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimalVaccinations_Cats_CatId",
                table: "AnimalVaccinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalVaccinations",
                table: "AnimalVaccinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalSchedule",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "UID",
                table: "Cats");

            migrationBuilder.RenameTable(
                name: "AnimalVaccinations",
                newName: "Vaccinations");

            migrationBuilder.RenameTable(
                name: "AnimalSchedule",
                newName: "Schedules");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalVaccinations_ScheduleId",
                table: "Vaccinations",
                newName: "IX_Vaccinations_ScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalVaccinations_CatId",
                table: "Vaccinations",
                newName: "IX_Vaccinations_CatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vaccinations",
                table: "Vaccinations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccinations_Cats_CatId",
                table: "Vaccinations",
                column: "CatId",
                principalTable: "Cats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccinations_Schedules_ScheduleId",
                table: "Vaccinations",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaccinations_Cats_CatId",
                table: "Vaccinations");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaccinations_Schedules_ScheduleId",
                table: "Vaccinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vaccinations",
                table: "Vaccinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules");

            migrationBuilder.RenameTable(
                name: "Vaccinations",
                newName: "AnimalVaccinations");

            migrationBuilder.RenameTable(
                name: "Schedules",
                newName: "AnimalSchedule");

            migrationBuilder.RenameIndex(
                name: "IX_Vaccinations_ScheduleId",
                table: "AnimalVaccinations",
                newName: "IX_AnimalVaccinations_ScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_Vaccinations_CatId",
                table: "AnimalVaccinations",
                newName: "IX_AnimalVaccinations_CatId");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Cats",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UID",
                table: "Cats",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalVaccinations",
                table: "AnimalVaccinations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalSchedule",
                table: "AnimalSchedule",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalVaccinations_AnimalSchedule_ScheduleId",
                table: "AnimalVaccinations",
                column: "ScheduleId",
                principalTable: "AnimalSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalVaccinations_Cats_CatId",
                table: "AnimalVaccinations",
                column: "CatId",
                principalTable: "Cats",
                principalColumn: "Id");
        }
    }
}
