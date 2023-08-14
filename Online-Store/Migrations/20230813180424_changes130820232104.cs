using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes130820232104 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

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
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc3ab337-f058-4a57-b347-a05b026a0d8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7658ae8e-0ab8-4408-a9bb-f37147b2437b"));

            migrationBuilder.AddColumn<Guid>(
                name: "RoleId",
                table: "Users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("0d9b1d4d-b526-413c-9107-7dc43fb71301"), new DateTime(2023, 8, 13, 18, 4, 24, 417, DateTimeKind.Utc).AddTicks(8509), false, true, "manager", 2 },
                    { new Guid("38151a62-bc6c-4077-a44c-2933306f8d75"), new DateTime(2023, 8, 13, 18, 4, 24, 417, DateTimeKind.Utc).AddTicks(8462), false, true, "admin", 1 },
                    { new Guid("617ed921-823b-4547-b84d-74395f98b504"), new DateTime(2023, 8, 13, 18, 4, 24, 417, DateTimeKind.Utc).AddTicks(8526), false, true, "supporter", 3 },
                    { new Guid("b338bdb9-8e49-4472-82a3-a73967ef30f9"), new DateTime(2023, 8, 13, 18, 4, 24, 417, DateTimeKind.Utc).AddTicks(8533), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("99fe6bc3-5a7a-4e40-8c6b-64d1180e578f"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 13, 18, 4, 24, 417, DateTimeKind.Utc).AddTicks(8535), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$pcreQMO4YcBxaqPvq0e2BQaafaA1zADyijvj1sc8Hz9ukXs2", "1234567890", null, null, new Guid("38151a62-bc6c-4077-a44c-2933306f8d75") });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0d9b1d4d-b526-413c-9107-7dc43fb71301"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("617ed921-823b-4547-b84d-74395f98b504"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b338bdb9-8e49-4472-82a3-a73967ef30f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99fe6bc3-5a7a-4e40-8c6b-64d1180e578f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("38151a62-bc6c-4077-a44c-2933306f8d75"));

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }
    }
}
