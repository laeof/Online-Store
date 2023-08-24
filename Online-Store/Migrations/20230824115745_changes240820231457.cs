using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes240820231457 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("21f8650a-fbe8-462f-b20e-22d732e45242"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("558363bb-a69a-4e08-8d25-f718330caed6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6dd9caca-5f2b-4049-aaf1-de337a549409"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("eba6c703-0ef7-494d-864a-cc377fbc3dfa"));

            migrationBuilder.AddColumn<Guid>(
                name: "CartId",
                table: "Users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "ProductImages",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Carts_CartId",
                table: "Users",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Carts_CartId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CartId",
                table: "Users");

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

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "ProductImages",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("21f8650a-fbe8-462f-b20e-22d732e45242"), new DateTime(2023, 8, 15, 20, 25, 1, 534, DateTimeKind.Utc).AddTicks(1619), false, true, "user", 4 },
                    { new Guid("558363bb-a69a-4e08-8d25-f718330caed6"), new DateTime(2023, 8, 15, 20, 25, 1, 534, DateTimeKind.Utc).AddTicks(1613), false, true, "supporter", 3 },
                    { new Guid("6dd9caca-5f2b-4049-aaf1-de337a549409"), new DateTime(2023, 8, 15, 20, 25, 1, 534, DateTimeKind.Utc).AddTicks(1568), false, true, "admin", 1 },
                    { new Guid("eba6c703-0ef7-494d-864a-cc377fbc3dfa"), new DateTime(2023, 8, 15, 20, 25, 1, 534, DateTimeKind.Utc).AddTicks(1606), false, true, "manager", 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
