using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class friapr1413 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8b93082f-a9f4-44d5-a8a2-2dcee9991e5c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a551d3f2-2501-4034-a802-b8616c913aa5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c0571c32-79d7-4a3c-b307-997a4b05f598"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e269499c-0739-4465-a581-6744a5c7733e"));

            migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacteristicsProduct",
                columns: table => new
                {
                    CharacteristicsId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacteristicsProduct", x => new { x.CharacteristicsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CharacteristicsProduct_Characteristics_CharacteristicsId",
                        column: x => x.CharacteristicsId,
                        principalTable: "Characteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacteristicsProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("32aa933b-7b6f-4104-af31-971441543cc4"), new DateTime(2024, 4, 12, 11, 13, 53, 821, DateTimeKind.Utc).AddTicks(5763), false, true, "user", 4 },
                    { new Guid("6c3b710d-15e6-4333-9d97-f4b4a7b593d2"), new DateTime(2024, 4, 12, 11, 13, 53, 821, DateTimeKind.Utc).AddTicks(5705), false, true, "admin", 1 },
                    { new Guid("8efca720-884f-4633-9f6d-6c132c037027"), new DateTime(2024, 4, 12, 11, 13, 53, 821, DateTimeKind.Utc).AddTicks(5733), false, true, "manager", 2 },
                    { new Guid("d44e97de-506c-428f-8eea-f339e82e028a"), new DateTime(2024, 4, 12, 11, 13, 53, 821, DateTimeKind.Utc).AddTicks(5748), false, true, "supporter", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacteristicsProduct_ProductsId",
                table: "CharacteristicsProduct",
                column: "ProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacteristicsProduct");

            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("32aa933b-7b6f-4104-af31-971441543cc4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6c3b710d-15e6-4333-9d97-f4b4a7b593d2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8efca720-884f-4633-9f6d-6c132c037027"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d44e97de-506c-428f-8eea-f339e82e028a"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("8b93082f-a9f4-44d5-a8a2-2dcee9991e5c"), new DateTime(2024, 4, 12, 11, 0, 6, 919, DateTimeKind.Utc).AddTicks(9615), false, true, "supporter", 3 },
                    { new Guid("a551d3f2-2501-4034-a802-b8616c913aa5"), new DateTime(2024, 4, 12, 11, 0, 6, 919, DateTimeKind.Utc).AddTicks(9600), false, true, "manager", 2 },
                    { new Guid("c0571c32-79d7-4a3c-b307-997a4b05f598"), new DateTime(2024, 4, 12, 11, 0, 6, 919, DateTimeKind.Utc).AddTicks(9630), false, true, "user", 4 },
                    { new Guid("e269499c-0739-4465-a581-6744a5c7733e"), new DateTime(2024, 4, 12, 11, 0, 6, 919, DateTimeKind.Utc).AddTicks(9571), false, true, "admin", 1 }
                });
        }
    }
}
