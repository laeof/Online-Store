using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231638 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Monitors_MonitorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MonitorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Monitors_ProductId",
                table: "Monitors");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("160cecdf-12e1-4ead-b552-0e11014dfff3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2fa78f09-5f28-4070-bfa9-24d0573e7295"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b134f51a-eb60-4641-bd4e-2295c8afc188"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54d46861-da45-4237-9b3b-e3b8edffab8d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("05588cba-366a-414a-950c-dcf5006859f8"));

            migrationBuilder.DropColumn(
                name: "MonitorId",
                table: "Products");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("05588cba-366a-414a-950c-dcf5006859f8"), new DateTime(2023, 8, 14, 13, 35, 10, 337, DateTimeKind.Utc).AddTicks(5759), false, true, "admin", 1 },
                    { new Guid("160cecdf-12e1-4ead-b552-0e11014dfff3"), new DateTime(2023, 8, 14, 13, 35, 10, 337, DateTimeKind.Utc).AddTicks(5789), false, true, "manager", 2 },
                    { new Guid("2fa78f09-5f28-4070-bfa9-24d0573e7295"), new DateTime(2023, 8, 14, 13, 35, 10, 337, DateTimeKind.Utc).AddTicks(5796), false, true, "supporter", 3 },
                    { new Guid("b134f51a-eb60-4641-bd4e-2295c8afc188"), new DateTime(2023, 8, 14, 13, 35, 10, 337, DateTimeKind.Utc).AddTicks(5803), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("54d46861-da45-4237-9b3b-e3b8edffab8d"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 35, 10, 337, DateTimeKind.Utc).AddTicks(5805), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$CEpcBdIghK8TIvvkFBA1255it/DlRyjbiyloNZutIRWeeerO", "1234567890", null, null, new Guid("05588cba-366a-414a-950c-dcf5006859f8") });

            migrationBuilder.CreateIndex(
                name: "IX_Products_MonitorId",
                table: "Products",
                column: "MonitorId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_ProductId",
                table: "Monitors",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Monitors_MonitorId",
                table: "Products",
                column: "MonitorId",
                principalTable: "Monitors",
                principalColumn: "Id");
        }
    }
}
