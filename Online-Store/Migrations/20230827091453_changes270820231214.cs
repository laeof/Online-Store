using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes270820231214 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7ec235e1-2741-4fe2-8ede-9d1925e171b3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b7b2f40c-6bb3-4046-9060-825cde40f9d1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ce3f6a8c-8315-4ed1-bc04-99f8d282d11b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("de7e6ae9-9708-4964-a6bc-478acf6a611e"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("09bae7e8-1a44-4157-adb7-70ab0518e9a1"), new DateTime(2023, 8, 27, 9, 14, 53, 50, DateTimeKind.Utc).AddTicks(1880), false, true, "supporter", 3 },
                    { new Guid("10c0e58b-bb87-4b49-ae4e-3b327a9a64b1"), new DateTime(2023, 8, 27, 9, 14, 53, 50, DateTimeKind.Utc).AddTicks(1858), false, true, "admin", 1 },
                    { new Guid("7729119f-3632-48c9-b151-0e41a1a8f894"), new DateTime(2023, 8, 27, 9, 14, 53, 50, DateTimeKind.Utc).AddTicks(1873), false, true, "manager", 2 },
                    { new Guid("a4186f17-48bc-4fd4-848c-abca4e538899"), new DateTime(2023, 8, 27, 9, 14, 53, 50, DateTimeKind.Utc).AddTicks(1886), false, true, "user", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("09bae7e8-1a44-4157-adb7-70ab0518e9a1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("10c0e58b-bb87-4b49-ae4e-3b327a9a64b1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7729119f-3632-48c9-b151-0e41a1a8f894"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4186f17-48bc-4fd4-848c-abca4e538899"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("7ec235e1-2741-4fe2-8ede-9d1925e171b3"), new DateTime(2023, 8, 24, 11, 58, 33, 258, DateTimeKind.Utc).AddTicks(5345), false, true, "admin", 1 },
                    { new Guid("b7b2f40c-6bb3-4046-9060-825cde40f9d1"), new DateTime(2023, 8, 24, 11, 58, 33, 258, DateTimeKind.Utc).AddTicks(5371), false, true, "supporter", 3 },
                    { new Guid("ce3f6a8c-8315-4ed1-bc04-99f8d282d11b"), new DateTime(2023, 8, 24, 11, 58, 33, 258, DateTimeKind.Utc).AddTicks(5377), false, true, "user", 4 },
                    { new Guid("de7e6ae9-9708-4964-a6bc-478acf6a611e"), new DateTime(2023, 8, 24, 11, 58, 33, 258, DateTimeKind.Utc).AddTicks(5363), false, true, "manager", 2 }
                });
        }
    }
}
