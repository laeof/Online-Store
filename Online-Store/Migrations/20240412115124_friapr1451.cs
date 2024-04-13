using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class friapr1451 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("32aa933b-7b6f-4104-af31-971441543cc4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6c3b710d-15e6-4333-9d97-f4b4a7b593d2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8efca720-884f-4633-9f6d-6c132c037027"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d44e97de-506c-428f-8eea-f339e82e028a"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("1760f7b2-f863-42c4-b2a3-37a12c879d23"), new DateTime(2024, 4, 12, 11, 51, 24, 707, DateTimeKind.Utc).AddTicks(8520), false, true, "admin", 1 },
                    { new Guid("46942283-36a2-4744-9731-6e21cd3fc7bb"), new DateTime(2024, 4, 12, 11, 51, 24, 707, DateTimeKind.Utc).AddTicks(8616), false, true, "user", 4 },
                    { new Guid("58a8b824-8483-4046-84c7-585e3b0f58d8"), new DateTime(2024, 4, 12, 11, 51, 24, 707, DateTimeKind.Utc).AddTicks(8585), false, true, "manager", 2 },
                    { new Guid("c207360b-6477-40b4-8405-0d0e68d69389"), new DateTime(2024, 4, 12, 11, 51, 24, 707, DateTimeKind.Utc).AddTicks(8601), false, true, "supporter", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1760f7b2-f863-42c4-b2a3-37a12c879d23"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("46942283-36a2-4744-9731-6e21cd3fc7bb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("58a8b824-8483-4046-84c7-585e3b0f58d8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c207360b-6477-40b4-8405-0d0e68d69389"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("32aa933b-7b6f-4104-af31-971441543cc4"), new DateTime(2024, 4, 12, 11, 13, 53, 821, DateTimeKind.Utc).AddTicks(5763), false, true, "user", 4 },
                    { new Guid("6c3b710d-15e6-4333-9d97-f4b4a7b593d2"), new DateTime(2024, 4, 12, 11, 13, 53, 821, DateTimeKind.Utc).AddTicks(5705), false, true, "admin", 1 },
                    { new Guid("8efca720-884f-4633-9f6d-6c132c037027"), new DateTime(2024, 4, 12, 11, 13, 53, 821, DateTimeKind.Utc).AddTicks(5733), false, true, "manager", 2 },
                    { new Guid("d44e97de-506c-428f-8eea-f339e82e028a"), new DateTime(2024, 4, 12, 11, 13, 53, 821, DateTimeKind.Utc).AddTicks(5748), false, true, "supporter", 3 }
                });
        }
    }
}
