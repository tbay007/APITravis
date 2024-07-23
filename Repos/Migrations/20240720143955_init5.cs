using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repos.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AnimalVaccinations",
                newName: "VaccinationsId");

            migrationBuilder.RenameColumn(
                name: "AnimalVaccinationId",
                table: "AnimalSchedule",
                newName: "VaccinationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AnimalSchedule",
                newName: "ScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VaccinationsId",
                table: "AnimalVaccinations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VaccinationId",
                table: "AnimalSchedule",
                newName: "AnimalVaccinationId");

            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "AnimalSchedule",
                newName: "Id");
        }
    }
}
