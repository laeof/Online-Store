using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class userrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("48acd922-ad3b-4ea6-8aa9-11ba28425ec3"), "admin" },
                    { new Guid("b9e8948e-1119-441a-8fd5-53cce0967c3b"), "user" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Email", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "Name", "Password", "PhoneNumber", "PostalCode", "Region", "RegistrationDate" },
                values: new object[] { new Guid("51f0ac1d-d49d-4224-8cf7-1aae3c8723e9"), null, "xd", "../../../../img/Avatar/user.png", null, null, "Admin", null, true, false, false, "Max", "$HASH|V1$10000$Cvrju1uiP0kD9HnWgakt7j9wnBhoXoz7pnWPyhVxbAo2LqNS", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[] { new Guid("a1b243d4-da9e-4e0a-a70f-4ee6db9da2a0"), new Guid("48acd922-ad3b-4ea6-8aa9-11ba28425ec3"), new Guid("51f0ac1d-d49d-4224-8cf7-1aae3c8723e9") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b9e8948e-1119-441a-8fd5-53cce0967c3b"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("a1b243d4-da9e-4e0a-a70f-4ee6db9da2a0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("48acd922-ad3b-4ea6-8aa9-11ba28425ec3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51f0ac1d-d49d-4224-8cf7-1aae3c8723e9"));

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
    }
}
