namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using SeedingDataConstants;

    internal class TeamSeeder
    {
        internal ICollection<Team> GenerateTeams()
        {
            ICollection<Team> teams = new HashSet<Team>()
            {
                new Team()
                {
                    Id = 1,
                    Name = "Ботев",
                    Abbreviation = "БТВ",
                    TownId = TownDataConstants.TrunchovicaId,
                },
                new Team()
                {
                    Id = 2,
                    Name = "Вихър",
                    Abbreviation = "ВХР",
                    TownId = TownDataConstants.GulqnciId,
                },
                new Team()
                {
                    Id = 3,
                    Name = "Гигант",
                    Abbreviation = "ГГТ",
                    TownId = TownDataConstants.BeleneId,
                },
                new Team()
                {
                    Id = 4,
                    Name = "Космос",
                    Abbreviation = "КМС",
                    TownId = TownDataConstants.GrivicaId,
                },
                //new Team()
                //{
                //    Id = 5,
                //    Name = "Левски",
                //    Abbreviation = "ЛСК",
                //    TownId = TownDataConstants.BrestId,
                //},
                //new Team()
                //{
                //    Id = 6,
                //    Name = "Светослав",
                //    Abbreviation = "ССВ",
                //    TownId = TownDataConstants.LepicaId,
                //},
                //new Team()
                //{
                //    Id = 7,
                //    Name = "Ситомир",
                //    Abbreviation = "СМР",
                //    TownId = TownDataConstants.NikopolId,
                //},
                //new Team()
                //{
                //    Id = 8,
                //    Name = "Тръстеник",
                //    Abbreviation = "ТНК",
                //    TownId = TownDataConstants.TrustenikId,
                //},
                //new Team()
                //{
                //    Id = 9,
                //    Name = "Ботев",
                //    Abbreviation = "БТВ",
                //    TownId = TownDataConstants.BulgareneId,
                //},
                //new Team()
                //{
                //    Id = 10,
                //    Name = "Ботев",
                //    Abbreviation = "БТВ",
                //    TownId = TownDataConstants.VulchitrunId,
                //},
                //new Team()
                //{
                //    Id = 11,
                //    Name = "Виная",
                //    Abbreviation = "ВИН",
                //    TownId = TownDataConstants.ZgalevoId,
                //},
                //new Team()
                //{
                //    Id = 12,
                //    Name = "Динамо",
                //    Abbreviation = "ДИН",
                //    TownId = TownDataConstants.IzgrevId,
                //},
                //new Team()
                //{
                //    Id = 13,
                //    Name = "Обнова",
                //    Abbreviation = "ОБН",
                //    TownId = TownDataConstants.ObnovaId,
                //},
                //new Team()
                //{
                //    Id = 14,
                //    Name = "Славия",
                //    Abbreviation = "СЛВ",
                //    TownId = TownDataConstants.NovacheneId,
                //},
                //new Team()
                //{
                //    Id = 15,
                //    Name = "Спартак",
                //    Abbreviation = "СТК",
                //    TownId = TownDataConstants.MuselievoId,
                //},
                //new Team()
                //{
                //    Id = 16,
                //    Name = "Пордим",
                //    Abbreviation = "ПДМ",
                //    TownId = TownDataConstants.PordimId,
                //},
                //new Team()
                //{
                //    Id = 17,
                //    Name = "Чавдар",
                //    Abbreviation = "ЧВР",
                //    TownId = TownDataConstants.BrushlqnicaId,
                //},
            };

            return teams;
        }
    }
}
