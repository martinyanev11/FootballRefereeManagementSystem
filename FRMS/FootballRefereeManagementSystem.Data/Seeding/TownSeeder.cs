namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using SeedingDataConstants;

    internal class TownSeeder
    {
        internal ICollection<Town> GenerateTowns()
        {
            ICollection<Town> towns = new HashSet<Town>()
            {
                new Town()
                {
                    Id = TownDataConstants.PlevenTownId,
                    Name = "Плевен",
                    ZoneId = ZoneDataConstants.PlevenRegion
                },
                new Town()
                {
                    Id = TownDataConstants.TrunchovicaId,
                    Name = "Трънчовица",
                    ZoneId = ZoneDataConstants.PlevenRegion
                },
                new Town()
                {
                    Id = TownDataConstants.GulqnciId,
                    Name = "Гулянци",
                    ZoneId = ZoneDataConstants.PlevenRegion
                },
                new Town()
                {
                    Id = TownDataConstants.BeleneId,
                    Name = "Белене",
                    ZoneId = ZoneDataConstants.PlevenRegion
                },
                new Town()
                {
                    Id = TownDataConstants.GrivicaId,
                    Name = "Гривица",
                    ZoneId = ZoneDataConstants.PlevenRegion
                },
            };

            return towns;
        }
    }
}
