using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231616 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monitor");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0d9b1d4d-b526-413c-9107-7dc43fb71301"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("617ed921-823b-4547-b84d-74395f98b504"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b338bdb9-8e49-4472-82a3-a73967ef30f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99fe6bc3-5a7a-4e40-8c6b-64d1180e578f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("38151a62-bc6c-4077-a44c-2933306f8d75"));

            migrationBuilder.AddColumn<string>(
                name: "Brightness",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contrast",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Diagonal",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Frequency",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interfaces",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatrixType",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Products",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ratio",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reaction",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("55deac10-93fd-4afb-abc9-dc4106f55bee"), new DateTime(2023, 8, 14, 13, 16, 40, 200, DateTimeKind.Utc).AddTicks(2350), false, true, "manager", 2 },
                    { new Guid("8c7082ca-44eb-456e-a7a9-441013bdc8df"), new DateTime(2023, 8, 14, 13, 16, 40, 200, DateTimeKind.Utc).AddTicks(2357), false, true, "supporter", 3 },
                    { new Guid("b406906a-d3c9-4813-a3cc-22a5b32af7e3"), new DateTime(2023, 8, 14, 13, 16, 40, 200, DateTimeKind.Utc).AddTicks(2364), false, true, "user", 4 },
                    { new Guid("c8cf1233-9077-4f53-9a7a-1e7da8ba869a"), new DateTime(2023, 8, 14, 13, 16, 40, 200, DateTimeKind.Utc).AddTicks(2304), false, true, "admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("1277c693-eb61-4383-86dc-4f8a0c60f942"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 16, 40, 200, DateTimeKind.Utc).AddTicks(2366), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$othSPijMLp6IlBGUwJaYCh8dZ8/4mdcrrRFN7Wys+UqEudLF", "1234567890", null, null, new Guid("c8cf1233-9077-4f53-9a7a-1e7da8ba869a") });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ProductId",
                table: "Products",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ProductId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("55deac10-93fd-4afb-abc9-dc4106f55bee"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c7082ca-44eb-456e-a7a9-441013bdc8df"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b406906a-d3c9-4813-a3cc-22a5b32af7e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1277c693-eb61-4383-86dc-4f8a0c60f942"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c8cf1233-9077-4f53-9a7a-1e7da8ba869a"));

            migrationBuilder.DropColumn(
                name: "Brightness",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Contrast",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Diagonal",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Interfaces",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MatrixType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ratio",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Reaction",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Monitor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Brightness = table.Column<string>(type: "text", nullable: false),
                    Contrast = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Diagonal = table.Column<string>(type: "text", nullable: false),
                    Frequency = table.Column<string>(type: "text", nullable: false),
                    Interfaces = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false),
                    MatrixType = table.Column<string>(type: "text", nullable: false),
                    Ratio = table.Column<string>(type: "text", nullable: false),
                    Reaction = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitor_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("0d9b1d4d-b526-413c-9107-7dc43fb71301"), new DateTime(2023, 8, 13, 18, 4, 24, 417, DateTimeKind.Utc).AddTicks(8509), false, true, "manager", 2 },
                    { new Guid("38151a62-bc6c-4077-a44c-2933306f8d75"), new DateTime(2023, 8, 13, 18, 4, 24, 417, DateTimeKind.Utc).AddTicks(8462), false, true, "admin", 1 },
                    { new Guid("617ed921-823b-4547-b84d-74395f98b504"), new DateTime(2023, 8, 13, 18, 4, 24, 417, DateTimeKind.Utc).AddTicks(8526), false, true, "supporter", 3 },
                    { new Guid("b338bdb9-8e49-4472-82a3-a73967ef30f9"), new DateTime(2023, 8, 13, 18, 4, 24, 417, DateTimeKind.Utc).AddTicks(8533), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("99fe6bc3-5a7a-4e40-8c6b-64d1180e578f"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 13, 18, 4, 24, 417, DateTimeKind.Utc).AddTicks(8535), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$pcreQMO4YcBxaqPvq0e2BQaafaA1zADyijvj1sc8Hz9ukXs2", "1234567890", null, null, new Guid("38151a62-bc6c-4077-a44c-2933306f8d75") });

            migrationBuilder.CreateIndex(
                name: "IX_Monitor_ProductId",
                table: "Monitor",
                column: "ProductId");
        }
    }
}
