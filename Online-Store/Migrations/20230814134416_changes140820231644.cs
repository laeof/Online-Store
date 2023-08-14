using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231644 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("185e3834-feee-4495-9d33-fcb730e0dd06"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6a11c773-255e-449f-9795-8408022dff82"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b18fed09-610c-4e5b-aac4-2a66b8d194e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8ccc1c8-1910-48d8-8170-c2e1ef086ccb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("39565a58-a4d8-4d08-b09b-b2c9a1fa2219"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("23f5cba4-f55f-426e-9b30-8fa8c46bc2a7"), new DateTime(2023, 8, 14, 13, 44, 16, 841, DateTimeKind.Utc).AddTicks(7284), false, true, "user", 4 },
                    { new Guid("84a19b03-659e-4025-9a4c-4ee388697f1c"), new DateTime(2023, 8, 14, 13, 44, 16, 841, DateTimeKind.Utc).AddTicks(7278), false, true, "supporter", 3 },
                    { new Guid("c00e5a05-1f44-4e1f-aebb-8b021b1e54e3"), new DateTime(2023, 8, 14, 13, 44, 16, 841, DateTimeKind.Utc).AddTicks(7239), false, true, "admin", 1 },
                    { new Guid("ecf17ca4-8bb0-44b4-98aa-d5f90edb96fa"), new DateTime(2023, 8, 14, 13, 44, 16, 841, DateTimeKind.Utc).AddTicks(7271), false, true, "manager", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("940735c6-ef83-45eb-bb66-cc552e022516"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 44, 16, 841, DateTimeKind.Utc).AddTicks(7286), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$YJciWuFhhoiYlZsKrtRV97GjtzXZ2lM4YAdiAB1DI/2ALLfE", "1234567890", null, null, new Guid("c00e5a05-1f44-4e1f-aebb-8b021b1e54e3") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("23f5cba4-f55f-426e-9b30-8fa8c46bc2a7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("84a19b03-659e-4025-9a4c-4ee388697f1c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ecf17ca4-8bb0-44b4-98aa-d5f90edb96fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("940735c6-ef83-45eb-bb66-cc552e022516"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c00e5a05-1f44-4e1f-aebb-8b021b1e54e3"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("185e3834-feee-4495-9d33-fcb730e0dd06"), new DateTime(2023, 8, 14, 13, 40, 17, 824, DateTimeKind.Utc).AddTicks(7597), false, true, "user", 4 },
                    { new Guid("39565a58-a4d8-4d08-b09b-b2c9a1fa2219"), new DateTime(2023, 8, 14, 13, 40, 17, 824, DateTimeKind.Utc).AddTicks(7555), false, true, "admin", 1 },
                    { new Guid("6a11c773-255e-449f-9795-8408022dff82"), new DateTime(2023, 8, 14, 13, 40, 17, 824, DateTimeKind.Utc).AddTicks(7591), false, true, "supporter", 3 },
                    { new Guid("b18fed09-610c-4e5b-aac4-2a66b8d194e3"), new DateTime(2023, 8, 14, 13, 40, 17, 824, DateTimeKind.Utc).AddTicks(7584), false, true, "manager", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("d8ccc1c8-1910-48d8-8170-c2e1ef086ccb"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 40, 17, 824, DateTimeKind.Utc).AddTicks(7599), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$XJoo7WJsXVf9cAKKpmYCgg3Ul6kFY34ZPmIfkk+62G9v6R8N", "1234567890", null, null, new Guid("39565a58-a4d8-4d08-b09b-b2c9a1fa2219") });
        }
    }
}
