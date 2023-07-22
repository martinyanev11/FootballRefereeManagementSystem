namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using SeedingDataConstants;

    internal class MatchSeeder
    {
        internal ICollection<Match> GenerateMatches()
        {
            ICollection<Match> matches = new HashSet<Match>()
            {
                new Match()
                {
                    Id = 1,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2022, 9, 17, 17, 0, 0),
                    HomeTeamId = TownDataConstants.LepicaId,
                    AwayTeamId = TownDataConstants.GrivicaId,
                    SeasonId = 2,
                    RefereeSquadId = new Guid(RefereeSquadDataConstants.RefereeSquadGuid)
                },
                new Match()
                {
                    Id = 2,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2022, 9, 17, 17, 0, 0),
                    HomeTeamId = TownDataConstants.BrestId,
                    AwayTeamId = TownDataConstants.GulqnciId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 3,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2022, 9, 17, 17, 0, 0),
                    HomeTeamId = TownDataConstants.TrustenikId,
                    AwayTeamId = TownDataConstants.TrunchovicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 4,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2022, 9, 17, 17, 0, 0),
                    HomeTeamId = TownDataConstants.NikopolId,
                    AwayTeamId = TownDataConstants.BeleneId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 5,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2022, 9, 24, 17, 0, 0),
                    HomeTeamId = TownDataConstants.GrivicaId,
                    AwayTeamId = TownDataConstants.BeleneId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 6,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2022, 9, 24, 17, 0, 0),
                    HomeTeamId = TownDataConstants.TrunchovicaId,
                    AwayTeamId = TownDataConstants.NikopolId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 7,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2022, 9, 24, 17, 0, 0),
                    HomeTeamId = TownDataConstants.GulqnciId,
                    AwayTeamId = TownDataConstants.TrustenikId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 8,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2022, 9, 24, 17, 0, 0),
                    HomeTeamId = TownDataConstants.LepicaId,
                    AwayTeamId = TownDataConstants.BrestId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 9,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2022, 10, 8, 16, 0, 0),
                    HomeTeamId = TownDataConstants.BrestId,
                    AwayTeamId = TownDataConstants.GrivicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 10,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2022, 10, 8, 16, 0, 0),
                    HomeTeamId = TownDataConstants.TrustenikId,
                    AwayTeamId = TownDataConstants.LepicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 11,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2022, 10, 8, 16, 0, 0),
                    HomeTeamId = TownDataConstants.NikopolId,
                    AwayTeamId = TownDataConstants.GulqnciId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 12,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2022, 10, 8, 16, 0, 0),
                    HomeTeamId = TownDataConstants.BeleneId,
                    AwayTeamId = TownDataConstants.TrunchovicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 13,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2022, 10, 15, 16, 0, 0),
                    HomeTeamId = TownDataConstants.GrivicaId,
                    AwayTeamId = TownDataConstants.TrunchovicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 14,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2022, 10, 15, 16, 0, 0),
                    HomeTeamId = TownDataConstants.GulqnciId,
                    AwayTeamId = TownDataConstants.BeleneId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 15,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2022, 10, 15, 16, 0, 0),
                    HomeTeamId = TownDataConstants.LepicaId,
                    AwayTeamId = TownDataConstants.NikopolId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 16,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2022, 10, 15, 16, 0, 0),
                    HomeTeamId = TownDataConstants.BrestId,
                    AwayTeamId = TownDataConstants.TrustenikId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 17,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2022, 10, 22, 16, 0, 0),
                    HomeTeamId = TownDataConstants.TrustenikId,
                    AwayTeamId = TownDataConstants.GrivicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 18,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2022, 10, 22, 16, 0, 0),
                    HomeTeamId = TownDataConstants.NikopolId,
                    AwayTeamId = TownDataConstants.BrestId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 19,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2022, 10, 22, 16, 0, 0),
                    HomeTeamId = TownDataConstants.BeleneId,
                    AwayTeamId = TownDataConstants.LepicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 20,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2022, 10, 22, 16, 0, 0),
                    HomeTeamId = TownDataConstants.TrunchovicaId,
                    AwayTeamId = TownDataConstants.GulqnciId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 21,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2022, 10, 29, 15, 0, 0),
                    HomeTeamId = TownDataConstants.GrivicaId,
                    AwayTeamId = TownDataConstants.GulqnciId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 22,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2022, 10, 29, 15, 0, 0),
                    HomeTeamId = TownDataConstants.LepicaId,
                    AwayTeamId = TownDataConstants.TrunchovicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 23,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2022, 10, 29, 15, 0, 0),
                    HomeTeamId = TownDataConstants.BrestId,
                    AwayTeamId = TownDataConstants.BeleneId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 24,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2022, 10, 29, 15, 0, 0),
                    HomeTeamId = TownDataConstants.TrustenikId,
                    AwayTeamId = TownDataConstants.NikopolId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 25,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2022, 11, 5, 15, 0, 0),
                    HomeTeamId = TownDataConstants.NikopolId,
                    AwayTeamId = TownDataConstants.GrivicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 26,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2022, 11, 5, 15, 0, 0),
                    HomeTeamId = TownDataConstants.BeleneId,
                    AwayTeamId = TownDataConstants.TrustenikId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 27,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2022, 11, 5, 15, 0, 0),
                    HomeTeamId = TownDataConstants.TrunchovicaId,
                    AwayTeamId = TownDataConstants.BrestId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 28,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2022, 11, 5, 15, 0, 0),
                    HomeTeamId = TownDataConstants.GulqnciId,
                    AwayTeamId = TownDataConstants.LepicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 29,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2023, 3, 25, 16, 0, 0),
                    HomeTeamId = TownDataConstants.GrivicaId,
                    AwayTeamId = TownDataConstants.LepicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 30,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2023, 3, 25, 16, 0, 0),
                    HomeTeamId = TownDataConstants.GulqnciId,
                    AwayTeamId = TownDataConstants.BrestId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 31,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2023, 3, 25, 16, 0, 0),
                    HomeTeamId = TownDataConstants.TrunchovicaId,
                    AwayTeamId = TownDataConstants.TrustenikId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 32,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2023, 3, 25, 16, 0, 0),
                    HomeTeamId = TownDataConstants.BeleneId,
                    AwayTeamId = TownDataConstants.NikopolId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 33,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2023, 4, 8, 15, 0, 0),
                    HomeTeamId = TownDataConstants.BeleneId,
                    AwayTeamId = TownDataConstants.GrivicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 34,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2023, 4, 8, 15, 0, 0),
                    HomeTeamId = TownDataConstants.NikopolId,
                    AwayTeamId = TownDataConstants.TrunchovicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 35,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2023, 4, 8, 15, 0, 0),
                    HomeTeamId = TownDataConstants.TrustenikId,
                    AwayTeamId = TownDataConstants.GulqnciId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 36,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2023, 4, 8, 15, 0, 0),
                    HomeTeamId = TownDataConstants.BrestId,
                    AwayTeamId = TownDataConstants.LepicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 37,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2023, 4, 22, 17, 0, 0),
                    HomeTeamId = TownDataConstants.GrivicaId,
                    AwayTeamId = TownDataConstants.BrestId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 38,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2023, 4, 22, 17, 0, 0),
                    HomeTeamId = TownDataConstants.LepicaId,
                    AwayTeamId = TownDataConstants.TrustenikId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 39,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2023, 4, 22, 17, 0, 0),
                    HomeTeamId = TownDataConstants.GulqnciId,
                    AwayTeamId = TownDataConstants.NikopolId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 40,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2023, 4, 22, 17, 0, 0),
                    HomeTeamId = TownDataConstants.TrunchovicaId,
                    AwayTeamId = TownDataConstants.BeleneId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 41,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2023, 4, 29, 17, 0, 0),
                    HomeTeamId = TownDataConstants.TrunchovicaId,
                    AwayTeamId = TownDataConstants.GrivicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 42,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2023, 4, 29, 17, 0, 0),
                    HomeTeamId = TownDataConstants.BeleneId,
                    AwayTeamId = TownDataConstants.GulqnciId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 43,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2023, 4, 29, 17, 0, 0),
                    HomeTeamId = TownDataConstants.NikopolId,
                    AwayTeamId = TownDataConstants.LepicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 44,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2023, 4, 29, 17, 0, 0),
                    HomeTeamId = TownDataConstants.TrustenikId,
                    AwayTeamId = TownDataConstants.BrestId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 45,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2023, 5, 13, 18, 0, 0),
                    HomeTeamId = TownDataConstants.GrivicaId,
                    AwayTeamId = TownDataConstants.TrustenikId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 46,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2023, 5, 13, 18, 0, 0),
                    HomeTeamId = TownDataConstants.BrestId,
                    AwayTeamId = TownDataConstants.NikopolId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 47,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2023, 5, 13, 18, 0, 0),
                    HomeTeamId = TownDataConstants.LepicaId,
                    AwayTeamId = TownDataConstants.BeleneId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 48,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2023, 5, 13, 18, 0, 0),
                    HomeTeamId = TownDataConstants.GulqnciId,
                    AwayTeamId = TownDataConstants.TrunchovicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 49,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2023, 5, 20, 18, 0, 0),
                    HomeTeamId = TownDataConstants.GulqnciId,
                    AwayTeamId = TownDataConstants.GrivicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 50,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2023, 5, 20, 18, 0, 0),
                    HomeTeamId = TownDataConstants.TrunchovicaId,
                    AwayTeamId = TownDataConstants.LepicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 51,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2023, 5, 20, 18, 0, 0),
                    HomeTeamId = TownDataConstants.BeleneId,
                    AwayTeamId = TownDataConstants.BrestId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 52,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2023, 5, 20, 18, 0, 0),
                    HomeTeamId = TownDataConstants.NikopolId,
                    AwayTeamId = TownDataConstants.TrustenikId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 53,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2023, 5, 27, 18, 0, 0),
                    HomeTeamId = TownDataConstants.GrivicaId,
                    AwayTeamId = TownDataConstants.NikopolId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 54,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2023, 5, 27, 18, 0, 0),
                    HomeTeamId = TownDataConstants.TrustenikId,
                    AwayTeamId = TownDataConstants.BeleneId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 55,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2023, 5, 27, 18, 0, 0),
                    HomeTeamId = TownDataConstants.BrestId,
                    AwayTeamId = TownDataConstants.TrunchovicaId,
                    SeasonId = 2,
                },
                new Match()
                {
                    Id = 56,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2023, 5, 27, 18, 0, 0),
                    HomeTeamId = TownDataConstants.LepicaId,
                    AwayTeamId = TownDataConstants.GulqnciId,
                    SeasonId = 2,
                },
            };

            //// Seed matches for teams in zone "B regional group east"
            //for (int i = TownDataConstants.BulgareneId; i < length; i++)
            //{

            //}

            return matches;
        }
    }
}
