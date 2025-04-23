using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNetStore.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 980m, 980m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 980m, 980m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 980m, 980m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 980m, 980m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Categorie", "Prix", "PrixAncien" },
                values: new object[] { "Ordinateurs", 980m, 980m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Categorie", "Prix", "PrixAncien" },
                values: new object[] { "Ordinateurs", 980m, 980m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Categorie", "Prix", "PrixAncien" },
                values: new object[] { "Ordinateurs", 980m, 980m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Categorie", "Prix", "PrixAncien" },
                values: new object[] { "Ordinateurs", 980m, 980m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Categorie", "Prix", "PrixAncien" },
                values: new object[] { "Ordinateurs", 980m, 980m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Categorie", "Prix", "PrixAncien" },
                values: new object[] { "Tablettes", null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Categorie", "Prix", "PrixAncien" },
                values: new object[] { "Smartphones", null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Categorie", "Prix", "PrixAncien" },
                values: new object[] { "Cameras", null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Categorie", "Prix", "PrixAncien" },
                values: new object[] { "Accessories", null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Categorie", "Prix", "PrixAncien" },
                values: new object[] { "Accessories", null, null });
        }
    }
}
