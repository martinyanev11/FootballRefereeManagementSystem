using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class NewDataSeedingWithMoreStaticValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreatedOn", "ImageUrl", "IsActive", "Title" },
                values: new object[,]
                {
                    { 1, "На 08.06.2023г в ОС на БФС-Плевен се проведе заседание на СТК при ОС на БФС Плевен и бяха взети следните решения:\r\n\r\nНа 04.06.2023г. в среща от 18 кръг на първенството на „Б”ОФГ-изток между отборите на ФК\"Обнова-2022\" – Обнова и ФК\"Чавдар-1920\" – Бръшляница, проведена в с.Обнова от 18ч. В 80мин. на срещата при резултат 1:0 в полза на ФК\"Обнова-2022\" е отсъден 11-метров наказателен удар в полза на ФК\"Обнова-2022\".Следва бурен протест от състезателите на ФК\"Чавдар-1920\" – Бръшляница.Нанесени са удари на гл.съдия в главата и тялото от състезатели на ФК\"Чавдар-1920\" – Бръшляница.поради създалата се обстановка при която е застрашено здравето и сигурността на длъжностните лица и няма условия футболната среща да продължи, същата е прекратена.\r\n\r\nНа основание чл.24 ал.9 от наредбата на БФС,се присъжда служебна  загуба при резултат 4:0 в полза на ФК\"Обнова-2022\".\r\n\r\nНеизрядната страна няма право да обжалва наказанието по тази алинея.", new DateTime(2023, 7, 23, 17, 22, 48, 147, DateTimeKind.Utc).AddTicks(1509), null, true, "Заседание на СТК при ОС на БФС Плевен" },
                    { 2, "В среща от 17-ти кръг от първенството на „Б” ОФГ-запад между отборите на ФК\"Мизия-1924\" – Кнежа и ФК”Спартак-1924”-Койнаре проведена на 28.05. от 18ч. в гр.Кнежа и бяха взети следните решения:За навлизане на публиката на гостите от ФК”Спартак-1924”-Койнаре на терена по  време на срещата :Наказва ФК”Спартак-1924”-Койнаре с предупреждение, лишаване от домакинство и глоба в размер на 150/сто и петдесет/лева  по чл.37 ал.1 буква „в” от ДП.", new DateTime(2023, 7, 23, 17, 22, 48, 147, DateTimeKind.Utc).AddTicks(1517), null, true, "Решение на ДК- ОС на БФС Плевен" },
                    { 3, "В среща от 15-ти кръг от първенството на „Б” ОФГ-изток между отборите на ФК\"Славия\"-Новачене и ФК\"Обнова-2022\" - Обнова проведена на14.05.от 18ч. в с.Новачене и бяха взети следните решения:Наказва Явор Руменов Димитров  от отбора на ФК\"Славия\"-Новачене за получен червен картон със ССП за 1/една/ среща по чл.22 ал.1 т.1буква „з”от ДП.Наказва Галин Пламенов Георгиев от отбора на ФК\"Обнова-2022\" - Обнова за получен червен картон със ССП за 1/една/ среща по чл.22 ал.1 т.1буква „в”от ДП.", new DateTime(2023, 7, 23, 17, 22, 48, 147, DateTimeKind.Utc).AddTicks(1518), null, true, "Решение на ДК- ОС на БФС Плевен" },
                    { 4, "Съдийската комисия към Българския футболен съюз уведомява клубовете в системата на българското първенство, че от началото на новия спортно-състезателен сезон 2023/2024 г. в сила влизат някои промени и допълнения към Правилата на играта в съответствие с изискванията на Международния борд на футболните асоциации (IFAB).", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Utc), null, true, "Промени и допълнения в Правилата на играта, влизащи в сила през новия сезон" },
                    { 5, "Ръководителят на отдел „Техническо развитие“ към УЕФА Франк К. Лудолф изпрати официално писмо до Българския футболен съюз, в което изказва положителната оценка на европейската централа за програмата за развитие на обучители на треньори на БФС, която отговаря на стандартите на УЕФА.\nНа панела Jira, проведен в Нион на 5 май т.г., Българският футболен съюз и Треньорската школа по футбол са получили отлични отзиви за работата си с менторите на треньори.", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), null, true, "УЕФА с положителна оценка за развитието на обучители на треньори у нас" },
                    { 6, "Заседанието премина при следния дневен ред.\r\n\r\n1.Разглеждане на жалба от ФК „Свобода ”-Милковица за нередовен състезател.\r\n\r\nСлед като СТК се запозна с жалбата и с приложените доказателства по нея установи:\r\n\r\n1.На 09.11.2022г. по време на футболната среща от 12-кръг на „Б”ОФГ-Център  между ФК\"Спартак\"-Божурица и ФК „Свобода ”-Милковица.проведена в с.Божурица от11ч.,взема участие нередовен състезател в отбора на ФК\"Спартак\"-Божурица", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, true, "Протокол №8 от заседание на СТК при ОС на БФС Плевен" },
                    { 7, "В среща от 11-ти кръг от първенството на „Б” ОФГ-център,между отборите на ФК\"Бенковски\" – Петърница и ФК\"Устрем\" – Крета,проведена на 26.03.2023г. от 11ч. в с.Петърница наказва:Борислав Красимиров Петров от отбора на ФК\"Устрем\" – Крета за получен червен картон и обиди на гл.съдия със ССП за 2/две/срещи на основание чл.22ал2 т.1 буква”а”и „к”от Д.П.", new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Utc), null, true, "Решение на ДК- ОС на БФС Плевен" },
                    { 8, "В среща от 11-ти кръг от първенството на „Б” ОФГ-център,между отборите на ФК \"Вихър\" – Крушовене и ФК\"Ботев-2022\" – Комарево\r\n\r\nпроведена на  26.03.2023г. от 11ч в с.Крушовене  наказва:Борислав Бориславов Сергеев от отбора на ФК \"Вихър\" – Крушовене  за получен червен картон със  ССП за 1/една/среща на основание чл.22.ал.2 т.1 буква”б” от ДП", new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Utc), null, true, "Решение на ДК- ОС на БФС Плевен" },
                    { 9, "Бяха разгледани провиненията в срещи от 11-ти кръг първенството на „Б” ОФГ-изток\r\n\r\nВ среща от 11-ти кръг от първенството на „Б” ОФГ-изток  между отборите на ФК\"Славия\"-Новачене и ФК\" Пордим 2017\"-Пордим проведена      на  26.03.2023г. от 15ч в с.Новачене наказва:Георги Димитров Велчев от отбора на  ФК\" Пордим 2017\"-Пордим  за получен червен картон със  ССП за 1/една/среща на основание чл.22.ал.2 т.1 буква”а” от ДП.", new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Utc), null, true, "Решение на ДК- ОС на БФС Плевен" },
                    { 10, "По доклад на длъжностните лица и взе следните решения:\r\n\r\nНаказва :Николай Георгиев Иванов от отбора на ФК\"Чавдар-1920\" – Бръшляница за нанесени удари в главата на гл.съдия със ССП за срок от 1/една /година на основание чл.25 от ДП на БФС.Наказва:Цветан Христов Нинов от обора на ФК\"Чавдар-1920\" – Бръшляница,за нанесен удар в тялото на гл.съдия със ССП за срок от 1/една /година на основание чл.25 от ДП на БФС.Наказва:Емил Илиев Трифонов от отбора на ФК\"Чавдар-1920\" – Бръшляница за блъскане на гл.съдия със ССП за срок  от 6/шест/срещи по чл.23 ал.2 буква”д” от ДП на БФС", new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, true, "Решение на ДК- ОС на БФС Плевен" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApplicationId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefereeId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"), 0, null, "0c2f16a3-3f96-42b0-a52c-0475a6d146f3", "assitant_referee2@bfs.com", false, false, null, "ASSITANT_REFEREE2@BFS.COM", "ASSITANT_REFEREE2@BFS.COM", "AQAAAAEAACcQAAAAELIOWxiKGvcP/egIc0F8dfeCDjQeUtpfJV10lzO+DUBb/oIQnhyEX2RSETUCKQtcSg==", null, false, 3, "54aa92fc-e351-4099-b8c2-2e11844b5055", false, "assitant_referee2@bfs.com" },
                    { new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"), 0, null, "00ee8d3f-aca4-4577-ab85-569e0862eddf", "assitant_referee1@bfs.com", false, false, null, "ASSITANT_REFEREE1@BFS.COM", "ASSITANT_REFEREE1@BFS.COM", "AQAAAAEAACcQAAAAEFMdnDMIUL/5XK3Le3T4LSfuZ7fbK5lwuijOu0ohfZAxnFqk+Sa6i3LXJVD74iOp4w==", null, false, 2, "953c5389-11bf-4a85-985e-8838dbc244e9", false, "assitant_referee1@bfs.com" },
                    { new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"), 0, null, "6d76d446-b7d7-4292-ab97-11b73ae73285", "delegate@bfs.com", false, false, null, "DELEGATE@BFS.COM", "DELEGATE@BFS.COM", "AQAAAAEAACcQAAAAEHfeh2HUJmESRv10VNZWucYbAbhoRyZof8zNJNqdvJCi5YcAtxQyQEB4+ggH7wf+NA==", null, false, 4, "0d2f845c-5cff-4c19-9b10-897c8e4293bf", false, "delegate@bfs.com" },
                    { new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"), 0, null, "76800a49-b066-4f09-b319-ad1b28b9aeef", "admin@bfs.com", false, false, null, "ADMIN@BFS.COM", "ADMIN@BFS.COM", "AQAAAAEAACcQAAAAEFtbBU2Z6PPKGYlaI3aP4txh4habU8qbq9ndDvDZJeq4VXjwAfZfdk2MQdeDy1clqw==", null, false, 5, "e2dc0205-924a-40d8-88f7-7ebf282eba0f", false, "admin@bfs.com" },
                    { new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"), 0, null, "ab6fd9bb-dd1e-41ac-a9a7-23b38fe7b4d4", "referee@bfs.com", false, false, null, "REFEREE@BFS.COM", "REFEREE@BFS.COM", "AQAAAAEAACcQAAAAEEdJ8Jr4g1hNuOzYqc3jugWRjWN7X+oAVx7rlTy8NvC5Y35ktCqDUEEv6WDqnkJodA==", null, false, 1, "db733aa2-e6af-45eb-89f4-f313843a9477", false, "referee@bfs.com" }
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

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 1, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 2, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 3, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 4, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 5, 25, "ИмеФутболист", "ФамилияФутболист", null }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 6, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 7, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 8, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 9, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 10, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 11, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 12, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 13, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 14, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 15, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 16, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 17, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 18, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 19, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 20, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 21, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 22, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 23, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 24, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 25, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 26, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 27, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 28, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 29, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 30, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 31, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 32, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 33, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 34, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 35, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 36, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 37, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 38, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 39, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 40, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 41, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 42, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 43, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 44, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 45, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 46, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 47, 25, "ИмеФутболист", "ФамилияФутболист", null }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 48, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 49, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 50, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 51, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 52, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 53, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 54, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 55, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 56, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 57, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 58, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 59, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 60, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 61, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 62, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 63, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 64, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 65, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 66, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 67, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 68, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 69, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 70, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 71, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 72, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 73, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 74, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 75, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 76, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 77, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 78, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 79, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 80, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 81, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 82, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 83, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 84, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 85, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 86, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 87, 25, "ИмеФутболист", "ФамилияФутболист", null },
                    { 88, 25, "ИмеФутболист", "ФамилияФутболист", null }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "Description", "End", "Start" },
                values: new object[] { 1, "2022/23", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "Description", "End", "Start" },
                values: new object[] { 2, "2023/24", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                    { 5, 0.0, "Гривица", 0.0, 0, 4 },
                    { 6, 0.0, "Брест", 0.0, 0, 4 },
                    { 7, 0.0, "Лепица", 0.0, 0, 4 },
                    { 8, 0.0, "Никопол", 0.0, 0, 4 },
                    { 9, 0.0, "Тръстеник", 0.0, 0, 4 },
                    { 10, 0.0, "Българене", 0.0, 0, 1 },
                    { 11, 0.0, "Вълчитрън", 0.0, 0, 1 },
                    { 12, 0.0, "Згалево", 0.0, 0, 1 },
                    { 13, 0.0, "Изгрев", 0.0, 0, 1 },
                    { 14, 0.0, "Обнова", 0.0, 0, 1 },
                    { 15, 0.0, "Новачене", 0.0, 0, 1 },
                    { 16, 0.0, "Муселиево", 0.0, 0, 1 },
                    { 17, 0.0, "Пордим", 0.0, 0, 1 },
                    { 18, 0.0, "Бръшляница", 0.0, 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Referees",
                columns: new[] { "Id", "Age", "CareerStart", "Contact", "CurrentlyAppointedMatchesCount", "FirstName", "IsAvaliable", "LastName", "Role", "TotalMatchesOfficiated", "TownId", "UserId" },
                values: new object[,]
                {
                    { 1, 30, new DateTime(2018, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0898556248", 0, "ИмеСъдия", true, "ФламилияСъдия", 0, 0, 1, new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478") },
                    { 2, 30, new DateTime(2018, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0898556248", 0, "ИмеСъдия", true, "ФламилияСъдия", 1, 0, 1, new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a") },
                    { 3, 30, new DateTime(2018, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0898556248", 0, "ИмеСъдия", true, "ФламилияСъдия", 1, 0, 1, new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9") },
                    { 4, 30, new DateTime(2018, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0898556248", 0, "ИмеСъдия", true, "ФламилияСъдия", 2, 0, 1, new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1") },
                    { 5, 30, new DateTime(2018, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0898556248", 0, "ИмеСъдия", false, "ФламилияСъдия", 3, 0, 1, new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6") }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name", "TownId" },
                values: new object[,]
                {
                    { 1, "Ботев", 2 },
                    { 2, "Вихър", 3 },
                    { 3, "Гигант", 4 },
                    { 4, "Космос", 5 },
                    { 5, "Левски", 6 },
                    { 6, "Светослав", 7 },
                    { 7, "Ситомир", 8 },
                    { 8, "Тръстеник", 9 },
                    { 9, "Ботев", 10 },
                    { 10, "Ботев", 11 },
                    { 11, "Виная", 12 },
                    { 12, "Динамо", 13 },
                    { 13, "Обнова", 14 },
                    { 14, "Славия", 15 },
                    { 15, "Спартак", 16 },
                    { 16, "Пордим", 17 },
                    { 17, "Чавдар", 18 }
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
                    { 1, 1, 4, 0, 0, 0, 0, 1, 0, 0, 11, 0 },
                    { 2, 1, 4, 0, 0, 0, 0, 1, 0, 0, 11, 0 },
                    { 1, 2, 4, 0, 0, 0, 0, 2, 0, 0, 0, 0 },
                    { 2, 2, 4, 0, 0, 0, 0, 2, 0, 0, 0, 0 },
                    { 1, 3, 4, 0, 0, 0, 0, 3, 0, 0, 4, 0 },
                    { 2, 3, 4, 0, 0, 0, 0, 3, 0, 0, 4, 0 },
                    { 1, 4, 4, 0, 0, 0, 0, 4, 0, 0, 2, 0 },
                    { 2, 4, 4, 0, 0, 0, 0, 4, 0, 0, 2, 0 },
                    { 2, 5, 4, 0, 0, 0, 0, 5, 0, 0, 7, 0 },
                    { 2, 6, 4, 0, 0, 0, 0, 6, 0, 0, 6, 0 },
                    { 2, 7, 4, 0, 0, 0, 0, 7, 0, 0, 1, 0 },
                    { 2, 8, 4, 0, 0, 0, 0, 8, 0, 0, 10, 0 },
                    { 1, 9, 5, 3, 32, 37, 5, 9, 0, 0, 0, 8 },
                    { 1, 10, 5, 1, 73, 20, 14, 10, 0, 0, 10, 1 },
                    { 1, 11, 5, 1, 56, 33, 9, 11, 0, 0, 5, 6 },
                    { 1, 12, 5, 2, 19, 48, 3, 12, 0, 0, 11, 11 },
                    { 1, 13, 5, 1, 20, 62, 2, 13, 0, 0, 8, 13 },
                    { 1, 14, 5, 1, 36, 26, 11, 14, 0, 0, 0, 4 },
                    { 1, 15, 5, 2, 38, 28, 9, 15, 0, 0, 4, 5 },
                    { 1, 16, 5, 3, 37, 22, 9, 16, 0, 0, 2, 4 },
                    { 1, 17, 5, 4, 16, 51, 1, 17, 0, 0, 3, 11 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "DivisionId", "FixtureTime", "HomeTeamId", "HomeTeamScore", "RefereeSquadId", "SeasonId", "SeasonRound", "TownId" },
                values: new object[,]
                {
                    { 1, 4, 0, 4, new DateTime(2023, 9, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), 6, 0, new Guid("5f7a5bad-da9c-4fd9-871a-483492e9bdaa"), 2, 0, 7 },
                    { 2, 2, 0, 4, new DateTime(2023, 9, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), 5, 0, null, 2, 0, 6 },
                    { 3, 1, 0, 4, new DateTime(2023, 9, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), 8, 0, null, 2, 0, 9 },
                    { 4, 3, 0, 4, new DateTime(2023, 9, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), 7, 0, null, 2, 0, 8 },
                    { 5, 3, 0, 4, new DateTime(2023, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, 0, null, 2, 0, 5 },
                    { 6, 7, 0, 4, new DateTime(2023, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, null, 2, 0, 2 },
                    { 7, 8, 0, 4, new DateTime(2023, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, null, 2, 0, 3 },
                    { 8, 5, 0, 4, new DateTime(2023, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 6, 0, null, 2, 0, 7 },
                    { 9, 4, 0, 4, new DateTime(2023, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, 0, null, 2, 0, 6 },
                    { 10, 6, 0, 4, new DateTime(2023, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 8, 0, null, 2, 0, 9 },
                    { 11, 2, 0, 4, new DateTime(2023, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 7, 0, null, 2, 0, 8 },
                    { 12, 1, 0, 4, new DateTime(2023, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, 0, null, 2, 0, 4 },
                    { 13, 1, 0, 4, new DateTime(2023, 10, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 4, 0, null, 2, 0, 5 },
                    { 14, 3, 0, 4, new DateTime(2023, 10, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, null, 2, 0, 3 },
                    { 15, 7, 0, 4, new DateTime(2023, 10, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 6, 0, null, 2, 0, 7 },
                    { 16, 8, 0, 4, new DateTime(2023, 10, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, 0, null, 2, 0, 6 },
                    { 17, 4, 0, 4, new DateTime(2023, 10, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 8, 0, null, 2, 0, 9 },
                    { 18, 5, 0, 4, new DateTime(2023, 10, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 7, 0, null, 2, 0, 8 },
                    { 19, 6, 0, 4, new DateTime(2023, 10, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, 0, null, 2, 0, 4 },
                    { 20, 2, 0, 4, new DateTime(2023, 10, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, null, 2, 0, 2 },
                    { 21, 2, 0, 4, new DateTime(2023, 10, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 0, null, 2, 0, 5 },
                    { 22, 1, 0, 4, new DateTime(2023, 10, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 6, 0, null, 2, 0, 7 },
                    { 23, 3, 0, 4, new DateTime(2023, 10, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 5, 0, null, 2, 0, 6 },
                    { 24, 7, 0, 4, new DateTime(2023, 10, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 8, 0, null, 2, 0, 9 },
                    { 25, 4, 0, 4, new DateTime(2023, 11, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 7, 0, null, 2, 0, 8 },
                    { 26, 8, 0, 4, new DateTime(2023, 11, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, 0, null, 2, 0, 4 },
                    { 27, 5, 0, 4, new DateTime(2023, 11, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, null, 2, 0, 2 },
                    { 28, 6, 0, 4, new DateTime(2023, 11, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, null, 2, 0, 3 },
                    { 29, 6, 0, 4, new DateTime(2024, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 4, 0, null, 2, 0, 5 },
                    { 30, 5, 0, 4, new DateTime(2024, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, null, 2, 0, 3 },
                    { 31, 8, 0, 4, new DateTime(2024, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, null, 2, 0, 2 },
                    { 32, 7, 0, 4, new DateTime(2024, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, 0, null, 2, 0, 4 },
                    { 33, 4, 0, 4, new DateTime(2024, 4, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, 0, null, 2, 0, 4 },
                    { 34, 1, 0, 4, new DateTime(2024, 4, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 7, 0, null, 2, 0, 8 },
                    { 35, 2, 0, 4, new DateTime(2024, 4, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 8, 0, null, 2, 0, 9 },
                    { 36, 6, 0, 4, new DateTime(2024, 4, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 5, 0, null, 2, 0, 6 },
                    { 37, 5, 0, 4, new DateTime(2024, 4, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, 0, null, 2, 0, 5 },
                    { 38, 8, 0, 4, new DateTime(2024, 4, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 6, 0, null, 2, 0, 7 },
                    { 39, 7, 0, 4, new DateTime(2024, 4, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, null, 2, 0, 3 },
                    { 40, 3, 0, 4, new DateTime(2024, 4, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, null, 2, 0, 2 },
                    { 41, 4, 0, 4, new DateTime(2024, 4, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, null, 2, 0, 2 },
                    { 42, 2, 0, 4, new DateTime(2024, 4, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, 0, null, 2, 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "DivisionId", "FixtureTime", "HomeTeamId", "HomeTeamScore", "RefereeSquadId", "SeasonId", "SeasonRound", "TownId" },
                values: new object[,]
                {
                    { 43, 6, 0, 4, new DateTime(2024, 4, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 7, 0, null, 2, 0, 8 },
                    { 44, 5, 0, 4, new DateTime(2024, 4, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 8, 0, null, 2, 0, 9 },
                    { 45, 8, 0, 4, new DateTime(2024, 5, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, 0, null, 2, 0, 5 },
                    { 46, 7, 0, 4, new DateTime(2024, 5, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, 0, null, 2, 0, 6 },
                    { 47, 3, 0, 4, new DateTime(2024, 5, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), 6, 0, null, 2, 0, 7 },
                    { 48, 1, 0, 4, new DateTime(2024, 5, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, null, 2, 0, 3 },
                    { 49, 4, 0, 4, new DateTime(2024, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, null, 2, 0, 3 },
                    { 50, 6, 0, 4, new DateTime(2024, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, null, 2, 0, 2 },
                    { 51, 5, 0, 4, new DateTime(2024, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, 0, null, 2, 0, 4 },
                    { 52, 8, 0, 4, new DateTime(2024, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 7, 0, null, 2, 0, 8 },
                    { 53, 7, 0, 4, new DateTime(2024, 5, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, 0, null, 2, 0, 5 },
                    { 54, 3, 0, 4, new DateTime(2024, 5, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 8, 0, null, 2, 0, 9 },
                    { 55, 1, 0, 4, new DateTime(2024, 5, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, 0, null, 2, 0, 6 },
                    { 56, 2, 0, 4, new DateTime(2024, 5, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 6, 0, null, 2, 0, 7 },
                    { 57, 10, 0, 5, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 0, null, 1, 1, 10 },
                    { 58, 11, 0, 5, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 0, null, 1, 1, 10 },
                    { 59, 12, 0, 5, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 0, null, 1, 1, 10 },
                    { 60, 13, 0, 5, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 0, null, 1, 1, 10 },
                    { 61, 14, 0, 5, new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 0, null, 1, 2, 10 },
                    { 62, 15, 0, 5, new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 0, null, 1, 2, 10 },
                    { 63, 16, 0, 5, new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 0, null, 1, 2, 10 },
                    { 64, 17, 0, 5, new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 0, null, 1, 2, 10 },
                    { 65, 9, 0, 5, new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 0, null, 1, 3, 11 },
                    { 66, 11, 0, 5, new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 0, null, 1, 3, 11 },
                    { 67, 12, 0, 5, new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 0, null, 1, 3, 11 },
                    { 68, 13, 0, 5, new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 0, null, 1, 3, 11 },
                    { 69, 14, 0, 5, new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 0, null, 1, 4, 11 },
                    { 70, 15, 0, 5, new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 0, null, 1, 4, 11 },
                    { 71, 16, 0, 5, new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 0, null, 1, 4, 11 },
                    { 72, 17, 0, 5, new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 0, null, 1, 4, 11 },
                    { 73, 9, 0, 5, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 0, null, 1, 5, 12 },
                    { 74, 10, 0, 5, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 0, null, 1, 5, 12 },
                    { 75, 12, 0, 5, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 0, null, 1, 5, 12 },
                    { 76, 13, 0, 5, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 0, null, 1, 5, 12 },
                    { 77, 14, 0, 5, new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 0, null, 1, 6, 12 },
                    { 78, 15, 0, 5, new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 0, null, 1, 6, 12 },
                    { 79, 16, 0, 5, new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 0, null, 1, 6, 12 },
                    { 80, 17, 0, 5, new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 0, null, 1, 6, 12 },
                    { 81, 9, 0, 5, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 0, null, 1, 7, 13 },
                    { 82, 10, 0, 5, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 0, null, 1, 7, 13 },
                    { 83, 11, 0, 5, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 0, null, 1, 7, 13 },
                    { 84, 13, 0, 5, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 0, null, 1, 7, 13 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "DivisionId", "FixtureTime", "HomeTeamId", "HomeTeamScore", "RefereeSquadId", "SeasonId", "SeasonRound", "TownId" },
                values: new object[,]
                {
                    { 85, 14, 0, 5, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 0, null, 1, 8, 13 },
                    { 86, 15, 0, 5, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 0, null, 1, 8, 13 },
                    { 87, 16, 0, 5, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 0, null, 1, 8, 13 },
                    { 88, 17, 0, 5, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 0, null, 1, 8, 13 },
                    { 89, 9, 0, 5, new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 0, null, 1, 9, 14 },
                    { 90, 10, 0, 5, new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 0, null, 1, 9, 14 },
                    { 91, 11, 0, 5, new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 0, null, 1, 9, 14 },
                    { 92, 12, 0, 5, new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 0, null, 1, 9, 14 },
                    { 93, 14, 0, 5, new DateTime(2023, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 13, 0, null, 1, 10, 14 },
                    { 94, 15, 0, 5, new DateTime(2023, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 13, 0, null, 1, 10, 14 },
                    { 95, 16, 0, 5, new DateTime(2023, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 13, 0, null, 1, 10, 14 },
                    { 96, 17, 0, 5, new DateTime(2023, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 13, 0, null, 1, 10, 14 },
                    { 97, 9, 0, 5, new DateTime(2023, 3, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, 0, null, 1, 11, 15 },
                    { 98, 10, 0, 5, new DateTime(2023, 3, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, 0, null, 1, 11, 15 },
                    { 99, 11, 0, 5, new DateTime(2023, 3, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, 0, null, 1, 11, 15 },
                    { 100, 12, 0, 5, new DateTime(2023, 3, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, 0, null, 1, 11, 15 },
                    { 101, 13, 0, 5, new DateTime(2023, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, 0, null, 1, 12, 15 },
                    { 102, 15, 0, 5, new DateTime(2023, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, 0, null, 1, 12, 15 },
                    { 103, 16, 0, 5, new DateTime(2023, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, 0, null, 1, 12, 15 },
                    { 104, 17, 0, 5, new DateTime(2023, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, 0, null, 1, 12, 15 },
                    { 105, 9, 0, 5, new DateTime(2023, 4, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 15, 0, null, 1, 13, 16 },
                    { 106, 10, 0, 5, new DateTime(2023, 4, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 15, 0, null, 1, 13, 16 },
                    { 107, 11, 0, 5, new DateTime(2023, 4, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 15, 0, null, 1, 13, 16 },
                    { 108, 12, 0, 5, new DateTime(2023, 4, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 15, 0, null, 1, 13, 16 },
                    { 109, 13, 0, 5, new DateTime(2023, 4, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 15, 0, null, 1, 14, 16 },
                    { 110, 14, 0, 5, new DateTime(2023, 4, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 15, 0, null, 1, 14, 16 },
                    { 111, 16, 0, 5, new DateTime(2023, 4, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 15, 0, null, 1, 14, 16 },
                    { 112, 17, 0, 5, new DateTime(2023, 4, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 15, 0, null, 1, 14, 16 },
                    { 113, 9, 0, 5, new DateTime(2023, 4, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, 0, null, 1, 15, 17 },
                    { 114, 10, 0, 5, new DateTime(2023, 4, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, 0, null, 1, 15, 17 },
                    { 115, 11, 0, 5, new DateTime(2023, 4, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, 0, null, 1, 15, 17 },
                    { 116, 12, 0, 5, new DateTime(2023, 4, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, 0, null, 1, 15, 17 },
                    { 117, 13, 0, 5, new DateTime(2023, 4, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, 0, null, 1, 16, 17 },
                    { 118, 14, 0, 5, new DateTime(2023, 4, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, 0, null, 1, 16, 17 },
                    { 119, 15, 0, 5, new DateTime(2023, 4, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, 0, null, 1, 16, 17 },
                    { 120, 17, 0, 5, new DateTime(2023, 4, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, 0, null, 1, 16, 17 },
                    { 121, 9, 0, 5, new DateTime(2023, 5, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, 0, null, 1, 17, 18 },
                    { 122, 10, 0, 5, new DateTime(2023, 5, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, 0, null, 1, 17, 18 },
                    { 123, 11, 0, 5, new DateTime(2023, 5, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, 0, null, 1, 17, 18 },
                    { 124, 12, 0, 5, new DateTime(2023, 5, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, 0, null, 1, 17, 18 },
                    { 125, 13, 0, 5, new DateTime(2023, 5, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, 0, null, 1, 18, 18 },
                    { 126, 14, 0, 5, new DateTime(2023, 5, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, 0, null, 1, 18, 18 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "DivisionId", "FixtureTime", "HomeTeamId", "HomeTeamScore", "RefereeSquadId", "SeasonId", "SeasonRound", "TownId" },
                values: new object[,]
                {
                    { 127, 15, 0, 5, new DateTime(2023, 5, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, 0, null, 1, 18, 18 },
                    { 128, 16, 0, 5, new DateTime(2023, 5, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, 0, null, 1, 18, 18 }
                });

            migrationBuilder.InsertData(
                table: "PlayerTeamSeason",
                columns: new[] { "PlayerId", "SeasonId", "TeamId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 2, 1 },
                    { 3, 2, 1 },
                    { 4, 2, 1 },
                    { 5, 2, 1 },
                    { 6, 2, 1 },
                    { 7, 2, 1 },
                    { 8, 2, 1 },
                    { 9, 2, 1 },
                    { 10, 2, 1 },
                    { 11, 2, 1 },
                    { 12, 2, 2 },
                    { 13, 2, 2 },
                    { 14, 2, 2 },
                    { 15, 2, 2 },
                    { 16, 2, 2 },
                    { 17, 2, 2 },
                    { 18, 2, 2 },
                    { 19, 2, 2 },
                    { 20, 2, 2 },
                    { 21, 2, 2 },
                    { 22, 2, 2 },
                    { 23, 2, 3 },
                    { 24, 2, 3 },
                    { 25, 2, 3 },
                    { 26, 2, 3 },
                    { 27, 2, 3 },
                    { 28, 2, 3 },
                    { 29, 2, 3 },
                    { 30, 2, 3 },
                    { 31, 2, 3 },
                    { 32, 2, 3 },
                    { 33, 2, 3 },
                    { 34, 2, 4 },
                    { 35, 2, 4 },
                    { 36, 2, 4 },
                    { 37, 2, 4 },
                    { 38, 2, 4 },
                    { 39, 2, 4 },
                    { 40, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "PlayerTeamSeason",
                columns: new[] { "PlayerId", "SeasonId", "TeamId" },
                values: new object[,]
                {
                    { 41, 2, 4 },
                    { 42, 2, 4 },
                    { 43, 2, 4 },
                    { 44, 2, 4 },
                    { 45, 2, 5 },
                    { 46, 2, 5 },
                    { 47, 2, 5 },
                    { 48, 2, 5 },
                    { 49, 2, 5 },
                    { 50, 2, 5 },
                    { 51, 2, 5 },
                    { 52, 2, 5 },
                    { 53, 2, 5 },
                    { 54, 2, 5 },
                    { 55, 2, 5 },
                    { 56, 2, 6 },
                    { 57, 2, 6 },
                    { 58, 2, 6 },
                    { 59, 2, 6 },
                    { 60, 2, 6 },
                    { 61, 2, 6 },
                    { 62, 2, 6 },
                    { 63, 2, 6 },
                    { 64, 2, 6 },
                    { 65, 2, 6 },
                    { 66, 2, 6 },
                    { 67, 2, 7 },
                    { 68, 2, 7 },
                    { 69, 2, 7 },
                    { 70, 2, 7 },
                    { 71, 2, 7 },
                    { 72, 2, 7 },
                    { 73, 2, 7 },
                    { 74, 2, 7 },
                    { 75, 2, 7 },
                    { 76, 2, 7 },
                    { 77, 2, 7 },
                    { 78, 2, 8 },
                    { 79, 2, 8 },
                    { 80, 2, 8 },
                    { 81, 2, 8 },
                    { 82, 2, 8 }
                });

            migrationBuilder.InsertData(
                table: "PlayerTeamSeason",
                columns: new[] { "PlayerId", "SeasonId", "TeamId" },
                values: new object[,]
                {
                    { 83, 2, 8 },
                    { 84, 2, 8 },
                    { 85, 2, 8 },
                    { 86, 2, 8 },
                    { 87, 2, 8 },
                    { 88, 2, 8 }
                });

            migrationBuilder.InsertData(
                table: "RefereesSquads",
                columns: new[] { "Id", "DelegateId", "FirstAssistantRefereeId", "MainRefereeId", "MatchId", "SecondAssistantRefereeId" },
                values: new object[] { new Guid("5f7a5bad-da9c-4fd9-871a-483492e9bdaa"), 4, 2, 1, 1, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10);

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
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 3, 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 4, 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 5, 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 6, 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 7, 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 8, 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 9, 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 10, 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 11, 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 12, 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 13, 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 14, 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 15, 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 16, 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 17, 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 18, 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 19, 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 20, 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 21, 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 22, 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 23, 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 24, 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 25, 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 26, 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 27, 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 28, 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 29, 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 30, 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 31, 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 32, 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 33, 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 34, 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 35, 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 36, 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 37, 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 38, 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 39, 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 40, 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 41, 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 42, 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 43, 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 44, 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 45, 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 46, 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 47, 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 48, 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 49, 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 50, 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 51, 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 52, 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 53, 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 54, 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 55, 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 56, 2, 6 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 57, 2, 6 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 58, 2, 6 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 59, 2, 6 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 60, 2, 6 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 61, 2, 6 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 62, 2, 6 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 63, 2, 6 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 64, 2, 6 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 65, 2, 6 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 66, 2, 6 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 67, 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 68, 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 69, 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 70, 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 71, 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 72, 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 73, 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 74, 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 75, 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 76, 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 77, 2, 7 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 78, 2, 8 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 79, 2, 8 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 80, 2, 8 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 81, 2, 8 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 82, 2, 8 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 83, 2, 8 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 84, 2, 8 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 85, 2, 8 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 86, 2, 8 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 87, 2, 8 });

            migrationBuilder.DeleteData(
                table: "PlayerTeamSeason",
                keyColumns: new[] { "PlayerId", "SeasonId", "TeamId" },
                keyValues: new object[] { 88, 2, 8 });

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
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 4 });

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
                table: "Players",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88);

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
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 1, 17 });

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
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 17);

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
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "TeamsSeasons",
                keyColumns: new[] { "SeasonId", "TeamId" },
                keyValues: new object[] { 2, 6 });

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
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

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
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
