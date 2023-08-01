using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class secondrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1a46d713-e5fb-4958-bd48-4bb8059ca96a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7699d7fa-a93a-4a52-8083-cf3c476f29af"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5707fa7c-5878-4ae8-8e23-7390bf3ac840"), "admin" },
                    { new Guid("5c7e3ffc-cf32-4478-8118-387000386e8f"), "user" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Email", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "Name", "Password", "PhoneNumber", "PostalCode", "Region", "RegistrationDate" },
                values: new object[] { new Guid("fd6bb6d6-ee65-432c-bbcf-2e5236390b0a"), null, "xd", "../../../../img/Avatar/user.png", null, null, "Admin", null, true, false, false, "Max", "$HASH|V1$10000$73y/Hzr1c1EDFbRRC7JUJoXTiFJ0+W6P3pcbT963e21uKvah", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5707fa7c-5878-4ae8-8e23-7390bf3ac840"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5c7e3ffc-cf32-4478-8118-387000386e8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd6bb6d6-ee65-432c-bbcf-2e5236390b0a"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("1a46d713-e5fb-4958-bd48-4bb8059ca96a"), "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Email", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "Name", "Password", "PhoneNumber", "PostalCode", "Region", "RegistrationDate" },
                values: new object[] { new Guid("7699d7fa-a93a-4a52-8083-cf3c476f29af"), null, "xd", "../../../../img/Avatar/user.png", null, null, "Admin", null, true, false, false, "Max", "$HASH|V1$10000$LRY3gohIQloveX5TKIXrPRiyRbrRMUFELZ82uCxRdisxprrF", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
