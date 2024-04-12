using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class satapr13828 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("089bac27-49a2-40e0-a233-0d0d67e8dc07"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6f3bdc1d-2aca-4413-a0f6-d96c074d8e4d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("85869f81-3472-4e18-8fa9-b74df9bd7086"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a56e701e-5864-46c6-92bc-13e36bb894d5"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("089bac27-49a2-40e0-a233-0d0d67e8dc07"), new DateTime(2024, 4, 12, 22, 25, 28, 938, DateTimeKind.Utc).AddTicks(3257), false, true, "user", 4 },
                    { new Guid("6f3bdc1d-2aca-4413-a0f6-d96c074d8e4d"), new DateTime(2024, 4, 12, 22, 25, 28, 938, DateTimeKind.Utc).AddTicks(3242), false, true, "supporter", 3 },
                    { new Guid("85869f81-3472-4e18-8fa9-b74df9bd7086"), new DateTime(2024, 4, 12, 22, 25, 28, 938, DateTimeKind.Utc).AddTicks(3227), false, true, "manager", 2 },
                    { new Guid("a56e701e-5864-46c6-92bc-13e36bb894d5"), new DateTime(2024, 4, 12, 22, 25, 28, 938, DateTimeKind.Utc).AddTicks(3195), false, true, "admin", 1 }
                });
        }
    }
}
