using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class change2149060823 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("624db571-7b42-446b-acc4-00c20c3e4601"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("81f7b577-e6bf-4bc7-ae44-5536b464af38"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("902ac896-e761-4641-bd66-422fe0165581"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("cbee14f8-7654-4104-b898-56c76fcc5785"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8085d43e-3f47-4785-981e-4625c9f238e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cac486af-6847-4141-b6e0-c78daf11cdcc"));

            migrationBuilder.AddColumn<string>(
                name: "Brightness",
                table: "Products",
                type: "text",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Brightness",
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
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Brightness = table.Column<string>(type: "text", nullable: false),
                    Contrast = table.Column<string>(type: "text", nullable: false),
                    Diagonal = table.Column<string>(type: "text", nullable: false),
                    Frequency = table.Column<string>(type: "text", nullable: false),
                    Interfaces = table.Column<string>(type: "text", nullable: false),
                    MatrixType = table.Column<string>(type: "text", nullable: false),
                    Ratio = table.Column<string>(type: "text", nullable: false),
                    Reaction = table.Column<string>(type: "text", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Monitors_Products_ProductId",
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
                    { new Guid("624db571-7b42-446b-acc4-00c20c3e4601"), new DateTime(2023, 8, 6, 18, 43, 55, 113, DateTimeKind.Utc).AddTicks(9973), false, true, "supporter", 3 },
                    { new Guid("8085d43e-3f47-4785-981e-4625c9f238e4"), new DateTime(2023, 8, 6, 18, 43, 55, 111, DateTimeKind.Utc).AddTicks(3659), false, true, "admin", 1 },
                    { new Guid("81f7b577-e6bf-4bc7-ae44-5536b464af38"), new DateTime(2023, 8, 6, 18, 43, 55, 113, DateTimeKind.Utc).AddTicks(9965), false, true, "manager", 2 },
                    { new Guid("902ac896-e761-4641-bd66-422fe0165581"), new DateTime(2023, 8, 6, 18, 43, 55, 113, DateTimeKind.Utc).AddTicks(9979), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("cac486af-6847-4141-b6e0-c78daf11cdcc"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 18, 43, 55, 111, DateTimeKind.Utc).AddTicks(3673), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$6WUh7ddutYvUqPT8JcgtooMW2eY/PlJmlFoWUOATewywRDbQ", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("cbee14f8-7654-4104-b898-56c76fcc5785"), new DateTime(2023, 8, 6, 18, 43, 55, 113, DateTimeKind.Utc).AddTicks(9999), false, true, new Guid("8085d43e-3f47-4785-981e-4625c9f238e4"), new Guid("cac486af-6847-4141-b6e0-c78daf11cdcc") });

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_ProductId",
                table: "Monitors",
                column: "ProductId");
        }
    }
}
