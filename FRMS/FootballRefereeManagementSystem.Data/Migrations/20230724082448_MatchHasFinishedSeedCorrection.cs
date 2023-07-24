using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class MatchHasFinishedSeedCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 24, 8, 24, 47, 646, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 24, 8, 24, 47, 646, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 24, 8, 24, 47, 646, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9fb59782-101d-474a-b954-d773df109e4b", "AQAAAAEAACcQAAAAEL+g1CUVFxxFGlSjZ0BpcV+UnkP8Olp/XOtUHk4JGyXPBc7RlUU8zisEb0NqxV9seQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6948a76-1c5d-41e1-863d-c5eb57f18b55", "AQAAAAEAACcQAAAAECJbu35t/+xWfsJBqpUirIHs1hAqUKwZUj845Grd/0cDh4RvQzfqVTNC6VTJLwK02A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69f29cf1-0f80-4d9f-9d19-4bb997f70761", "AQAAAAEAACcQAAAAEGz6YYH/DnmNr9y5Za6RWetGGRuMGb1Ln5M17namYzKfYrKvMKPEvS40GEudmhhBvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3baf9a45-b2cc-474a-9195-ca2eb9a7156a", "AQAAAAEAACcQAAAAEOaXQnXdHIQdepz9f9NQHBHCW/ubK06p0YPgTKhJYzgBWx/GzCtUFkjAQfce5nqAYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99aedc19-6c72-40fa-9ce9-72dc1c6a73de", "AQAAAAEAACcQAAAAEEKVvI2KIQR0+Q5k1Lh2JAXggoCiBAO21//WR67YuzWF2Se0RNWgisqEVPwux9nw9g==" });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 57,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 58,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 59,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 60,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 61,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 62,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 63,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 64,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 65,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 66,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 67,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 68,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 69,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 70,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 71,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 72,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 73,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 74,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 75,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 76,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 77,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 78,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 79,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 80,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 81,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 82,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 83,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 84,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 85,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 86,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 87,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 88,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 89,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 90,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 91,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 92,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 93,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 94,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 95,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 96,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 97,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 98,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 99,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 100,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 101,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 102,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 103,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 104,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 105,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 106,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 107,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 108,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 109,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 110,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 111,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 112,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 113,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 114,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 115,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 116,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 117,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 118,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 119,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 120,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 121,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 122,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 123,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 124,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 125,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 126,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 127,
                column: "HasFinished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 128,
                column: "HasFinished",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 23, 17, 22, 48, 147, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 23, 17, 22, 48, 147, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 23, 17, 22, 48, 147, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c2f16a3-3f96-42b0-a52c-0475a6d146f3", "AQAAAAEAACcQAAAAELIOWxiKGvcP/egIc0F8dfeCDjQeUtpfJV10lzO+DUBb/oIQnhyEX2RSETUCKQtcSg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "00ee8d3f-aca4-4577-ab85-569e0862eddf", "AQAAAAEAACcQAAAAEFMdnDMIUL/5XK3Le3T4LSfuZ7fbK5lwuijOu0ohfZAxnFqk+Sa6i3LXJVD74iOp4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d76d446-b7d7-4292-ab97-11b73ae73285", "AQAAAAEAACcQAAAAEHfeh2HUJmESRv10VNZWucYbAbhoRyZof8zNJNqdvJCi5YcAtxQyQEB4+ggH7wf+NA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76800a49-b066-4f09-b319-ad1b28b9aeef", "AQAAAAEAACcQAAAAEFtbBU2Z6PPKGYlaI3aP4txh4habU8qbq9ndDvDZJeq4VXjwAfZfdk2MQdeDy1clqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab6fd9bb-dd1e-41ac-a9a7-23b38fe7b4d4", "AQAAAAEAACcQAAAAEEdJ8Jr4g1hNuOzYqc3jugWRjWN7X+oAVx7rlTy8NvC5Y35ktCqDUEEv6WDqnkJodA==" });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 57,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 58,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 59,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 60,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 61,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 62,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 63,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 64,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 65,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 66,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 67,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 68,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 69,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 70,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 71,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 72,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 73,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 74,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 75,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 76,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 77,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 78,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 79,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 80,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 81,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 82,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 83,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 84,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 85,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 86,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 87,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 88,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 89,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 90,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 91,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 92,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 93,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 94,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 95,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 96,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 97,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 98,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 99,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 100,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 101,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 102,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 103,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 104,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 105,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 106,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 107,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 108,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 109,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 110,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 111,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 112,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 113,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 114,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 115,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 116,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 117,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 118,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 119,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 120,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 121,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 122,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 123,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 124,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 125,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 126,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 127,
                column: "HasFinished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 128,
                column: "HasFinished",
                value: false);
        }
    }
}
