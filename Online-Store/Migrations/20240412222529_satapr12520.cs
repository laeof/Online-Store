using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class satapr12520 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("018b867a-9f3e-4667-bf32-cb8a208a54b4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("50ae03ff-6620-476f-ab11-f3b060b39b74"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6a8d4c38-2d9a-4fd2-8611-2fce1d79da47"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c107ab1a-3203-4d5e-a27a-435c19babda9"));

            migrationBuilder.DropColumn(
                name: "IntValue",
                table: "Characteristics");

            migrationBuilder.AddColumn<double>(
                name: "DoubleValue",
                table: "Characteristics",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryParentId",
                table: "Categories",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("089bac27-49a2-40e0-a233-0d0d67e8dc07"), new DateTime(2024, 4, 12, 22, 25, 28, 938, DateTimeKind.Utc).AddTicks(3257), false, true, "user", 4 },
                    { new Guid("6f3bdc1d-2aca-4413-a0f6-d96c074d8e4d"), new DateTime(2024, 4, 12, 22, 25, 28, 938, DateTimeKind.Utc).AddTicks(3242), false, true, "supporter", 3 },
                    { new Guid("85869f81-3472-4e18-8fa9-b74df9bd7086"), new DateTime(2024, 4, 12, 22, 25, 28, 938, DateTimeKind.Utc).AddTicks(3227), false, true, "manager", 2 },
                    { new Guid("a56e701e-5864-46c6-92bc-13e36bb894d5"), new DateTime(2024, 4, 12, 22, 25, 28, 938, DateTimeKind.Utc).AddTicks(3195), false, true, "admin", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("089bac27-49a2-40e0-a233-0d0d67e8dc07"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6f3bdc1d-2aca-4413-a0f6-d96c074d8e4d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("85869f81-3472-4e18-8fa9-b74df9bd7086"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a56e701e-5864-46c6-92bc-13e36bb894d5"));

            migrationBuilder.DropColumn(
                name: "DoubleValue",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "CategoryParentId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "IntValue",
                table: "Characteristics",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("018b867a-9f3e-4667-bf32-cb8a208a54b4"), new DateTime(2024, 4, 12, 16, 4, 20, 574, DateTimeKind.Utc).AddTicks(7618), false, true, "manager", 2 },
                    { new Guid("50ae03ff-6620-476f-ab11-f3b060b39b74"), new DateTime(2024, 4, 12, 16, 4, 20, 574, DateTimeKind.Utc).AddTicks(7652), false, true, "user", 4 },
                    { new Guid("6a8d4c38-2d9a-4fd2-8611-2fce1d79da47"), new DateTime(2024, 4, 12, 16, 4, 20, 574, DateTimeKind.Utc).AddTicks(7636), false, true, "supporter", 3 },
                    { new Guid("c107ab1a-3203-4d5e-a27a-435c19babda9"), new DateTime(2024, 4, 12, 16, 4, 20, 574, DateTimeKind.Utc).AddTicks(7591), false, true, "admin", 1 }
                });
        }
    }
}
