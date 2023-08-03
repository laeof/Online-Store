using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes030820231237 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c0a8987a-bb47-41ae-bdbf-d5082a0a734f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c857a515-7729-42e3-849a-b8cb68ae501e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("caf9737b-0277-4d69-82c3-8e9cb4b94acb"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("7f76237d-f0a9-4d58-80e3-0f7803ad1274"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7017ef91-1fd3-409e-99dd-94cfeeee06f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("804028a0-c0a0-4172-a36c-05a31a4c507e"));

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("4f8ff642-4ed9-4f87-8287-c6fe10b1d6d1"), new DateTime(2023, 8, 3, 9, 37, 34, 727, DateTimeKind.Utc).AddTicks(3523), false, true, "supporter", 3 },
                    { new Guid("b8c34bc5-cccc-4b24-92c8-27ce5262546c"), new DateTime(2023, 8, 3, 9, 37, 34, 724, DateTimeKind.Utc).AddTicks(7179), false, true, "admin", 1 },
                    { new Guid("c16075ab-9260-4699-880e-aae5e7bba5b4"), new DateTime(2023, 8, 3, 9, 37, 34, 727, DateTimeKind.Utc).AddTicks(3517), false, true, "manager", 2 },
                    { new Guid("f6ee87d5-b1bb-44ab-95e7-c6ff5d09fa08"), new DateTime(2023, 8, 3, 9, 37, 34, 727, DateTimeKind.Utc).AddTicks(3529), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("538854f3-f011-4147-9529-81f9305dfe15"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 3, 9, 37, 34, 724, DateTimeKind.Utc).AddTicks(7194), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$2EEFDX9bl3X+2+KpgCvy4hPG6Tqq9gkE5w74pS3sZ7PZL3FP", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("f362dae3-27f7-43df-95e7-851e2cf31ad5"), new DateTime(2023, 8, 3, 9, 37, 34, 727, DateTimeKind.Utc).AddTicks(3578), false, true, new Guid("b8c34bc5-cccc-4b24-92c8-27ce5262546c"), new Guid("538854f3-f011-4147-9529-81f9305dfe15") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4f8ff642-4ed9-4f87-8287-c6fe10b1d6d1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c16075ab-9260-4699-880e-aae5e7bba5b4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f6ee87d5-b1bb-44ab-95e7-c6ff5d09fa08"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("f362dae3-27f7-43df-95e7-851e2cf31ad5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8c34bc5-cccc-4b24-92c8-27ce5262546c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("538854f3-f011-4147-9529-81f9305dfe15"));

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Users",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("7017ef91-1fd3-409e-99dd-94cfeeee06f3"), new DateTime(2023, 8, 3, 8, 55, 33, 262, DateTimeKind.Utc).AddTicks(1775), false, true, "admin", 1 },
                    { new Guid("c0a8987a-bb47-41ae-bdbf-d5082a0a734f"), new DateTime(2023, 8, 3, 8, 55, 33, 264, DateTimeKind.Utc).AddTicks(8462), false, true, "user", 4 },
                    { new Guid("c857a515-7729-42e3-849a-b8cb68ae501e"), new DateTime(2023, 8, 3, 8, 55, 33, 264, DateTimeKind.Utc).AddTicks(8455), false, true, "supporter", 3 },
                    { new Guid("caf9737b-0277-4d69-82c3-8e9cb4b94acb"), new DateTime(2023, 8, 3, 8, 55, 33, 264, DateTimeKind.Utc).AddTicks(8448), false, true, "manager", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("804028a0-c0a0-4172-a36c-05a31a4c507e"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 3, 8, 55, 33, 262, DateTimeKind.Utc).AddTicks(1778), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$Y+LH7hCvK1vITNCtk4yLAHs62Rx4zSmCmBkIPLMMvT03QaXQ", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("7f76237d-f0a9-4d58-80e3-0f7803ad1274"), new DateTime(2023, 8, 3, 8, 55, 33, 264, DateTimeKind.Utc).AddTicks(8513), false, true, new Guid("7017ef91-1fd3-409e-99dd-94cfeeee06f3"), new Guid("804028a0-c0a0-4172-a36c-05a31a4c507e") });
        }
    }
}
