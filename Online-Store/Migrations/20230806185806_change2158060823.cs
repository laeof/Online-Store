using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class change2158060823 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitor", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "Name", "Priority" },
                values: new object[,]
                {
                    { new Guid("8674b5a0-25a1-4011-89fc-a5731f085596"), new DateTime(2023, 8, 6, 18, 58, 6, 322, DateTimeKind.Utc).AddTicks(4482), false, true, "user", 4 },
                    { new Guid("a7724b19-a6ec-486a-a6cc-af12e913d580"), new DateTime(2023, 8, 6, 18, 58, 6, 319, DateTimeKind.Utc).AddTicks(8445), false, true, "admin", 1 },
                    { new Guid("b7655b4f-0f5f-4060-98a0-5bdcfb005b97"), new DateTime(2023, 8, 6, 18, 58, 6, 322, DateTimeKind.Utc).AddTicks(4458), false, true, "manager", 2 },
                    { new Guid("d635df0e-6bff-4af6-9b83-0598fdd5b42a"), new DateTime(2023, 8, 6, 18, 58, 6, 322, DateTimeKind.Utc).AddTicks(4476), false, true, "supporter", 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "ApiKey", "AvatarUrl", "City", "Country", "Created", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "IsEmailConfirmed", "IsNew", "LastName", "Password", "PhoneNumber", "PostalCode", "Region" },
                values: new object[] { new Guid("4ea557e2-4d61-40c0-8606-43c347529a78"), null, "xd", "../../../../img/Avatar/user.png", null, null, new DateTime(2023, 8, 6, 18, 58, 6, 319, DateTimeKind.Utc).AddTicks(8447), "Admin", "Max", null, true, false, false, true, "Admin", "$HASH|V1$10000$z6h9hkSK5eWALtl8B/XmU6RNAH022rR+0+tGJcx+2PzsMub4", "1234567890", null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Created", "IsDeleted", "IsNew", "RoleId", "UserId" },
                values: new object[] { new Guid("f3d33462-424b-4384-b9c2-5d9729f407e9"), new DateTime(2023, 8, 6, 18, 58, 6, 322, DateTimeKind.Utc).AddTicks(4503), false, true, new Guid("a7724b19-a6ec-486a-a6cc-af12e913d580"), new Guid("4ea557e2-4d61-40c0-8606-43c347529a78") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monitor");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8674b5a0-25a1-4011-89fc-a5731f085596"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b7655b4f-0f5f-4060-98a0-5bdcfb005b97"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d635df0e-6bff-4af6-9b83-0598fdd5b42a"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("f3d33462-424b-4384-b9c2-5d9729f407e9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a7724b19-a6ec-486a-a6cc-af12e913d580"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ea557e2-4d61-40c0-8606-43c347529a78"));

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
    }
}
