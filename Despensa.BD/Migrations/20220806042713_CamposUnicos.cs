using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Despensa.BD.Migrations
{
    public partial class CamposUnicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "Proveedor: 34902124",
                table: "Proveedores",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Producto: Dragon Ball Z",
                table: "Producto_Proveedores",
                column: "ClaveProducto",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Proveedor: 34902124",
                table: "Proveedores");

            migrationBuilder.DropIndex(
                name: "Producto: Dragon Ball Z",
                table: "Producto_Proveedores");
        }
    }
}
