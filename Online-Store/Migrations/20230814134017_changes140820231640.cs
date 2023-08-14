using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231640 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_Products_ProductId",
                table: "Monitors");

            migrationBuilder.DropIndex(
                name: "IX_Monitors_ProductId",
                table: "Monitors");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1a7626ce-3dbe-49e9-b35b-018b42877439"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a806f3d3-6c59-4c79-bc09-80c606a8e809"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ea02d3f4-fb2e-4e7d-8786-66e0ea67df8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0a3b4bc-69fc-4d3e-a316-8bb9970c6778"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("06cb6f77-7a73-487f-b4dd-185867d12867"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Monitors");

            migrationBuilder.AddColumn<Guid>(
                name: "MonitorId",
                table: "Products",
                type: "uuid",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_MonitorId",
                table: "Products",
                column: "MonitorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Monitors_MonitorId",
                table: "Products",
                column: "MonitorId",
                principalTable: "Monitors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Monitors_MonitorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MonitorId",
                table: "Products");

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

            migrationBuilder.DropColumn(
                name: "MonitorId",
                table: "Products");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Monitors",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("06cb6f77-7a73-487f-b4dd-185867d12867"), new DateTime(2023, 8, 14, 13, 38, 36, 366, DateTimeKind.Utc).AddTicks(5407), false, true, "admin", 1 },
                    { new Guid("1a7626ce-3dbe-49e9-b35b-018b42877439"), new DateTime(2023, 8, 14, 13, 38, 36, 366, DateTimeKind.Utc).AddTicks(5450), false, true, "user", 4 },
                    { new Guid("a806f3d3-6c59-4c79-bc09-80c606a8e809"), new DateTime(2023, 8, 14, 13, 38, 36, 366, DateTimeKind.Utc).AddTicks(5443), false, true, "supporter", 3 },
                    { new Guid("ea02d3f4-fb2e-4e7d-8786-66e0ea67df8d"), new DateTime(2023, 8, 14, 13, 38, 36, 366, DateTimeKind.Utc).AddTicks(5436), false, true, "manager", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("d0a3b4bc-69fc-4d3e-a316-8bb9970c6778"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 38, 36, 366, DateTimeKind.Utc).AddTicks(5452), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$ouXU1dwZ+Xx2VmHHo4Ru9YAgws1sO5J/f0gZIsJ0aXdWFFHv", "1234567890", null, null, new Guid("06cb6f77-7a73-487f-b4dd-185867d12867") });

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_ProductId",
                table: "Monitors",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_Products_ProductId",
                table: "Monitors",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
