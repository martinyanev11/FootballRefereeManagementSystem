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
                    Id = TownDataConstants.TrunchovicaId,
                    Name = "Ботев",
                    TownId = TownDataConstants.TrunchovicaId,
                },
                new Team()
                {
                    Id = TownDataConstants.GulqnciId,
                    Name = "Вихър",
                    TownId = TownDataConstants.GulqnciId,
                },
                new Team()
                {
                    Id = TownDataConstants.BeleneId,
                    Name = "Гигант",
                    TownId = TownDataConstants.BeleneId,
                },
                new Team()
                {
                    Id = TownDataConstants.GrivicaId,
                    Name = "Космос",
                    TownId = TownDataConstants.GrivicaId,
                },
                new Team()
                {
                    Id = TownDataConstants.BrestId,
                    Name = "Левски",
                    TownId = TownDataConstants.BrestId,
                },
                new Team()
                {
                    Id = TownDataConstants.LepicaId,
                    Name = "Светослав",
                    TownId = TownDataConstants.LepicaId,
                },
                new Team()
                {
                    Id = TownDataConstants.NikopolId,
                    Name = "Ситомир",
                    TownId = TownDataConstants.NikopolId,
                },
                new Team()
                {
                    Id = TownDataConstants.TrustenikId,
                    Name = "Тръстеник",
                    TownId = TownDataConstants.TrustenikId,
                },
                new Team()
                {
                    Id = TownDataConstants.BulgareneId,
                    Name = "Ботев",
                    TownId = TownDataConstants.BulgareneId,
                },
                new Team()
                {
                    Id = TownDataConstants.VulchitrunId,
                    Name = "Ботев",
                    TownId = TownDataConstants.VulchitrunId,
                },
                new Team()
                {
                    Id = TownDataConstants.ZgalevoId,
                    Name = "Виная",
                    TownId = TownDataConstants.ZgalevoId,
                },
                new Team()
                {
                    Id = TownDataConstants.IzgrevId,
                    Name = "Динамо",
                    TownId = TownDataConstants.IzgrevId,
                },
                new Team()
                {
                    Id = TownDataConstants.ObnovaId,
                    Name = "Обнова",
                    TownId = TownDataConstants.ObnovaId,
                },
                new Team()
                {
                    Id = TownDataConstants.NovacheneId,
                    Name = "Славия",
                    TownId = TownDataConstants.NovacheneId,
                },
                new Team()
                {
                    Id = TownDataConstants.MuselievoId,
                    Name = "Спартак",
                    TownId = TownDataConstants.MuselievoId,
                },
                new Team()
                {
                    Id = TownDataConstants.PordimId,
                    Name = "Пордим",
                    TownId = TownDataConstants.PordimId,
                },
                new Team()
                {
                    Id = TownDataConstants.BrushlqnicaId,
                    Name = "Чавдар",
                    TownId = TownDataConstants.BrushlqnicaId,
                },
            };

            return teams;
        }
    }
}
