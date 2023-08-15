using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class _initial7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Product_ProductId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("013f13f7-c0f0-455e-aa61-63d22ae4546e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("935374c3-4b6c-4eb2-9b83-4a371be922e4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a108bf07-bda6-4cc1-bb9d-f78778182356"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d0e2db51-a80e-4ed1-8309-429760a4e17e"));

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Monitors");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductImages",
                newName: "MonitorId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_MonitorId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Monitors",
                newName: "IX_Monitors_CategoryId");

            migrationBuilder.AddColumn<Guid>(
                name: "KeyboardId",
                table: "ProductImages",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monitors",
                table: "Monitors",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Keyboards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    SalePrice = table.Column<decimal>(type: "numeric", nullable: true),
                    Amount = table.Column<int>(type: "integer", nullable: true),
                    Size = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<string>(type: "text", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    Guarantee = table.Column<string>(type: "text", nullable: true),
                    Additional = table.Column<string>(type: "text", nullable: true),
                    Kit = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Keyboards_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("49e5e504-5ffa-4a74-872d-fdfb0b9a9102"), new DateTime(2023, 8, 15, 18, 35, 17, 887, DateTimeKind.Utc).AddTicks(1987), false, true, "user", 4 },
                    { new Guid("4dbc5236-076d-4a2a-85da-cfadb7cb6fab"), new DateTime(2023, 8, 15, 18, 35, 17, 887, DateTimeKind.Utc).AddTicks(1904), false, true, "admin", 1 },
                    { new Guid("58f7fcac-ca4f-4fa5-aeaa-6462b1064412"), new DateTime(2023, 8, 15, 18, 35, 17, 887, DateTimeKind.Utc).AddTicks(1981), false, true, "supporter", 3 },
                    { new Guid("bf60dc57-a15d-4f0d-8da8-e2adba6339b7"), new DateTime(2023, 8, 15, 18, 35, 17, 887, DateTimeKind.Utc).AddTicks(1974), false, true, "manager", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_KeyboardId",
                table: "ProductImages",
                column: "KeyboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Keyboards_CategoryId",
                table: "Keyboards",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_Categories_CategoryId",
                table: "Monitors",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Keyboards_KeyboardId",
                table: "ProductImages",
                column: "KeyboardId",
                principalTable: "Keyboards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Monitors_MonitorId",
                table: "ProductImages",
                column: "MonitorId",
                principalTable: "Monitors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_Categories_CategoryId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Keyboards_KeyboardId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Monitors_MonitorId",
                table: "ProductImages");

            migrationBuilder.DropTable(
                name: "Keyboards");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_KeyboardId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Monitors",
                table: "Monitors");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("49e5e504-5ffa-4a74-872d-fdfb0b9a9102"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4dbc5236-076d-4a2a-85da-cfadb7cb6fab"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("58f7fcac-ca4f-4fa5-aeaa-6462b1064412"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bf60dc57-a15d-4f0d-8da8-e2adba6339b7"));

            migrationBuilder.DropColumn(
                name: "KeyboardId",
                table: "ProductImages");

            migrationBuilder.RenameTable(
                name: "Monitors",
                newName: "Product");

            migrationBuilder.RenameColumn(
                name: "MonitorId",
                table: "ProductImages",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_MonitorId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Monitors_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Product",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("013f13f7-c0f0-455e-aa61-63d22ae4546e"), new DateTime(2023, 8, 15, 18, 34, 39, 237, DateTimeKind.Utc).AddTicks(6010), false, true, "supporter", 3 },
                    { new Guid("935374c3-4b6c-4eb2-9b83-4a371be922e4"), new DateTime(2023, 8, 15, 18, 34, 39, 237, DateTimeKind.Utc).AddTicks(5947), false, true, "admin", 1 },
                    { new Guid("a108bf07-bda6-4cc1-bb9d-f78778182356"), new DateTime(2023, 8, 15, 18, 34, 39, 237, DateTimeKind.Utc).AddTicks(6017), false, true, "user", 4 },
                    { new Guid("d0e2db51-a80e-4ed1-8309-429760a4e17e"), new DateTime(2023, 8, 15, 18, 34, 39, 237, DateTimeKind.Utc).AddTicks(5994), false, true, "manager", 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Product_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");
        }
    }
}
