using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNetStore.Migrations
{
    /// <inheritdoc />
    public partial class _12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BadgeReduction",
                table: "Produits",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                column: "BadgeReduction",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                column: "BadgeReduction",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                column: "BadgeReduction",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                column: "BadgeReduction",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                column: "BadgeReduction",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BadgeReduction",
                table: "Produits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                column: "BadgeReduction",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                column: "BadgeReduction",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                column: "BadgeReduction",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                column: "BadgeReduction",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                column: "BadgeReduction",
                value: null);
        }
    }
}
