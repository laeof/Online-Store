using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class thuapr102537 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "GoogleId",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("1c2d3762-0fb9-48e9-895e-f4be7396c0ed"), new DateTime(2024, 4, 18, 7, 26, 19, 378, DateTimeKind.Utc).AddTicks(5893), false, true, "admin", 1 },
                    { new Guid("22e8e907-19a6-4c54-944b-7e3062adf632"), new DateTime(2024, 4, 18, 7, 26, 19, 378, DateTimeKind.Utc).AddTicks(5949), false, true, "user", 4 },
                    { new Guid("609f6fb8-f86c-485e-8591-9d71de5b1ebd"), new DateTime(2024, 4, 18, 7, 26, 19, 378, DateTimeKind.Utc).AddTicks(5935), false, true, "supporter", 3 },
                    { new Guid("ea6a19e9-3682-48cb-a21d-a92ef97716af"), new DateTime(2024, 4, 18, 7, 26, 19, 378, DateTimeKind.Utc).AddTicks(5919), false, true, "manager", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_GoogleId",
                table: "Users",
                column: "GoogleId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_GoogleId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c2d3762-0fb9-48e9-895e-f4be7396c0ed"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("22e8e907-19a6-4c54-944b-7e3062adf632"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("609f6fb8-f86c-485e-8591-9d71de5b1ebd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ea6a19e9-3682-48cb-a21d-a92ef97716af"));

            migrationBuilder.DropColumn(
                name: "GoogleId",
                table: "Users");

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
        }
    }
}
