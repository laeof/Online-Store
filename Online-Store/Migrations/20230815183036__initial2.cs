using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class _initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0892c5de-72e4-4628-a027-a85904661345"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0c671e52-883b-4944-84f9-e8e6b9cdb58f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("79bb8c2b-0253-4c6e-9758-ec36df3d6ae2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a1dad193-2a7c-47bf-bacc-dab05d7174cc"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("387d2965-c0c1-4b60-8749-25726f7cd7e3"), new DateTime(2023, 8, 15, 18, 30, 36, 451, DateTimeKind.Utc).AddTicks(6248), false, true, "user", 4 },
                    { new Guid("3e4e14d2-d06d-4a86-a4a3-0559d04b32a1"), new DateTime(2023, 8, 15, 18, 30, 36, 451, DateTimeKind.Utc).AddTicks(6242), false, true, "supporter", 3 },
                    { new Guid("6fefc210-2c06-40a7-bdc0-b4a5fd3c4ef5"), new DateTime(2023, 8, 15, 18, 30, 36, 451, DateTimeKind.Utc).AddTicks(6234), false, true, "manager", 2 },
                    { new Guid("d060f38a-e647-458b-b6cb-439093f6e629"), new DateTime(2023, 8, 15, 18, 30, 36, 451, DateTimeKind.Utc).AddTicks(6179), false, true, "admin", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("387d2965-c0c1-4b60-8749-25726f7cd7e3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3e4e14d2-d06d-4a86-a4a3-0559d04b32a1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6fefc210-2c06-40a7-bdc0-b4a5fd3c4ef5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d060f38a-e647-458b-b6cb-439093f6e629"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("0892c5de-72e4-4628-a027-a85904661345"), new DateTime(2023, 8, 15, 18, 29, 4, 856, DateTimeKind.Utc).AddTicks(8819), false, true, "user", 4 },
                    { new Guid("0c671e52-883b-4944-84f9-e8e6b9cdb58f"), new DateTime(2023, 8, 15, 18, 29, 4, 856, DateTimeKind.Utc).AddTicks(8806), false, true, "manager", 2 },
                    { new Guid("79bb8c2b-0253-4c6e-9758-ec36df3d6ae2"), new DateTime(2023, 8, 15, 18, 29, 4, 856, DateTimeKind.Utc).AddTicks(8756), false, true, "admin", 1 },
                    { new Guid("a1dad193-2a7c-47bf-bacc-dab05d7174cc"), new DateTime(2023, 8, 15, 18, 29, 4, 856, DateTimeKind.Utc).AddTicks(8812), false, true, "supporter", 3 }
                });
        }
    }
}
