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
                    TownId = TownDataConstants.TrunchovicaId,
                },
                new Team()
                {
                    Id = 2,
                    Name = "Вихър",
                    TownId = TownDataConstants.GulqnciId,
                },
                new Team()
                {
                    Id = 3,
                    Name = "Гигант",
                    TownId = TownDataConstants.BeleneId,
                },
                new Team()
                {
                    Id = 4,
                    Name = "Космос",
                    TownId = TownDataConstants.GrivicaId,
                },
            };

            return teams;
        }
    }
}
