using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class ApplicationEntityPropertiesRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_AspNetUsers_UserId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_UserId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "KnowsFootballRules",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Applications");

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
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Георги", "Николов" });

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
                columns: new[] { "Age", "FirstName" },
                values: new object[] { 18, "Петър" });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ApplicationId",
                table: "AspNetUsers",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Applications_ApplicationId",
                table: "AspNetUsers",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Applications_ApplicationId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ApplicationId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "KnowsFootballRules",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Has applicant read football rules");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Applications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "User profile who applied");

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
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Ивайло", "Михайлов" });

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
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Любомир", "Михаелов" });

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
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 16, "Николай", "Любенов" });

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
                columns: new[] { "Age", "FirstName" },
                values: new object[] { 16, "Николай" });

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
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 14, "Димитър", "Петров" });

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
                columns: new[] { "Age", "CareerStart", "Contact", "LastName" },
                values: new object[] { 30, new DateTime(2016, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0996737720", "Радославов" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserId",
                table: "Applications",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_AspNetUsers_UserId",
                table: "Applications",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
