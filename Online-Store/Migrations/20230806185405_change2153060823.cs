using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class change2153060823 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ProductId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6c0b5888-6e04-48d0-bd97-996100709b3a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a48df03f-8939-4e7f-9a17-257609338da5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f1cc170b-76b9-46ef-93f2-96c352156962"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("473c8c79-7511-44f1-8616-910e09258fad"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3a2de765-d048-46ba-a22b-c61dffe0846a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdc30893-a32d-44b5-95ef-2ed7638579b6"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Products");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Products",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("3a2de765-d048-46ba-a22b-c61dffe0846a"), new DateTime(2023, 8, 6, 18, 50, 2, 747, DateTimeKind.Utc).AddTicks(2041), false, true, "admin", 1 },
                    { new Guid("6c0b5888-6e04-48d0-bd97-996100709b3a"), new DateTime(2023, 8, 6, 18, 50, 2, 749, DateTimeKind.Utc).AddTicks(8443), false, true, "manager", 2 },
                    { new Guid("a48df03f-8939-4e7f-9a17-257609338da5"), new DateTime(2023, 8, 6, 18, 50, 2, 749, DateTimeKind.Utc).AddTicks(8452), false, true, "supporter", 3 },
                    { new Guid("f1cc170b-76b9-46ef-93f2-96c352156962"), new DateTime(2023, 8, 6, 18, 50, 2, 749, DateTimeKind.Utc).AddTicks(8472), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("cdc30893-a32d-44b5-95ef-2ed7638579b6"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 18, 50, 2, 747, DateTimeKind.Utc).AddTicks(2044), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$ewtp++YSKTrF59pk7oXIzWnTlBtn9mokFmqGgby7QupQPpNs", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("473c8c79-7511-44f1-8616-910e09258fad"), new DateTime(2023, 8, 6, 18, 50, 2, 749, DateTimeKind.Utc).AddTicks(8541), false, true, new Guid("3a2de765-d048-46ba-a22b-c61dffe0846a"), new Guid("cdc30893-a32d-44b5-95ef-2ed7638579b6") });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ProductId",
                table: "Products",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
