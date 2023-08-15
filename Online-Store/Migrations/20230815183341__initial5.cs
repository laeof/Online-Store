using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class _initial5 : Migration
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
                keyValue: new Guid("14f0aa78-9270-4656-baa3-d30485defe8d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2b6af30c-0e04-4ec9-a366-92b5f0dc3d7e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("349038d0-3816-42e1-a0ce-30a565bdecd6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3b286b19-2390-4adc-8d71-f077b7c8e759"));

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

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "ProductImages",
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
                    { new Guid("6c98687f-008d-4279-a4da-316fa5dc32cf"), new DateTime(2023, 8, 15, 18, 33, 40, 934, DateTimeKind.Utc).AddTicks(7428), false, true, "user", 4 },
                    { new Guid("b77862e6-a7a5-409f-b2cd-58b2d1f0e7e6"), new DateTime(2023, 8, 15, 18, 33, 40, 934, DateTimeKind.Utc).AddTicks(7415), false, true, "manager", 2 },
                    { new Guid("e6437fbb-3bd5-4969-a5f5-ef47fb31e015"), new DateTime(2023, 8, 15, 18, 33, 40, 934, DateTimeKind.Utc).AddTicks(7422), false, true, "supporter", 3 },
                    { new Guid("f748a07c-8828-4109-a2e2-1747221eeef5"), new DateTime(2023, 8, 15, 18, 33, 40, 934, DateTimeKind.Utc).AddTicks(7369), false, true, "admin", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Product_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Product_ProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Product_ProductId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6c98687f-008d-4279-a4da-316fa5dc32cf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b77862e6-a7a5-409f-b2cd-58b2d1f0e7e6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e6437fbb-3bd5-4969-a5f5-ef47fb31e015"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f748a07c-8828-4109-a2e2-1747221eeef5"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "CartItems");

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
                    { new Guid("14f0aa78-9270-4656-baa3-d30485defe8d"), new DateTime(2023, 8, 15, 18, 31, 48, 33, DateTimeKind.Utc).AddTicks(2267), false, true, "supporter", 3 },
                    { new Guid("2b6af30c-0e04-4ec9-a366-92b5f0dc3d7e"), new DateTime(2023, 8, 15, 18, 31, 48, 33, DateTimeKind.Utc).AddTicks(2274), false, true, "user", 4 },
                    { new Guid("349038d0-3816-42e1-a0ce-30a565bdecd6"), new DateTime(2023, 8, 15, 18, 31, 48, 33, DateTimeKind.Utc).AddTicks(2261), false, true, "manager", 2 },
                    { new Guid("3b286b19-2390-4adc-8d71-f077b7c8e759"), new DateTime(2023, 8, 15, 18, 31, 48, 33, DateTimeKind.Utc).AddTicks(2206), false, true, "admin", 1 }
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
