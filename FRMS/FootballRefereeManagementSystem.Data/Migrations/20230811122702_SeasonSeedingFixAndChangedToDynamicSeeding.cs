using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class SeasonSeedingFixAndChangedToDynamicSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 11, 12, 27, 0, 676, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 11, 12, 27, 0, 676, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 11, 12, 27, 0, 676, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07951c8a-1950-4119-88c7-ae7850e0e3dd", "AQAAAAEAACcQAAAAEISqmuC8WbcRbf/ilFYySD/VMuV6Bc6/rELLPleb8fzYc5kgMbMzJvRiUJnUrrugKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b06262b0-07ea-4159-b7e1-08d99f8fb6e8", "AQAAAAEAACcQAAAAEJNtEBCg+xuF73AfnblbMQRcsuvHqgu4gXeFtK4eAUDIfNPta6Blp10HRsUOsms7Pg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd211f7a-17cf-4e24-bb2f-6424dfa0c38a", "AQAAAAEAACcQAAAAEJXlXJbNTGOFoC6xZhfj8J+NhOeB4hGQTTTgzYQ+Yv0ihFslux6DUBdv53Tt+Vtxpg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d8f0404-df81-4142-b4a3-06beda6965e1", "AQAAAAEAACcQAAAAEOM2RfDiUorxRJsoUF/d5Iavd8NJ9CJpwipU+fLPvCk/KS9I8A79KwORrZtDc8AbFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1889d05-33c2-425d-86b7-2a295681e1e5", "AQAAAAEAACcQAAAAELi75DrNl/ZIIkghLJUahoK7ab03Yqt6Ce2kmu0QBg7rPdeZrD0qZUlfYGiv3/6LZg==" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Борис", "Даниелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Стефанос", "Михаелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Кристиян", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "Илиян", "Емилов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Роберт", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Павел", "Максимов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Борис", "Антониев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Любен", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Илиян", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Стефан", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 27, "Стефанос", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Стефанос", "Михайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Християн", "Любенов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Михаел", "Викторов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 15, "Михаел", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Борислав", "Маринов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Стефано", "Руменов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Георги", "Илиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Илия", "Калоянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Андрей", "Любенов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Алексей", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Димитър", "Михайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Петър", "Бориславов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Илия", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Стефанос", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Георги", "Янков" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Илиян", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Даниел", "Руменов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ивайло", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Велин", "Даниелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Кристиян", "Йорданов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Никола", "Илиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Калоян", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Стефанос", "Ангелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Емил", "Тодоров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Димитър", "Ивайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Павел", "Михаелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Стефан", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Александър", "Ангелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Михаил", "Михайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Михаил", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Марин", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Антонио", "Ангелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Емил", "Антониев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Андрей", "Емилов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Димо", "Йорданов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Румен", "Руменов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Стефанос", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Максим", "Даниелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Антон", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Ивайло", "Борисов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Любомир", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Георги", "Михайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Никола", "Йорданов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Илиян", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Стефан", "Алексиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 27, "Александър", "Ангелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Радослав", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 16, "Алексей", "Робертов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Димо", "Викторов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Стефанос", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Роберт", "Робертов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Даниел", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Георгиос", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Мартин", "Борисов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Алексей", "Михайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Иво", "Стефаносов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Иво", "Димов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ивайло", "Антониев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Стефан", "Велинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Християн", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Борис", "Ангелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Габриел", "Ивов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Димо", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Йордан", "Ивов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Емил", "Павлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Кристиян", "Илиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Радослав", "Руменов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Борислав", "Петров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Андрей", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Александър", "Василев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Борис", "Робертов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 15, "Георги", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Ивайло", "Андреев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Роберт", "Антонов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Петър", "Маринов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Михаел", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Велин", "Василев" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CareerStart", "FirstName", "LastName" },
                values: new object[] { 34, new DateTime(2017, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Иво", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CareerStart", "FirstName", "LastName" },
                values: new object[] { 17, new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Даниел", "Емилов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CareerStart", "FirstName", "LastName" },
                values: new object[] { 27, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Александър", "Тодоров" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CareerStart", "FirstName", "LastName" },
                values: new object[] { 39, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Васил", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CareerStart", "FirstName", "LastName" },
                values: new object[] { 45, new DateTime(2016, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Борис", "Николов" });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 9, 16, 9, 15, 388, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 9, 16, 9, 15, 388, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 9, 16, 9, 15, 388, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2941b6d-9e2a-4983-a52b-cbf5e6987d4d", "AQAAAAEAACcQAAAAEDmlvKUB360yC2q38GYwd0+DVEGNvAGR5ojhBWopd9VZ9zLxRIBdGAnFhaTeVpkxzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3899e519-88a0-4cbf-993e-9dffd3e1f8a3", "AQAAAAEAACcQAAAAEObwVPiIqJC2opIOUuUUaFfJIcBKFD7sCSiikArAMnREmfyxWu7UKzviCaB8UdwJwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "945b8757-0ea0-4a15-8b52-d801b019b495", "AQAAAAEAACcQAAAAEK4Es45HBx6xh9HVP6Mvw4lr7lizf8VvcMTSWkuIqzHkGl1cVehroLqA/3VeMS79/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5dc0f90c-eda7-4fff-80dc-6931b1174852", "AQAAAAEAACcQAAAAEN59L55RvJjo6L+clLvejACU1M0/Hlz7sZYEHaMkN5puiap85h5lBGoyVyWH7mPz8A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69cf2ce8-a33d-4455-941c-65c3184615fe", "AQAAAAEAACcQAAAAEGfDHJiRrEfDT7QglrqOTxT5OC5luPfx9VDSIz312EvUWNcXEGcLqzgaCgj3SnJGbw==" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "ИмеФутболист", "ФамилияФутболист" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CareerStart", "FirstName", "LastName" },
                values: new object[] { 30, new DateTime(2018, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ИмеСъдия", "ФламилияСъдия" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CareerStart", "FirstName", "LastName" },
                values: new object[] { 30, new DateTime(2018, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ИмеСъдия", "ФламилияСъдия" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CareerStart", "FirstName", "LastName" },
                values: new object[] { 30, new DateTime(2018, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ИмеСъдия", "ФламилияСъдия" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CareerStart", "FirstName", "LastName" },
                values: new object[] { 30, new DateTime(2018, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ИмеСъдия", "ФламилияСъдия" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CareerStart", "FirstName", "LastName" },
                values: new object[] { 30, new DateTime(2018, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ИмеСъдия", "ФламилияСъдия" });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 2);
        }
    }
}
