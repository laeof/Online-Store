using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class changes140820231647 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("23f5cba4-f55f-426e-9b30-8fa8c46bc2a7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("84a19b03-659e-4025-9a4c-4ee388697f1c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ecf17ca4-8bb0-44b4-98aa-d5f90edb96fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("940735c6-ef83-45eb-bb66-cc552e022516"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c00e5a05-1f44-4e1f-aebb-8b021b1e54e3"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("ac1a85ba-2c59-41e3-9d30-47cdf64e5b89"), new DateTime(2023, 8, 14, 13, 47, 49, 565, DateTimeKind.Utc).AddTicks(5503), false, true, "manager", 2 },
                    { new Guid("ca332870-c5f0-4c8a-a486-1b61e75e22bc"), new DateTime(2023, 8, 14, 13, 47, 49, 565, DateTimeKind.Utc).AddTicks(5527), false, true, "user", 4 },
                    { new Guid("cade323c-bfe2-4412-90b7-697b178d04ea"), new DateTime(2023, 8, 14, 13, 47, 49, 565, DateTimeKind.Utc).AddTicks(5520), false, true, "supporter", 3 },
                    { new Guid("ef38c717-2756-454d-9567-053547eef7f2"), new DateTime(2023, 8, 14, 13, 47, 49, 565, DateTimeKind.Utc).AddTicks(5473), false, true, "admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("c482664c-59b9-4ac8-bf79-bb789939cc33"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 47, 49, 565, DateTimeKind.Utc).AddTicks(5529), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$RHaH6aWw8TMaDPGmDs3rIkGAGnQ6z/R/lBkm+OusebIkZTbQ", "1234567890", null, null, new Guid("ef38c717-2756-454d-9567-053547eef7f2") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ac1a85ba-2c59-41e3-9d30-47cdf64e5b89"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ca332870-c5f0-4c8a-a486-1b61e75e22bc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cade323c-bfe2-4412-90b7-697b178d04ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c482664c-59b9-4ac8-bf79-bb789939cc33"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ef38c717-2756-454d-9567-053547eef7f2"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("23f5cba4-f55f-426e-9b30-8fa8c46bc2a7"), new DateTime(2023, 8, 14, 13, 44, 16, 841, DateTimeKind.Utc).AddTicks(7284), false, true, "user", 4 },
                    { new Guid("84a19b03-659e-4025-9a4c-4ee388697f1c"), new DateTime(2023, 8, 14, 13, 44, 16, 841, DateTimeKind.Utc).AddTicks(7278), false, true, "supporter", 3 },
                    { new Guid("c00e5a05-1f44-4e1f-aebb-8b021b1e54e3"), new DateTime(2023, 8, 14, 13, 44, 16, 841, DateTimeKind.Utc).AddTicks(7239), false, true, "admin", 1 },
                    { new Guid("ecf17ca4-8bb0-44b4-98aa-d5f90edb96fa"), new DateTime(2023, 8, 14, 13, 44, 16, 841, DateTimeKind.Utc).AddTicks(7271), false, true, "manager", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region", "RoleId" },
                values: new object[] { new Guid("940735c6-ef83-45eb-bb66-cc552e022516"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 14, 13, 44, 16, 841, DateTimeKind.Utc).AddTicks(7286), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$YJciWuFhhoiYlZsKrtRV97GjtzXZ2lM4YAdiAB1DI/2ALLfE", "1234567890", null, null, new Guid("c00e5a05-1f44-4e1f-aebb-8b021b1e54e3") });
        }
    }
}
