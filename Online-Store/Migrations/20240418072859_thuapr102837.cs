using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class thuapr102837 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c2d3762-0fb9-48e9-895e-f4be7396c0ed"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("22e8e907-19a6-4c54-944b-7e3062adf632"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("609f6fb8-f86c-485e-8591-9d71de5b1ebd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ea6a19e9-3682-48cb-a21d-a92ef97716af"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("12fd8d24-4b02-4d90-9c3c-5b8cb46b2570"), new DateTime(2024, 4, 18, 7, 28, 59, 218, DateTimeKind.Utc).AddTicks(6431), false, true, "admin", 1 },
                    { new Guid("6fa5ff99-8756-4fd2-a36b-6e198fdbda84"), new DateTime(2024, 4, 18, 7, 28, 59, 218, DateTimeKind.Utc).AddTicks(6488), false, true, "user", 4 },
                    { new Guid("ae0bf20d-f0d5-4467-9760-b3a78e13116a"), new DateTime(2024, 4, 18, 7, 28, 59, 218, DateTimeKind.Utc).AddTicks(6458), false, true, "manager", 2 },
                    { new Guid("d6f83b8a-bdf9-465b-9013-4657f703aa2b"), new DateTime(2024, 4, 18, 7, 28, 59, 218, DateTimeKind.Utc).AddTicks(6473), false, true, "supporter", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("12fd8d24-4b02-4d90-9c3c-5b8cb46b2570"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6fa5ff99-8756-4fd2-a36b-6e198fdbda84"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ae0bf20d-f0d5-4467-9760-b3a78e13116a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d6f83b8a-bdf9-465b-9013-4657f703aa2b"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("1c2d3762-0fb9-48e9-895e-f4be7396c0ed"), new DateTime(2024, 4, 18, 7, 26, 19, 378, DateTimeKind.Utc).AddTicks(5893), false, true, "admin", 1 },
                    { new Guid("22e8e907-19a6-4c54-944b-7e3062adf632"), new DateTime(2024, 4, 18, 7, 26, 19, 378, DateTimeKind.Utc).AddTicks(5949), false, true, "user", 4 },
                    { new Guid("609f6fb8-f86c-485e-8591-9d71de5b1ebd"), new DateTime(2024, 4, 18, 7, 26, 19, 378, DateTimeKind.Utc).AddTicks(5935), false, true, "supporter", 3 },
                    { new Guid("ea6a19e9-3682-48cb-a21d-a92ef97716af"), new DateTime(2024, 4, 18, 7, 26, 19, 378, DateTimeKind.Utc).AddTicks(5919), false, true, "manager", 2 }
                });
        }
    }
}
