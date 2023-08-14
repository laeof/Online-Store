using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820232110 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("717bbc72-1e33-4bcc-b8f7-7e80f85b7797"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8db542b9-58a5-4b6e-bb8c-0c3a13a98e4f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5de9791-26ca-42e3-895a-5e8c15c0e4bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54c610a1-1215-4a3c-aa62-d996868c71bd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ac886564-89b1-41f5-b9c2-bb8092b6fd68"));

            migrationBuilder.CreateTable(
                name: "Keyboards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Keyboards_Products_Id",
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
                    { new Guid("15dbc710-9a99-478a-b9b2-91c5abfdb776"), new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8454), false, true, "user", 4 },
                    { new Guid("281cc92a-1595-4227-a0ad-639a4aee3616"), new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8448), false, true, "supporter", 3 },
                    { new Guid("acba65e7-a2e0-4805-9f57-4880d2f9f57b"), new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8440), false, true, "manager", 2 },
                    { new Guid("b9083f5c-1cf3-4af2-975f-0d76674ce03d"), new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8391), false, true, "admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("e673aa99-cf98-4bca-82d4-296852356f1b"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8457), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$2WZTanMJNNq52zdj5cVzzcXKLeJUpOU1mSo00CNeJ39YF3P8", "1234567890", null, null, new Guid("b9083f5c-1cf3-4af2-975f-0d76674ce03d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Keyboards");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("15dbc710-9a99-478a-b9b2-91c5abfdb776"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("281cc92a-1595-4227-a0ad-639a4aee3616"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("acba65e7-a2e0-4805-9f57-4880d2f9f57b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e673aa99-cf98-4bca-82d4-296852356f1b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b9083f5c-1cf3-4af2-975f-0d76674ce03d"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("717bbc72-1e33-4bcc-b8f7-7e80f85b7797"), new DateTime(2023, 8, 14, 17, 30, 43, 801, DateTimeKind.Utc).AddTicks(7222), false, true, "manager", 2 },
                    { new Guid("8db542b9-58a5-4b6e-bb8c-0c3a13a98e4f"), new DateTime(2023, 8, 14, 17, 30, 43, 801, DateTimeKind.Utc).AddTicks(7297), false, true, "user", 4 },
                    { new Guid("a5de9791-26ca-42e3-895a-5e8c15c0e4bc"), new DateTime(2023, 8, 14, 17, 30, 43, 801, DateTimeKind.Utc).AddTicks(7231), false, true, "supporter", 3 },
                    { new Guid("ac886564-89b1-41f5-b9c2-bb8092b6fd68"), new DateTime(2023, 8, 14, 17, 30, 43, 801, DateTimeKind.Utc).AddTicks(7178), false, true, "admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("54c610a1-1215-4a3c-aa62-d996868c71bd"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 17, 30, 43, 801, DateTimeKind.Utc).AddTicks(7300), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$m7xeDL5kxtHvZX56iaBxNQ/wmQEgdzduvYdApT14/yhmwM11", "1234567890", null, null, new Guid("ac886564-89b1-41f5-b9c2-bb8092b6fd68") });
        }
    }
}
