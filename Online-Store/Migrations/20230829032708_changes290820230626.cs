using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes290820230626 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("09bae7e8-1a44-4157-adb7-70ab0518e9a1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("10c0e58b-bb87-4b49-ae4e-3b327a9a64b1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7729119f-3632-48c9-b151-0e41a1a8f894"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4186f17-48bc-4fd4-848c-abca4e538899"));

            migrationBuilder.AddColumn<int>(
                name: "ClickCount",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("16ee029e-5892-4576-a391-9fb65fb9db72"), new DateTime(2023, 8, 29, 3, 27, 8, 823, DateTimeKind.Utc).AddTicks(5797), false, true, "manager", 2 },
                    { new Guid("1aba357d-bdc7-40d2-91b2-838b28c498c9"), new DateTime(2023, 8, 29, 3, 27, 8, 823, DateTimeKind.Utc).AddTicks(5804), false, true, "supporter", 3 },
                    { new Guid("212f0b4c-34a3-462a-848d-7a5cc6ec1f09"), new DateTime(2023, 8, 29, 3, 27, 8, 823, DateTimeKind.Utc).AddTicks(5810), false, true, "user", 4 },
                    { new Guid("2abd6cc5-1229-4334-9812-cf5ba84cef3c"), new DateTime(2023, 8, 29, 3, 27, 8, 823, DateTimeKind.Utc).AddTicks(5778), false, true, "admin", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("16ee029e-5892-4576-a391-9fb65fb9db72"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1aba357d-bdc7-40d2-91b2-838b28c498c9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("212f0b4c-34a3-462a-848d-7a5cc6ec1f09"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2abd6cc5-1229-4334-9812-cf5ba84cef3c"));

            migrationBuilder.DropColumn(
                name: "ClickCount",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("09bae7e8-1a44-4157-adb7-70ab0518e9a1"), new DateTime(2023, 8, 27, 9, 14, 53, 50, DateTimeKind.Utc).AddTicks(1880), false, true, "supporter", 3 },
                    { new Guid("10c0e58b-bb87-4b49-ae4e-3b327a9a64b1"), new DateTime(2023, 8, 27, 9, 14, 53, 50, DateTimeKind.Utc).AddTicks(1858), false, true, "admin", 1 },
                    { new Guid("7729119f-3632-48c9-b151-0e41a1a8f894"), new DateTime(2023, 8, 27, 9, 14, 53, 50, DateTimeKind.Utc).AddTicks(1873), false, true, "manager", 2 },
                    { new Guid("a4186f17-48bc-4fd4-848c-abca4e538899"), new DateTime(2023, 8, 27, 9, 14, 53, 50, DateTimeKind.Utc).AddTicks(1886), false, true, "user", 4 }
                });
        }
    }
}
