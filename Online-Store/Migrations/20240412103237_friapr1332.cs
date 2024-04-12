using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class friapr1332 : Migration
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
                keyValue: new Guid("079d3b12-c11e-4966-a5b2-e4b9d69c12dd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0a900a32-e130-487a-8d75-a5015cc15533"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1fb1f485-9ae9-4528-9dc3-9d27b156f8ea"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6f6ef244-a2af-4c20-b205-76ca26ba22ed"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("079d3b12-c11e-4966-a5b2-e4b9d69c12dd"), new DateTime(2024, 4, 12, 10, 29, 4, 201, DateTimeKind.Utc).AddTicks(3975), false, true, "admin", 1 },
                    { new Guid("0a900a32-e130-487a-8d75-a5015cc15533"), new DateTime(2024, 4, 12, 10, 29, 4, 201, DateTimeKind.Utc).AddTicks(4031), false, true, "user", 4 },
                    { new Guid("1fb1f485-9ae9-4528-9dc3-9d27b156f8ea"), new DateTime(2024, 4, 12, 10, 29, 4, 201, DateTimeKind.Utc).AddTicks(4001), false, true, "manager", 2 },
                    { new Guid("6f6ef244-a2af-4c20-b205-76ca26ba22ed"), new DateTime(2024, 4, 12, 10, 29, 4, 201, DateTimeKind.Utc).AddTicks(4017), false, true, "supporter", 3 }
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
