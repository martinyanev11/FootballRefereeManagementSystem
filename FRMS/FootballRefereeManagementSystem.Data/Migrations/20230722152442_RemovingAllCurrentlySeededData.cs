using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class RemovingAllCurrentlySeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreatedOn", "ImageUrl", "IsActive", "Title" },
                values: new object[,]
                {
                    { 1, "На 08.06.2023г в ОС на БФС-Плевен се проведе заседание на СТК при ОС на БФС Плевен и бяха взети следните решения:\r\n\r\nНа 04.06.2023г. в среща от 18 кръг на първенството на „Б”ОФГ-изток между отборите на ФК\"Обнова-2022\" – Обнова и ФК\"Чавдар-1920\" – Бръшляница, проведена в с.Обнова от 18ч. В 80мин. на срещата при резултат 1:0 в полза на ФК\"Обнова-2022\" е отсъден 11-метров наказателен удар в полза на ФК\"Обнова-2022\".Следва бурен протест от състезателите на ФК\"Чавдар-1920\" – Бръшляница.Нанесени са удари на гл.съдия в главата и тялото от състезатели на ФК\"Чавдар-1920\" – Бръшляница.поради създалата се обстановка при която е застрашено здравето и сигурността на длъжностните лица и няма условия футболната среща да продължи, същата е прекратена.\r\n\r\nНа основание чл.24 ал.9 от наредбата на БФС,се присъжда служебна  загуба при резултат 4:0 в полза на ФК\"Обнова-2022\".\r\n\r\nНеизрядната страна няма право да обжалва наказанието по тази алинея.", new DateTime(2023, 7, 22, 9, 21, 32, 365, DateTimeKind.Utc).AddTicks(444), null, true, "Заседание на СТК при ОС на БФС Плевен" },
                    { 2, "В среща от 17-ти кръг от първенството на „Б” ОФГ-запад между отборите на ФК\"Мизия-1924\" – Кнежа и ФК”Спартак-1924”-Койнаре проведена на 28.05. от 18ч. в гр.Кнежа и бяха взети следните решения:За навлизане на публиката на гостите от ФК”Спартак-1924”-Койнаре на терена по  време на срещата :Наказва ФК”Спартак-1924”-Койнаре с предупреждение, лишаване от домакинство и глоба в размер на 150/сто и петдесет/лева  по чл.37 ал.1 буква „в” от ДП.", new DateTime(2023, 7, 22, 9, 21, 32, 365, DateTimeKind.Utc).AddTicks(452), null, true, "Решение на ДК- ОС на БФС Плевен" },
                    { 3, "В среща от 15-ти кръг от първенството на „Б” ОФГ-изток между отборите на ФК\"Славия\"-Новачене и ФК\"Обнова-2022\" - Обнова проведена на14.05.от 18ч. в с.Новачене и бяха взети следните решения:Наказва Явор Руменов Димитров  от отбора на ФК\"Славия\"-Новачене за получен червен картон със ССП за 1/една/ среща по чл.22 ал.1 т.1буква „з”от ДП.Наказва Галин Пламенов Георгиев от отбора на ФК\"Обнова-2022\" - Обнова за получен червен картон със ССП за 1/една/ среща по чл.22 ал.1 т.1буква „в”от ДП.", new DateTime(2023, 7, 22, 9, 21, 32, 365, DateTimeKind.Utc).AddTicks(453), null, true, "Решение на ДК- ОС на БФС Плевен" },
                    { 4, "Съдийската комисия към Българския футболен съюз уведомява клубовете в системата на българското първенство, че от началото на новия спортно-състезателен сезон 2023/2024 г. в сила влизат някои промени и допълнения към Правилата на играта в съответствие с изискванията на Международния борд на футболните асоциации (IFAB).", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Utc), null, true, "Промени и допълнения в Правилата на играта, влизащи в сила през новия сезон" },
                    { 5, "Ръководителят на отдел „Техническо развитие“ към УЕФА Франк К. Лудолф изпрати официално писмо до Българския футболен съюз, в което изказва положителната оценка на европейската централа за програмата за развитие на обучители на треньори на БФС, която отговаря на стандартите на УЕФА.\nНа панела Jira, проведен в Нион на 5 май т.г., Българският футболен съюз и Треньорската школа по футбол са получили отлични отзиви за работата си с менторите на треньори.", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, true, "УЕФА с положителна оценка за развитието на обучители на треньори у нас" },
                    { 6, "Заседанието премина при следния дневен ред.\r\n\r\n1.Разглеждане на жалба от ФК „Свобода ”-Милковица за нередовен състезател.\r\n\r\nСлед като СТК се запозна с жалбата и с приложените доказателства по нея установи:\r\n\r\n1.На 09.11.2022г. по време на футболната среща от 12-кръг на „Б”ОФГ-Център  между ФК\"Спартак\"-Божурица и ФК „Свобода ”-Милковица.проведена в с.Божурица от11ч.,взема участие нередовен състезател в отбора на ФК\"Спартак\"-Божурица", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, true, "Протокол №8 от заседание на СТК при ОС на БФС Плевен" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApplicationId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefereeId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"), 0, null, "54fbbba0-e699-4a1a-af57-1a4dff1b6e05", "assitant_referee2@bfs.com", false, false, null, "ASSITANT_REFEREE2@BFS.COM", "ASSITANT_REFEREE2@BFS.COM", "AQAAAAEAACcQAAAAEOsid7cGk8SFkxDZOO6CwvLKVegsCNaQEa3IDICSzPUvARrHKuJeTkhU5wLkPDcyPg==", null, false, 3, "2e120751-2ca3-475f-bfe4-f40e6f2964a6", false, "assitant_referee2@bfs.com" },
                    { new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"), 0, null, "cfd97abc-0042-4cf9-8f38-e9be15c33c34", "assitant_referee1@bfs.com", false, false, null, "ASSITANT_REFEREE1@BFS.COM", "ASSITANT_REFEREE1@BFS.COM", "AQAAAAEAACcQAAAAEBsYTANdtpi4fXPK6kFNyD0m3S5v4d0Hl0jGSIYRKlhKvOhJ6fWBknCpjHGC8OgDHg==", null, false, 2, "874c18db-15a7-4e23-8838-3c66d8faf2cc", false, "assitant_referee1@bfs.com" },
                    { new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"), 0, null, "78cc6321-a2a8-4c16-8e5b-aa216c0b497a", "delegate@bfs.com", false, false, null, "DELEGATE@BFS.COM", "DELEGATE@BFS.COM", "AQAAAAEAACcQAAAAEML5tq5GMN2UCtVkn2srEb8T9RYnU9q5YDhPFH4Gt21WC9V4LgivhF6by/rj9lNvTA==", null, false, 4, "2e64ebbd-92ae-404a-8360-127a1d38edba", false, "delegate@bfs.com" },
                    { new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"), 0, null, "2cc1913e-3ef1-461a-8750-dc7b56f31fdf", "admin@bfs.com", false, false, null, "ADMIN@BFS.COM", "ADMIN@BFS.COM", "AQAAAAEAACcQAAAAEHyD1vItUojYhbJ3x+frPKeQbn1UVVD+i81rDIex9PqaXCch6N66XMT/KcDcvlVaGw==", null, false, 5, "e7b59d93-decc-4044-a889-2607f1f4aaf4", false, "admin@bfs.com" },
                    { new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"), 0, null, "2732dc73-1d92-4cfd-861d-5bc1d5fbdee1", "referee@bfs.com", false, false, null, "REFEREE@BFS.COM", "REFEREE@BFS.COM", "AQAAAAEAACcQAAAAEAx1olg0Q7c8nClYBF9bjzQ7yFIvYmdJuhRF/nliDzd6OkXuMD3XzDvX39wof2oeDg==", null, false, 1, "1c6f9e35-d20d-439e-bb8e-7f2a1e697472", false, "referee@bfs.com" }
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
                    { 1, 62, "Александър", "Георгиев" },
                    { 2, 64, "Марио", "Борисов" },
                    { 3, 33, "Кристиян", "Николов" },
                    { 4, 62, "Иво", "Петров" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 1, 33, "Христо", "Иванов", null },
                    { 2, 15, "Калоян", "Михайлов", null },
                    { 3, 35, "Антон", "Емилов", null },
                    { 4, 33, "Георги", "Андреев", null },
                    { 5, 34, "Радослав", "Николов", null },
                    { 6, 15, "Стефанос", "Калоянов", null },
                    { 7, 36, "Димо", "Владимиров", null },
                    { 8, 32, "Иво", "Емилов", null },
                    { 9, 18, "Велин", "Андреев", null },
                    { 10, 38, "Радослав", "Викторов", null },
                    { 11, 26, "Георгиос", "Ивайлов", null },
                    { 12, 28, "Александър", "Василев", null },
                    { 13, 30, "Калоян", "Георгиев", null },
                    { 14, 23, "Александър", "Емилов", null },
                    { 15, 34, "Калоян", "Христов", null },
                    { 16, 31, "Михаил", "Стефанов", null },
                    { 17, 34, "Даниел", "Георгиев", null },
                    { 18, 18, "Антонио", "Любомиров", null },
                    { 19, 33, "Роберт", "Димитров", null },
                    { 20, 39, "Николай", "Андреев", null },
                    { 21, 37, "Васил", "Емилов", null },
                    { 22, 20, "Борислав", "Симеонов", null }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 23, 24, "Илия", "Димитров", null },
                    { 24, 22, "Любен", "Михаелов", null },
                    { 25, 32, "Ивайло", "Димов", null },
                    { 26, 35, "Владимир", "Ивов", null },
                    { 27, 37, "Тодор", "Велинов", null },
                    { 28, 20, "Ангел", "Христов", null },
                    { 29, 17, "Георги", "Антониев", null },
                    { 30, 20, "Радослав", "Илиев", null },
                    { 31, 30, "Георги", "Ивов", null },
                    { 32, 23, "Георгиос", "Георгиев", null },
                    { 33, 15, "Марин", "Димов", null },
                    { 34, 24, "Ивайло", "Илиев", null },
                    { 35, 23, "Илия", "Емилов", null },
                    { 36, 21, "Христо", "Кристиянов", null },
                    { 37, 37, "Алексей", "Андреев", null },
                    { 38, 24, "Никола", "Янков", null },
                    { 39, 21, "Михаел", "Бориславов", null },
                    { 40, 20, "Мартин", "Димитров", null },
                    { 41, 35, "Георгиос", "Борисов", null },
                    { 42, 39, "Виктор", "Михаелов", null },
                    { 43, 24, "Михаил", "Стефаносов", null },
                    { 44, 24, "Виктор", "Робертов", null }
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
                    { 1, 54, new DateTime(2017, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915433499", 0, "Ивайло", true, "Любенов", 0, 0, 1, new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478") },
                    { 2, 50, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0996526700", 0, "Христо", true, "Борисов", 1, 0, 1, new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a") },
                    { 3, 41, new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912365117", 0, "Борислав", true, "Кристиянов", 1, 0, 1, new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9") },
                    { 4, 28, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0991608752", 0, "Владимир", true, "Димов", 2, 0, 1, new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1") },
                    { 5, 54, new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0972187210", 0, "Янко", false, "Георгиев", 3, 0, 1, new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6") }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name", "TownId" },
                values: new object[,]
                {
                    { 1, "Ботев", 2 },
                    { 2, "Вихър", 3 },
                    { 3, "Гигант", 4 },
                    { 4, "Космос", 5 }
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
                columns: new[] { "SeasonId", "TeamId", "DivisionId", "Draws", "GoalsAgainst", "GoalsFor", "Losses", "ManagerId", "Placement", "Points", "ShirtColor", "Wins" },
                values: new object[,]
                {
                    { 1, 1, 4, 0, 0, 0, 0, 1, 1, 0, 11, 0 },
                    { 1, 2, 4, 0, 0, 0, 0, 2, 1, 0, 0, 0 },
                    { 1, 3, 4, 0, 0, 0, 0, 3, 1, 0, 4, 0 },
                    { 1, 4, 4, 0, 0, 0, 0, 4, 1, 0, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "DivisionId", "FixtureTime", "HasFinished", "HomeTeamId", "HomeTeamScore", "RefereeSquadId", "SeasonId", "TownId" },
                values: new object[,]
                {
                    { 1, 2, 0, 4, new DateTime(2022, 9, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 0, new Guid("5f7a5bad-da9c-4fd9-871a-483492e9bdaa"), 1, 2 },
                    { 2, 3, 0, 4, new DateTime(2022, 9, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 0, null, 1, 2 },
                    { 3, 4, 0, 4, new DateTime(2022, 10, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 0, null, 1, 2 },
                    { 4, 1, 0, 4, new DateTime(2022, 10, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), false, 2, 0, null, 1, 3 },
                    { 5, 3, 0, 4, new DateTime(2022, 9, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), false, 2, 0, null, 1, 3 },
                    { 6, 4, 0, 4, new DateTime(2022, 9, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), false, 2, 0, null, 1, 3 },
                    { 7, 1, 0, 4, new DateTime(2022, 10, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 0, null, 1, 4 },
                    { 8, 2, 0, 4, new DateTime(2022, 10, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 0, null, 1, 4 },
                    { 9, 4, 0, 4, new DateTime(2022, 9, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 0, null, 1, 4 },
                    { 10, 1, 0, 4, new DateTime(2022, 9, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), false, 4, 0, null, 1, 5 },
                    { 11, 2, 0, 4, new DateTime(2022, 9, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 4, 0, null, 1, 5 },
                    { 12, 3, 0, 4, new DateTime(2022, 10, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), false, 4, 0, null, 1, 5 }
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
    }
}
