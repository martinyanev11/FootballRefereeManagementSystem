using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class UserRefereeDivisionTownZoneDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsApprovedForReferee", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefereeId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"), 0, "a8f5a584-47dd-44da-a5d1-ed4c5ea4d115", "assitant_referee2@bfs.com", false, true, false, null, "ASSITANT_REFEREE2@BFS.COM", "SECOND AR", "AQAAAAEAACcQAAAAEDzqF1jr7ZDufWpKKpdGyQSlUKQwIhenF3jFUekQGwGqaMGM6TXXom94HBmddezDQQ==", null, false, 3, null, false, "Second AR" },
                    { new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"), 0, "792680f3-8a41-4d43-8479-f7e50969f4cc", "assitant_referee1@bfs.com", false, true, false, null, "ASSITANT_REFEREE1@BFS.COM", "FIRST AR", "AQAAAAEAACcQAAAAEIRwqiJbbmJxjQA504MWlhyC6zDbLXrZ2sWSHUX5XnZptBN7ij27jEutXwcCIdOM1Q==", null, false, 2, null, false, "First AR" },
                    { new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"), 0, "be1d66f7-e756-46a7-9317-0f313f48188e", "delegate@bfs.com", false, true, false, null, "DELEGATE@BFS.COM", "DELEGATE", "AQAAAAEAACcQAAAAEPqG8ZoLhGqttIG2N8Y0AjtHlunUHf6J4uw/oCbXBs2eqt20278s+jkwjcC0BTA4/A==", null, false, 4, null, false, "Delegate" },
                    { new Guid("d7185597-822e-42ec-92ce-8d1a8ca42691"), 0, "7c3d9218-cdf8-47b4-8998-e2bf1e4362bb", "random_person@gmail.com", false, false, false, null, "RANDOM_PERSON@GMAIL.COM", "REGULAR USER", "AQAAAAEAACcQAAAAEKNpgrIWd2hfttl45jpyvKy3UJs4pQSkXvMCUyurio1RnYsXecuR4XBVKBIvT4jjGA==", null, false, null, null, false, "Regular User" },
                    { new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"), 0, "a43192ae-6e29-489b-be51-bb354bb745ef", "admin@bfs.com", false, true, false, null, "ADMIN@BFS.COM", "ADMIN", "AQAAAAEAACcQAAAAEIr6BNNVfy5aeiQKLzDkBMHwyx7e7TtX65HaV9b6VKVU8/QrjNWWe2WGZj3z6N6AuQ==", null, false, 5, null, false, "Admin" },
                    { new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"), 0, "8adcfccf-e535-4877-9bcf-735082677da5", "referee@bfs.com", false, true, false, null, "REFEREE@BFS.COM", "MAIN REFEREE", "AQAAAAEAACcQAAAAEJ8cJzCUPsQzckXG/bgH3M0e5RuObaXElL5WW2VLVRHK+a/fVsz2ZhIkapeEJOFsVA==", null, false, 1, null, false, "Main Referee" }
                });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Първа професионална футболна лига" },
                    { 2, "Втора професионална футболна лига" },
                    { 3, "Трета аматьорска футболна лига" },
                    { 4, "„А“ областнa футболнa групa" },
                    { 5, "„Б“ областнa футболнa групa" }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Плевен Изток" },
                    { 2, "Плевен Център" },
                    { 3, "Плевен Запад" },
                    { 4, "Плевенска Област" }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Distance", "Name", "TravelCost", "TravelTime", "ZoneId" },
                values: new object[,]
                {
                    { 1, 0.0, "Плевен", 0.0, 0, 4 },
                    { 2, 0.0, "Трънчовица", 0.0, 0, 4 },
                    { 3, 0.0, "Гулянци", 0.0, 0, 4 },
                    { 4, 0.0, "Белене", 0.0, 0, 4 },
                    { 5, 0.0, "Гривица", 0.0, 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Referees",
                columns: new[] { "Id", "Age", "CareerStart", "Contact", "CurrentlyAppointedMatchesCount", "FirstName", "IsAvaliable", "LastName", "Role", "TotalMatchesOfficiated", "TownId", "UserId" },
                values: new object[,]
                {
                    { 1, 42, new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0868240908", 0, "Иво", true, "Иванов", 0, 0, 1, new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478") },
                    { 2, 21, new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0826292875", 0, "Георги", true, "Маринов", 1, 0, 1, new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a") },
                    { 3, 32, new DateTime(2017, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0966804747", 0, "Радослав", true, "Георгиев", 1, 0, 1, new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9") },
                    { 4, 54, new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0979979734", 0, "Иво", true, "Павлов", 2, 0, 1, new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1") },
                    { 5, 33, new DateTime(2017, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0822844956", 0, "Стефан", false, "Николов", 3, 0, 1, new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6") }
                });

            migrationBuilder.InsertData(
                table: "RefereesDivisions",
                columns: new[] { "DivisionId", "RefereeId", "DivisionMatchesOfficiated" },
                values: new object[,]
                {
                    { 4, 1, 0 },
                    { 5, 1, 0 },
                    { 4, 2, 0 },
                    { 5, 2, 0 },
                    { 4, 3, 0 },
                    { 5, 3, 0 },
                    { 3, 4, 0 },
                    { 4, 4, 0 },
                    { 5, 4, 0 },
                    { 1, 5, 0 },
                    { 2, 5, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7185597-822e-42ec-92ce-8d1a8ca42691"));

            migrationBuilder.DeleteData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
