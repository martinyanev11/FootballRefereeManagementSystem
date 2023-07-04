using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsApprovedForReferee", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefereeId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"), 0, "74c835d7-2f5a-43f4-812d-4b935b19950b", "assitant_referee2@bfs.com", false, true, false, null, "ASSITANT_REFEREE2@BFS.COM", "ASSITANT_REFEREE2@BFS.COM", "AQAAAAEAACcQAAAAEFqmUmIrmgeJEWZb4G9iYZtvxiszEyVvlb8aF3Hv3bY4XvFSXeRoxTM44EkrfvS5lA==", null, false, 3, "7b7facd1-3ed7-4d6f-99b6-92bfddd2a150", false, "assitant_referee2@bfs.com" },
                    { new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"), 0, "58ed9764-56cc-4680-b9bc-af7a5b11599a", "assitant_referee1@bfs.com", false, true, false, null, "ASSITANT_REFEREE1@BFS.COM", "ASSITANT_REFEREE1@BFS.COM", "AQAAAAEAACcQAAAAEGJjdq9d7AgEM7VCSVstG7hQZqxF2zD14p06H8SAKCvTZQ3PAlADFkZRAwY6Zmz52Q==", null, false, 2, "f2a6f49d-e069-4633-93d2-c977ce283ea0", false, "assitant_referee1@bfs.com" },
                    { new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"), 0, "79f39826-6bff-465b-8b33-d463539f9351", "delegate@bfs.com", false, true, false, null, "DELEGATE@BFS.COM", "DELEGATE@BFS.COM", "AQAAAAEAACcQAAAAEJR5ft+CjBSGJp3dtPXr6Ra2tgmpAmJUh+sQzKqw3Iaywyk8YMXgCymxDIMmIdZAlw==", null, false, 4, "4b56621d-32f1-47f9-8823-aa0fec847952", false, "delegate@bfs.com" },
                    { new Guid("625400fd-3a0d-4e0a-98a3-81590eb56816"), 0, "13b6049c-7581-481d-a320-3fe29918fa8d", "random_person@gmail.com", false, false, false, null, "RANDOM_PERSON@GMAIL.COM", "RANDOM_PERSON@GMAIL.COM", "AQAAAAEAACcQAAAAEMUavFCH9PnQDRDVdxxxNOOGvENQj34M+YYvGlwMQhvI76oZD5VpOT47cNmGxiHUrA==", null, false, null, "945fd909-a485-43a6-ad33-63c7d5f4e701", false, "random_person@gmail.com" },
                    { new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"), 0, "7dce1744-5c00-4f5b-9772-f88870fbe22e", "admin@bfs.com", false, true, false, null, "ADMIN@BFS.COM", "ADMIN@BFS.COM", "AQAAAAEAACcQAAAAENFqhUSSHssUZMlhzWdje/quzdqhjO1uAWBAkAAoXh9WLXpIVg2GLeOW8qIAZYAUFw==", null, false, 5, "12c231e6-8ae9-4444-8aaf-e71ad9f1b339", false, "admin@bfs.com" },
                    { new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"), 0, "463c400f-230d-4813-89ee-7487bec51d33", "referee@bfs.com", false, true, false, null, "REFEREE@BFS.COM", "REFEREE@BFS.COM", "AQAAAAEAACcQAAAAEBF/gi3lGCp4LkxFwz75FYa6k+VOQUHzVjJ577iowrvFvHRZlZjHRSeaNX+SEOf/cw==", null, false, 1, "e1772a57-1957-44cc-97d5-3c8e170b411f", false, "referee@bfs.com" }
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
                table: "Managers",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 56, "Янко", "Павлов" },
                    { 2, 30, "Димитър", "Стефанов" },
                    { 3, 62, "Михаил", "Симеонов" },
                    { 4, 36, "Михаел", "Димов" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 1, 20, "Емил", "Иванов", null },
                    { 2, 16, "Илия", "Даниелов", null },
                    { 3, 15, "Антон", "Георгиев", null },
                    { 4, 17, "Борислав", "Павлов", null },
                    { 5, 36, "Тодор", "Николов", null },
                    { 6, 37, "Владимир", "Георгиев", null },
                    { 7, 34, "Михаел", "Калоянов", null },
                    { 8, 24, "Георгиос", "Илиев", null },
                    { 9, 20, "Румен", "Мартинов", null },
                    { 10, 24, "Алексей", "Стефанов", null },
                    { 11, 27, "Виктор", "Руменов", null },
                    { 12, 36, "Никола", "Мартинов", null },
                    { 13, 23, "Георгиос", "Илиев", null },
                    { 14, 22, "Димо", "Габриелов", null },
                    { 15, 26, "Антонио", "Янков", null },
                    { 16, 27, "Стефано", "Борисов", null },
                    { 17, 35, "Андрей", "Георгиев", null },
                    { 18, 23, "Андрей", "Габриелов", null },
                    { 19, 34, "Андрей", "Ивайлов", null },
                    { 20, 36, "Иво", "Максимов", null },
                    { 21, 30, "Роберт", "Ивов", null },
                    { 22, 33, "Мартин", "Петров", null },
                    { 23, 35, "Християн", "Алексеев", null },
                    { 24, 33, "Емил", "Димитров", null },
                    { 25, 28, "Марио", "Георгиев", null },
                    { 26, 26, "Михаил", "Стефаносов", null },
                    { 27, 20, "Мартин", "Илиев", null }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 28, 14, "Радослав", "Николов", null },
                    { 29, 22, "Калоян", "Велинов", null },
                    { 30, 28, "Георги", "Владимиров", null },
                    { 31, 24, "Любомир", "Ивайлов", null },
                    { 32, 34, "Георги", "Кристиянов", null },
                    { 33, 35, "Борислав", "Павлов", null },
                    { 34, 21, "Иво", "Василев", null },
                    { 35, 23, "Александър", "Робертов", null },
                    { 36, 17, "Георгиос", "Николов", null },
                    { 37, 34, "Васил", "Владимиров", null },
                    { 38, 21, "Румен", "Петров", null },
                    { 39, 28, "Марин", "Мартинов", null },
                    { 40, 28, "Любен", "Николов", null },
                    { 41, 28, "Радослав", "Георгиев", null },
                    { 42, 25, "Николай", "Николов", null },
                    { 43, 25, "Марин", "Радославов", null },
                    { 44, 35, "Иван", "Георгиев", null }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "Description", "End", "Start" },
                values: new object[] { 1, "2022/23", new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                    { 1, 46, new DateTime(2017, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0981899391", 0, "Янко", true, "Христов", 0, 0, 1, new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478") },
                    { 2, 29, new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "0962329705", 0, "Марин", true, "Радославов", 1, 0, 1, new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a") },
                    { 3, 53, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0991130099", 0, "Петър", true, "Николов", 1, 0, 1, new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9") },
                    { 4, 33, new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0962607874", 0, "Никола", true, "Антонов", 2, 0, 1, new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1") },
                    { 5, 19, new DateTime(2019, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0875267481", 0, "Симеон", false, "Радославов", 3, 0, 1, new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6") }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Abbreviation", "Name", "TownId" },
                values: new object[,]
                {
                    { 1, "БТВ", "Ботев", 2 },
                    { 2, "ВИХР", "Вихър", 3 },
                    { 3, "ГГНТ", "Гигант", 4 },
                    { 4, "КМОС", "Космос", 5 }
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

            migrationBuilder.InsertData(
                table: "TeamsSeasons",
                columns: new[] { "SeasonId", "TeamId", "DivisionId", "ManagerId", "Placement", "Points", "ShirtColor" },
                values: new object[,]
                {
                    { 1, 1, 4, 1, 1, 0, 11 },
                    { 1, 2, 4, 2, 1, 0, 0 },
                    { 1, 3, 4, 3, 1, 0, 4 },
                    { 1, 4, 4, 4, 1, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayTeamId", "DivisionId", "FinalResult", "FixtureTime", "HomeTeamId", "RefereeSquadId", "SeasonId", "TownId" },
                values: new object[,]
                {
                    { 1, 2, 4, null, new DateTime(2022, 9, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("5f7a5bad-da9c-4fd9-871a-483492e9bdaa"), 1, 2 },
                    { 2, 3, 4, null, new DateTime(2022, 9, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, 2 },
                    { 3, 4, 4, null, new DateTime(2022, 10, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, 2 },
                    { 4, 1, 4, null, new DateTime(2022, 10, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 1, 3 },
                    { 5, 3, 4, null, new DateTime(2022, 9, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 1, 3 },
                    { 6, 4, 4, null, new DateTime(2022, 9, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 1, 3 },
                    { 7, 1, 4, null, new DateTime(2022, 10, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 1, 4 },
                    { 8, 2, 4, null, new DateTime(2022, 10, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 1, 4 },
                    { 9, 4, 4, null, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 1, 4 },
                    { 10, 1, 4, null, new DateTime(2022, 9, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 1, 5 },
                    { 11, 2, 4, null, new DateTime(2022, 9, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 1, 5 },
                    { 12, 3, 4, null, new DateTime(2022, 10, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "PlayerTeamSeason",
                columns: new[] { "PlayerId", "SeasonId", "TeamId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 },
                    { 3, 1, 1 },
                    { 4, 1, 1 },
                    { 5, 1, 1 },
                    { 6, 1, 1 },
                    { 7, 1, 1 },
                    { 8, 1, 1 },
                    { 9, 1, 1 },
                    { 10, 1, 1 },
                    { 11, 1, 1 },
                    { 12, 1, 2 },
                    { 13, 1, 2 },
                    { 14, 1, 2 },
                    { 15, 1, 2 },
                    { 16, 1, 2 },
                    { 17, 1, 2 },
                    { 18, 1, 2 },
                    { 19, 1, 2 },
                    { 20, 1, 2 },
                    { 21, 1, 2 },
                    { 22, 1, 2 },
                    { 23, 1, 3 },
                    { 24, 1, 3 },
                    { 25, 1, 3 },
                    { 26, 1, 3 },
                    { 27, 1, 3 },
                    { 28, 1, 3 },
                    { 29, 1, 3 },
                    { 30, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "PlayerTeamSeason",
                columns: new[] { "PlayerId", "SeasonId", "TeamId" },
                values: new object[,]
                {
                    { 31, 1, 3 },
                    { 32, 1, 3 },
                    { 33, 1, 3 },
                    { 34, 1, 4 },
                    { 35, 1, 4 },
                    { 36, 1, 4 },
                    { 37, 1, 4 },
                    { 38, 1, 4 },
                    { 39, 1, 4 },
                    { 40, 1, 4 },
                    { 41, 1, 4 },
                    { 42, 1, 4 },
                    { 43, 1, 4 },
                    { 44, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "RefereesSquads",
                columns: new[] { "Id", "DelegateId", "FirstAssistantRefereeId", "MainRefereeId", "MatchId", "SecondAssistantRefereeId" },
                values: new object[] { new Guid("5f7a5bad-da9c-4fd9-871a-483492e9bdaa"), 4, 2, 1, 1, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("625400fd-3a0d-4e0a-98a3-81590eb56816"));

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 3, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 4, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 5, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 6, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 7, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 8, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 9, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 10, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 11, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 12, 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 13, 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 14, 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 15, 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 16, 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 17, 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 18, 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 19, 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 20, 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 21, 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 22, 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 23, 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 24, 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 25, 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 26, 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 27, 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 28, 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 29, 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 30, 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 31, 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 32, 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 33, 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 34, 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 35, 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 36, 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 37, 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 38, 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 39, 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 40, 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 41, 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 42, 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 43, 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 44, 1, 4 });

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
                table: "RefereesSquads",
                keyColumn: "Id",
                keyValue: new Guid("5f7a5bad-da9c-4fd9-871a-483492e9bdaa"));

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
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44);

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
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 4 });

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
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
