﻿namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using SeedingDataConstants;

    internal class ArticleSeeder
    {
        internal ICollection<Article> GenerateArticles()
        {
            ICollection<Article> articles = new HashSet<Article>()
            {
                new Article()
                {
                    Id = 1,
                    Title = "Заседание на СТК при ОС на БФС Плевен",
                    Content = $"На 08.06.2023г в ОС на БФС-Плевен се проведе заседание на СТК при ОС на БФС Плевен и бяха взети следните решения:\r\n\r\nНа 04.06.2023г. в среща от 18 кръг на първенството на „Б”ОФГ-изток между отборите на ФК\"Обнова-2022\" – Обнова и ФК\"Чавдар-1920\" – Бръшляница, проведена в с.Обнова от 18ч. В 80мин. на срещата при резултат 1:0 в полза на ФК\"Обнова-2022\" е отсъден 11-метров наказателен удар в полза на ФК\"Обнова-2022\".Следва бурен протест от състезателите на ФК\"Чавдар-1920\" – Бръшляница.Нанесени са удари на гл.съдия в главата и тялото от състезатели на ФК\"Чавдар-1920\" – Бръшляница.поради създалата се обстановка при която е застрашено здравето и сигурността на длъжностните лица и няма условия футболната среща да продължи, същата е прекратена.\r\n\r\nНа основание чл.24 ал.9 от наредбата на БФС,се присъжда служебна  загуба при резултат 4:0 в полза на ФК\"Обнова-2022\".\r\n\r\nНеизрядната страна няма право да обжалва наказанието по тази алинея.",
                },
                new Article()
                {
                    Id = 2,
                    Title = "Решение на ДК- ОС на БФС Плевен",
                    Content = "В среща от 17-ти кръг от първенството на „Б” ОФГ-запад между отборите на ФК\"Мизия-1924\" – Кнежа и ФК”Спартак-1924”-Койнаре проведена на 28.05. от 18ч. в гр.Кнежа и бяха взети следните решения:За навлизане на публиката на гостите от ФК”Спартак-1924”-Койнаре на терена по  време на срещата :Наказва ФК”Спартак-1924”-Койнаре с предупреждение, лишаване от домакинство и глоба в размер на 150/сто и петдесет/лева  по чл.37 ал.1 буква „в” от ДП.",
                },
                new Article()
                {
                    Id = 3,
                    Title = "Решение на ДК- ОС на БФС Плевен",
                    Content = "В среща от 15-ти кръг от първенството на „Б” ОФГ-изток между отборите на ФК\"Славия\"-Новачене и ФК\"Обнова-2022\" - Обнова проведена на14.05.от 18ч. в с.Новачене и бяха взети следните решения:Наказва Явор Руменов Димитров  от отбора на ФК\"Славия\"-Новачене за получен червен картон със ССП за 1/една/ среща по чл.22 ал.1 т.1буква „з”от ДП.Наказва Галин Пламенов Георгиев от отбора на ФК\"Обнова-2022\" - Обнова за получен червен картон със ССП за 1/една/ среща по чл.22 ал.1 т.1буква „в”от ДП.",
                },
                new Article()
                {
                    Id = 4,
                    Title = "Промени и допълнения в Правилата на играта, влизащи в сила през новия сезон",
                    Content = "Съдийската комисия към Българския футболен съюз уведомява клубовете в системата на българското първенство, че от началото на новия спортно-състезателен сезон 2023/2024 г. в сила влизат някои промени и допълнения към Правилата на играта в съответствие с изискванията на Международния борд на футболните асоциации (IFAB).",
                    CreatedOn = new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Utc)
                },
                new Article()
                {
                    Id = 5,
                    Title = "УЕФА с положителна оценка за развитието на обучители на треньори у нас",
                    Content = "Ръководителят на отдел „Техническо развитие“ към УЕФА Франк К. Лудолф изпрати официално писмо до Българския футболен съюз, в което изказва положителната оценка на европейската централа за програмата за развитие на обучители на треньори на БФС, която отговаря на стандартите на УЕФА.\nНа панела Jira, проведен в Нион на 5 май т.г., Българският футболен съюз и Треньорската школа по футбол са получили отлични отзиви за работата си с менторите на треньори.",
                    CreatedOn = new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc)
                },
                new Article()
                {
                    Id = 6,
                    Title = "Протокол №8 от заседание на СТК при ОС на БФС Плевен",
                    Content = "Заседанието премина при следния дневен ред.\r\n\r\n1.Разглеждане на жалба от ФК „Свобода ”-Милковица за нередовен състезател.\r\n\r\nСлед като СТК се запозна с жалбата и с приложените доказателства по нея установи:\r\n\r\n1.На 09.11.2022г. по време на футболната среща от 12-кръг на „Б”ОФГ-Център  между ФК\"Спартак\"-Божурица и ФК „Свобода ”-Милковица.проведена в с.Божурица от11ч.,взема участие нередовен състезател в отбора на ФК\"Спартак\"-Божурица",
                    CreatedOn = new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc)
                }
            };

            return articles;
        }
    }
}
