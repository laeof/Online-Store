using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class firstuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("1a46d713-e5fb-4958-bd48-4bb8059ca96a"), "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Email", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "Name", "Password", "PhoneNumber", "PostalCode", "Region", "RegistrationDate" },
                values: new object[] { new Guid("7699d7fa-a93a-4a52-8083-cf3c476f29af"), null, "xd", "../../../../img/Avatar/user.png", null, null, "Admin", null, true, false, false, "Max", "$HASH|V1$10000$LRY3gohIQloveX5TKIXrPRiyRbrRMUFELZ82uCxRdisxprrF", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1a46d713-e5fb-4958-bd48-4bb8059ca96a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7699d7fa-a93a-4a52-8083-cf3c476f29af"));
        }
    }
}
