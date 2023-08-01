using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class ApplicationAndDivisionEntitesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasCar",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "HasDriverLicense",
                table: "Applications");

            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "Divisions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Number representing the difficulty level of a division compared to the rest");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 1, 10, 11, 57, 638, DateTimeKind.Utc).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 1, 10, 11, 57, 638, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 1, 10, 11, 57, 638, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e3f4e20-2b41-44de-8011-9b9d0db62f69", "AQAAAAEAACcQAAAAEHOWzhsYK6oYFZ3HJP/zL3h+laTker9OkhN4F0Hg1RWPodkfoO2RHaxvJ8KE/h3CRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ef21f89-a20a-455c-bafe-ffc636a19047", "AQAAAAEAACcQAAAAEEkW+s57Docc23W46A0Ic8zujzJCGrEDhcNLd4yrhn7sFPVeZnrMTNXlcpGrPd0L2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b36994c2-028e-492e-83a7-a8d59f57dcac", "AQAAAAEAACcQAAAAEF+0KkmRVBXDhSNUNVsYSRny9KPG/XjGRpPhlCQauuNyIPwBfgervpiiwraSnrsoAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a83ff2f-f5bd-4814-88ae-95f740983ae0", "AQAAAAEAACcQAAAAEIikjw/7OT+SZNq8OQgkkxTAvCy9rtAOsvpMkyZoNRQhca9v8ZWxEU1llVcuY/gHag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72387e79-0da5-454d-8309-5c85af0d13cf", "AQAAAAEAACcQAAAAEJ5S5oMIZ0Mmzmm1cxXmNvhZRCj420ArD7oJmJOm4p6zpv3Nc8K+ZNEO/XSNWH38eA==" });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Difficulty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Difficulty",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Difficulty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Difficulty",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Difficulty",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Divisions");

            migrationBuilder.AddColumn<bool>(
                name: "HasCar",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Does applicant have car");

            migrationBuilder.AddColumn<bool>(
                name: "HasDriverLicense",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Does applicant have drivers license");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 1, 7, 51, 41, 435, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 1, 7, 51, 41, 435, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 1, 7, 51, 41, 435, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd6fec9e-7488-4dfd-943d-91cd3f40bef7", "AQAAAAEAACcQAAAAEJSAVkocEShWO9u3p3c0QcgKjmQn3WvqCvWFrn4nvcFDuheEvb7qkIO653aHujTAOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82fef500-39b9-48ce-a56d-d9a30d3e633d", "AQAAAAEAACcQAAAAELl9wUctqyjtfc0VHzSZhINgnt5h+GMGdvVIWQ+78eD8JfzDrwFqL0mOhi9vFKHOdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d0110962-0112-4411-9527-eec67d20ac6e", "AQAAAAEAACcQAAAAEBrRshZ0P09lXHdvaAHfC/776wrZqBhcb8joyCWVJnMfHFvirqXksHVGMAjNBYwJ+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "441357dc-36ef-45db-adbf-baa4cefe52fe", "AQAAAAEAACcQAAAAEFCFZ7YyU/VpavCxTkR1diLimVV2vyWY1sOiCwA6rM/qq/5F0BSs/1KufdT3q+ZP+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9a0de47-704b-4422-ac1e-dc8509154b43", "AQAAAAEAACcQAAAAEARxCznImfZT1O8EiatmF+ARC14g4iQUunv993RdwkW7n6iXcTzOttfd3D6Dm5UXrA==" });
        }
    }
}
