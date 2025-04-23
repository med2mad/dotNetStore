using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotNetStore.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "SousCategories");

            migrationBuilder.RenameColumn(
                name: "SousCategorie",
                table: "Produits",
                newName: "Photo4");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Produits",
                newName: "Photo3");

            migrationBuilder.AlterColumn<int>(
                name: "BadgeReduction",
                table: "Produits",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo1",
                table: "Produits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo2",
                table: "Produits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoriesProduits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categorie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SousCategorie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesProduits", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CategoriesProduits",
                columns: new[] { "Id", "Categorie", "Photo", "SousCategorie" },
                values: new object[,]
                {
                    { 1, "Ordinateurs", null, "" },
                    { 2, "Tablettes", null, "" },
                    { 3, "Smartphones", null, "" },
                    { 4, "Cameras", null, "" },
                    { 5, "Accessories", null, "" }
                });

            migrationBuilder.InsertData(
                table: "Produits",
                columns: new[] { "Id", "BadgeNew", "BadgeReduction", "Categorie", "Description", "IsDeleted", "Nom", "Nouveau", "Photo1", "Photo2", "Photo3", "Photo4", "Prix", "PrixAncien", "Top" },
                values: new object[,]
                {
                    { 1, null, null, "Ordinateurs", null, false, "Ordinateur1", null, "ordinateur1-1.png", "ordinateur1-2.png", "ordinateur1-1.png", "ordinateur1-4.png", null, null, null },
                    { 2, null, null, "Ordinateurs", null, false, "Ordinateur2", null, "ordinateur2-1.png", null, null, null, null, null, null },
                    { 3, null, null, "Ordinateurs", null, false, "Ordinateur3", null, "ordinateur3-1.png", "ordinateur3-2.png", null, null, null, null, null },
                    { 4, null, null, "Ordinateurs", null, false, "Ordinateur4", null, "ordinateur4-1.png", "ordinateur4-2.png", "ordinateur4-3.png", "ordinateur4-4.png", null, null, null },
                    { 5, null, null, "Tablettes", null, false, "Tablette1", null, "tablette1-1.png", "tablette1-2.png", null, null, null, null, null },
                    { 6, null, null, "Smartphones", null, false, "Smartphone1", null, "smartphone1-1.png", null, null, null, null, null, null },
                    { 7, null, null, "Cameras", null, false, "Camera1", null, "camera1-1.png", null, null, null, null, null, null },
                    { 8, null, null, "Accessories", null, false, "Ecouteuses1", null, "ecouteuses1-1.png", "ecouteuses1-2.png", "ecouteuses1-3.png", null, null, null, null },
                    { 9, null, null, "Accessories", null, false, "Ecouteuses2", null, "ecouteuses2-1.png", "ecouteuses2-2.png", null, null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesProduits");

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "Photo1",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "Photo2",
                table: "Produits");

            migrationBuilder.RenameColumn(
                name: "Photo4",
                table: "Produits",
                newName: "SousCategorie");

            migrationBuilder.RenameColumn(
                name: "Photo3",
                table: "Produits",
                newName: "Photo");

            migrationBuilder.AlterColumn<bool>(
                name: "BadgeReduction",
                table: "Produits",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SousCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SousCategories", x => x.Id);
                });
        }
    }
}
