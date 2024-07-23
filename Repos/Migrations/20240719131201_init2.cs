using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repos.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dogs",
                table: "Dogs");

            migrationBuilder.RenameTable(
                name: "Dogs",
                newName: "AnimalSchedule");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AnimalSchedule",
                type: "TEXT",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EveryDay",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Friday",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Monday",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Monthly",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "AnimalSchedule",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Reoccurring",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Saturday",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateForSchedule",
                table: "AnimalSchedule",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Sunday",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Thursday",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tuesday",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Wednesday",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Yearly",
                table: "AnimalSchedule",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalSchedule",
                table: "AnimalSchedule",
                column: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalSchedule_AnimalSchedule_ScheduleId",
                table: "AnimalSchedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalSchedule",
                table: "AnimalSchedule");

            migrationBuilder.DropIndex(
                name: "IX_AnimalSchedule_ScheduleId",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "EveryDay",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Friday",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Monday",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Monthly",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Reoccurring",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Saturday",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "StartDateForSchedule",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Sunday",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Thursday",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Tuesday",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Wednesday",
                table: "AnimalSchedule");

            migrationBuilder.DropColumn(
                name: "Yearly",
                table: "AnimalSchedule");

            migrationBuilder.RenameTable(
                name: "AnimalSchedule",
                newName: "Dogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dogs",
                table: "Dogs",
                column: "Id");
        }
    }
}
