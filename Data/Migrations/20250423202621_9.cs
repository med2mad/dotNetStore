using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotNetStore.Migrations
{
    /// <inheritdoc />
    public partial class _9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marque",
                table: "Produits");

            migrationBuilder.AddColumn<int>(
                name: "MarqueId",
                table: "Produits",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Marques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marques", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Nom" },
                values: new object[,]
                {
                    { 1, "SAMSUNG" },
                    { 2, "LG" },
                    { 3, "SONY" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Produits_MarqueId",
                table: "Produits",
                column: "MarqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Marques_MarqueId",
                table: "Produits",
                column: "MarqueId",
                principalTable: "Marques",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Marques_MarqueId",
                table: "Produits");

            migrationBuilder.DropTable(
                name: "Marques");

            migrationBuilder.DropIndex(
                name: "IX_Produits_MarqueId",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "MarqueId",
                table: "Produits");

            migrationBuilder.AddColumn<string>(
                name: "Marque",
                table: "Produits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Marque",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Marque",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Marque",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Marque",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Marque",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Marque",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Marque",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Marque",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Marque",
                value: null);
        }
    }
}
