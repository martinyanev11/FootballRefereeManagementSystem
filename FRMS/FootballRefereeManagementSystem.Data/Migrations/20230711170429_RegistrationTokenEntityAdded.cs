using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class RegistrationTokenEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Applications",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                comment: "Contact number of applicant",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldComment: "Contact number of applicant");

            migrationBuilder.CreateTable(
                name: "RegistrationTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Email of user who is invited to register"),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false, comment: "To track for one-time use of this token"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of creation of the token")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationTokens", x => x.Id);
                },
                comment: "Registration token is used to restrict register of random users");

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
                column: "CreatedOn",
                value: new DateTime(2023, 7, 11, 17, 4, 28, 363, DateTimeKind.Utc).AddTicks(2600));

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
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Димитър", "Янков" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Александър", "Димитров" });

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
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 16, "Емил", "Маринов" });

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
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Велин", "Георгиев" });

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
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Християн", "Димитров" });

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
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Румен", "Тодоров" });

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
                columns: new[] { "Age", "CareerStart", "Contact", "LastName" },
                values: new object[] { 37, new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0877317243", "Бориславов" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationTokens");

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Applications",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                comment: "Contact number of applicant",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "Contact number of applicant");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 9, 15, 15, 34, 296, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 9, 15, 15, 34, 296, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 9, 15, 15, 34, 296, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0e7730d-8bbc-49c5-b372-b5c1d95cd6b1", "AQAAAAEAACcQAAAAEBm1kBAXAdwcPa3WTnrv6ut3BWrU9I1CbhB4WRQ668LlpR5dkTqaC8gLfpkdEsIF8g==", "d9d4a3ae-e2cf-461f-87be-bfd5e8916610" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f750afed-31fa-439b-beeb-48695cfac05e", "AQAAAAEAACcQAAAAELox/fPjfK/LE3vzwXei6YpoLHtYaeMaCm6Dbu8OfFykcnb2lS0x+fg2w6iH64AwwA==", "96152c00-0d5d-46fc-bbdd-e79fc3612488" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3480b03-650e-4e21-be22-3daca3b65fd3", "AQAAAAEAACcQAAAAEEn5VsZfLJBZ53XhQ0dJrWyF1LykAB/v5c1WjRE44S4ojAa6IlTn4LmCtOn4THenJw==", "5d63b155-4707-4391-829a-1b694316201a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b58a3fe1-f4a9-4809-9882-5504b1c4beb0", "AQAAAAEAACcQAAAAED/u6tD7myzyOWT8aUF2cJOW0MF4dJ/qF684Fxma/1uC/os19VxtvRTOO7nGajEd0g==", "b4d9d406-489c-42a5-9478-286325b05d7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d7c3ce0-0ed0-42a4-96f9-bc378c4d5131", "AQAAAAEAACcQAAAAEBhcBqSwGIlMk/mgOWDPsH1GphojuS0J8sxtHSb7ygnydeJsfvsJjs2MRPkEzIiWwg==", "7af4648c-65d8-4e85-8f43-69a2d24262d0" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 66, "Радослав", "Александров" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 64, "Стефан", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 61, "Кристиян", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Андрей", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Николай", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Марин", "Любомиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Румен", "Емилов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Тодор", "Тодоров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Радослав", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Георги", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Стефан", "Любомиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Любомир", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Иво", "Стефаносов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Андрей", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Роберт", "Бориславов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Любен", "Калоянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Тодор", "Бориславов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Кристиян", "Антонов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Петър", "Стефаносов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Симеон", "Любенов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Димитър", "Бориславов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Антонио", "Емилов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 15, "Максим", "Ивов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 27, "Стефано", "Любомиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Тодор", "Борисов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Кристиян", "Антонов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Никола", "Тодоров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Михаел", "Михайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Даниел", "Викторов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "Димитър", "Любомиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Стефано", "Маринов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Христо", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Никола", "Калоянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Габриел", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Андрей", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Ивайло", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Иван", "Михаелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Иван", "Емилов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Иван", "Ивайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Петър", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Янко", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 27, "Стефан", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 15, "Румен", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Владимир", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Георги", "Стефаносов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Симеон", "Андреев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Васил", "Янков" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Алексей", "Христов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 39, new DateTime(2016, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0904574649", "Велин", "Христов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CareerStart", "Contact", "LastName" },
                values: new object[] { 31, new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0883424773", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 22, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914061450", "Емил", "Михайлов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 35, new DateTime(2017, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0883173027", "Роберт", "Христов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 46, new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "0928774600", "Христо", "Даниелов" });
        }
    }
}
