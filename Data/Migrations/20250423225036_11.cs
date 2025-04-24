using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNetStore.Migrations
{
    /// <inheritdoc />
    public partial class _11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categorie",
                table: "Produits");

            migrationBuilder.AddColumn<int>(
                name: "CategorieId",
                table: "Produits",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategorieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategorieId", "MarqueId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategorieId", "MarqueId" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategorieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategorieId", "MarqueId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategorieId", "MarqueId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                column: "CategorieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategorieId", "MarqueId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategorieId", "MarqueId" },
                values: new object[] { 5, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Produits_CategorieId",
                table: "Produits",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_CategoriesProduits_CategorieId",
                table: "Produits",
                column: "CategorieId",
                principalTable: "CategoriesProduits",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_CategoriesProduits_CategorieId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_CategorieId",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "CategorieId",
                table: "Produits");

            migrationBuilder.AddColumn<string>(
                name: "Categorie",
                table: "Produits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Categorie",
                value: "Ordinateurs");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Categorie", "MarqueId" },
                values: new object[] { "Ordinateurs", 1 });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Categorie", "MarqueId" },
                values: new object[] { "Ordinateurs", 1 });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Categorie",
                value: "Ordinateurs");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Categorie", "MarqueId" },
                values: new object[] { "Tablettes", 1 });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Categorie", "MarqueId" },
                values: new object[] { "Smartphones", 1 });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Categorie",
                value: "Cameras");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Categorie", "MarqueId" },
                values: new object[] { "Accessories", 1 });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Categorie", "MarqueId" },
                values: new object[] { "Accessories", 1 });
        }
    }
}
