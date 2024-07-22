using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repos.Migrations
{
    /// <inheritdoc />
    public partial class init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalVaccinations_AnimalSchedule_ScheduleId",
                table: "AnimalVaccinations");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimalVaccinations_Dogs_DogId",
                table: "AnimalVaccinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalVaccinations",
                table: "AnimalVaccinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalSchedule",
                table: "AnimalSchedule");

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
                name: "IX_AnimalVaccinations_DogId",
                table: "Vaccinations",
                newName: "IX_Vaccinations_DogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vaccinations",
                table: "Vaccinations",
                column: "VaccinationsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccinations_Dogs_DogId",
                table: "Vaccinations",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccinations_Schedules_ScheduleId",
                table: "Vaccinations",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "ScheduleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaccinations_Dogs_DogId",
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
                name: "IX_Vaccinations_DogId",
                table: "AnimalVaccinations",
                newName: "IX_AnimalVaccinations_DogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalVaccinations",
                table: "AnimalVaccinations",
                column: "VaccinationsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalSchedule",
                table: "AnimalSchedule",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalVaccinations_AnimalSchedule_ScheduleId",
                table: "AnimalVaccinations",
                column: "ScheduleId",
                principalTable: "AnimalSchedule",
                principalColumn: "ScheduleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalVaccinations_Dogs_DogId",
                table: "AnimalVaccinations",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id");
        }
    }
}
