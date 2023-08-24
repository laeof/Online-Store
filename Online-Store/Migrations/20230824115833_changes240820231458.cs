using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes240820231458 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Carts_CartId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CartId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1efb81a2-b564-4ff1-a70b-811e4074855d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8df41fa0-1969-4dac-892d-cf940666c7e3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9dd7a10d-43ac-4156-9a5b-434b607f7aca"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e173e1f2-da88-4d86-ae8c-ab6dd6020010"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("7ec235e1-2741-4fe2-8ede-9d1925e171b3"), new DateTime(2023, 8, 24, 11, 58, 33, 258, DateTimeKind.Utc).AddTicks(5345), false, true, "admin", 1 },
                    { new Guid("b7b2f40c-6bb3-4046-9060-825cde40f9d1"), new DateTime(2023, 8, 24, 11, 58, 33, 258, DateTimeKind.Utc).AddTicks(5371), false, true, "supporter", 3 },
                    { new Guid("ce3f6a8c-8315-4ed1-bc04-99f8d282d11b"), new DateTime(2023, 8, 24, 11, 58, 33, 258, DateTimeKind.Utc).AddTicks(5377), false, true, "user", 4 },
                    { new Guid("de7e6ae9-9708-4964-a6bc-478acf6a611e"), new DateTime(2023, 8, 24, 11, 58, 33, 258, DateTimeKind.Utc).AddTicks(5363), false, true, "manager", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7ec235e1-2741-4fe2-8ede-9d1925e171b3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b7b2f40c-6bb3-4046-9060-825cde40f9d1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ce3f6a8c-8315-4ed1-bc04-99f8d282d11b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("de7e6ae9-9708-4964-a6bc-478acf6a611e"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("1efb81a2-b564-4ff1-a70b-811e4074855d"), new DateTime(2023, 8, 24, 11, 57, 44, 917, DateTimeKind.Utc).AddTicks(1088), false, true, "supporter", 3 },
                    { new Guid("8df41fa0-1969-4dac-892d-cf940666c7e3"), new DateTime(2023, 8, 24, 11, 57, 44, 917, DateTimeKind.Utc).AddTicks(1065), false, true, "admin", 1 },
                    { new Guid("9dd7a10d-43ac-4156-9a5b-434b607f7aca"), new DateTime(2023, 8, 24, 11, 57, 44, 917, DateTimeKind.Utc).AddTicks(1080), false, true, "manager", 2 },
                    { new Guid("e173e1f2-da88-4d86-ae8c-ab6dd6020010"), new DateTime(2023, 8, 24, 11, 57, 44, 917, DateTimeKind.Utc).AddTicks(1094), false, true, "user", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CartId",
                table: "Users",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Carts_CartId",
                table: "Users",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
