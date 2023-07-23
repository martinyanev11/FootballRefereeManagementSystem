namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using SeedingDataConstants;

    internal class SeasonSeeder
    {
        internal ICollection<Season> GenerateSeasons()
        {
            ICollection<Season> seasons = new HashSet<Season>()
            {
                new Season()
                {
                    Id = SeasonDataConstants.Season22And23Id,
                    Description = "2022/23",
                    Start = DateTime.Parse(SeasonDataConstants.S22And23Start),
                    End = DateTime.Parse(SeasonDataConstants.S22And23End)
                },
                new Season()
                {
                    Id = SeasonDataConstants.Season23And24Id,
                    Description = "2023/24",
                    Start = DateTime.Parse(SeasonDataConstants.S23And24Start),
                    End = DateTime.Parse(SeasonDataConstants.S23And24End)
                },
            };

            return seasons;
        }
    }
}
