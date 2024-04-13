using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class friapr1333 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8a02a434-8afa-4173-847c-e5d66b9ad000"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d0a9dd8-1fb5-4970-bb24-263e8afa23af"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b9e500a9-c69c-42bc-9e8f-b32d3ec6751e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c14aef69-35ec-4f9e-a20e-61ea841c8c34"));

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
                    { new Guid("5834f2d9-ffaf-4a5b-9234-73f72f550368"), new DateTime(2024, 4, 12, 10, 34, 2, 694, DateTimeKind.Utc).AddTicks(7068), false, true, "user", 4 },
                    { new Guid("5c8cf688-5ebd-4b0d-9da5-c9bbb4a80a83"), new DateTime(2024, 4, 12, 10, 34, 2, 694, DateTimeKind.Utc).AddTicks(7053), false, true, "supporter", 3 },
                    { new Guid("993d1ca4-1ac3-4540-9374-b4153046a8b3"), new DateTime(2024, 4, 12, 10, 34, 2, 694, DateTimeKind.Utc).AddTicks(7038), false, true, "manager", 2 },
                    { new Guid("beb286da-677f-48b6-9641-610d2bcdbbe9"), new DateTime(2024, 4, 12, 10, 34, 2, 694, DateTimeKind.Utc).AddTicks(7011), false, true, "admin", 1 }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("5834f2d9-ffaf-4a5b-9234-73f72f550368"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5c8cf688-5ebd-4b0d-9da5-c9bbb4a80a83"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("993d1ca4-1ac3-4540-9374-b4153046a8b3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("beb286da-677f-48b6-9641-610d2bcdbbe9"));

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("8a02a434-8afa-4173-847c-e5d66b9ad000"), new DateTime(2024, 4, 12, 10, 32, 37, 761, DateTimeKind.Utc).AddTicks(1614), false, true, "supporter", 3 },
                    { new Guid("8d0a9dd8-1fb5-4970-bb24-263e8afa23af"), new DateTime(2024, 4, 12, 10, 32, 37, 761, DateTimeKind.Utc).AddTicks(1599), false, true, "manager", 2 },
                    { new Guid("b9e500a9-c69c-42bc-9e8f-b32d3ec6751e"), new DateTime(2024, 4, 12, 10, 32, 37, 761, DateTimeKind.Utc).AddTicks(1629), false, true, "user", 4 },
                    { new Guid("c14aef69-35ec-4f9e-a20e-61ea841c8c34"), new DateTime(2024, 4, 12, 10, 32, 37, 761, DateTimeKind.Utc).AddTicks(1572), false, true, "admin", 1 }
                });
        }
    }
}
