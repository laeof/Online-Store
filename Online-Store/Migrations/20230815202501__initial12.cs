using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class _initial12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("27dc9db2-c10f-42df-9cdc-b8525bd5e97b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6d9f32d6-6189-44be-ad0f-14f87513c754"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8587e62f-6ccf-4337-9666-8885f9f2a6d7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d1efe96-e52e-4433-8730-855ed2204dc4"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("21f8650a-fbe8-462f-b20e-22d732e45242"), new DateTime(2023, 8, 15, 20, 25, 1, 534, DateTimeKind.Utc).AddTicks(1619), false, true, "user", 4 },
                    { new Guid("558363bb-a69a-4e08-8d25-f718330caed6"), new DateTime(2023, 8, 15, 20, 25, 1, 534, DateTimeKind.Utc).AddTicks(1613), false, true, "supporter", 3 },
                    { new Guid("6dd9caca-5f2b-4049-aaf1-de337a549409"), new DateTime(2023, 8, 15, 20, 25, 1, 534, DateTimeKind.Utc).AddTicks(1568), false, true, "admin", 1 },
                    { new Guid("eba6c703-0ef7-494d-864a-cc377fbc3dfa"), new DateTime(2023, 8, 15, 20, 25, 1, 534, DateTimeKind.Utc).AddTicks(1606), false, true, "manager", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("21f8650a-fbe8-462f-b20e-22d732e45242"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("558363bb-a69a-4e08-8d25-f718330caed6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6dd9caca-5f2b-4049-aaf1-de337a549409"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("eba6c703-0ef7-494d-864a-cc377fbc3dfa"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("27dc9db2-c10f-42df-9cdc-b8525bd5e97b"), new DateTime(2023, 8, 15, 19, 18, 47, 721, DateTimeKind.Utc).AddTicks(7937), false, true, "admin", 1 },
                    { new Guid("6d9f32d6-6189-44be-ad0f-14f87513c754"), new DateTime(2023, 8, 15, 19, 18, 47, 721, DateTimeKind.Utc).AddTicks(7976), false, true, "user", 4 },
                    { new Guid("8587e62f-6ccf-4337-9666-8885f9f2a6d7"), new DateTime(2023, 8, 15, 19, 18, 47, 721, DateTimeKind.Utc).AddTicks(7969), false, true, "supporter", 3 },
                    { new Guid("8d1efe96-e52e-4433-8730-855ed2204dc4"), new DateTime(2023, 8, 15, 19, 18, 47, 721, DateTimeKind.Utc).AddTicks(7962), false, true, "manager", 2 }
                });
        }
    }
}
