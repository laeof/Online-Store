using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231633 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Brightness",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Contrast",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Diagonal",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Interfaces",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "MatrixType",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Ratio",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Reaction",
                table: "Product");

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

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Diagonal = table.Column<string>(type: "text", nullable: false),
                    Frequency = table.Column<string>(type: "text", nullable: false),
                    Reaction = table.Column<string>(type: "text", nullable: false),
                    Brightness = table.Column<string>(type: "text", nullable: false),
                    MatrixType = table.Column<string>(type: "text", nullable: false),
                    Interfaces = table.Column<string>(type: "text", nullable: false),
                    Contrast = table.Column<string>(type: "text", nullable: false),
                    Ratio = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitors_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("20051e27-f34e-4804-a009-e0faf45d9479"), new DateTime(2023, 8, 14, 13, 33, 43, 573, DateTimeKind.Utc).AddTicks(208), false, true, "supporter", 3 },
                    { new Guid("6543b607-2cab-4cf0-9e40-751e2b0da6d1"), new DateTime(2023, 8, 14, 13, 33, 43, 573, DateTimeKind.Utc).AddTicks(214), false, true, "user", 4 },
                    { new Guid("6ca19d1e-8170-43d2-861e-cb5756ccf6c6"), new DateTime(2023, 8, 14, 13, 33, 43, 573, DateTimeKind.Utc).AddTicks(174), false, true, "admin", 1 },
                    { new Guid("ebe03ea0-4a4b-4f99-9273-2fcf3ecc675d"), new DateTime(2023, 8, 14, 13, 33, 43, 573, DateTimeKind.Utc).AddTicks(202), false, true, "manager", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("4f716089-4baf-4ba0-85a8-a5673fa3668e"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 33, 43, 573, DateTimeKind.Utc).AddTicks(216), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$SdTa2PxkLAm1vTNfzPqIL1xvEU7BjBim7t24pu6B+06eK/am", "1234567890", null, null, new Guid("6ca19d1e-8170-43d2-861e-cb5756ccf6c6") });

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
                name: "FK_Products_Monitors_MotinorId",
                table: "Products",
                column: "MotinorId",
                principalTable: "Monitors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_Products_Monitors_MotinorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20051e27-f34e-4804-a009-e0faf45d9479"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6543b607-2cab-4cf0-9e40-751e2b0da6d1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ebe03ea0-4a4b-4f99-9273-2fcf3ecc675d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f716089-4baf-4ba0-85a8-a5673fa3668e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ca19d1e-8170-43d2-861e-cb5756ccf6c6"));

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

            migrationBuilder.AddColumn<string>(
                name: "Brightness",
                table: "Product",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contrast",
                table: "Product",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Diagonal",
                table: "Product",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Product",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Frequency",
                table: "Product",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interfaces",
                table: "Product",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatrixType",
                table: "Product",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ratio",
                table: "Product",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reaction",
                table: "Product",
                type: "text",
                nullable: true);

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
    }
}
