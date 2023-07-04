namespace FootballRefereeManagementSystem.Data.Seeding
{
    using FootballRefereeManagementSystem.Data.Models;

    internal class SeasonSeeder
    {
        internal ICollection<Season> GenerateSeasons()
        {
            ICollection<Season> seasons = new HashSet<Season>()
            {
                new Season()
                {
                    Id = 1,
                    Description = "2022/23",
                    Start = new DateTime(2022, 9, 16),
                    End = new DateTime(2023, 5, 28)
                }
            };

            return seasons;
        }
    }
}
