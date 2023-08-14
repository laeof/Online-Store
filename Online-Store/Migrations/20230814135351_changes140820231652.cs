using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231652 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_Products_Id",
                table: "Monitors");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ac1a85ba-2c59-41e3-9d30-47cdf64e5b89"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ca332870-c5f0-4c8a-a486-1b61e75e22bc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cade323c-bfe2-4412-90b7-697b178d04ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c482664c-59b9-4ac8-bf79-bb789939cc33"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ef38c717-2756-454d-9567-053547eef7f2"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Monitors",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Monitors",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNew",
                table: "Monitors",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("a5591a40-a218-443b-8462-98abc494bac6"), new DateTime(2023, 8, 14, 13, 53, 50, 969, DateTimeKind.Utc).AddTicks(3264), false, true, "user", 4 },
                    { new Guid("d2d7401d-24e2-44ce-a208-abd731890a76"), new DateTime(2023, 8, 14, 13, 53, 50, 969, DateTimeKind.Utc).AddTicks(3250), false, true, "manager", 2 },
                    { new Guid("da661b42-dd50-448a-8592-2669237d6f76"), new DateTime(2023, 8, 14, 13, 53, 50, 969, DateTimeKind.Utc).AddTicks(3257), false, true, "supporter", 3 },
                    { new Guid("f084e972-47ae-4124-bcbf-e190fbf42ebc"), new DateTime(2023, 8, 14, 13, 53, 50, 969, DateTimeKind.Utc).AddTicks(3209), false, true, "admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("74b84c9c-9079-48f2-9028-212d448991c6"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 53, 50, 969, DateTimeKind.Utc).AddTicks(3277), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$JMDpDSpf8Yl4f1nv8SiRvfxT9o675cFIvihcMCEKueqxj7rs", "1234567890", null, null, new Guid("f084e972-47ae-4124-bcbf-e190fbf42ebc") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5591a40-a218-443b-8462-98abc494bac6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d7401d-24e2-44ce-a208-abd731890a76"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("da661b42-dd50-448a-8592-2669237d6f76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74b84c9c-9079-48f2-9028-212d448991c6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f084e972-47ae-4124-bcbf-e190fbf42ebc"));

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "IsNew",
                table: "Monitors");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("ac1a85ba-2c59-41e3-9d30-47cdf64e5b89"), new DateTime(2023, 8, 14, 13, 47, 49, 565, DateTimeKind.Utc).AddTicks(5503), false, true, "manager", 2 },
                    { new Guid("ca332870-c5f0-4c8a-a486-1b61e75e22bc"), new DateTime(2023, 8, 14, 13, 47, 49, 565, DateTimeKind.Utc).AddTicks(5527), false, true, "user", 4 },
                    { new Guid("cade323c-bfe2-4412-90b7-697b178d04ea"), new DateTime(2023, 8, 14, 13, 47, 49, 565, DateTimeKind.Utc).AddTicks(5520), false, true, "supporter", 3 },
                    { new Guid("ef38c717-2756-454d-9567-053547eef7f2"), new DateTime(2023, 8, 14, 13, 47, 49, 565, DateTimeKind.Utc).AddTicks(5473), false, true, "admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("c482664c-59b9-4ac8-bf79-bb789939cc33"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 47, 49, 565, DateTimeKind.Utc).AddTicks(5529), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$RHaH6aWw8TMaDPGmDs3rIkGAGnQ6z/R/lBkm+OusebIkZTbQ", "1234567890", null, null, new Guid("ef38c717-2756-454d-9567-053547eef7f2") });

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_Products_Id",
                table: "Monitors",
                column: "Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
