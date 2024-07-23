using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repos.Migrations.CatReposMigrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vaccinations",
                newName: "VaccinationsId");

            migrationBuilder.RenameColumn(
                name: "AnimalVaccinationId",
                table: "Schedules",
                newName: "VaccinationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Schedules",
                newName: "ScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VaccinationsId",
                table: "Vaccinations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VaccinationId",
                table: "Schedules",
                newName: "AnimalVaccinationId");

            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "Schedules",
                newName: "Id");
        }
    }
}
