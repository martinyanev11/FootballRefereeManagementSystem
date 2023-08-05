using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class TeamSoftDeleteAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Soft delete value");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 5, 11, 17, 17, 466, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 5, 11, 17, 17, 466, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 5, 11, 17, 17, 466, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13a50e05-da4d-4700-a6f1-1e46f59e1b89", "AQAAAAEAACcQAAAAEBfJ083zw8yM4bnQdOJ4f5hFXv+R63dHEai0o+B9MhSh1cOA3sgycpiABgiwgtR/Gg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6be4576-a8a9-4305-8388-55dd2b56ed92", "AQAAAAEAACcQAAAAEDdjpolhzx2d87xBEG0PRNmn2wWl5QmWq2ryl5/VGQ5/C6KR3avMZFReIuhmI1LzTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2007953a-a8bd-4a06-9aa2-9bf0133e4fde", "AQAAAAEAACcQAAAAEFkjrI2PaPhPpqqp5jta9lR1mzL299+HaXtd1Z7kpRLhuRCISWII6kXVKhOy1sdW2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae123ac1-3624-48e6-b9d6-5fea7a820908", "AQAAAAEAACcQAAAAEGeNhvMSMP/szY8meP1nMHxFMxB1vpFSrVt9pU5GErhFpyDU3/J3JKW7XyLHK3d1jQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f019473-79bf-4204-ab2b-e550fb27f503", "AQAAAAEAACcQAAAAEB+6cdYpEPIqIBppgA1omYCOjLAxoOKM2ZcLZHlMeYFgue1Nb81a9sBdM9jr0CF9UQ==" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 18, 54, 59, 189, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 18, 54, 59, 189, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 18, 54, 59, 189, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aae0fe13-74d6-4f20-bb65-66b11ad72e96", "AQAAAAEAACcQAAAAEBNjCLdECFSdy5ImVyGcbnO5RHcj0JqYmAUKt3rIqtTfHQ8UAr7yQCCmqPhtk7YEgA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ae38e13-e4e7-4413-906d-c9811b132a1b", "AQAAAAEAACcQAAAAELxozhGWkNgWY7oIkRGaRY8ydSpOZSEbOTwwM2nDVpuzGvU5WgQVHc6bqkp3c7z+sw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9c3f800-9899-4856-836a-f1864918a3fb", "AQAAAAEAACcQAAAAECKiMHL7Cfkka+qP4k79QU5jllR3K+g7Fqt/HAdnxdNhS2rGNzwf6kDqmUyHNP5p5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70605bb2-45fa-4ddc-b79f-959d13802181", "AQAAAAEAACcQAAAAEG2O9q2UPzYylqu3c1zGjlgaaayqFji5xgmk9UjQhu65jcgIX7GzmpStzyLItShrQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aea1192f-afd8-422e-a2ac-041e024b8998", "AQAAAAEAACcQAAAAEDVzGso+dg4oKJZYzmsNIM8HXdUYFuA8ghipG3ji7McPM8z+73yl0SR9NumL4CTgiw==" });
        }
    }
}
