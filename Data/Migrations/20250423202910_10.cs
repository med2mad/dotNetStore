using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNetStore.Migrations
{
    /// <inheritdoc />
    public partial class _10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                column: "MarqueId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                column: "MarqueId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                column: "MarqueId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                column: "MarqueId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                column: "MarqueId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                column: "MarqueId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                column: "MarqueId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                column: "MarqueId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                column: "MarqueId",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                column: "MarqueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                column: "MarqueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                column: "MarqueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                column: "MarqueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                column: "MarqueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                column: "MarqueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                column: "MarqueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                column: "MarqueId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                column: "MarqueId",
                value: null);
        }
    }
}
