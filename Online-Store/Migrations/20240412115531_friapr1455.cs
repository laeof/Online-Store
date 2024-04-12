using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class friapr1455 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1760f7b2-f863-42c4-b2a3-37a12c879d23"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("46942283-36a2-4744-9731-6e21cd3fc7bb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("58a8b824-8483-4046-84c7-585e3b0f58d8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c207360b-6477-40b4-8405-0d0e68d69389"));

            migrationBuilder.AddColumn<int>(
                name: "IntValue",
                table: "Characteristics",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Characteristics",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Characteristics",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("883d0598-47e3-46ae-bddf-8f648623bc35"), new DateTime(2024, 4, 12, 11, 55, 31, 162, DateTimeKind.Utc).AddTicks(8445), false, true, "manager", 2 },
                    { new Guid("9ca42dfd-c4a7-43e0-9396-d15f212bd7b7"), new DateTime(2024, 4, 12, 11, 55, 31, 162, DateTimeKind.Utc).AddTicks(8418), false, true, "admin", 1 },
                    { new Guid("c9fe2242-f12e-454f-b37f-a3254a18d5e5"), new DateTime(2024, 4, 12, 11, 55, 31, 162, DateTimeKind.Utc).AddTicks(8475), false, true, "user", 4 },
                    { new Guid("d835dae1-de92-44c1-a298-68f7c2102057"), new DateTime(2024, 4, 12, 11, 55, 31, 162, DateTimeKind.Utc).AddTicks(8461), false, true, "supporter", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("883d0598-47e3-46ae-bddf-8f648623bc35"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9ca42dfd-c4a7-43e0-9396-d15f212bd7b7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c9fe2242-f12e-454f-b37f-a3254a18d5e5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d835dae1-de92-44c1-a298-68f7c2102057"));

            migrationBuilder.DropColumn(
                name: "IntValue",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Characteristics");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("1760f7b2-f863-42c4-b2a3-37a12c879d23"), new DateTime(2024, 4, 12, 11, 51, 24, 707, DateTimeKind.Utc).AddTicks(8520), false, true, "admin", 1 },
                    { new Guid("46942283-36a2-4744-9731-6e21cd3fc7bb"), new DateTime(2024, 4, 12, 11, 51, 24, 707, DateTimeKind.Utc).AddTicks(8616), false, true, "user", 4 },
                    { new Guid("58a8b824-8483-4046-84c7-585e3b0f58d8"), new DateTime(2024, 4, 12, 11, 51, 24, 707, DateTimeKind.Utc).AddTicks(8585), false, true, "manager", 2 },
                    { new Guid("c207360b-6477-40b4-8405-0d0e68d69389"), new DateTime(2024, 4, 12, 11, 51, 24, 707, DateTimeKind.Utc).AddTicks(8601), false, true, "supporter", 3 }
                });
        }
    }
}
