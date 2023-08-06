using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class change2335060823 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2c38f3ae-a3ce-47b4-a5cd-999485da9b8c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6047e75e-a9aa-41da-8bc8-bc25e334c2ac"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3a16fee-c246-445e-ae86-8412b3593d55"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("93d1273b-d2cc-4ad3-9679-7be3284fc0f1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1b27327b-534f-4560-a30a-c135470a0dfb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00b61eeb-a4de-4779-8efa-b6b7dd941f97"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("aa6b842c-53db-44dc-a616-ee140bc6f6e0"), new DateTime(2023, 8, 6, 20, 35, 41, 984, DateTimeKind.Utc).AddTicks(7508), false, true, "user", 4 },
                    { new Guid("d85a197e-a0bf-4f17-9de2-dd432f6f06d3"), new DateTime(2023, 8, 6, 20, 35, 41, 984, DateTimeKind.Utc).AddTicks(7492), false, true, "manager", 2 },
                    { new Guid("d93d8206-99aa-481d-a54a-ec000d1faac2"), new DateTime(2023, 8, 6, 20, 35, 41, 984, DateTimeKind.Utc).AddTicks(7502), false, true, "supporter", 3 },
                    { new Guid("dc3ab337-f058-4a57-b347-a05b026a0d8e"), new DateTime(2023, 8, 6, 20, 35, 41, 981, DateTimeKind.Utc).AddTicks(521), false, true, "admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("7658ae8e-0ab8-4408-a9bb-f37147b2437b"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 20, 35, 41, 981, DateTimeKind.Utc).AddTicks(524), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$LDBhDFQqy5xZErqcrXuP5o5yQAt7xjE1IWJN0Dr93UIVRAkQ", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("d5d4e90e-4f33-4304-8651-1ab1eabdb6ed"), new DateTime(2023, 8, 6, 20, 35, 41, 984, DateTimeKind.Utc).AddTicks(7533), false, true, new Guid("dc3ab337-f058-4a57-b347-a05b026a0d8e"), new Guid("7658ae8e-0ab8-4408-a9bb-f37147b2437b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("aa6b842c-53db-44dc-a616-ee140bc6f6e0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d85a197e-a0bf-4f17-9de2-dd432f6f06d3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d93d8206-99aa-481d-a54a-ec000d1faac2"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("d5d4e90e-4f33-4304-8651-1ab1eabdb6ed"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc3ab337-f058-4a57-b347-a05b026a0d8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7658ae8e-0ab8-4408-a9bb-f37147b2437b"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("1b27327b-534f-4560-a30a-c135470a0dfb"), new DateTime(2023, 8, 6, 20, 22, 37, 594, DateTimeKind.Utc).AddTicks(4119), false, true, "admin", 1 },
                    { new Guid("2c38f3ae-a3ce-47b4-a5cd-999485da9b8c"), new DateTime(2023, 8, 6, 20, 22, 37, 597, DateTimeKind.Utc).AddTicks(614), false, true, "manager", 2 },
                    { new Guid("6047e75e-a9aa-41da-8bc8-bc25e334c2ac"), new DateTime(2023, 8, 6, 20, 22, 37, 597, DateTimeKind.Utc).AddTicks(621), false, true, "supporter", 3 },
                    { new Guid("f3a16fee-c246-445e-ae86-8412b3593d55"), new DateTime(2023, 8, 6, 20, 22, 37, 597, DateTimeKind.Utc).AddTicks(627), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("00b61eeb-a4de-4779-8efa-b6b7dd941f97"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 20, 22, 37, 594, DateTimeKind.Utc).AddTicks(4123), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$4KZDb1mb2IoXf3Cg4UHQLI4INPuhSFsAp8mYrc7N73pnMoYn", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("93d1273b-d2cc-4ad3-9679-7be3284fc0f1"), new DateTime(2023, 8, 6, 20, 22, 37, 597, DateTimeKind.Utc).AddTicks(649), false, true, new Guid("1b27327b-534f-4560-a30a-c135470a0dfb"), new Guid("00b61eeb-a4de-4779-8efa-b6b7dd941f97") });
        }
    }
}
