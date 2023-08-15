using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class _initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("387d2965-c0c1-4b60-8749-25726f7cd7e3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3e4e14d2-d06d-4a86-a4a3-0559d04b32a1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6fefc210-2c06-40a7-bdc0-b4a5fd3c4ef5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d060f38a-e647-458b-b6cb-439093f6e629"));

            migrationBuilder.AddColumn<Guid>(
                name: "KeyboardId",
                table: "ProductImages",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MonitorId",
                table: "ProductImages",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Additional",
                table: "Monitors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Monitors",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Monitors",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Monitors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Monitors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Monitors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Guarantee",
                table: "Monitors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kit",
                table: "Monitors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Monitors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Monitors",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SalePrice",
                table: "Monitors",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Monitors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Monitors",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Additional",
                table: "Keyboards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Keyboards",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Keyboards",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Keyboards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Keyboards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Keyboards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Guarantee",
                table: "Keyboards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kit",
                table: "Keyboards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Keyboards",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Keyboards",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SalePrice",
                table: "Keyboards",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Keyboards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Keyboards",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("1ad61d25-273f-41ce-bd25-07e72ce128d5"), new DateTime(2023, 8, 15, 18, 31, 20, 193, DateTimeKind.Utc).AddTicks(9477), false, true, "manager", 2 },
                    { new Guid("37921872-f9e0-4ea9-b27a-6359bcce9ed7"), new DateTime(2023, 8, 15, 18, 31, 20, 193, DateTimeKind.Utc).AddTicks(9491), false, true, "user", 4 },
                    { new Guid("80364476-fa5e-42d4-add0-fd9e6cdadfc4"), new DateTime(2023, 8, 15, 18, 31, 20, 193, DateTimeKind.Utc).AddTicks(9485), false, true, "supporter", 3 },
                    { new Guid("959b89a0-034a-49a6-a156-f4e2653cbf83"), new DateTime(2023, 8, 15, 18, 31, 20, 193, DateTimeKind.Utc).AddTicks(9428), false, true, "admin", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_KeyboardId",
                table: "ProductImages",
                column: "KeyboardId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_MonitorId",
                table: "ProductImages",
                column: "MonitorId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_CategoryId",
                table: "Monitors",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Keyboards_CategoryId",
                table: "Keyboards",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Keyboards_Categories_CategoryId",
                table: "Keyboards",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_Categories_CategoryId",
                table: "Monitors",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Keyboards_KeyboardId",
                table: "ProductImages",
                column: "KeyboardId",
                principalTable: "Keyboards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Monitors_MonitorId",
                table: "ProductImages",
                column: "MonitorId",
                principalTable: "Monitors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Keyboards_Categories_CategoryId",
                table: "Keyboards");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_Categories_CategoryId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Keyboards_KeyboardId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Monitors_MonitorId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_KeyboardId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_MonitorId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_Monitors_CategoryId",
                table: "Monitors");

            migrationBuilder.DropIndex(
                name: "IX_Keyboards_CategoryId",
                table: "Keyboards");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1ad61d25-273f-41ce-bd25-07e72ce128d5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("37921872-f9e0-4ea9-b27a-6359bcce9ed7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("80364476-fa5e-42d4-add0-fd9e6cdadfc4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("959b89a0-034a-49a6-a156-f4e2653cbf83"));

            migrationBuilder.DropColumn(
                name: "KeyboardId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "MonitorId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "Additional",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Guarantee",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Kit",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Additional",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "Guarantee",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "Kit",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Keyboards");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("387d2965-c0c1-4b60-8749-25726f7cd7e3"), new DateTime(2023, 8, 15, 18, 30, 36, 451, DateTimeKind.Utc).AddTicks(6248), false, true, "user", 4 },
                    { new Guid("3e4e14d2-d06d-4a86-a4a3-0559d04b32a1"), new DateTime(2023, 8, 15, 18, 30, 36, 451, DateTimeKind.Utc).AddTicks(6242), false, true, "supporter", 3 },
                    { new Guid("6fefc210-2c06-40a7-bdc0-b4a5fd3c4ef5"), new DateTime(2023, 8, 15, 18, 30, 36, 451, DateTimeKind.Utc).AddTicks(6234), false, true, "manager", 2 },
                    { new Guid("d060f38a-e647-458b-b6cb-439093f6e629"), new DateTime(2023, 8, 15, 18, 30, 36, 451, DateTimeKind.Utc).AddTicks(6179), false, true, "admin", 1 }
                });
        }
    }
}
