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
                new Town()
                {
                    Id = TownDataConstants.BrestId,
                    Name = "Брест",
                    ZoneId= ZoneDataConstants.PlevenRegion
                },
                new Town()
                {
                    Id = TownDataConstants.LepicaId,
                    Name = "Лепица",
                    ZoneId = ZoneDataConstants.PlevenRegion
                },
                new Town()
                {
                    Id = TownDataConstants.NikopolId,
                    Name = "Никопол",
                    ZoneId = ZoneDataConstants.PlevenRegion
                },
                new Town()
                {
                    Id = TownDataConstants.TrustenikId,
                    Name = "Тръстеник",
                    ZoneId = ZoneDataConstants.PlevenRegion
                },
                new Town()
                {
                    Id = TownDataConstants.BulgareneId,
                    Name = "Българене",
                    ZoneId = ZoneDataConstants.PlevenEastZoneId
                },
                new Town()
                {
                    Id = TownDataConstants.VulchitrunId,
                    Name = "Вълчитрън",
                    ZoneId = ZoneDataConstants.PlevenEastZoneId
                },
                new Town()
                {
                    Id = TownDataConstants.ZgalevoId,
                    Name = "Згалево",
                    ZoneId = ZoneDataConstants.PlevenEastZoneId
                },
                new Town()
                {
                    Id = TownDataConstants.IzgrevId,
                    Name = "Изгрев",
                    ZoneId = ZoneDataConstants.PlevenEastZoneId
                },
                new Town()
                {
                    Id = TownDataConstants.ObnovaId,
                    Name = "Обнова",
                    ZoneId = ZoneDataConstants.PlevenEastZoneId
                },
                new Town()
                {
                    Id = TownDataConstants.NovacheneId,
                    Name = "Новачене",
                    ZoneId = ZoneDataConstants.PlevenEastZoneId
                },
                new Town()
                {
                    Id = TownDataConstants.MuselievoId,
                    Name = "Муселиево",
                    ZoneId = ZoneDataConstants.PlevenEastZoneId
                },
                new Town()
                {
                    Id = TownDataConstants.PordimId,
                    Name = "Пордим",
                    ZoneId = ZoneDataConstants.PlevenEastZoneId
                },
                new Town()
                {
                    Id = TownDataConstants.BrushlqnicaId,
                    Name = "Бръшляница",
                    ZoneId = ZoneDataConstants.PlevenEastZoneId
                },
            };

            return towns;
        }
    }
}
