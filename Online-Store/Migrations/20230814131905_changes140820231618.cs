using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231618 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("55deac10-93fd-4afb-abc9-dc4106f55bee"), new DateTime(2023, 8, 14, 13, 16, 40, 200, DateTimeKind.Utc).AddTicks(2350), false, true, "manager", 2 },
                    { new Guid("8c7082ca-44eb-456e-a7a9-441013bdc8df"), new DateTime(2023, 8, 14, 13, 16, 40, 200, DateTimeKind.Utc).AddTicks(2357), false, true, "supporter", 3 },
                    { new Guid("b406906a-d3c9-4813-a3cc-22a5b32af7e3"), new DateTime(2023, 8, 14, 13, 16, 40, 200, DateTimeKind.Utc).AddTicks(2364), false, true, "user", 4 },
                    { new Guid("c8cf1233-9077-4f53-9a7a-1e7da8ba869a"), new DateTime(2023, 8, 14, 13, 16, 40, 200, DateTimeKind.Utc).AddTicks(2304), false, true, "admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("1277c693-eb61-4383-86dc-4f8a0c60f942"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 16, 40, 200, DateTimeKind.Utc).AddTicks(2366), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$othSPijMLp6IlBGUwJaYCh8dZ8/4mdcrrRFN7Wys+UqEudLF", "1234567890", null, null, new Guid("c8cf1233-9077-4f53-9a7a-1e7da8ba869a") });
        }
    }
}
