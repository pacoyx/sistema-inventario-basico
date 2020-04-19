using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "VDJ", "Videos Juegos" },
                    { "PRF", "Perfumeria" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "2110dc94-4001-4299-9eb1-f74356b62d60", "av peru 123 SMP", "Bodega Central" },
                    { "55609b52-1ce1-43a9-815b-010c2da0879d", "av callao 1823 Callao Callao", "Bodega Callao" },
                    { "ec5381ff-61c0-4d8c-b7da-9f70bf53b4c2", "av Lima 1423 Lima Breña", "Bodega Lima" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "VDJ");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "2110dc94-4001-4299-9eb1-f74356b62d60");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "55609b52-1ce1-43a9-815b-010c2da0879d");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "ec5381ff-61c0-4d8c-b7da-9f70bf53b4c2");
        }
    }
}
