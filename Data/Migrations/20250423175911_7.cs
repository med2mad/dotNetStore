using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNetStore.Migrations
{
    /// <inheritdoc />
    public partial class _7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Top",
                table: "Produits",
                newName: "TopVente");

            migrationBuilder.RenameColumn(
                name: "ReductionMax",
                table: "Produits",
                newName: "ReductionFolle");

            migrationBuilder.AddColumn<bool>(
                name: "AfficheEnBas1",
                table: "Produits",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AfficheEnBas2",
                table: "Produits",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AfficheEnBas3",
                table: "Produits",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AfficheEnBas1", "AfficheEnBas2", "AfficheEnBas3" },
                values: new object[] { true, false, true });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AfficheEnBas1", "AfficheEnBas2", "AfficheEnBas3" },
                values: new object[] { true, true, false });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AfficheEnBas1", "AfficheEnBas2", "AfficheEnBas3" },
                values: new object[] { true, false, true });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AfficheEnBas1", "AfficheEnBas2", "AfficheEnBas3" },
                values: new object[] { false, true, true });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AfficheEnBas1", "AfficheEnBas2", "AfficheEnBas3" },
                values: new object[] { true, true, false });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AfficheEnBas1", "AfficheEnBas2", "AfficheEnBas3" },
                values: new object[] { true, true, false });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AfficheEnBas1", "AfficheEnBas2", "AfficheEnBas3" },
                values: new object[] { true, true, false });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AfficheEnBas1", "AfficheEnBas2", "AfficheEnBas3" },
                values: new object[] { true, false, true });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AfficheEnBas1", "AfficheEnBas2", "AfficheEnBas3" },
                values: new object[] { false, true, true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AfficheEnBas1",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "AfficheEnBas2",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "AfficheEnBas3",
                table: "Produits");

            migrationBuilder.RenameColumn(
                name: "TopVente",
                table: "Produits",
                newName: "Top");

            migrationBuilder.RenameColumn(
                name: "ReductionFolle",
                table: "Produits",
                newName: "ReductionMax");
        }
    }
}
