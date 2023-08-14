using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231627 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_MotinorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("001b6551-e2d4-4d6e-b204-93941f3737e0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ab46e825-1159-4df6-a44e-e758e6b08e44"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("badbc24b-9ec7-4e01-981f-9dd75c1fafad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6487aff4-8f1d-467c-a050-b35f9c040d0e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("479bfa12-35f6-403f-809c-3ea83478f442"));

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Products_MotinorId",
                table: "Product",
                newName: "IX_Product_MotinorId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("0b9bdb8d-54ed-4919-9aa8-5a3551efecfe"), new DateTime(2023, 8, 14, 13, 29, 43, 839, DateTimeKind.Utc).AddTicks(2709), false, true, "admin", 1 },
                    { new Guid("5dcad338-491d-43aa-9357-6d6c21aa77e7"), new DateTime(2023, 8, 14, 13, 29, 43, 839, DateTimeKind.Utc).AddTicks(2758), false, true, "manager", 2 },
                    { new Guid("ac5d1feb-e33f-4122-92aa-b28f9f47b825"), new DateTime(2023, 8, 14, 13, 29, 43, 839, DateTimeKind.Utc).AddTicks(2770), false, true, "user", 4 },
                    { new Guid("fa1a845b-7174-47e2-8cdf-0385342a847f"), new DateTime(2023, 8, 14, 13, 29, 43, 839, DateTimeKind.Utc).AddTicks(2765), false, true, "supporter", 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("59caff5d-0b81-4822-abd3-36d22699d6ac"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 29, 43, 839, DateTimeKind.Utc).AddTicks(2773), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$/rQH5Q9w739KIQwX3Lv4yHjvRj0rTmCT5qRtjwQchWiH0kCb", "1234567890", null, null, new Guid("0b9bdb8d-54ed-4919-9aa8-5a3551efecfe") });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Product_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Product_MotinorId",
                table: "Product",
                column: "MotinorId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Product_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Product_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Product_ProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Product_MotinorId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Product_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Product_ProductId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5dcad338-491d-43aa-9357-6d6c21aa77e7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ac5d1feb-e33f-4122-92aa-b28f9f47b825"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fa1a845b-7174-47e2-8cdf-0385342a847f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59caff5d-0b81-4822-abd3-36d22699d6ac"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0b9bdb8d-54ed-4919-9aa8-5a3551efecfe"));

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Product_MotinorId",
                table: "Products",
                newName: "IX_Products_MotinorId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("001b6551-e2d4-4d6e-b204-93941f3737e0"), new DateTime(2023, 8, 14, 13, 23, 24, 451, DateTimeKind.Utc).AddTicks(1519), false, true, "supporter", 3 },
                    { new Guid("479bfa12-35f6-403f-809c-3ea83478f442"), new DateTime(2023, 8, 14, 13, 23, 24, 451, DateTimeKind.Utc).AddTicks(1463), false, true, "admin", 1 },
                    { new Guid("ab46e825-1159-4df6-a44e-e758e6b08e44"), new DateTime(2023, 8, 14, 13, 23, 24, 451, DateTimeKind.Utc).AddTicks(1512), false, true, "manager", 2 },
                    { new Guid("badbc24b-9ec7-4e01-981f-9dd75c1fafad"), new DateTime(2023, 8, 14, 13, 23, 24, 451, DateTimeKind.Utc).AddTicks(1526), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("6487aff4-8f1d-467c-a050-b35f9c040d0e"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 23, 24, 451, DateTimeKind.Utc).AddTicks(1550), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$kCLZ8KZjbfTv3MYpn1XXLo2doWBUB8VsQxYhZd1w50a8dCDt", "1234567890", null, null, new Guid("479bfa12-35f6-403f-809c-3ea83478f442") });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_MotinorId",
                table: "Products",
                column: "MotinorId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
