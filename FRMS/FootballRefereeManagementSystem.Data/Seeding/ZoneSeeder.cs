namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using static SeedingDataConstants.ZoneDataConstants;

    public static class ZoneSeeder
    {
        public static ICollection<Zone> GenerateZones()
        {
            ICollection<Zone> zones = new HashSet<Zone>()
            {
                new Zone()
                {
                    Id = PlevenEastZoneId,
                    Name = "Плевен Изток"
                },
                new Zone()
                {
                    Id= PlevenWestZoneId,
                    Name = "Плевен Запад"
                },
                new Zone()
                {
                    Id= PlevenCentralZoneId,
                    Name = "Плевен Център"
                },
                new Zone()
                {
                    Id= PlevenRegion,
                    Name = "Плевенска Област"
                }
            };

            return zones;
        }
    }
}
