using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820232131 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("15dbc710-9a99-478a-b9b2-91c5abfdb776"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("281cc92a-1595-4227-a0ad-639a4aee3616"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("acba65e7-a2e0-4805-9f57-4880d2f9f57b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e673aa99-cf98-4bca-82d4-296852356f1b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b9083f5c-1cf3-4af2-975f-0d76674ce03d"));

            migrationBuilder.AddColumn<Guid>(
                name: "KeyboardId",
                table: "Products",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("1adf8e56-847c-47bd-b8a7-37f119b98180"), new DateTime(2023, 8, 14, 18, 31, 51, 714, DateTimeKind.Utc).AddTicks(7560), false, true, "supporter", 3 },
                    { new Guid("69e6d115-eb2d-4755-9511-1f7d95a811a7"), new DateTime(2023, 8, 14, 18, 31, 51, 714, DateTimeKind.Utc).AddTicks(7566), false, true, "user", 4 },
                    { new Guid("747c58c1-3c40-4644-9e5a-22d1f609e796"), new DateTime(2023, 8, 14, 18, 31, 51, 714, DateTimeKind.Utc).AddTicks(7500), false, true, "admin", 1 },
                    { new Guid("76dfeb9e-2e85-4cdb-993e-1cd8e1ffc90c"), new DateTime(2023, 8, 14, 18, 31, 51, 714, DateTimeKind.Utc).AddTicks(7553), false, true, "manager", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_KeyboardId",
                table: "Products",
                column: "KeyboardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Keyboards_KeyboardId",
                table: "Products",
                column: "KeyboardId",
                principalTable: "Keyboards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Keyboards_KeyboardId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_KeyboardId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1adf8e56-847c-47bd-b8a7-37f119b98180"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("69e6d115-eb2d-4755-9511-1f7d95a811a7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("747c58c1-3c40-4644-9e5a-22d1f609e796"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("76dfeb9e-2e85-4cdb-993e-1cd8e1ffc90c"));

            migrationBuilder.DropColumn(
                name: "KeyboardId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("15dbc710-9a99-478a-b9b2-91c5abfdb776"), new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8454), false, true, "user", 4 },
                    { new Guid("281cc92a-1595-4227-a0ad-639a4aee3616"), new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8448), false, true, "supporter", 3 },
                    { new Guid("acba65e7-a2e0-4805-9f57-4880d2f9f57b"), new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8440), false, true, "manager", 2 },
                    { new Guid("b9083f5c-1cf3-4af2-975f-0d76674ce03d"), new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8391), false, true, "admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("e673aa99-cf98-4bca-82d4-296852356f1b"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8457), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$2WZTanMJNNq52zdj5cVzzcXKLeJUpOU1mSo00CNeJ39YF3P8", "1234567890", null, null, new Guid("b9083f5c-1cf3-4af2-975f-0d76674ce03d") });
        }
    }
}
