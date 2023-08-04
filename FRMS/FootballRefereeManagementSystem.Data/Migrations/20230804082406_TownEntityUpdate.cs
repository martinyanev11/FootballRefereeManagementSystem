using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class TownEntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Distance",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "TravelCost",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "TravelTime",
                table: "Towns");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 8, 24, 5, 496, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 8, 24, 5, 496, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 8, 24, 5, 496, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "805ebccb-ed19-4161-b02d-04a5e1e7602f", "AQAAAAEAACcQAAAAEFebE4KB4dq0M5auArz0tXf5pDo4QQttXMy+TtnO0qPel9SXBAbS97eH+tiAXE8mqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1fb74f5-bd24-4925-b6ad-8dfe5bd9276a", "AQAAAAEAACcQAAAAEB1VXyZIlYTSYQSxcrivzXvmcDEhLekfmdGVsMF/8/WSo49DmZFdjPArzdmoKh3zBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0e5c0ed2-0a90-4594-87cd-5973feddf46d", "AQAAAAEAACcQAAAAEDwACvMFO5LWloePN1mKWykbbRshUuekngO+WPoMYxOmlraGbfhPh6k5drhMMaqqbg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19d43154-8b3b-44fd-bc87-931fc4204a7e", "AQAAAAEAACcQAAAAEJwXLM3s+6/oqwXtmUhxrcE4ApZf/KrV3eOi90BBgCWi+IkB4Ow/H7vjB5mMbhPxgA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ddbe4a19-b3fe-4dfc-aa2d-e6495499de96", "AQAAAAEAACcQAAAAEA6GKeGtVgnW6j7X6aVqDuQpBPDX1pKSFuUHdcWHK9vnrJOUV40TFNQFcPu2wzoGDQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Distance",
                table: "Towns",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                comment: "Distance to town from given location");

            migrationBuilder.AddColumn<double>(
                name: "TravelCost",
                table: "Towns",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                comment: "The cost of travel which is calculated from distance and gas price");

            migrationBuilder.AddColumn<int>(
                name: "TravelTime",
                table: "Towns",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "The time it takes to go to the town from given location");

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
        }
    }
}
