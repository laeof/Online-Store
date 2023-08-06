using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class change2154060823 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0e9e9cda-0b54-4b89-bacf-4c86b7a3de6b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a3d9492d-209b-4bef-9949-a0ba8ca3a68e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b14116e7-b297-45a9-8553-fe5a9b2c256b"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b846ab0-71bc-451e-bf43-677d8ebe3ab9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ff81464c-1aed-4273-8897-b1c8bfbe4a10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("077c8e79-e1a3-4fdd-9a83-99c33ac5202a"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("49ba0596-39e9-4547-b220-18fc0f49cd90"), new DateTime(2023, 8, 6, 18, 55, 43, 753, DateTimeKind.Utc).AddTicks(521), false, true, "user", 4 },
                    { new Guid("69a70af4-614f-407b-bfc1-1c5e2fae8dae"), new DateTime(2023, 8, 6, 18, 55, 43, 753, DateTimeKind.Utc).AddTicks(509), false, true, "manager", 2 },
                    { new Guid("8c8520f3-5302-40c6-aef2-51bf3f0c974f"), new DateTime(2023, 8, 6, 18, 55, 43, 750, DateTimeKind.Utc).AddTicks(4394), false, true, "admin", 1 },
                    { new Guid("cf771383-3686-49fa-b353-cfef6dad5b79"), new DateTime(2023, 8, 6, 18, 55, 43, 753, DateTimeKind.Utc).AddTicks(515), false, true, "supporter", 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("69c881d6-0296-4d74-b858-913c7a2f378b"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 18, 55, 43, 750, DateTimeKind.Utc).AddTicks(4396), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$/GCdqrR8TVy/rqKx6Lau2nX7tSSjoa1ezVLa0TLwfWMHY+MY", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("4bcbba73-e264-4c75-a3ab-91570c11375f"), new DateTime(2023, 8, 6, 18, 55, 43, 753, DateTimeKind.Utc).AddTicks(557), false, true, new Guid("8c8520f3-5302-40c6-aef2-51bf3f0c974f"), new Guid("69c881d6-0296-4d74-b858-913c7a2f378b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("49ba0596-39e9-4547-b220-18fc0f49cd90"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("69a70af4-614f-407b-bfc1-1c5e2fae8dae"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cf771383-3686-49fa-b353-cfef6dad5b79"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("4bcbba73-e264-4c75-a3ab-91570c11375f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c8520f3-5302-40c6-aef2-51bf3f0c974f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69c881d6-0296-4d74-b858-913c7a2f378b"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("0e9e9cda-0b54-4b89-bacf-4c86b7a3de6b"), new DateTime(2023, 8, 6, 18, 54, 5, 775, DateTimeKind.Utc).AddTicks(6517), false, true, "manager", 2 },
                    { new Guid("a3d9492d-209b-4bef-9949-a0ba8ca3a68e"), new DateTime(2023, 8, 6, 18, 54, 5, 775, DateTimeKind.Utc).AddTicks(6532), false, true, "user", 4 },
                    { new Guid("b14116e7-b297-45a9-8553-fe5a9b2c256b"), new DateTime(2023, 8, 6, 18, 54, 5, 775, DateTimeKind.Utc).AddTicks(6526), false, true, "supporter", 3 },
                    { new Guid("ff81464c-1aed-4273-8897-b1c8bfbe4a10"), new DateTime(2023, 8, 6, 18, 54, 5, 772, DateTimeKind.Utc).AddTicks(9836), false, true, "admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("077c8e79-e1a3-4fdd-9a83-99c33ac5202a"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 18, 54, 5, 772, DateTimeKind.Utc).AddTicks(9850), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$N3vEJ9rtDUXUeNMsfMJTmFWUulrGsh+/zuSqb1sFl/hqNP3K", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("4b846ab0-71bc-451e-bf43-677d8ebe3ab9"), new DateTime(2023, 8, 6, 18, 54, 5, 775, DateTimeKind.Utc).AddTicks(6552), false, true, new Guid("ff81464c-1aed-4273-8897-b1c8bfbe4a10"), new Guid("077c8e79-e1a3-4fdd-9a83-99c33ac5202a") });
        }
    }
}
