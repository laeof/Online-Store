using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class change2143060823 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("28d3e8de-e114-4427-8aa2-df0732c00cce"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("644f3f32-7c16-4f17-a828-075271533295"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("88c20fe2-eabd-491f-bd8d-6d78599cba5c"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("33460f07-59e9-466b-a4d5-03124de39fa6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ba5265d1-85f2-46f3-a99e-d1506d78850c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27bea011-c18c-4e5f-9332-50ec3324797b"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("624db571-7b42-446b-acc4-00c20c3e4601"), new DateTime(2023, 8, 6, 18, 43, 55, 113, DateTimeKind.Utc).AddTicks(9973), false, true, "supporter", 3 },
                    { new Guid("8085d43e-3f47-4785-981e-4625c9f238e4"), new DateTime(2023, 8, 6, 18, 43, 55, 111, DateTimeKind.Utc).AddTicks(3659), false, true, "admin", 1 },
                    { new Guid("81f7b577-e6bf-4bc7-ae44-5536b464af38"), new DateTime(2023, 8, 6, 18, 43, 55, 113, DateTimeKind.Utc).AddTicks(9965), false, true, "manager", 2 },
                    { new Guid("902ac896-e761-4641-bd66-422fe0165581"), new DateTime(2023, 8, 6, 18, 43, 55, 113, DateTimeKind.Utc).AddTicks(9979), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("cac486af-6847-4141-b6e0-c78daf11cdcc"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 18, 43, 55, 111, DateTimeKind.Utc).AddTicks(3673), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$6WUh7ddutYvUqPT8JcgtooMW2eY/PlJmlFoWUOATewywRDbQ", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("cbee14f8-7654-4104-b898-56c76fcc5785"), new DateTime(2023, 8, 6, 18, 43, 55, 113, DateTimeKind.Utc).AddTicks(9999), false, true, new Guid("8085d43e-3f47-4785-981e-4625c9f238e4"), new Guid("cac486af-6847-4141-b6e0-c78daf11cdcc") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("624db571-7b42-446b-acc4-00c20c3e4601"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("81f7b577-e6bf-4bc7-ae44-5536b464af38"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("902ac896-e761-4641-bd66-422fe0165581"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("cbee14f8-7654-4104-b898-56c76fcc5785"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8085d43e-3f47-4785-981e-4625c9f238e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cac486af-6847-4141-b6e0-c78daf11cdcc"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("28d3e8de-e114-4427-8aa2-df0732c00cce"), new DateTime(2023, 8, 6, 17, 3, 30, 602, DateTimeKind.Utc).AddTicks(2749), false, true, "supporter", 3 },
                    { new Guid("644f3f32-7c16-4f17-a828-075271533295"), new DateTime(2023, 8, 6, 17, 3, 30, 602, DateTimeKind.Utc).AddTicks(2755), false, true, "user", 4 },
                    { new Guid("88c20fe2-eabd-491f-bd8d-6d78599cba5c"), new DateTime(2023, 8, 6, 17, 3, 30, 602, DateTimeKind.Utc).AddTicks(2740), false, true, "manager", 2 },
                    { new Guid("ba5265d1-85f2-46f3-a99e-d1506d78850c"), new DateTime(2023, 8, 6, 17, 3, 30, 599, DateTimeKind.Utc).AddTicks(6257), false, true, "admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("27bea011-c18c-4e5f-9332-50ec3324797b"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 17, 3, 30, 599, DateTimeKind.Utc).AddTicks(6259), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$Kta+FyX3Id2pYfJ26bOQWPFvYJL7pk7Qye98nqdFSTJBO4tz", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("33460f07-59e9-466b-a4d5-03124de39fa6"), new DateTime(2023, 8, 6, 17, 3, 30, 602, DateTimeKind.Utc).AddTicks(2785), false, true, new Guid("ba5265d1-85f2-46f3-a99e-d1506d78850c"), new Guid("27bea011-c18c-4e5f-9332-50ec3324797b") });
        }
    }
}
