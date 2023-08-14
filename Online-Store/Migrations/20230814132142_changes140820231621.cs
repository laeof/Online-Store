using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231621 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ProductId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2938fc55-02ce-4c29-9f30-b7e01c839229"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d3c00d91-c922-4470-8ca7-c1689e21791b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc6a7a7b-0aea-4a19-9379-3f2ccaff845a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9151bf61-2028-4692-9a5a-feb5b6f00957"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7f310742-4297-4003-991d-ca36474c75ec"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("5406fe34-40ff-43f5-a909-e74643d30300"), new DateTime(2023, 8, 14, 13, 21, 42, 240, DateTimeKind.Utc).AddTicks(3748), false, true, "admin", 1 },
                    { new Guid("544e33a8-4ac7-4859-8cbe-a47c8b10eeb7"), new DateTime(2023, 8, 14, 13, 21, 42, 240, DateTimeKind.Utc).AddTicks(3801), false, true, "supporter", 3 },
                    { new Guid("922a408b-51d9-4f92-8e91-3065e2e8bbb9"), new DateTime(2023, 8, 14, 13, 21, 42, 240, DateTimeKind.Utc).AddTicks(3806), false, true, "user", 4 },
                    { new Guid("f79b082f-b368-419e-865c-0e04a77914bb"), new DateTime(2023, 8, 14, 13, 21, 42, 240, DateTimeKind.Utc).AddTicks(3794), false, true, "manager", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("1a55ccf5-48d6-4b97-aaef-6369102589bb"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 21, 42, 240, DateTimeKind.Utc).AddTicks(3809), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$u44OpZNF7Nr2wfinBZmGKwH689ZH6hFddSOKLi8S2L3YORgS", "1234567890", null, null, new Guid("5406fe34-40ff-43f5-a909-e74643d30300") });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ProductId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("544e33a8-4ac7-4859-8cbe-a47c8b10eeb7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("922a408b-51d9-4f92-8e91-3065e2e8bbb9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f79b082f-b368-419e-865c-0e04a77914bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a55ccf5-48d6-4b97-aaef-6369102589bb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5406fe34-40ff-43f5-a909-e74643d30300"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("2938fc55-02ce-4c29-9f30-b7e01c839229"), new DateTime(2023, 8, 14, 13, 19, 4, 881, DateTimeKind.Utc).AddTicks(4713), false, true, "user", 4 },
                    { new Guid("7f310742-4297-4003-991d-ca36474c75ec"), new DateTime(2023, 8, 14, 13, 19, 4, 881, DateTimeKind.Utc).AddTicks(4655), false, true, "admin", 1 },
                    { new Guid("d3c00d91-c922-4470-8ca7-c1689e21791b"), new DateTime(2023, 8, 14, 13, 19, 4, 881, DateTimeKind.Utc).AddTicks(4700), false, true, "manager", 2 },
                    { new Guid("dc6a7a7b-0aea-4a19-9379-3f2ccaff845a"), new DateTime(2023, 8, 14, 13, 19, 4, 881, DateTimeKind.Utc).AddTicks(4707), false, true, "supporter", 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("9151bf61-2028-4692-9a5a-feb5b6f00957"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 19, 4, 881, DateTimeKind.Utc).AddTicks(4716), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$aB9cHW4n2wRgPHvtARrmxQC6Sc7g75FgYmWRWeV+QcgXxKR1", "1234567890", null, null, new Guid("7f310742-4297-4003-991d-ca36474c75ec") });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId");
        }
    }
}
