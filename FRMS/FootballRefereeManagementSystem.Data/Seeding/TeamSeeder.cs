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
                    Id = TeamDataConstants.TrunchovicaId,
                    Name = "Ботев",
                    TownId = TownDataConstants.TrunchovicaId,
                },
                new Team()
                {
                    Id = TeamDataConstants.GulqnciId,
                    Name = "Вихър",
                    TownId = TownDataConstants.GulqnciId,
                },
                new Team()
                {
                    Id = TeamDataConstants.BeleneId,
                    Name = "Гигант",
                    TownId = TownDataConstants.BeleneId,
                },
                new Team()
                {
                    Id = TeamDataConstants.GrivicaId,
                    Name = "Космос",
                    TownId = TownDataConstants.GrivicaId,
                },
                new Team()
                {
                    Id = TeamDataConstants.BrestId,
                    Name = "Левски",
                    TownId = TownDataConstants.BrestId,
                },
                new Team()
                {
                    Id = TeamDataConstants.LepicaId,
                    Name = "Светослав",
                    TownId = TownDataConstants.LepicaId,
                },
                new Team()
                {
                    Id = TeamDataConstants.NikopolId,
                    Name = "Ситомир",
                    TownId = TownDataConstants.NikopolId,
                },
                new Team()
                {
                    Id = TeamDataConstants.TrustenikId,
                    Name = "Тръстеник",
                    TownId = TownDataConstants.TrustenikId,
                },
                new Team()
                {
                    Id = TeamDataConstants.BulgareneId,
                    Name = "Ботев",
                    TownId = TownDataConstants.BulgareneId,
                },
                new Team()
                {
                    Id = TeamDataConstants.VulchitrunId,
                    Name = "Ботев",
                    TownId = TownDataConstants.VulchitrunId,
                },
                new Team()
                {
                    Id = TeamDataConstants.ZgalevoId,
                    Name = "Виная",
                    TownId = TownDataConstants.ZgalevoId,
                },
                new Team()
                {
                    Id = TeamDataConstants.IzgrevId,
                    Name = "Динамо",
                    TownId = TownDataConstants.IzgrevId,
                },
                new Team()
                {
                    Id = TeamDataConstants.ObnovaId,
                    Name = "Обнова",
                    TownId = TownDataConstants.ObnovaId,
                },
                new Team()
                {
                    Id = TeamDataConstants.NovacheneId,
                    Name = "Славия",
                    TownId = TownDataConstants.NovacheneId,
                },
                new Team()
                {
                    Id = TeamDataConstants.MuselievoId,
                    Name = "Спартак",
                    TownId = TownDataConstants.MuselievoId,
                },
                new Team()
                {
                    Id = TeamDataConstants.PordimId,
                    Name = "Пордим",
                    TownId = TownDataConstants.PordimId,
                },
                new Team()
                {
                    Id = TeamDataConstants.BrushlqnicaId,
                    Name = "Чавдар",
                    TownId = TownDataConstants.BrushlqnicaId,
                },
            };

            return teams;
        }
    }
}
