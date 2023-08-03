using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class DivisionSoftDeleteFlagAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Divisions",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Soft delete value");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Articles",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Soft delete value",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Soft delete value");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 56, 34, 380, DateTimeKind.Utc).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 56, 34, 380, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 56, 34, 380, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79bb6536-6fdc-4369-9a11-c965d8270ce5", "AQAAAAEAACcQAAAAEPZ9gmkaHk3lr+Bu7SQllpaFuTNxUyfdLfwswsWshk0Tfhw7QDK3U7FCTvSLZa+8Pg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2792b231-3070-4c33-86bf-1d5f74ad083e", "AQAAAAEAACcQAAAAENqsm5fOjKZf+lzU+/2XsWS4CUZP4DKJ5C+dX2WLURb1XdRo48rudoMeOMGinX8oDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71746e5e-b407-480c-ad99-2e484da5eb38", "AQAAAAEAACcQAAAAENDzjs6kTSlvfOO9unscTh0EJdyR3ALBvkjNzU1SwhaxfBLXVMom9iKuZrbpYgEiTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "051b2627-08d1-4bc1-b659-9b22be03b842", "AQAAAAEAACcQAAAAEIw6BqptSKl2JiLd/+GsOKOPeMFgrvLoXHWcez9YFSorP0NZ14ItQkSC9mdRIvbFOQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "221cd059-f916-4331-9a6f-fffe8a8aa155", "AQAAAAEAACcQAAAAEHWh+7NskQVmv2pBMZcw6Il67osipjjh+Z2shTa1H1nSLCKbWha/5+pfrGZW+PiIcg==" });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Divisions");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Articles",
                type: "bit",
                nullable: false,
                comment: "Soft delete value",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Soft delete value");

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
        }
    }
}
