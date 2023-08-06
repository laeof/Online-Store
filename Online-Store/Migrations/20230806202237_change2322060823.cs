using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class change2322060823 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7b26096d-7994-49a1-99aa-4dde7b27198a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("99d84225-4cec-435f-9f9f-17cf735f6c8d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1f765f4-30d7-4df5-8b50-d1236df79f35"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("5a7ce9c8-4d7e-41b7-ad5e-1f033180a9df"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("30736e29-a409-456e-b0f3-abddef63e117"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36bcfa88-6e45-429d-b3a8-2a6fa4ada72c"));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
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
                    { new Guid("1b27327b-534f-4560-a30a-c135470a0dfb"), new DateTime(2023, 8, 6, 20, 22, 37, 594, DateTimeKind.Utc).AddTicks(4119), false, true, "admin", 1 },
                    { new Guid("2c38f3ae-a3ce-47b4-a5cd-999485da9b8c"), new DateTime(2023, 8, 6, 20, 22, 37, 597, DateTimeKind.Utc).AddTicks(614), false, true, "manager", 2 },
                    { new Guid("6047e75e-a9aa-41da-8bc8-bc25e334c2ac"), new DateTime(2023, 8, 6, 20, 22, 37, 597, DateTimeKind.Utc).AddTicks(621), false, true, "supporter", 3 },
                    { new Guid("f3a16fee-c246-445e-ae86-8412b3593d55"), new DateTime(2023, 8, 6, 20, 22, 37, 597, DateTimeKind.Utc).AddTicks(627), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("00b61eeb-a4de-4779-8efa-b6b7dd941f97"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 20, 22, 37, 594, DateTimeKind.Utc).AddTicks(4123), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$4KZDb1mb2IoXf3Cg4UHQLI4INPuhSFsAp8mYrc7N73pnMoYn", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("93d1273b-d2cc-4ad3-9679-7be3284fc0f1"), new DateTime(2023, 8, 6, 20, 22, 37, 597, DateTimeKind.Utc).AddTicks(649), false, true, new Guid("1b27327b-534f-4560-a30a-c135470a0dfb"), new Guid("00b61eeb-a4de-4779-8efa-b6b7dd941f97") });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2c38f3ae-a3ce-47b4-a5cd-999485da9b8c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6047e75e-a9aa-41da-8bc8-bc25e334c2ac"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3a16fee-c246-445e-ae86-8412b3593d55"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("93d1273b-d2cc-4ad3-9679-7be3284fc0f1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1b27327b-534f-4560-a30a-c135470a0dfb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00b61eeb-a4de-4779-8efa-b6b7dd941f97"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("30736e29-a409-456e-b0f3-abddef63e117"), new DateTime(2023, 8, 6, 19, 17, 43, 490, DateTimeKind.Utc).AddTicks(1667), false, true, "admin", 1 },
                    { new Guid("7b26096d-7994-49a1-99aa-4dde7b27198a"), new DateTime(2023, 8, 6, 19, 17, 43, 492, DateTimeKind.Utc).AddTicks(7782), false, true, "user", 4 },
                    { new Guid("99d84225-4cec-435f-9f9f-17cf735f6c8d"), new DateTime(2023, 8, 6, 19, 17, 43, 492, DateTimeKind.Utc).AddTicks(7767), false, true, "manager", 2 },
                    { new Guid("b1f765f4-30d7-4df5-8b50-d1236df79f35"), new DateTime(2023, 8, 6, 19, 17, 43, 492, DateTimeKind.Utc).AddTicks(7776), false, true, "supporter", 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("36bcfa88-6e45-429d-b3a8-2a6fa4ada72c"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 19, 17, 43, 490, DateTimeKind.Utc).AddTicks(1669), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$aoBF8Wx4REqieGVIhb0VAWR2hm2YyNMGysiERho3bmjAAGGb", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("5a7ce9c8-4d7e-41b7-ad5e-1f033180a9df"), new DateTime(2023, 8, 6, 19, 17, 43, 492, DateTimeKind.Utc).AddTicks(7812), false, true, new Guid("30736e29-a409-456e-b0f3-abddef63e117"), new Guid("36bcfa88-6e45-429d-b3a8-2a6fa4ada72c") });
        }
    }
}
