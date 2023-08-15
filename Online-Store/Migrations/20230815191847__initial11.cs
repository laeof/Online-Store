using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class _initial11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("47f59bf1-cb4d-4568-99f3-97c0c874b8f4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4a78816a-cc1c-475b-bd04-965621172ec5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("988c9e19-d168-4b32-a17a-d7f20ffeaf79"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fce51554-69dc-4a61-8e98-82ec8094b0eb"));

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Products",
                newName: "Product");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Product",
                table: "Products",
                newName: "Discriminator");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("47f59bf1-cb4d-4568-99f3-97c0c874b8f4"), new DateTime(2023, 8, 15, 18, 46, 16, 378, DateTimeKind.Utc).AddTicks(3355), false, true, "supporter", 3 },
                    { new Guid("4a78816a-cc1c-475b-bd04-965621172ec5"), new DateTime(2023, 8, 15, 18, 46, 16, 378, DateTimeKind.Utc).AddTicks(3302), false, true, "admin", 1 },
                    { new Guid("988c9e19-d168-4b32-a17a-d7f20ffeaf79"), new DateTime(2023, 8, 15, 18, 46, 16, 378, DateTimeKind.Utc).AddTicks(3347), false, true, "manager", 2 },
                    { new Guid("fce51554-69dc-4a61-8e98-82ec8094b0eb"), new DateTime(2023, 8, 15, 18, 46, 16, 378, DateTimeKind.Utc).AddTicks(3362), false, true, "user", 4 }
                });
        }
    }
}
