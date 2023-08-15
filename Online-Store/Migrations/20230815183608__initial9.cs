using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class _initial9 : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("125c73e0-a274-497b-9c65-53507ee07197"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6115a6ed-8224-4a86-82bf-e1f08d587a9b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d66f4ca6-8c83-4f15-b2fb-5128707ab554"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e201cb01-0833-4d7e-b4a3-cf68efcc067f"));

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Monitors");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Monitors",
                newName: "IX_Monitors_CategoryId");

            migrationBuilder.AddColumn<Guid>(
                name: "KeyboardId",
                table: "ProductImages",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MonitorId",
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
                    { new Guid("113ce889-3ac9-4eea-99ff-341de8fc481c"), new DateTime(2023, 8, 15, 18, 36, 8, 834, DateTimeKind.Utc).AddTicks(1764), false, true, "admin", 1 },
                    { new Guid("b1bd43a4-1a2b-4750-a4ab-de2600198cd9"), new DateTime(2023, 8, 15, 18, 36, 8, 834, DateTimeKind.Utc).AddTicks(1835), false, true, "user", 4 },
                    { new Guid("b4c4f3d9-6bfb-4125-95e5-38478a569658"), new DateTime(2023, 8, 15, 18, 36, 8, 834, DateTimeKind.Utc).AddTicks(1828), false, true, "supporter", 3 },
                    { new Guid("e74d6329-325f-4771-907d-b7d4beca974d"), new DateTime(2023, 8, 15, 18, 36, 8, 834, DateTimeKind.Utc).AddTicks(1811), false, true, "manager", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_KeyboardId",
                table: "ProductImages",
                column: "KeyboardId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_MonitorId",
                table: "ProductImages",
                column: "MonitorId");

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

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_MonitorId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Monitors",
                table: "Monitors");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("113ce889-3ac9-4eea-99ff-341de8fc481c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1bd43a4-1a2b-4750-a4ab-de2600198cd9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b4c4f3d9-6bfb-4125-95e5-38478a569658"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e74d6329-325f-4771-907d-b7d4beca974d"));

            migrationBuilder.DropColumn(
                name: "KeyboardId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "MonitorId",
                table: "ProductImages");

            migrationBuilder.RenameTable(
                name: "Monitors",
                newName: "Product");

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
                    { new Guid("125c73e0-a274-497b-9c65-53507ee07197"), new DateTime(2023, 8, 15, 18, 35, 46, 499, DateTimeKind.Utc).AddTicks(7733), false, true, "admin", 1 },
                    { new Guid("6115a6ed-8224-4a86-82bf-e1f08d587a9b"), new DateTime(2023, 8, 15, 18, 35, 46, 499, DateTimeKind.Utc).AddTicks(7778), false, true, "manager", 2 },
                    { new Guid("d66f4ca6-8c83-4f15-b2fb-5128707ab554"), new DateTime(2023, 8, 15, 18, 35, 46, 499, DateTimeKind.Utc).AddTicks(7799), false, true, "supporter", 3 },
                    { new Guid("e201cb01-0833-4d7e-b4a3-cf68efcc067f"), new DateTime(2023, 8, 15, 18, 35, 46, 499, DateTimeKind.Utc).AddTicks(7806), false, true, "user", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
