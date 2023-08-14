using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231635 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Monitors_MotinorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MotinorId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20051e27-f34e-4804-a009-e0faf45d9479"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6543b607-2cab-4cf0-9e40-751e2b0da6d1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ebe03ea0-4a4b-4f99-9273-2fcf3ecc675d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f716089-4baf-4ba0-85a8-a5673fa3668e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ca19d1e-8170-43d2-861e-cb5756ccf6c6"));

            migrationBuilder.DropColumn(
                name: "MotinorId",
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
                name: "FK_Monitors_Products_ProductId",
                table: "Monitors",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Monitors_Products_ProductId",
                table: "Monitors");

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
                name: "ProductId",
                table: "Monitors");

            migrationBuilder.AddColumn<Guid>(
                name: "MotinorId",
                table: "Products",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("20051e27-f34e-4804-a009-e0faf45d9479"), new DateTime(2023, 8, 14, 13, 33, 43, 573, DateTimeKind.Utc).AddTicks(208), false, true, "supporter", 3 },
                    { new Guid("6543b607-2cab-4cf0-9e40-751e2b0da6d1"), new DateTime(2023, 8, 14, 13, 33, 43, 573, DateTimeKind.Utc).AddTicks(214), false, true, "user", 4 },
                    { new Guid("6ca19d1e-8170-43d2-861e-cb5756ccf6c6"), new DateTime(2023, 8, 14, 13, 33, 43, 573, DateTimeKind.Utc).AddTicks(174), false, true, "admin", 1 },
                    { new Guid("ebe03ea0-4a4b-4f99-9273-2fcf3ecc675d"), new DateTime(2023, 8, 14, 13, 33, 43, 573, DateTimeKind.Utc).AddTicks(202), false, true, "manager", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("4f716089-4baf-4ba0-85a8-a5673fa3668e"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 33, 43, 573, DateTimeKind.Utc).AddTicks(216), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$SdTa2PxkLAm1vTNfzPqIL1xvEU7BjBim7t24pu6B+06eK/am", "1234567890", null, null, new Guid("6ca19d1e-8170-43d2-861e-cb5756ccf6c6") });

            migrationBuilder.CreateIndex(
                name: "IX_Products_MotinorId",
                table: "Products",
                column: "MotinorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Monitors_MotinorId",
                table: "Products",
                column: "MotinorId",
                principalTable: "Monitors",
                principalColumn: "Id");
        }
    }
}
