using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Author",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Author",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Author");
        }
    }
}
