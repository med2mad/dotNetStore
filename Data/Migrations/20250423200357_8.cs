using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNetStore.Migrations
{
    /// <inheritdoc />
    public partial class _8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AfficheEnBas3",
                table: "Produits",
                newName: "Autre3");

            migrationBuilder.RenameColumn(
                name: "AfficheEnBas2",
                table: "Produits",
                newName: "Autre2");

            migrationBuilder.RenameColumn(
                name: "AfficheEnBas1",
                table: "Produits",
                newName: "Autre1");

            migrationBuilder.AddColumn<string>(
                name: "Marque",
                table: "Produits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Marque", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, "seed/ordinateur1-1.png", "seed/ordinateur1-2.png", "seed/ordinateur1-1.png", "seed/ordinateur1-4.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Marque", "Photo1" },
                values: new object[] { null, "seed/ordinateur2-1.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Marque", "Photo1", "Photo2" },
                values: new object[] { null, "seed/ordinateur3-1.png", "seed/ordinateur3-2.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Marque", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, "seed/ordinateur4-1.png", "seed/ordinateur4-2.png", "seed/ordinateur4-3.png", "seed/ordinateur4-4.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Autre1", "Autre3", "Marque", "Photo1", "Photo2" },
                values: new object[] { false, true, null, "seed/tablette1-1.png", "seed/tablette1-2.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Marque", "Photo1" },
                values: new object[] { null, "seed/smartphone1-1.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Marque", "Photo1" },
                values: new object[] { null, "seed/camera1-1.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Marque", "Photo1", "Photo2", "Photo3" },
                values: new object[] { null, "seed/ecouteuses1-1.png", "seed/ecouteuses1-2.png", "seed/ecouteuses1-3.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Marque", "Photo1", "Photo2" },
                values: new object[] { null, "seed/ecouteuses2-1.png", "seed/ecouteuses2-2.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marque",
                table: "Produits");

            migrationBuilder.RenameColumn(
                name: "Autre3",
                table: "Produits",
                newName: "AfficheEnBas3");

            migrationBuilder.RenameColumn(
                name: "Autre2",
                table: "Produits",
                newName: "AfficheEnBas2");

            migrationBuilder.RenameColumn(
                name: "Autre1",
                table: "Produits",
                newName: "AfficheEnBas1");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "ordinateur1-1.png", "ordinateur1-2.png", "ordinateur1-1.png", "ordinateur1-4.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo1",
                value: "ordinateur2-1.png");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Photo1", "Photo2" },
                values: new object[] { "ordinateur3-1.png", "ordinateur3-2.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "ordinateur4-1.png", "ordinateur4-2.png", "ordinateur4-3.png", "ordinateur4-4.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AfficheEnBas1", "AfficheEnBas3", "Photo1", "Photo2" },
                values: new object[] { true, false, "tablette1-1.png", "tablette1-2.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Photo1",
                value: "smartphone1-1.png");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Photo1",
                value: "camera1-1.png");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Photo1", "Photo2", "Photo3" },
                values: new object[] { "ecouteuses1-1.png", "ecouteuses1-2.png", "ecouteuses1-3.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Photo1", "Photo2" },
                values: new object[] { "ecouteuses2-1.png", "ecouteuses2-2.png" });
        }
    }
}
