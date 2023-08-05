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
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.GulqnciId,
                    Name = "Вихър",
                    TownId = TownDataConstants.GulqnciId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.BeleneId,
                    Name = "Гигант",
                    TownId = TownDataConstants.BeleneId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.GrivicaId,
                    Name = "Космос",
                    TownId = TownDataConstants.GrivicaId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.BrestId,
                    Name = "Левски",
                    TownId = TownDataConstants.BrestId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.LepicaId,
                    Name = "Светослав",
                    TownId = TownDataConstants.LepicaId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.NikopolId,
                    Name = "Ситомир",
                    TownId = TownDataConstants.NikopolId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.TrustenikId,
                    Name = "Тръстеник",
                    TownId = TownDataConstants.TrustenikId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.BulgareneId,
                    Name = "Ботев",
                    TownId = TownDataConstants.BulgareneId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.VulchitrunId,
                    Name = "Ботев",
                    TownId = TownDataConstants.VulchitrunId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.ZgalevoId,
                    Name = "Виная",
                    TownId = TownDataConstants.ZgalevoId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.IzgrevId,
                    Name = "Динамо",
                    TownId = TownDataConstants.IzgrevId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.ObnovaId,
                    Name = "Обнова",
                    TownId = TownDataConstants.ObnovaId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.NovacheneId,
                    Name = "Славия",
                    TownId = TownDataConstants.NovacheneId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.MuselievoId,
                    Name = "Спартак",
                    TownId = TownDataConstants.MuselievoId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.PordimId,
                    Name = "Пордим",
                    TownId = TownDataConstants.PordimId,
                    IsActive = true,
                },
                new Team()
                {
                    Id = TeamDataConstants.BrushlqnicaId,
                    Name = "Чавдар",
                    TownId = TownDataConstants.BrushlqnicaId,
                    IsActive = true,
                },
            };

            return teams;
        }
    }
}
