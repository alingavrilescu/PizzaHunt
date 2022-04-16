using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizza_Hunt.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ingredients",
                table: "desert");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ingredients",
                table: "desert",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
