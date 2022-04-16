using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizza_Hunt.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_desert_ingredients_ingredientsId",
                table: "desert");

            migrationBuilder.DropForeignKey(
                name: "FK_pasta_ingredients_ingredientsId",
                table: "pasta");

            migrationBuilder.DropForeignKey(
                name: "FK_pizza_ingredients_ingredientsId",
                table: "pizza");

            migrationBuilder.DropTable(
                name: "ingredients");

            migrationBuilder.DropIndex(
                name: "IX_pizza_ingredientsId",
                table: "pizza");

            migrationBuilder.DropIndex(
                name: "IX_pasta_ingredientsId",
                table: "pasta");

            migrationBuilder.DropIndex(
                name: "IX_desert_ingredientsId",
                table: "desert");

            migrationBuilder.DropColumn(
                name: "idingredients",
                table: "pizza");

            migrationBuilder.DropColumn(
                name: "ingredientsId",
                table: "pizza");

            migrationBuilder.DropColumn(
                name: "idingredients",
                table: "pasta");

            migrationBuilder.DropColumn(
                name: "ingredientsId",
                table: "pasta");

            migrationBuilder.DropColumn(
                name: "idingredients",
                table: "desert");

            migrationBuilder.DropColumn(
                name: "ingredientsId",
                table: "desert");

            migrationBuilder.AddColumn<string>(
                name: "ingredients",
                table: "pizza",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ingredients",
                table: "pasta",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ingredients",
                table: "desert",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ingredients",
                table: "pizza");

            migrationBuilder.DropColumn(
                name: "ingredients",
                table: "pasta");

            migrationBuilder.DropColumn(
                name: "ingredients",
                table: "desert");

            migrationBuilder.AddColumn<int>(
                name: "idingredients",
                table: "pizza",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ingredientsId",
                table: "pizza",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idingredients",
                table: "pasta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ingredientsId",
                table: "pasta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idingredients",
                table: "desert",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ingredientsId",
                table: "desert",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ingredients",
                columns: table => new
                {
                    ingredientsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredients", x => x.ingredientsId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pizza_ingredientsId",
                table: "pizza",
                column: "ingredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_pasta_ingredientsId",
                table: "pasta",
                column: "ingredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_desert_ingredientsId",
                table: "desert",
                column: "ingredientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_desert_ingredients_ingredientsId",
                table: "desert",
                column: "ingredientsId",
                principalTable: "ingredients",
                principalColumn: "ingredientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_pasta_ingredients_ingredientsId",
                table: "pasta",
                column: "ingredientsId",
                principalTable: "ingredients",
                principalColumn: "ingredientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_pizza_ingredients_ingredientsId",
                table: "pizza",
                column: "ingredientsId",
                principalTable: "ingredients",
                principalColumn: "ingredientsId");
        }
    }
}
