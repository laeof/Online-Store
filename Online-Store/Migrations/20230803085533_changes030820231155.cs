using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes030820231155 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("81bfbde4-1e0b-4031-83d7-57b6c0f1c7d6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a388d6cd-3e88-4908-aed8-966c1bc5b976"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("eec4b9d5-efca-4a6e-b566-6a6330c6309c"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("751fd776-d504-4542-8344-214854bddba1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("250fda0b-a2b7-4b26-8530-abc88eaba9df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a938320-ffc6-47a3-8f8a-0734a633ebf7"));

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "Name");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("250fda0b-a2b7-4b26-8530-abc88eaba9df"), new DateTime(2023, 8, 3, 7, 39, 6, 856, DateTimeKind.Utc).AddTicks(3051), false, true, "admin", 1 },
                    { new Guid("81bfbde4-1e0b-4031-83d7-57b6c0f1c7d6"), new DateTime(2023, 8, 3, 7, 39, 6, 858, DateTimeKind.Utc).AddTicks(9275), false, true, "user", 4 },
                    { new Guid("a388d6cd-3e88-4908-aed8-966c1bc5b976"), new DateTime(2023, 8, 3, 7, 39, 6, 858, DateTimeKind.Utc).AddTicks(9268), false, true, "supporter", 3 },
                    { new Guid("eec4b9d5-efca-4a6e-b566-6a6330c6309c"), new DateTime(2023, 8, 3, 7, 39, 6, 858, DateTimeKind.Utc).AddTicks(9261), false, true, "manager", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "Name", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("2a938320-ffc6-47a3-8f8a-0734a633ebf7"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 3, 7, 39, 6, 856, DateTimeKind.Utc).AddTicks(3077), "Admin", null, true, false, false, true, "Max", "$HASH|V1$10000$+t/8+TlbxMO2JJBo9K7BaV7ZO8u7HrJE5zPr7/eQ7uEP1NuT", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("751fd776-d504-4542-8344-214854bddba1"), new DateTime(2023, 8, 3, 7, 39, 6, 858, DateTimeKind.Utc).AddTicks(9298), false, true, new Guid("250fda0b-a2b7-4b26-8530-abc88eaba9df"), new Guid("2a938320-ffc6-47a3-8f8a-0734a633ebf7") });
        }
    }
}
