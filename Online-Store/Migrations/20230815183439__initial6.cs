using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class _initial6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Product_ProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Product_ProductId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6c98687f-008d-4279-a4da-316fa5dc32cf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b77862e6-a7a5-409f-b2cd-58b2d1f0e7e6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e6437fbb-3bd5-4969-a5f5-ef47fb31e015"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f748a07c-8828-4109-a2e2-1747221eeef5"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "CartItems");

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
                    { new Guid("013f13f7-c0f0-455e-aa61-63d22ae4546e"), new DateTime(2023, 8, 15, 18, 34, 39, 237, DateTimeKind.Utc).AddTicks(6010), false, true, "supporter", 3 },
                    { new Guid("935374c3-4b6c-4eb2-9b83-4a371be922e4"), new DateTime(2023, 8, 15, 18, 34, 39, 237, DateTimeKind.Utc).AddTicks(5947), false, true, "admin", 1 },
                    { new Guid("a108bf07-bda6-4cc1-bb9d-f78778182356"), new DateTime(2023, 8, 15, 18, 34, 39, 237, DateTimeKind.Utc).AddTicks(6017), false, true, "user", 4 },
                    { new Guid("d0e2db51-a80e-4ed1-8309-429760a4e17e"), new DateTime(2023, 8, 15, 18, 34, 39, 237, DateTimeKind.Utc).AddTicks(5994), false, true, "manager", 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Product_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Product_ProductId",
                table: "ProductImages");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("013f13f7-c0f0-455e-aa61-63d22ae4546e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("935374c3-4b6c-4eb2-9b83-4a371be922e4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a108bf07-bda6-4cc1-bb9d-f78778182356"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d0e2db51-a80e-4ed1-8309-429760a4e17e"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "ProductImages",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "CartItems",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("6c98687f-008d-4279-a4da-316fa5dc32cf"), new DateTime(2023, 8, 15, 18, 33, 40, 934, DateTimeKind.Utc).AddTicks(7428), false, true, "user", 4 },
                    { new Guid("b77862e6-a7a5-409f-b2cd-58b2d1f0e7e6"), new DateTime(2023, 8, 15, 18, 33, 40, 934, DateTimeKind.Utc).AddTicks(7415), false, true, "manager", 2 },
                    { new Guid("e6437fbb-3bd5-4969-a5f5-ef47fb31e015"), new DateTime(2023, 8, 15, 18, 33, 40, 934, DateTimeKind.Utc).AddTicks(7422), false, true, "supporter", 3 },
                    { new Guid("f748a07c-8828-4109-a2e2-1747221eeef5"), new DateTime(2023, 8, 15, 18, 33, 40, 934, DateTimeKind.Utc).AddTicks(7369), false, true, "admin", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Product_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Product_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
