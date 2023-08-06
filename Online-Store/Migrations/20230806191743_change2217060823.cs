using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class change2217060823 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("59611280-da08-4d0d-9889-928f934d284f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8835d46c-0255-4394-9b15-411efeab5219"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5a63740-8f6a-4aed-88e4-0518b956abbe"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("0145f37c-5737-425f-b883-f1ce788d58f8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("814b2c56-2729-4b72-85d9-9092d83d1212"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66a9ab71-4f70-4958-938a-97cbd732a522"));

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
                    Diagonal = table.Column<string>(type: "text", nullable: false),
                    Frequency = table.Column<string>(type: "text", nullable: false),
                    Reaction = table.Column<string>(type: "text", nullable: false),
                    Brightness = table.Column<string>(type: "text", nullable: false),
                    MatrixType = table.Column<string>(type: "text", nullable: false),
                    Interfaces = table.Column<string>(type: "text", nullable: false),
                    Contrast = table.Column<string>(type: "text", nullable: false),
                    Ratio = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Monitor_ProductId",
                table: "Monitor",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monitor");

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
                    { new Guid("59611280-da08-4d0d-9889-928f934d284f"), new DateTime(2023, 8, 6, 19, 14, 48, 389, DateTimeKind.Utc).AddTicks(4878), false, true, "supporter", 3 },
                    { new Guid("814b2c56-2729-4b72-85d9-9092d83d1212"), new DateTime(2023, 8, 6, 19, 14, 48, 386, DateTimeKind.Utc).AddTicks(8362), false, true, "admin", 1 },
                    { new Guid("8835d46c-0255-4394-9b15-411efeab5219"), new DateTime(2023, 8, 6, 19, 14, 48, 389, DateTimeKind.Utc).AddTicks(4867), false, true, "manager", 2 },
                    { new Guid("e5a63740-8f6a-4aed-88e4-0518b956abbe"), new DateTime(2023, 8, 6, 19, 14, 48, 389, DateTimeKind.Utc).AddTicks(4884), false, true, "user", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("66a9ab71-4f70-4958-938a-97cbd732a522"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 19, 14, 48, 386, DateTimeKind.Utc).AddTicks(8364), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$VFXlTCmQoTpNHrON0gJbkd6PehAXlPfk+91ybGDMh0tMxGuS", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("0145f37c-5737-425f-b883-f1ce788d58f8"), new DateTime(2023, 8, 6, 19, 14, 48, 389, DateTimeKind.Utc).AddTicks(4906), false, true, new Guid("814b2c56-2729-4b72-85d9-9092d83d1212"), new Guid("66a9ab71-4f70-4958-938a-97cbd732a522") });
        }
    }
}
