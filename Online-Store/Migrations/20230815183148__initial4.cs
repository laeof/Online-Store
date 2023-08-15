using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class _initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1ad61d25-273f-41ce-bd25-07e72ce128d5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("37921872-f9e0-4ea9-b27a-6359bcce9ed7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("80364476-fa5e-42d4-add0-fd9e6cdadfc4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("959b89a0-034a-49a6-a156-f4e2653cbf83"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("1ad61d25-273f-41ce-bd25-07e72ce128d5"), new DateTime(2023, 8, 15, 18, 31, 20, 193, DateTimeKind.Utc).AddTicks(9477), false, true, "manager", 2 },
                    { new Guid("37921872-f9e0-4ea9-b27a-6359bcce9ed7"), new DateTime(2023, 8, 15, 18, 31, 20, 193, DateTimeKind.Utc).AddTicks(9491), false, true, "user", 4 },
                    { new Guid("80364476-fa5e-42d4-add0-fd9e6cdadfc4"), new DateTime(2023, 8, 15, 18, 31, 20, 193, DateTimeKind.Utc).AddTicks(9485), false, true, "supporter", 3 },
                    { new Guid("959b89a0-034a-49a6-a156-f4e2653cbf83"), new DateTime(2023, 8, 15, 18, 31, 20, 193, DateTimeKind.Utc).AddTicks(9428), false, true, "admin", 1 }
                });
        }
    }
}
