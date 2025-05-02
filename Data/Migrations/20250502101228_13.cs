using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNetStore.Migrations
{
    /// <inheritdoc />
    public partial class _13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Produits_ProduiId",
                table: "Commandes");

            migrationBuilder.RenameColumn(
                name: "Quantite",
                table: "Commandes",
                newName: "Qte");

            migrationBuilder.RenameColumn(
                name: "ProduiId",
                table: "Commandes",
                newName: "ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_Commandes_ProduiId",
                table: "Commandes",
                newName: "IX_Commandes_ProduitId");

            migrationBuilder.AddColumn<string>(
                name: "Nom",
                table: "Commandes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MarqueId", "Photo3" },
                values: new object[] { 2, "seed/ordinateur1-3.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MarqueId", "Prix", "PrixAncien" },
                values: new object[] { 4, 880m, 900m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 780m, 800m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 680m, 700m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MarqueId", "Prix", "PrixAncien" },
                values: new object[] { 3, 580m, 600m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MarqueId", "Photo2", "Photo3", "Photo4", "Prix", "PrixAncien" },
                values: new object[] { 1, "seed/smartphone1-2.png", "seed/smartphone1-3.png", "seed/smartphone1-4.png", 480m, 500m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 380m, 400m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 280m, 300m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 180m, 200m });

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Produits_ProduitId",
                table: "Commandes",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Produits_ProduitId",
                table: "Commandes");

            migrationBuilder.DropColumn(
                name: "Nom",
                table: "Commandes");

            migrationBuilder.RenameColumn(
                name: "Qte",
                table: "Commandes",
                newName: "Quantite");

            migrationBuilder.RenameColumn(
                name: "ProduitId",
                table: "Commandes",
                newName: "ProduiId");

            migrationBuilder.RenameIndex(
                name: "IX_Commandes_ProduitId",
                table: "Commandes",
                newName: "IX_Commandes_ProduiId");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MarqueId", "Photo3" },
                values: new object[] { 1, "seed/ordinateur1-1.png" });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MarqueId", "Prix", "PrixAncien" },
                values: new object[] { 2, 980m, 1000m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 980m, 1000m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 980m, 1000m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MarqueId", "Prix", "PrixAncien" },
                values: new object[] { 2, 980m, 1000m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MarqueId", "Photo2", "Photo3", "Photo4", "Prix", "PrixAncien" },
                values: new object[] { 3, null, null, null, 980m, 1000m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 980m, 1000m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 980m, 1000m });

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Prix", "PrixAncien" },
                values: new object[] { 980m, 1000m });

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Produits_ProduiId",
                table: "Commandes",
                column: "ProduiId",
                principalTable: "Produits",
                principalColumn: "Id");
        }
    }
}
