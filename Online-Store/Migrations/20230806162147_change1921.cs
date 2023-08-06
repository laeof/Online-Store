using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class change1921 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("70fd4302-aa59-4f31-b8e8-dd36b90610d4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7d0812b7-e0b5-40c0-81e9-beeb70bfee20"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e1fb342e-9ecb-408d-9da5-74b020fe14a0"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("ea6a193a-dd8e-46f2-ad2e-8c11b10568fc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d0101fcd-ea66-44fe-b189-49b3b4b1085b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("473aadaa-a462-4716-ba93-f9cf1d80fa24"));

            migrationBuilder.DropColumn(
                name: "Additional",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Brightness",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Contrast",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Country",
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
                name: "Guarantee",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Interfaces",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Kit",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MatrixType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ratio",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Reaction",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "MonitorCharacteristics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Diagonal = table.Column<string>(type: "text", nullable: true),
                    Frequency = table.Column<string>(type: "text", nullable: true),
                    Reaction = table.Column<string>(type: "text", nullable: true),
                    Brightness = table.Column<string>(type: "text", nullable: true),
                    MatrixType = table.Column<string>(type: "text", nullable: true),
                    Interfaces = table.Column<string>(type: "text", nullable: true),
                    Contrast = table.Column<string>(type: "text", nullable: true),
                    Ratio = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Size = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<string>(type: "text", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    Guarantee = table.Column<string>(type: "text", nullable: true),
                    Additional = table.Column<string>(type: "text", nullable: true),
                    Kit = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitorCharacteristics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonitorCharacteristics_Products_ProductId",
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
                    { new Guid("5cc0a1ba-1429-4347-a4ad-e19899163a65"), new DateTime(2023, 8, 6, 16, 21, 46, 974, DateTimeKind.Utc).AddTicks(604), false, true, "manager", 2 },
                    { new Guid("6ea8b783-339a-433c-97b2-2899a287044b"), new DateTime(2023, 8, 6, 16, 21, 46, 971, DateTimeKind.Utc).AddTicks(4564), false, true, "admin", 1 },
                    { new Guid("79ec7869-521a-466c-b86b-90954a1416b8"), new DateTime(2023, 8, 6, 16, 21, 46, 974, DateTimeKind.Utc).AddTicks(649), false, true, "supporter", 3 },
                    { new Guid("b7a14a28-2b1e-478a-ad3b-c8857f972d1b"), new DateTime(2023, 8, 6, 16, 21, 46, 974, DateTimeKind.Utc).AddTicks(656), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("72f39b98-4b20-4f56-a8d4-d8fdcf6a65a6"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 16, 21, 46, 971, DateTimeKind.Utc).AddTicks(4566), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$glm0whZXnsIDONqr1nOPNh9YURe4H941kwaAy2FexFfd2fhI", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("493ac82f-ab6d-488c-ba4f-31c837c0b3da"), new DateTime(2023, 8, 6, 16, 21, 46, 974, DateTimeKind.Utc).AddTicks(676), false, true, new Guid("6ea8b783-339a-433c-97b2-2899a287044b"), new Guid("72f39b98-4b20-4f56-a8d4-d8fdcf6a65a6") });

            migrationBuilder.CreateIndex(
                name: "IX_MonitorCharacteristics_ProductId",
                table: "MonitorCharacteristics",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonitorCharacteristics");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5cc0a1ba-1429-4347-a4ad-e19899163a65"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("79ec7869-521a-466c-b86b-90954a1416b8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b7a14a28-2b1e-478a-ad3b-c8857f972d1b"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("493ac82f-ab6d-488c-ba4f-31c837c0b3da"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ea8b783-339a-433c-97b2-2899a287044b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72f39b98-4b20-4f56-a8d4-d8fdcf6a65a6"));

            migrationBuilder.AddColumn<string>(
                name: "Additional",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Brightness",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contrast",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
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
                name: "Guarantee",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interfaces",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kit",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatrixType",
                table: "Products",
                type: "text",
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

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("70fd4302-aa59-4f31-b8e8-dd36b90610d4"), new DateTime(2023, 8, 6, 16, 13, 10, 252, DateTimeKind.Utc).AddTicks(5508), false, true, "manager", 2 },
                    { new Guid("7d0812b7-e0b5-40c0-81e9-beeb70bfee20"), new DateTime(2023, 8, 6, 16, 13, 10, 252, DateTimeKind.Utc).AddTicks(5521), false, true, "user", 4 },
                    { new Guid("d0101fcd-ea66-44fe-b189-49b3b4b1085b"), new DateTime(2023, 8, 6, 16, 13, 10, 249, DateTimeKind.Utc).AddTicks(8988), false, true, "admin", 1 },
                    { new Guid("e1fb342e-9ecb-408d-9da5-74b020fe14a0"), new DateTime(2023, 8, 6, 16, 13, 10, 252, DateTimeKind.Utc).AddTicks(5515), false, true, "supporter", 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("473aadaa-a462-4716-ba93-f9cf1d80fa24"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 16, 13, 10, 249, DateTimeKind.Utc).AddTicks(8990), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$jFdRF3G+5pPsHBKMdWaw0Vn8eIkXDcqtGifB0JRgRAfs3Yci", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("ea6a193a-dd8e-46f2-ad2e-8c11b10568fc"), new DateTime(2023, 8, 6, 16, 13, 10, 252, DateTimeKind.Utc).AddTicks(5547), false, true, new Guid("d0101fcd-ea66-44fe-b189-49b3b4b1085b"), new Guid("473aadaa-a462-4716-ba93-f9cf1d80fa24") });
        }
    }
}
