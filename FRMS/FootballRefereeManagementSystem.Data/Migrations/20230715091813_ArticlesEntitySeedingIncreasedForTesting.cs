using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class ArticlesEntitySeedingIncreasedForTesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 15, 9, 18, 12, 352, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 15, 9, 18, 12, 352, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Title" },
                values: new object[] { new DateTime(2023, 7, 15, 9, 18, 12, 352, DateTimeKind.Utc).AddTicks(7006), "Решение на ДК- ОС на БФС Плевен" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedOn", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 4, new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"), "Съдийската комисия към Българския футболен съюз уведомява клубовете в системата на българското първенство, че от началото на новия спортно-състезателен сезон 2023/2024 г. в сила влизат някои промени и допълнения към Правилата на играта в съответствие с изискванията на Международния борд на футболните асоциации (IFAB).", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Utc), null, "Промени и допълнения в Правилата на играта, влизащи в сила през новия сезон" },
                    { 5, new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"), "Ръководителят на отдел „Техническо развитие“ към УЕФА Франк К. Лудолф изпрати официално писмо до Българския футболен съюз, в което изказва положителната оценка на европейската централа за програмата за развитие на обучители на треньори на БФС, която отговаря на стандартите на УЕФА.\nНа панела Jira, проведен в Нион на 5 май т.г., Българският футболен съюз и Треньорската школа по футбол са получили отлични отзиви за работата си с менторите на треньори.", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, "УЕФА с положителна оценка за развитието на обучители на треньори у нас" },
                    { 6, new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"), "Заседанието премина при следния дневен ред.\r\n\r\n1.Разглеждане на жалба от ФК „Свобода ”-Милковица за нередовен състезател.\r\n\r\nСлед като СТК се запозна с жалбата и с приложените доказателства по нея установи:\r\n\r\n1.На 09.11.2022г. по време на футболната среща от 12-кръг на „Б”ОФГ-Център  между ФК\"Спартак\"-Божурица и ФК „Свобода ”-Милковица.проведена в с.Божурица от11ч.,взема участие нередовен състезател в отбора на ФК\"Спартак\"-Божурица", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, "Протокол №8 от заседание на СТК при ОС на БФС Плевен" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61fe5477-6c9d-438b-a93a-90e4d69c0bb2", "AQAAAAEAACcQAAAAEOsH5mJc9m5QTHS40zu2D5BP0eOkkCNZWWcRWIAr7Lx41cmq6vUIAv8Zi4+qFKu5Ew==", "10f2b0c8-755c-4ca9-b256-042b1da9f99f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55b78e52-37fd-4cf9-85d3-5975c06be83c", "AQAAAAEAACcQAAAAEMwOxqu/4DfB6pPBHenUeGrzvrwo2rF1PjZ3BzuvSKufI8CVExVtEyhLi00atN6OOA==", "0b807e6e-b337-4f55-8125-3c3e037f0a28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3167d0d0-a21e-414f-b3b2-ddc0090f03ca", "AQAAAAEAACcQAAAAEEEhW2tIBUdAI6Qy3I4f6nmHd+xoW1gKIZg8krYkQRd2MFiODOYhDmfRFJen10qzPg==", "c70e3126-8ce2-43d8-867c-b9579b6718f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f49ae23-472b-4ea7-97e9-4af8931ec7e1", "AQAAAAEAACcQAAAAEFdmeooYiESSVQMuHMy/YwhSwBn3vfrAJI0I7XbM5NaRIn/HyDBTdQER/YmUPpOTuA==", "d8f2dfb8-cfd8-48c1-bb11-4068098d7adb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd3808cf-6f6e-43a4-bd90-27cd4578b806", "AQAAAAEAACcQAAAAEFRMiOTeo0ImW3slfvQ5KJhpteD0waIIYneuHhlwE5n3cdmaAKcdvPOtdmRW0BC02g==", "d23db0c9-2617-4c61-8d74-4188ad548367" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 66, "Ангел", "Алексиев" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Владимир", "Любомиров" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 44, "Даниел", "Симеонов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 66, "Петър", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Алексей", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Иво", "Тодоров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Никола", "Маринов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Габриел", "Павлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Георги", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Никола", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Антон", "Борисов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Максим", "Йорданов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Михаел", "Алексеев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Марио", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Илия", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Васил", "Велинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Иво", "Робертов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName" },
                values: new object[] { 31, "Борислав" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Радослав", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Никола", "Димов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 27, "Симеон", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Никола", "Маринов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Янко", "Владимиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "Георги", "Ангелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Стефано", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Стефанос", "Янков" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Васил", "Викторов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "LastName" },
                values: new object[] { 39, "Габриелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Роберт", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Стефанос", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Мартин", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Виктор", "Ангелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Антонио", "Алексеев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Георги", "Маринов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Християн", "Емилов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Андрей", "Алексеев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Георги", "Калоянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Николай", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Никола", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Николай", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Георги", "Илиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 16, "Антон", "Тодоров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Никола", "Емилов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Кристиян", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Радослав", "Йорданов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 15, "Християн", "Антониев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Никола", "Петров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Даниел", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 51, new DateTime(2016, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0963865547", "Максим", "Андреев" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 17, new DateTime(2017, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0982922061", "Борислав", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 37, new DateTime(2016, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0908985861", "Илиян", "Велинов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 32, new DateTime(2016, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0970328101", "Иван", "Димов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 22, new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0946742704", "Емил", "Янков" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 11, 17, 4, 28, 363, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 11, 17, 4, 28, 363, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Title" },
                values: new object[] { new DateTime(2023, 7, 11, 17, 4, 28, 363, DateTimeKind.Utc).AddTicks(2600), " Решение на ДК- ОС на БФС Плевен" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "665ba3c1-02d6-4f50-a56a-b96a15eee5b9", "AQAAAAEAACcQAAAAECF5+z9hNtDG2er2qokQlOzpL/UuTtGpzCFd9fAK4+43bdorwlfH3IjDjt7pmdIH1w==", "2e458be2-c224-4654-bd19-fddc555248e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25eee832-afa1-445b-aa43-1db564d708f1", "AQAAAAEAACcQAAAAEH3WqgRHcfJyc02dKBWecpO3H5VjJrnE1pSO0bXnC/GkY6jgBVqxCYSFhBUP3M2CLA==", "457446cc-7d39-4a38-930f-a95be83a66dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1144654-0ba4-4428-8f75-7924e0a265fc", "AQAAAAEAACcQAAAAEOXMwklgeR3klHTtf53rEXCCSp7FngEFjbRQGJiQcMEoLtAn2rPunIRsdTYPLJ+kbA==", "780ab43f-3758-464b-abf5-6bbfd59b89f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d4d3728-b2df-4159-93e3-c9bb1efe67ad", "AQAAAAEAACcQAAAAEJ9LX+KYNB+bfAFolE/LpG4L0tRrItuTZRV+lr2HV90jPchtPvQ9DpM3Ho3k/VTLzA==", "8419cdc7-bba8-439e-bf9e-5d5366837be9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e797dfd3-e67d-4cd1-8ba2-349669d3dd74", "AQAAAAEAACcQAAAAELYXZ6P/j21YOMhPT0W7MM5IfOUR9l6Wpvj5gKAI4tCPJgccWhaX4cwXOuyY/SLiUA==", "6cdb3885-54a1-40ae-a20e-fa3734ae44b0" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Александър", "Калоянов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 55, "Стефано", "Руменов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Николай", "Петров" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 64, "Марио", "Викторов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Християн", "Габриелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Борислав", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Габриел", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Димо", "Димов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Николай", "Тодоров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Димитър", "Янков" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Александър", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Борислав", "Василев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Владимир", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Георги", "Алексеев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Емил", "Маринов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Георгиос", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "Михаел", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName" },
                values: new object[] { 19, "Велин" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Роберт", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Димо", "Руменов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Стефанос", "Борисов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Александър", "Янков" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Алексей", "Ивайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Борислав", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Виктор", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Християн", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 27, "Радослав", "Петров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "LastName" },
                values: new object[] { 37, "Тодоров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Християн", "Антонов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Николай", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Велин", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Николай", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 16, "Борис", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Георгиос", "Владимиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Даниел", "Ангелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Максим", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Емил", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Никола", "Велинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Васил", "Максимов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Владимир", "Алексеев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Михаел", "Любенов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Виктор", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 16, "Даниел", "Велинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Стефанос", "Симеонов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "Георгиос", "Маринов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Виктор", "Василев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Велин", "Михайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Ивайло", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 38, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0877948508", "Йордан", "Василев" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 37, new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0877317243", "Румен", "Бориславов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 46, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0980149737", "Павел", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 44, new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0903271655", "Калоян", "Петров" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 24, new DateTime(2019, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0895482760", "Илия", "Мартинов" });
        }
    }
}
