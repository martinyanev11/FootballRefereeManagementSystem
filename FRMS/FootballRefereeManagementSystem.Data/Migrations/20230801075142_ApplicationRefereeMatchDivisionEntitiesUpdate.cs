using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class ApplicationRefereeMatchDivisionEntitiesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Referees_Towns_TownId",
                table: "Referees");

            migrationBuilder.DropIndex(
                name: "IX_Referees_TownId",
                table: "Referees");

            migrationBuilder.DropColumn(
                name: "TownId",
                table: "Referees");

            migrationBuilder.DropColumn(
                name: "SeasonRound",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Applications");

            migrationBuilder.AddColumn<int>(
                name: "ExperienceInYears",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Number of years of experience for similar job");

            migrationBuilder.AddColumn<int>(
                name: "StartingDivisionId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Дивизия, в която кандидата е подходящ да работи");

            migrationBuilder.AddColumn<int>(
                name: "StartingRole",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Позицията, която този кандидат е подходящ да заема");

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

            migrationBuilder.CreateIndex(
                name: "IX_Applications_StartingDivisionId",
                table: "Applications",
                column: "StartingDivisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Divisions_StartingDivisionId",
                table: "Applications",
                column: "StartingDivisionId",
                principalTable: "Divisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Divisions_StartingDivisionId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_StartingDivisionId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ExperienceInYears",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "StartingDivisionId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "StartingRole",
                table: "Applications");

            migrationBuilder.AddColumn<int>(
                name: "TownId",
                table: "Referees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Current town which the person represented by this entity resides");

            migrationBuilder.AddColumn<int>(
                name: "SeasonRound",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Specifies in which round of matches this particular match will be played");

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Weight of applicant");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 31, 16, 59, 31, 138, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 31, 16, 59, 31, 138, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 31, 16, 59, 31, 138, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ce2e6dc-5333-4abb-a918-d9293a081a56", "AQAAAAEAACcQAAAAEO9pw56w01QGza2Z8NU25h36+FbUAKMzEqqjqxswV/VxVMiGbAUlzs+tRgSN/TBq+Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e66d6e2-1c84-47e9-9fa9-07d18f283951", "AQAAAAEAACcQAAAAEAwNYmHTbAkUESfDXD/E/toLq1LugpKE9u4oDOGezuvj5R3wHLfGuD7k37qzPI4G0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40f4a688-da27-40d1-a797-fef387127dc7", "AQAAAAEAACcQAAAAEMRfW2rGXgP3/Iqqs403Uth2wSuKf45ulMBB+X35Q5b74gBAi0uOPkwD4NCuqPHWzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb286228-fab4-4c75-adb1-78eda0c228a5", "AQAAAAEAACcQAAAAEMEuuiyvU4+LKzV2p5qAr8Oqu/UPcPUeuY5WhtFAgNIHcbufvwFwOpZEezDW8b9z+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4feec1a5-9fc6-4e10-927d-edb8072b20f2", "AQAAAAEAACcQAAAAEN3RmyqTC4kirkM7KBqh1OQpmyYo59pf81KSzgtwRrXk/X/yX5kfch1WqrrgSTVlBA==" });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 57,
                column: "SeasonRound",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 58,
                column: "SeasonRound",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 59,
                column: "SeasonRound",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 60,
                column: "SeasonRound",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 61,
                column: "SeasonRound",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 62,
                column: "SeasonRound",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 63,
                column: "SeasonRound",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 64,
                column: "SeasonRound",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 65,
                column: "SeasonRound",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 66,
                column: "SeasonRound",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 67,
                column: "SeasonRound",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 68,
                column: "SeasonRound",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 69,
                column: "SeasonRound",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 70,
                column: "SeasonRound",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 71,
                column: "SeasonRound",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 72,
                column: "SeasonRound",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 73,
                column: "SeasonRound",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 74,
                column: "SeasonRound",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 75,
                column: "SeasonRound",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 76,
                column: "SeasonRound",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 77,
                column: "SeasonRound",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 78,
                column: "SeasonRound",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 79,
                column: "SeasonRound",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 80,
                column: "SeasonRound",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 81,
                column: "SeasonRound",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 82,
                column: "SeasonRound",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 83,
                column: "SeasonRound",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 84,
                column: "SeasonRound",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 85,
                column: "SeasonRound",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 86,
                column: "SeasonRound",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 87,
                column: "SeasonRound",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 88,
                column: "SeasonRound",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 89,
                column: "SeasonRound",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 90,
                column: "SeasonRound",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 91,
                column: "SeasonRound",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 92,
                column: "SeasonRound",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 93,
                column: "SeasonRound",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 94,
                column: "SeasonRound",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 95,
                column: "SeasonRound",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 96,
                column: "SeasonRound",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 97,
                column: "SeasonRound",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 98,
                column: "SeasonRound",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 99,
                column: "SeasonRound",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 100,
                column: "SeasonRound",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 101,
                column: "SeasonRound",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 102,
                column: "SeasonRound",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 103,
                column: "SeasonRound",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 104,
                column: "SeasonRound",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 105,
                column: "SeasonRound",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 106,
                column: "SeasonRound",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 107,
                column: "SeasonRound",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 108,
                column: "SeasonRound",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 109,
                column: "SeasonRound",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 110,
                column: "SeasonRound",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 111,
                column: "SeasonRound",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 112,
                column: "SeasonRound",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 113,
                column: "SeasonRound",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 114,
                column: "SeasonRound",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 115,
                column: "SeasonRound",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 116,
                column: "SeasonRound",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 117,
                column: "SeasonRound",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 118,
                column: "SeasonRound",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 119,
                column: "SeasonRound",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 120,
                column: "SeasonRound",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 121,
                column: "SeasonRound",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 122,
                column: "SeasonRound",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 123,
                column: "SeasonRound",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 124,
                column: "SeasonRound",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 125,
                column: "SeasonRound",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 126,
                column: "SeasonRound",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 127,
                column: "SeasonRound",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 128,
                column: "SeasonRound",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1,
                column: "TownId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2,
                column: "TownId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3,
                column: "TownId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4,
                column: "TownId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5,
                column: "TownId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Referees_TownId",
                table: "Referees",
                column: "TownId");

            migrationBuilder.AddForeignKey(
                name: "FK_Referees_Towns_TownId",
                table: "Referees",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
