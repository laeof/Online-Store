using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes03082023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Name",
                table: "Roles",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Roles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Roles");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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
    }
}
