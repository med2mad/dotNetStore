using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNetStore.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Top",
                table: "Produits",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Nouveau",
                table: "Produits",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "BadgeNew",
                table: "Produits",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BadgeNew", "BadgeReduction", "Nouveau", "Top" },
                values: new object[] { true, 30, false, false });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BadgeNew", "BadgeReduction", "Nouveau", "Top" },
                values: new object[] { false, 30, false, false });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BadgeNew", "BadgeReduction", "Nouveau", "Top" },
                values: new object[] { false, 30, false, false });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BadgeNew", "BadgeReduction", "Nouveau", "Top" },
                values: new object[] { true, 30, false, false });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BadgeNew", "Categorie", "Nouveau", "Top" },
                values: new object[] { false, "Tablettes", false, false });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BadgeNew", "Categorie", "Nouveau", "Top" },
                values: new object[] { true, "Smartphones", false, false });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BadgeNew", "Categorie", "Nouveau", "Top" },
                values: new object[] { false, "Cameras", false, false });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BadgeNew", "Categorie", "Nouveau", "Top" },
                values: new object[] { true, "Accessories", false, false });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BadgeNew", "Categorie", "Nouveau", "Top" },
                values: new object[] { false, "Accessories", false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Top",
                table: "Produits",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Nouveau",
                table: "Produits",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "BadgeNew",
                table: "Produits",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BadgeNew", "BadgeReduction", "Nouveau", "Top" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BadgeNew", "BadgeReduction", "Nouveau", "Top" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BadgeNew", "BadgeReduction", "Nouveau", "Top" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BadgeNew", "BadgeReduction", "Nouveau", "Top" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BadgeNew", "Categorie", "Nouveau", "Top" },
                values: new object[] { null, "Ordinateurs", null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BadgeNew", "Categorie", "Nouveau", "Top" },
                values: new object[] { null, "Ordinateurs", null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BadgeNew", "Categorie", "Nouveau", "Top" },
                values: new object[] { null, "Ordinateurs", null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BadgeNew", "Categorie", "Nouveau", "Top" },
                values: new object[] { null, "Ordinateurs", null, null });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BadgeNew", "Categorie", "Nouveau", "Top" },
                values: new object[] { null, "Ordinateurs", null, null });
        }
    }
}
