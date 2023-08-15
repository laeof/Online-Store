using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class _initial10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Monitors_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Reviews",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "OrderItems",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "CartItems",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("47f59bf1-cb4d-4568-99f3-97c0c874b8f4"), new DateTime(2023, 8, 15, 18, 46, 16, 378, DateTimeKind.Utc).AddTicks(3355), false, true, "supporter", 3 },
                    { new Guid("4a78816a-cc1c-475b-bd04-965621172ec5"), new DateTime(2023, 8, 15, 18, 46, 16, 378, DateTimeKind.Utc).AddTicks(3302), false, true, "admin", 1 },
                    { new Guid("988c9e19-d168-4b32-a17a-d7f20ffeaf79"), new DateTime(2023, 8, 15, 18, 46, 16, 378, DateTimeKind.Utc).AddTicks(3347), false, true, "manager", 2 },
                    { new Guid("fce51554-69dc-4a61-8e98-82ec8094b0eb"), new DateTime(2023, 8, 15, 18, 46, 16, 378, DateTimeKind.Utc).AddTicks(3362), false, true, "user", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("47f59bf1-cb4d-4568-99f3-97c0c874b8f4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4a78816a-cc1c-475b-bd04-965621172ec5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("988c9e19-d168-4b32-a17a-d7f20ffeaf79"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fce51554-69dc-4a61-8e98-82ec8094b0eb"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Monitors");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
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
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Additional = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<int>(type: "integer", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Guarantee = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false),
                    Kit = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    SalePrice = table.Column<decimal>(type: "numeric", nullable: true),
                    Size = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<string>(type: "text", nullable: true)
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
    }
}
