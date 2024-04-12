using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class friapr1904 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("883d0598-47e3-46ae-bddf-8f648623bc35"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9ca42dfd-c4a7-43e0-9396-d15f212bd7b7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c9fe2242-f12e-454f-b37f-a3254a18d5e5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d835dae1-de92-44c1-a298-68f7c2102057"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("018b867a-9f3e-4667-bf32-cb8a208a54b4"), new DateTime(2024, 4, 12, 16, 4, 20, 574, DateTimeKind.Utc).AddTicks(7618), false, true, "manager", 2 },
                    { new Guid("50ae03ff-6620-476f-ab11-f3b060b39b74"), new DateTime(2024, 4, 12, 16, 4, 20, 574, DateTimeKind.Utc).AddTicks(7652), false, true, "user", 4 },
                    { new Guid("6a8d4c38-2d9a-4fd2-8611-2fce1d79da47"), new DateTime(2024, 4, 12, 16, 4, 20, 574, DateTimeKind.Utc).AddTicks(7636), false, true, "supporter", 3 },
                    { new Guid("c107ab1a-3203-4d5e-a27a-435c19babda9"), new DateTime(2024, 4, 12, 16, 4, 20, 574, DateTimeKind.Utc).AddTicks(7591), false, true, "admin", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("018b867a-9f3e-4667-bf32-cb8a208a54b4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("50ae03ff-6620-476f-ab11-f3b060b39b74"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6a8d4c38-2d9a-4fd2-8611-2fce1d79da47"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c107ab1a-3203-4d5e-a27a-435c19babda9"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("883d0598-47e3-46ae-bddf-8f648623bc35"), new DateTime(2024, 4, 12, 11, 55, 31, 162, DateTimeKind.Utc).AddTicks(8445), false, true, "manager", 2 },
                    { new Guid("9ca42dfd-c4a7-43e0-9396-d15f212bd7b7"), new DateTime(2024, 4, 12, 11, 55, 31, 162, DateTimeKind.Utc).AddTicks(8418), false, true, "admin", 1 },
                    { new Guid("c9fe2242-f12e-454f-b37f-a3254a18d5e5"), new DateTime(2024, 4, 12, 11, 55, 31, 162, DateTimeKind.Utc).AddTicks(8475), false, true, "user", 4 },
                    { new Guid("d835dae1-de92-44c1-a298-68f7c2102057"), new DateTime(2024, 4, 12, 11, 55, 31, 162, DateTimeKind.Utc).AddTicks(8461), false, true, "supporter", 3 }
                });
        }
    }
}
