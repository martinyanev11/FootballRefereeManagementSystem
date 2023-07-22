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
                    Id = SeasonDataConstants.Season21And22Id,
                    Description = "2021/22",
                    Start = DateTime.Parse(SeasonDataConstants.S21And22Start),
                    End = DateTime.Parse(SeasonDataConstants.S21And22End)
                },
                new Season()
                {
                    Id = SeasonDataConstants.Season22And23Id,
                    Description = "2022/23",
                    Start = DateTime.Parse(SeasonDataConstants.S22And23Start),
                    End = DateTime.Parse(SeasonDataConstants.S22And23End)
                },
            };

            return seasons;
        }
    }
}
