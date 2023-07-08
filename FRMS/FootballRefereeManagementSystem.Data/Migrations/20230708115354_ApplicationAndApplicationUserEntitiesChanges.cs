using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class ApplicationAndApplicationUserEntitiesChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ed3f1887-39b0-4501-964e-a7a9d88bedb6"));

            migrationBuilder.DropColumn(
                name: "IsApprovedForReferee",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Email of applicant");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 8, 11, 53, 53, 960, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 8, 11, 53, 53, 960, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 8, 11, 53, 53, 960, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "748d49af-dce0-438b-a627-06f6d40b6c56", "AQAAAAEAACcQAAAAEOM4NXyxuP6yAwM6WUGLn4duuxer1T1K/sMCOT8eTsPCyMuLkeY5mDhzRpq5vMVByg==", "3b562f65-1fd5-472f-80fd-7cdf6d657447" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f09eff3-d21c-42d1-aa86-425388a3eed9", "AQAAAAEAACcQAAAAEJ5qYU0C5gCJiMWrffbDcit0f8DxZe6UU0E9cOP44xf6ZHJ/R8bJo0I+AIScafuF+g==", "4997d948-a53a-4117-9fda-df827c3441fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02b71297-7a70-42ea-8121-dfd05fbeef75", "AQAAAAEAACcQAAAAEFNekwTndfqVLXKeeQ6Iliig4J3Mem/J6wmHG/SeWJDZcppa0avJy37CL6FZWGfAYw==", "44937210-25d0-4cf8-803c-45db2c4c07c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06a30d1b-b584-4f64-a18d-74da896007f7", "AQAAAAEAACcQAAAAEDlrpeh8i/or8FxEnH2AoUYoAXLhxFXh/LHD3IFVHeFP+qgaZp4KZ05o0BDZtTjpjA==", "c1a8f37e-fc39-447f-a876-0247ba0bd5df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d16b9e2-8065-434a-884f-6d37eb784342", "AQAAAAEAACcQAAAAECcDNtE2Ka/KyTOv3XfxMyJsDeInEQTBZa75dcl7RjPjnGu1dkzXC0iSJfMUJc/jKA==", "db57a249-0967-4cf8-ab10-b0268f458ebe" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "Димо", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 44, "Любомир", "Робертов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 59, "Димо", "Владимиров" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 55, "Николай", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Роберт", "Симеонов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Стефанос", "Ивов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Илия", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Емил", "Михаелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Георги", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Роберт", "Даниелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Иван", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Андрей", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "Димо", "Маринов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Любен", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Симеон", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Антонио", "Маринов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Иван", "Янков" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Ангел", "Янков" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Стефанос", "Емилов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Калоян", "Янков" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Георгиос", "Ивов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ивайло", "Михайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Христо", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Илия", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Радослав", "Стефаносов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "LastName" },
                values: new object[] { 37, "Михаелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Антонио", "Руменов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Алексей", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Димитър", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Илия", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Симеон", "Антониев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Мартин", "Викторов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Николай", "Любенов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Антонио", "Андреев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Петър", "Ивов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Янко", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Михаил", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Роберт", "Руменов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Мартин", "Михаелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 16, "Николай", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Павел", "Илиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Любен", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Антон", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                column: "LastName",
                value: "Петров");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Петър", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Георги", "Велинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Даниел", "Александров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Тодор", "Илиев" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 19, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "0930411565", "Антонио", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 30, new DateTime(2016, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0996737720", "Румен", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 16, new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0927828260", "Павел", "Христов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 31, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912157336", "Румен", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 29, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0946372655", "Тодор", "Любомиров" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Applications");

            migrationBuilder.AddColumn<bool>(
                name: "IsApprovedForReferee",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Whether user has been approved to become referee");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 7, 9, 46, 19, 740, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 7, 9, 46, 19, 740, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 7, 9, 46, 19, 740, DateTimeKind.Utc).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "IsApprovedForReferee", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e372c67f-563d-4fea-94eb-706f17f258ab", true, "AQAAAAEAACcQAAAAEPRhM5+ZHrZqKJkNwRGO1TJjyp3JNtmZtJqSD0TOlecuDBju3jAwTyT1UsJHwp08jg==", "d658793f-4429-41db-a69d-b43f4448f09f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "IsApprovedForReferee", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcb1325e-64df-4aef-b71a-0ee25f67f860", true, "AQAAAAEAACcQAAAAEOyHsIHkdaQ8hav9kboqKckSJsb6EqkAc5Jv7GBH6l8REfnGqRBLBzOVtJtsqWuehg==", "888b11ab-e72f-4273-baff-4e1e7fa83d65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "IsApprovedForReferee", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73c7dbec-0d50-4672-ba0f-d979d9672475", true, "AQAAAAEAACcQAAAAELf1fYMlUV/+mfWiY9oGg07bGUKjiQWjiqxvEOrS9pQK2DA46Ov+qv2kBzg1r8yIcw==", "5bfa747c-ecb7-4847-b3f1-f719de1e2e1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "IsApprovedForReferee", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edcb3322-4683-43f3-be04-3d87d8d6cd37", true, "AQAAAAEAACcQAAAAEDyOGePDdHiVL3s0ypV9AZhuLZhWYabTWV2qowd9O/H3JYkcm5BgASJJs6nX7eCqaw==", "3ae6505b-6e9c-48ea-a141-97382882ee62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "IsApprovedForReferee", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec53bee0-751a-408d-af1f-443d99ec8ac9", true, "AQAAAAEAACcQAAAAECIItxugx7kFqoVyrclgeACepGckVPb4Ipz5Q34wzaCkXKq7o1RX/LaWABysDSeHNQ==", "619d22d8-ddaa-49fc-be86-67f7b000abf3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApplicationId", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsApprovedForReferee", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefereeId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ed3f1887-39b0-4501-964e-a7a9d88bedb6"), 0, null, "ae9f1d34-f30d-4571-ab86-e62657b68612", "random_person@gmail.com", false, false, false, null, "RANDOM_PERSON@GMAIL.COM", "RANDOM_PERSON@GMAIL.COM", "AQAAAAEAACcQAAAAEKchjNsxi35sF7y5UP1hjT/Pm5us1oQjw5KtzGd5SPX74SuA+ivaC+qzIbOdUY2TPA==", null, false, null, "0b95c4c8-1389-4027-b27e-3b8fb2d7b0c3", false, "random_person@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 47, "Илия", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Стефанос", "Ангелов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 41, "Владимир", "Велинов" });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 48, "Илиян", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Христо", "Александров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Владимир", "Любенов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Габриел", "Антониев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Максим", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Максим", "Илиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Максим", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Румен", "Даниелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Илия", "Андреев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 17, "Петър", "Любомиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 16, "Петър", "Стефаносов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 15, "Виктор", "Николов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Симеон", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Мартин", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Михаел", "Стефаносов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Ангел", "Антонов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Михаил", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Васил", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Християн", "Димов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Николай", "Владимиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Янко", "Антониев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Габриел", "Ангелов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "LastName" },
                values: new object[] { 15, "Илиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Стефан", "Георгиев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 15, "Ангел", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Велин", "Стефаносов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Виктор", "Любомиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Стефано", "Христов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Петър", "Антониев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Христо", "Димитров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Янко", "Радославов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Стефано", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Антон", "Василев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Роберт", "Ивов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Антонио", "Йорданов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Стефано", "Руменов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Даниел", "Иванов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "Иван", "Андреев" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Антон", "Владимиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Радослав", "Стефанов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                column: "LastName",
                value: "Мартинов");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Ивайло", "Михайлов" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Владимир", "Янков" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 16, "Янко", "Владимиров" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Роберт", "Любенов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 20, new DateTime(2016, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0980449165", "Иво", "Алексеев" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 18, new DateTime(2016, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0976905613", "Марин", "Михаелов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 26, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0899547014", "Роберт", "Кристиянов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 42, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0947423764", "Михаел", "Мартинов" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CareerStart", "Contact", "FirstName", "LastName" },
                values: new object[] { 49, new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0948630349", "Румен", "Максимов" });
        }
    }
}
