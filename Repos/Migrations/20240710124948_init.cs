using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repos.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DogUID",
                table: "Dogs",
                newName: "UID");

            migrationBuilder.RenameColumn(
                name: "DogId",
                table: "Dogs",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UID",
                table: "Dogs",
                newName: "DogUID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Dogs",
                newName: "DogId");
        }
    }
}
