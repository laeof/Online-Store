using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231622 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ProductId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("544e33a8-4ac7-4859-8cbe-a47c8b10eeb7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("922a408b-51d9-4f92-8e91-3065e2e8bbb9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f79b082f-b368-419e-865c-0e04a77914bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a55ccf5-48d6-4b97-aaef-6369102589bb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5406fe34-40ff-43f5-a909-e74643d30300"));

            migrationBuilder.AddColumn<Guid>(
                name: "MonitorId",
                table: "Products",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MotinorId",
                table: "Products",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("2e5a3a6d-f76b-49b0-9a51-cf486565b571"), new DateTime(2023, 8, 14, 13, 22, 41, 622, DateTimeKind.Utc).AddTicks(4417), false, true, "user", 4 },
                    { new Guid("534859d0-e025-4b19-911e-ce149e808574"), new DateTime(2023, 8, 14, 13, 22, 41, 622, DateTimeKind.Utc).AddTicks(4411), false, true, "supporter", 3 },
                    { new Guid("6421870b-fe03-4e41-90e4-dde1a6887011"), new DateTime(2023, 8, 14, 13, 22, 41, 622, DateTimeKind.Utc).AddTicks(4403), false, true, "manager", 2 },
                    { new Guid("9563e53d-bab1-4d29-bc85-9a736bf3d589"), new DateTime(2023, 8, 14, 13, 22, 41, 622, DateTimeKind.Utc).AddTicks(4330), false, true, "admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("fb7b96ee-e99c-411c-874f-eb5ebcff396b"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 22, 41, 622, DateTimeKind.Utc).AddTicks(4419), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$GmSSAa7sdvVe/WIOpmM2Yo6RbeJhYmXDZJ6AuIyJPgc3xazQ", "1234567890", null, null, new Guid("9563e53d-bab1-4d29-bc85-9a736bf3d589") });

            migrationBuilder.CreateIndex(
                name: "IX_Products_MotinorId",
                table: "Products",
                column: "MotinorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_MotinorId",
                table: "Products",
                column: "MotinorId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_MotinorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MotinorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2e5a3a6d-f76b-49b0-9a51-cf486565b571"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("534859d0-e025-4b19-911e-ce149e808574"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6421870b-fe03-4e41-90e4-dde1a6887011"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb7b96ee-e99c-411c-874f-eb5ebcff396b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9563e53d-bab1-4d29-bc85-9a736bf3d589"));

            migrationBuilder.DropColumn(
                name: "MonitorId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MotinorId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("5406fe34-40ff-43f5-a909-e74643d30300"), new DateTime(2023, 8, 14, 13, 21, 42, 240, DateTimeKind.Utc).AddTicks(3748), false, true, "admin", 1 },
                    { new Guid("544e33a8-4ac7-4859-8cbe-a47c8b10eeb7"), new DateTime(2023, 8, 14, 13, 21, 42, 240, DateTimeKind.Utc).AddTicks(3801), false, true, "supporter", 3 },
                    { new Guid("922a408b-51d9-4f92-8e91-3065e2e8bbb9"), new DateTime(2023, 8, 14, 13, 21, 42, 240, DateTimeKind.Utc).AddTicks(3806), false, true, "user", 4 },
                    { new Guid("f79b082f-b368-419e-865c-0e04a77914bb"), new DateTime(2023, 8, 14, 13, 21, 42, 240, DateTimeKind.Utc).AddTicks(3794), false, true, "manager", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("1a55ccf5-48d6-4b97-aaef-6369102589bb"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 21, 42, 240, DateTimeKind.Utc).AddTicks(3809), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$u44OpZNF7Nr2wfinBZmGKwH689ZH6hFddSOKLi8S2L3YORgS", "1234567890", null, null, new Guid("5406fe34-40ff-43f5-a909-e74643d30300") });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId",
                unique: true);
        }
    }
}
