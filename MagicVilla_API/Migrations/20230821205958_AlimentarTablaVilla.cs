using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa. . .", new DateTime(2023, 8, 21, 14, 59, 58, 843, DateTimeKind.Local).AddTicks(4152), new DateTime(2023, 8, 21, 14, 59, 58, 843, DateTimeKind.Local).AddTicks(4140), "", 50.0, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la villa. . .", new DateTime(2023, 8, 21, 14, 59, 58, 843, DateTimeKind.Local).AddTicks(4155), new DateTime(2023, 8, 21, 14, 59, 58, 843, DateTimeKind.Local).AddTicks(4155), "", 60.0, "Villa Mora", 10, 300.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
