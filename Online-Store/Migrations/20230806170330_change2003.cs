using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class change2003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonitorCharacteristics");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5cc0a1ba-1429-4347-a4ad-e19899163a65"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("79ec7869-521a-466c-b86b-90954a1416b8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b7a14a28-2b1e-478a-ad3b-c8857f972d1b"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("493ac82f-ab6d-488c-ba4f-31c837c0b3da"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ea8b783-339a-433c-97b2-2899a287044b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72f39b98-4b20-4f56-a8d4-d8fdcf6a65a6"));

            migrationBuilder.AddColumn<string>(
                name: "Additional",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Guarantee",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kit",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Diagonal = table.Column<string>(type: "text", nullable: false),
                    Frequency = table.Column<string>(type: "text", nullable: false),
                    Reaction = table.Column<string>(type: "text", nullable: false),
                    Brightness = table.Column<string>(type: "text", nullable: false),
                    MatrixType = table.Column<string>(type: "text", nullable: false),
                    Interfaces = table.Column<string>(type: "text", nullable: false),
                    Contrast = table.Column<string>(type: "text", nullable: false),
                    Ratio = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitors_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Monitors_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_ProductId",
                table: "Monitors",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monitors");

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

            migrationBuilder.DropColumn(
                name: "Additional",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Guarantee",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Kit",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "MonitorCharacteristics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Additional = table.Column<string>(type: "text", nullable: true),
                    Brightness = table.Column<string>(type: "text", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Contrast = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Diagonal = table.Column<string>(type: "text", nullable: true),
                    Frequency = table.Column<string>(type: "text", nullable: true),
                    Guarantee = table.Column<string>(type: "text", nullable: true),
                    Interfaces = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false),
                    Kit = table.Column<string>(type: "text", nullable: true),
                    MatrixType = table.Column<string>(type: "text", nullable: true),
                    Ratio = table.Column<string>(type: "text", nullable: true),
                    Reaction = table.Column<string>(type: "text", nullable: true),
                    Size = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitorCharacteristics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonitorCharacteristics_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("5cc0a1ba-1429-4347-a4ad-e19899163a65"), new DateTime(2023, 8, 6, 16, 21, 46, 974, DateTimeKind.Utc).AddTicks(604), false, true, "manager", 2 },
                    { new Guid("6ea8b783-339a-433c-97b2-2899a287044b"), new DateTime(2023, 8, 6, 16, 21, 46, 971, DateTimeKind.Utc).AddTicks(4564), false, true, "admin", 1 },
                    { new Guid("79ec7869-521a-466c-b86b-90954a1416b8"), new DateTime(2023, 8, 6, 16, 21, 46, 974, DateTimeKind.Utc).AddTicks(649), false, true, "supporter", 3 },
                    { new Guid("b7a14a28-2b1e-478a-ad3b-c8857f972d1b"), new DateTime(2023, 8, 6, 16, 21, 46, 974, DateTimeKind.Utc).AddTicks(656), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("72f39b98-4b20-4f56-a8d4-d8fdcf6a65a6"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 16, 21, 46, 971, DateTimeKind.Utc).AddTicks(4566), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$glm0whZXnsIDONqr1nOPNh9YURe4H941kwaAy2FexFfd2fhI", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("493ac82f-ab6d-488c-ba4f-31c837c0b3da"), new DateTime(2023, 8, 6, 16, 21, 46, 974, DateTimeKind.Utc).AddTicks(676), false, true, new Guid("6ea8b783-339a-433c-97b2-2899a287044b"), new Guid("72f39b98-4b20-4f56-a8d4-d8fdcf6a65a6") });

            migrationBuilder.CreateIndex(
                name: "IX_MonitorCharacteristics_ProductId",
                table: "MonitorCharacteristics",
                column: "ProductId");
        }
    }
}
