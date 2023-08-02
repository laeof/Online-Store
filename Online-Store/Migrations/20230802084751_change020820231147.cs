using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class change020820231147 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a6f89035-7048-46f4-915b-e256bcd5f5b8"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("8135e784-6e80-4ca8-94d9-0cff43134125"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f10af38e-1735-4dba-b0e2-1e057eb2b6ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7967f78b-23da-4c90-a072-6840dad33c52"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name" },
                values: new object[,]
                {
                    { new Guid("0ce25b9a-f187-475f-9867-77e63bb6455f"), new DateTime(2023, 8, 2, 8, 47, 51, 684, DateTimeKind.Utc).AddTicks(5215), false, true, "admin" },
                    { new Guid("6b9b04bd-32e2-4b50-a623-b4f07b578860"), new DateTime(2023, 8, 2, 8, 47, 51, 687, DateTimeKind.Utc).AddTicks(1405), false, true, "user" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "Name", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("b1ddf756-1e38-46ea-9f9a-0f45ebef898d"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 2, 8, 47, 51, 684, DateTimeKind.Utc).AddTicks(5217), "Admin", null, true, false, false, true, "Max", "$HASH|V1$10000$AHI6vKnlp7FksrI1ROrIEYHS4OMgyRUAqeu7BnIsFWq7PDb9", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("740811a0-bce6-4238-9e99-9d22c5e29450"), new DateTime(2023, 8, 2, 8, 47, 51, 687, DateTimeKind.Utc).AddTicks(1426), false, true, new Guid("0ce25b9a-f187-475f-9867-77e63bb6455f"), new Guid("b1ddf756-1e38-46ea-9f9a-0f45ebef898d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6b9b04bd-32e2-4b50-a623-b4f07b578860"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("740811a0-bce6-4238-9e99-9d22c5e29450"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0ce25b9a-f187-475f-9867-77e63bb6455f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1ddf756-1e38-46ea-9f9a-0f45ebef898d"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name" },
                values: new object[,]
                {
                    { new Guid("a6f89035-7048-46f4-915b-e256bcd5f5b8"), new DateTime(2023, 8, 2, 8, 12, 50, 84, DateTimeKind.Utc).AddTicks(3254), false, true, "user" },
                    { new Guid("f10af38e-1735-4dba-b0e2-1e057eb2b6ce"), new DateTime(2023, 8, 2, 8, 12, 50, 81, DateTimeKind.Utc).AddTicks(6642), false, true, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "Name", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("7967f78b-23da-4c90-a072-6840dad33c52"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 2, 8, 12, 50, 81, DateTimeKind.Utc).AddTicks(6645), "Admin", null, true, false, false, true, "Max", "$HASH|V1$10000$0f/WyEZ/YZmunnZaU1APYcYG7IXJSHTZib8Pbih+1Nk7tIqE", null, null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("8135e784-6e80-4ca8-94d9-0cff43134125"), new DateTime(2023, 8, 2, 8, 12, 50, 84, DateTimeKind.Utc).AddTicks(3276), false, true, new Guid("f10af38e-1735-4dba-b0e2-1e057eb2b6ce"), new Guid("7967f78b-23da-4c90-a072-6840dad33c52") });
        }
    }
}
