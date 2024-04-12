using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class friapr1359 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Brightness",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Contrast",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Diagonal",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Interfaces",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MatrixType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ratio",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Reaction",
                table: "Products");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Brightness",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contrast",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Diagonal",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Frequency",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interfaces",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatrixType",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ratio",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reaction",
                table: "Products",
                type: "text",
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
        }
    }
}
