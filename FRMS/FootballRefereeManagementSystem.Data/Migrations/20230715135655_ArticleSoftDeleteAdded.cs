using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class ArticleSoftDeleteAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Articles",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft delete value");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 56, 55, 62, DateTimeKind.Utc).AddTicks(5014), true });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 56, 55, 62, DateTimeKind.Utc).AddTicks(5028), true });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2023, 7, 15, 13, 56, 55, 62, DateTimeKind.Utc).AddTicks(5030), true });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "868331bd-ef8b-4a24-acb6-c40be6bfef36", "AQAAAAEAACcQAAAAEOEsNyQeEfe1tcNsjwsItoEEQ/uMHVNwdYF68ywSOyzd9pZ8YOO0fLoprBIY/JdiJg==", "875af9b1-9008-4098-9128-22d1df160bfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d582dce4-beb1-4043-b9fd-bea62736fab2", "AQAAAAEAACcQAAAAEC3gpG12/SDflKICTgI2YVqJxyDUaWgjjyeZROWfKL43mbXiHqmHES424QnXVPj6ng==", "a196078b-3aed-4b5c-a7f4-25a71354dffe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "486bbd9e-f111-46aa-9004-a3c7b448d910", "AQAAAAEAACcQAAAAEKiBfk/hhql1gbIHWqq2+35xew2cfORQ2ACdwu6ENxHJPHP06qN7rya5OT6SB31D9A==", "ad4793ee-d62c-4e67-81c4-658a2e3a3a39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09e5cd31-0b4c-4ac5-ba2f-978e4c09ba61", "AQAAAAEAACcQAAAAEEvG14NlMbduXhicfV4kE6cWgQqQa/5lMdzRe/aVZ4c7Z2evE1ZP73RgLWBNQXLzdA==", "f1c55909-3002-428e-b04e-4668f378a382" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e1cc364-d23a-4f49-a198-9f08d7602e6a", "AQAAAAEAACcQAAAAEADuX2RYSN88PGjlsR6F8EIQ5UZh0dpZaY6ThQlYjFDeAlQ/XdDlsVVH9tBuEGwTMw==", "78f62294-3b28-458c-80db-3495fc73d1d6" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Любомир", "Павлов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 55, "Симеон", "Христов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 54, "Георги", "Андреев" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Никола", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Велин", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Виктор", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Любомир", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Роберт", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Емил", "Руменов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Николай", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Марио", "Илиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Борислав", "Ивайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Антонио", "Любенов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Ивайло", "Максимов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Виктор", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Борис", "Александров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Стефан", "Симеонов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Калоян", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Стефано", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Илия", "Василев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Владимир", "Симеонов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Велин", "Симеонов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Илия", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Васил", "Алексиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "FirstName" },
                values: new object[] { 38, "Тодор" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Петър", "Любомиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Любен", "Викторов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Георги", "Тодоров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Андрей", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 27, "Калоян", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "FirstName" },
                values: new object[] { 17, "Георги" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Мартин", "Велинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Кристиян", "Йорданов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Стефано", "Андреев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 16, "Владимир", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Тодор", "Йорданов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Румен", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Йордан", "Велинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "FirstName" },
                values: new object[] { 29, "Виктор" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Христо", "Любомиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "Габриел", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Александър", "Ивов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Павел", "Йорданов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 27, "Йордан", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Симеон", "Антонов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Петър", "Михайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Иво", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 16, "Михаел", "Павлов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 34, new DateTime(2019, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0931485725", "Йордан", "Христов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 47, new DateTime(2016, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "0982383012", "Виктор", "Андреев" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 35, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0962206568", "Васил", "Велинов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 38, new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0889558540", "Петър", "Илиев" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 46, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0884862901", "Йордан", "Николов" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 15, 13, 36, 45, 861, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 15, 13, 36, 45, 862, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 15, 13, 36, 45, 862, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31b05991-2ccf-487f-bd7d-11a3e1152f43", "AQAAAAEAACcQAAAAELSLRI+lN4g2xpVhiT6wHqAuHJDkPVR11UC2JDbLaapYJyB6RPQK3XrJIPmIg3Zyvg==", "b7a588c6-342a-4291-9647-da64ddbc9fe3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d41088a7-0129-4d09-bee2-240b444b8faa", "AQAAAAEAACcQAAAAEJ5FVHr+wZcHaE2QuPeTuq20wr4O3idrhsaZMZBO4Cb0/dBtqNLyZXb4h5uKupz60A==", "7ffe4a77-9a52-4069-b51c-8057edc06290" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "073c4a2c-e7b7-4d41-a4a6-b88dd7b812e4", "AQAAAAEAACcQAAAAEEdFuf5mjCsbjnq8UM3oAuiU1+G7SBL3zVL/dgI0v419eqw6+AqIrga9lmhTboazvg==", "d91cae5b-680b-4c84-b672-454fa736eb84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8ba5fb3-d8d5-4254-b425-02583b316b20", "AQAAAAEAACcQAAAAED2pZMdoR4MruaqABS505ZJ09cRBD6tNX6/2u+ijgFLYADmLsxPk+utKQ39DweEoeA==", "fe746c5f-8cb6-4010-b096-aff202744394" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04a93cf2-d455-458c-93f3-4e6213587436", "AQAAAAEAACcQAAAAEP+CPxs75XVM4RufHfFNE1Ovpo0KAMa4zLBrxItpRcHx0FpfOVopfgOJE/x4B1LRHw==", "9fd97ba5-e843-4da2-b182-7a4ba51f9668" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 53, "Симеон", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 65, "Тодор", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 49, "Марин", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 41, "Габриел", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Андрей", "Даниелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Радослав", "Габриелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Симеон", "Петров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Мартин", "Робертов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Антон", "Андреев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "Михаил", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Янко", "Стефаносов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Християн", "Габриелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Павел", "Янков" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 27, "Иво", "Ангелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Велин", "Бориславов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Йордан", "Бориславов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Павел", "Йорданов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 15, "Радослав", "Антонов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Петър", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Роберт", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Симеон", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Радослав", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "Димитър", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Димитър", "Емилов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "FirstName" },
                values: new object[] { 37, "Максим" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Габриел", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Тодор", "Велинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Марио", "Ивов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Никола", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Стефанос", "Антониев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "FirstName" },
                values: new object[] { 36, "Марин" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Марин", "Михаелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Петър", "Алексеев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Калоян", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Иво", "Любенов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Владимир", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 16, "Димитър", "Михайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 15, "Стефанос", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "FirstName" },
                values: new object[] { 28, "Димо" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Кристиян", "Маринов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Марин", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Стефанос", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Георги", "Любенов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Илиян", "Любомиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Илиян", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Георги", "Калоянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Антон", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 15, "Марин", "Ивов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 45, new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0967179556", "Стефанос", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 45, new DateTime(2016, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0881424929", "Александър", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 53, new DateTime(2019, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0906019674", "Георгиос", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 30, new DateTime(2016, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "0879900124", "Александър", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 23, new DateTime(2017, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0951597362", "Алексей", "Емилов" });
        }
    }
}
