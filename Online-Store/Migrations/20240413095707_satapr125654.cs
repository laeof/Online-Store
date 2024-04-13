using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class satapr125654 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_CategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("29164577-4820-44b4-aa7b-8ce62d64b5f3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3bc5ef03-6960-4bc7-83f4-73f41a63be4a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("aecc3096-996a-4f22-8b40-766a796f9591"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5528142-35bb-4797-9cd8-62d5c7c9cd5b"));

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("9c6f9956-5865-47ee-8a4f-efa5b3ecc6b1"), new DateTime(2024, 4, 13, 9, 57, 7, 267, DateTimeKind.Utc).AddTicks(5321), false, true, "manager", 2 },
                    { new Guid("a6e56487-c291-4058-9144-6adb29d42bd6"), new DateTime(2024, 4, 13, 9, 57, 7, 267, DateTimeKind.Utc).AddTicks(5378), false, true, "user", 4 },
                    { new Guid("ad887b9c-1969-4ccd-a43b-6d8bfe180d13"), new DateTime(2024, 4, 13, 9, 57, 7, 267, DateTimeKind.Utc).AddTicks(5294), false, true, "admin", 1 },
                    { new Guid("d82de0dc-5d08-40a1-b5b4-b3ffe906b65e"), new DateTime(2024, 4, 13, 9, 57, 7, 267, DateTimeKind.Utc).AddTicks(5363), false, true, "supporter", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryParentId",
                table: "Categories",
                column: "CategoryParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoryParentId",
                table: "Categories",
                column: "CategoryParentId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_CategoryParentId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryParentId",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9c6f9956-5865-47ee-8a4f-efa5b3ecc6b1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a6e56487-c291-4058-9144-6adb29d42bd6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ad887b9c-1969-4ccd-a43b-6d8bfe180d13"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d82de0dc-5d08-40a1-b5b4-b3ffe906b65e"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Categories",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("29164577-4820-44b4-aa7b-8ce62d64b5f3"), new DateTime(2024, 4, 12, 22, 38, 38, 600, DateTimeKind.Utc).AddTicks(7382), false, true, "admin", 1 },
                    { new Guid("3bc5ef03-6960-4bc7-83f4-73f41a63be4a"), new DateTime(2024, 4, 12, 22, 38, 38, 600, DateTimeKind.Utc).AddTicks(7415), false, true, "manager", 2 },
                    { new Guid("aecc3096-996a-4f22-8b40-766a796f9591"), new DateTime(2024, 4, 12, 22, 38, 38, 600, DateTimeKind.Utc).AddTicks(7445), false, true, "user", 4 },
                    { new Guid("e5528142-35bb-4797-9cd8-62d5c7c9cd5b"), new DateTime(2024, 4, 12, 22, 38, 38, 600, DateTimeKind.Utc).AddTicks(7431), false, true, "supporter", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
