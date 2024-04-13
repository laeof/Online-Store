using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class friapr121328 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("16ee029e-5892-4576-a391-9fb65fb9db72"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1aba357d-bdc7-40d2-91b2-838b28c498c9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("212f0b4c-34a3-462a-848d-7a5cc6ec1f09"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2abd6cc5-1229-4334-9812-cf5ba84cef3c"));

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
                    { new Guid("16ee029e-5892-4576-a391-9fb65fb9db72"), new DateTime(2023, 8, 29, 3, 27, 8, 823, DateTimeKind.Utc).AddTicks(5797), false, true, "manager", 2 },
                    { new Guid("1aba357d-bdc7-40d2-91b2-838b28c498c9"), new DateTime(2023, 8, 29, 3, 27, 8, 823, DateTimeKind.Utc).AddTicks(5804), false, true, "supporter", 3 },
                    { new Guid("212f0b4c-34a3-462a-848d-7a5cc6ec1f09"), new DateTime(2023, 8, 29, 3, 27, 8, 823, DateTimeKind.Utc).AddTicks(5810), false, true, "user", 4 },
                    { new Guid("2abd6cc5-1229-4334-9812-cf5ba84cef3c"), new DateTime(2023, 8, 29, 3, 27, 8, 823, DateTimeKind.Utc).AddTicks(5778), false, true, "admin", 1 }
                });
        }
    }
}
