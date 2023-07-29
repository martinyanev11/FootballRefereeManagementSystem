using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class ApplicationEntityUpdateAndRegistrationTokenRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Applications_ApplicationId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "RegistrationTokens");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ApplicationId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "AspNetUsers");

            // --------------------------------------------------------
            // Custom fix of the Migration:
            // PROBLEM: Cannot alter Id column because of this error:
            // "To change the IDENTITY property of a column, the column needs to be dropped and recreated."

            //migrationBuilder.AlterColumn<Guid>(
            //    name: "Id",
            //    table: "Applications",
            //    type: "uniqueidentifier",
            //    nullable: false,
            //    comment: "Primary key",
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldComment: "Primary key")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            // SOLUTION:
            // 1. Add a new Guid column that will replace Id
            migrationBuilder.AddColumn<Guid>(
                name: "NewId",
                table: "Applications",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Primary key");

            // 3. Drop the old PK constraint
            migrationBuilder.DropPrimaryKey(
                name: "PK_Applications",
                table: "Applications");

            // 4. Drop the old Id column
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Applications");

            // 5. Rename the "NewId" column to "Id"
            migrationBuilder.RenameColumn(
                name: "NewId",
                table: "Applications",
                newName: "Id");

            // 6. Add the new PK constraint
            migrationBuilder.AddPrimaryKey(
                name: "PK_Applications",
                table: "Applications",
                column: "Id");
            // --------------------------------------------------------

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date and time of creation");

            migrationBuilder.AddColumn<bool>(
                name: "IsRegistered",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "To track for one-time use for registration");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 29, 18, 25, 34, 78, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 29, 18, 25, 34, 78, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 29, 18, 25, 34, 78, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30aee5b8-0b32-464f-8832-4b9a57b3b417", "AQAAAAEAACcQAAAAEFeYpM5wzDrZYiJRag0dfsLKLaXF6UT+ESa1PnPz6BPRLVCTtpZMf7zbtiPL8zYw6Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5063a0bb-e142-43a4-b1de-22a89db2515d", "AQAAAAEAACcQAAAAEMD8RH9paXr8r4xxdS+L/wssDtM3+OKXEsTdqE5Z9GajDzbaeH146HPkOQzxk7JqzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ad205e4-5162-4910-a5ec-bb50ad08ae3a", "AQAAAAEAACcQAAAAEGioUum7f+VdCNzT+8Ha98ixuaSX1uUdeqwttqHDQn1xBSaT9TEDhmP+2jmEiO+Bww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d366c9ac-69d8-4eeb-818d-654bf0a54476", "AQAAAAEAACcQAAAAEGsVyVjaR+K3IBWPLZ5gA55Kk4+yQT2oJfTO7cKhI8bCjfXEVCPKbIA+qASnRTOrrw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b09d693-07b2-4bb7-ac01-b3620a6b2c7c", "AQAAAAEAACcQAAAAENxrQqSz85dqMITyW4NqkMa7uVD1l5UI0PfIXTxLk3orcxmv9IGwciI/X5W0jowWiQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "IsRegistered",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Applications");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                comment: "Application for becoming a referee");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Applications",
                type: "int",
                nullable: false,
                comment: "Primary key",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Primary key")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "RegistrationTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of creation of the token"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Email of user who is invited to register"),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false, comment: "To track for one-time use of this token")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationTokens", x => x.Id);
                },
                comment: "Registration token is used to restrict register of random users");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 26, 15, 58, 2, 443, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 26, 15, 58, 2, 443, DateTimeKind.Utc).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 26, 15, 58, 2, 443, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f8b14e8-7c71-4ff0-a509-c5dfe568ec44", "AQAAAAEAACcQAAAAEInvjWtZNIlE7LNQEkMgV9W+ShKl93oYpPnk1KdW6rZR+yV2XbVNVgtgxVAM5L6wGw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5b2a109-6d3f-4fdf-9683-08bdfa3239e7", "AQAAAAEAACcQAAAAEL9V0uv09YSKgcBlHIR0nQUeBjWtfETcvBwi5tSWG0Nq8Dieu7cd87EEFLLR66Lsmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46eff332-d210-4d38-a12f-1c74a99ec865", "AQAAAAEAACcQAAAAEF95oqwS84Ez6zhB3o6z2koOdr0L957fXhYB0OHCWy6miQmUmH+80hNwCAv1qEnZUQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56ca116a-0986-424a-b132-7d3054f71736", "AQAAAAEAACcQAAAAEBPqIsBM5zmcEhNdfU8hK0yZA5OyKKpkHKn1B5BIvJm87hqcqlg98ZSVcUZFBxkf6g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a4b13cac-4329-4591-a809-044f022444a0", "AQAAAAEAACcQAAAAEFwTVDQZHifTh6TQ6f6qTEeQiHMYPeXmdXVPF+eYBe6MvifHYKmiHoe39r7K9of7Iw==" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ApplicationId",
                table: "AspNetUsers",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Applications_ApplicationId",
                table: "AspNetUsers",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id");
        }
    }
}
