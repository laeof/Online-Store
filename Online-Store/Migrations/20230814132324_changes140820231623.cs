using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231623 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ProductId",
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
                name: "ProductId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("001b6551-e2d4-4d6e-b204-93941f3737e0"), new DateTime(2023, 8, 14, 13, 23, 24, 451, DateTimeKind.Utc).AddTicks(1519), false, true, "supporter", 3 },
                    { new Guid("479bfa12-35f6-403f-809c-3ea83478f442"), new DateTime(2023, 8, 14, 13, 23, 24, 451, DateTimeKind.Utc).AddTicks(1463), false, true, "admin", 1 },
                    { new Guid("ab46e825-1159-4df6-a44e-e758e6b08e44"), new DateTime(2023, 8, 14, 13, 23, 24, 451, DateTimeKind.Utc).AddTicks(1512), false, true, "manager", 2 },
                    { new Guid("badbc24b-9ec7-4e01-981f-9dd75c1fafad"), new DateTime(2023, 8, 14, 13, 23, 24, 451, DateTimeKind.Utc).AddTicks(1526), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("6487aff4-8f1d-467c-a050-b35f9c040d0e"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 23, 24, 451, DateTimeKind.Utc).AddTicks(1550), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$kCLZ8KZjbfTv3MYpn1XXLo2doWBUB8VsQxYhZd1w50a8dCDt", "1234567890", null, null, new Guid("479bfa12-35f6-403f-809c-3ea83478f442") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("001b6551-e2d4-4d6e-b204-93941f3737e0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ab46e825-1159-4df6-a44e-e758e6b08e44"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("badbc24b-9ec7-4e01-981f-9dd75c1fafad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6487aff4-8f1d-467c-a050-b35f9c040d0e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("479bfa12-35f6-403f-809c-3ea83478f442"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
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
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ProductId",
                table: "Products",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
