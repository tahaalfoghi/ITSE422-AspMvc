using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Migrations
{
    /// <inheritdoc />
    public partial class Add_Gender_Property : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_profiles",
                table: "profiles");

            migrationBuilder.RenameTable(
                name: "profiles",
                newName: "Profiles");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Profiles",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Profiles");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "profiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_profiles",
                table: "profiles",
                column: "Id");
        }
    }
}
