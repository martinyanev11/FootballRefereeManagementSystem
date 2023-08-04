using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class ManagerEntityRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamsSeasons_Managers_ManagerId",
                table: "TeamsSeasons");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_TeamsSeasons_ManagerId",
                table: "TeamsSeasons");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "TeamsSeasons");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "TeamsSeasons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "The manager of the team for specific season");

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false, comment: "Age of the person represented by this entity"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "First name of the person represented by this entity"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Last name of the person represented by this entity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                },
                comment: "Manager is the one who is in charge of team");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 16, 8, 18, 922, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 16, 8, 18, 922, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 16, 8, 18, 922, DateTimeKind.Utc).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2b00b1b-f738-44b5-aa38-1c4b073f5bc4", "AQAAAAEAACcQAAAAEAGgC316Xez7y6UqxOqWNbIj7gjLBSRxDL+Z6Uq4+PDV6yvFieGB+LxDqsPFgKp5iQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b936f9d1-3f55-486c-a863-44b8dcccf44f", "AQAAAAEAACcQAAAAEDYtJBdh59VEG3Smh5pAfaZGKllWpPtb0Z3SzGs7Sr0yUpeG4GOtMLoD3G0UBCoW+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8709cd8-dba3-4e1a-a1bc-d0fd8e98126e", "AQAAAAEAACcQAAAAEKhCifH9eCMrAL2HpvoEo7PkvsuDjcFkoC+E+6ubJ8v2nNS5SGHC7xX9qW4aQ1jqew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5062e86a-50f7-41f4-af9e-f2260d393850", "AQAAAAEAACcQAAAAEJOKq5484fFZ/q1/WopwuOPp1jdKP2ym6V0NmVbE1ETLmAZxRNVdx0lwX5sbjs3YEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64c581ea-2166-4554-8767-9f0b695fdba3", "AQAAAAEAACcQAAAAEDgqAyEI5VXG+OTUIqvx22yAU9M46AGplp5O0tg7pLgURhqbQ1B/dIW81xv0HkY2vA==" });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 2, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 3, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 4, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 5, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 6, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 7, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 8, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 9, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 10, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 11, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 12, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 13, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 14, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 15, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 16, 40, "ИмеМенъджър", "ФамилияМениджър" },
                    { 17, 40, "ИмеМенъджър", "ФамилияМениджър" }
                });

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 1 },
                column: "ManagerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 1 },
                column: "ManagerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 2 },
                column: "ManagerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 2 },
                column: "ManagerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 3 },
                column: "ManagerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 3 },
                column: "ManagerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 4 },
                column: "ManagerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 4 },
                column: "ManagerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 5 },
                column: "ManagerId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 6 },
                column: "ManagerId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 7 },
                column: "ManagerId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 8 },
                column: "ManagerId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 9 },
                column: "ManagerId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 10 },
                column: "ManagerId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 11 },
                column: "ManagerId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 12 },
                column: "ManagerId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 13 },
                column: "ManagerId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 14 },
                column: "ManagerId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 15 },
                column: "ManagerId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 16 },
                column: "ManagerId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 17 },
                column: "ManagerId",
                value: 17);

            migrationBuilder.CreateIndex(
                name: "IX_TeamsSeasons_ManagerId",
                table: "TeamsSeasons",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamsSeasons_Managers_ManagerId",
                table: "TeamsSeasons",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
