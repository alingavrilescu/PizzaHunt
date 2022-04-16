using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizza_Hunt.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "refreshments",
                columns: table => new
                {
                    refreshmentsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kcal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img_url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refreshments", x => x.refreshmentsId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    usersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.usersID);
                });

            migrationBuilder.CreateTable(
                name: "desert",
                columns: table => new
                {
                    desertId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kcal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idingredients = table.Column<int>(type: "int", nullable: false),
                    ingredientsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_desert", x => x.desertId);
                    table.ForeignKey(
                        name: "FK_desert_ingredients_ingredientsId",
                        column: x => x.ingredientsId,
                        principalTable: "ingredients",
                        principalColumn: "ingredientsId");
                });

            migrationBuilder.CreateTable(
                name: "pasta",
                columns: table => new
                {
                    pastaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kcal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idingredients = table.Column<int>(type: "int", nullable: false),
                    ingredientsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pasta", x => x.pastaId);
                    table.ForeignKey(
                        name: "FK_pasta_ingredients_ingredientsId",
                        column: x => x.ingredientsId,
                        principalTable: "ingredients",
                        principalColumn: "ingredientsId");
                });

            migrationBuilder.CreateTable(
                name: "pizza",
                columns: table => new
                {
                    pizzaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kcal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idingredients = table.Column<int>(type: "int", nullable: false),
                    ingredientsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizza", x => x.pizzaId);
                    table.ForeignKey(
                        name: "FK_pizza_ingredients_ingredientsId",
                        column: x => x.ingredientsId,
                        principalTable: "ingredients",
                        principalColumn: "ingredientsId");
                });

            migrationBuilder.CreateTable(
                name: "FavoriteRefreshment",
                columns: table => new
                {
                    usersID = table.Column<int>(type: "int", nullable: false),
                    refreshmentsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteRefreshment", x => new { x.refreshmentsID, x.usersID });
                    table.ForeignKey(
                        name: "FK_FavoriteRefreshment_refreshments_refreshmentsID",
                        column: x => x.refreshmentsID,
                        principalTable: "refreshments",
                        principalColumn: "refreshmentsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteRefreshment_users_usersID",
                        column: x => x.usersID,
                        principalTable: "users",
                        principalColumn: "usersID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteDesert",
                columns: table => new
                {
                    usersID = table.Column<int>(type: "int", nullable: false),
                    desertID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteDesert", x => new { x.desertID, x.usersID });
                    table.ForeignKey(
                        name: "FK_FavoriteDesert_desert_desertID",
                        column: x => x.desertID,
                        principalTable: "desert",
                        principalColumn: "desertId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteDesert_users_usersID",
                        column: x => x.usersID,
                        principalTable: "users",
                        principalColumn: "usersID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoritePasta",
                columns: table => new
                {
                    usersID = table.Column<int>(type: "int", nullable: false),
                    pastaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoritePasta", x => new { x.pastaID, x.usersID });
                    table.ForeignKey(
                        name: "FK_FavoritePasta_pasta_pastaID",
                        column: x => x.pastaID,
                        principalTable: "pasta",
                        principalColumn: "pastaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoritePasta_users_usersID",
                        column: x => x.usersID,
                        principalTable: "users",
                        principalColumn: "usersID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoritePizza",
                columns: table => new
                {
                    usersID = table.Column<int>(type: "int", nullable: false),
                    pizzaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoritePizza", x => new { x.pizzaID, x.usersID });
                    table.ForeignKey(
                        name: "FK_FavoritePizza_pizza_pizzaID",
                        column: x => x.pizzaID,
                        principalTable: "pizza",
                        principalColumn: "pizzaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoritePizza_users_usersID",
                        column: x => x.usersID,
                        principalTable: "users",
                        principalColumn: "usersID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_desert_ingredientsId",
                table: "desert",
                column: "ingredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteDesert_usersID",
                table: "FavoriteDesert",
                column: "usersID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoritePasta_usersID",
                table: "FavoritePasta",
                column: "usersID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoritePizza_usersID",
                table: "FavoritePizza",
                column: "usersID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteRefreshment_usersID",
                table: "FavoriteRefreshment",
                column: "usersID");

            migrationBuilder.CreateIndex(
                name: "IX_pasta_ingredientsId",
                table: "pasta",
                column: "ingredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_pizza_ingredientsId",
                table: "pizza",
                column: "ingredientsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteDesert");

            migrationBuilder.DropTable(
                name: "FavoritePasta");

            migrationBuilder.DropTable(
                name: "FavoritePizza");

            migrationBuilder.DropTable(
                name: "FavoriteRefreshment");

            migrationBuilder.DropTable(
                name: "desert");

            migrationBuilder.DropTable(
                name: "pasta");

            migrationBuilder.DropTable(
                name: "pizza");

            migrationBuilder.DropTable(
                name: "refreshments");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "ingredients");
        }
    }
}
