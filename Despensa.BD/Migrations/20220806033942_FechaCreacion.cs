using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Despensa.BD.Migrations
{
    public partial class FechaCreacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CorreoElectronico",
                table: "Proveedores",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Proveedores",
                type: "Date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Proveedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroTelefono",
                table: "Proveedores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Producto_ProveedoresId",
                table: "Proveedores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClaveProducto",
                table: "Producto_Proveedores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescripcionProducto",
                table: "Producto_Proveedores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVencimientoProducto",
                table: "Producto_Proveedores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProveedores",
                table: "Producto_Proveedores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NombreProducto",
                table: "Producto_Proveedores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioProducto",
                table: "Producto_Proveedores",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_Producto_ProveedoresId",
                table: "Proveedores",
                column: "Producto_ProveedoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_Producto_Proveedores_Producto_ProveedoresId",
                table: "Proveedores",
                column: "Producto_ProveedoresId",
                principalTable: "Producto_Proveedores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_Producto_Proveedores_Producto_ProveedoresId",
                table: "Proveedores");

            migrationBuilder.DropIndex(
                name: "IX_Proveedores_Producto_ProveedoresId",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "CorreoElectronico",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "NumeroTelefono",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "Producto_ProveedoresId",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "ClaveProducto",
                table: "Producto_Proveedores");

            migrationBuilder.DropColumn(
                name: "DescripcionProducto",
                table: "Producto_Proveedores");

            migrationBuilder.DropColumn(
                name: "FechaVencimientoProducto",
                table: "Producto_Proveedores");

            migrationBuilder.DropColumn(
                name: "IdProveedores",
                table: "Producto_Proveedores");

            migrationBuilder.DropColumn(
                name: "NombreProducto",
                table: "Producto_Proveedores");

            migrationBuilder.DropColumn(
                name: "PrecioProducto",
                table: "Producto_Proveedores");
        }
    }
}
