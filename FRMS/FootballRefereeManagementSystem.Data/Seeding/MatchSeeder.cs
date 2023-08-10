namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using SeedingDataConstants;

    public static class MatchSeeder
    {
        public static ICollection<Match> GenerateMatches()
        {
            // Hard coded seed "A regional group" matches for season 2023/24
            ICollection<Match> matches = new HashSet<Match>()
            {
                new Match()
                {
                    Id = 1,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2023, 9, 17, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.LepicaId,
                    AwayTeamId = TeamDataConstants.GrivicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                    RefereeSquadId = new Guid(RefereeSquadDataConstants.RefereeSquadGuid)
                },
                new Match()
                {
                    Id = 2,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2023, 9, 17, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.BrestId,
                    AwayTeamId = TeamDataConstants.GulqnciId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 3,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2023, 9, 17, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.TrustenikId,
                    AwayTeamId = TeamDataConstants.TrunchovicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 4,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2023, 9, 17, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.NikopolId,
                    AwayTeamId = TeamDataConstants.BeleneId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 5,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2023, 9, 24, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.GrivicaId,
                    AwayTeamId = TeamDataConstants.BeleneId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 6,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2023, 9, 24, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.TrunchovicaId,
                    AwayTeamId = TeamDataConstants.NikopolId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 7,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2023, 9, 24, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.GulqnciId,
                    AwayTeamId = TeamDataConstants.TrustenikId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 8,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2023, 9, 24, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.LepicaId,
                    AwayTeamId = TeamDataConstants.BrestId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 9,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2023, 10, 8, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.BrestId,
                    AwayTeamId = TeamDataConstants.GrivicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 10,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2023, 10, 8, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.TrustenikId,
                    AwayTeamId = TeamDataConstants.LepicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 11,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2023, 10, 8, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.NikopolId,
                    AwayTeamId = TeamDataConstants.GulqnciId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 12,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2023, 10, 8, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.BeleneId,
                    AwayTeamId = TeamDataConstants.TrunchovicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 13,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2023, 10, 15, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.GrivicaId,
                    AwayTeamId = TeamDataConstants.TrunchovicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 14,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2023, 10, 15, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.GulqnciId,
                    AwayTeamId = TeamDataConstants.BeleneId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 15,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2023, 10, 15, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.LepicaId,
                    AwayTeamId = TeamDataConstants.NikopolId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 16,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2023, 10, 15, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.BrestId,
                    AwayTeamId = TeamDataConstants.TrustenikId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 17,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2023, 10, 22, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.TrustenikId,
                    AwayTeamId = TeamDataConstants.GrivicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 18,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2023, 10, 22, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.NikopolId,
                    AwayTeamId = TeamDataConstants.BrestId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 19,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2023, 10, 22, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.BeleneId,
                    AwayTeamId = TeamDataConstants.LepicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 20,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2023, 10, 22, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.TrunchovicaId,
                    AwayTeamId = TeamDataConstants.GulqnciId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 21,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2023, 10, 29, 15, 0, 0),
                    HomeTeamId = TeamDataConstants.GrivicaId,
                    AwayTeamId = TeamDataConstants.GulqnciId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 22,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2023, 10, 29, 15, 0, 0),
                    HomeTeamId = TeamDataConstants.LepicaId,
                    AwayTeamId = TeamDataConstants.TrunchovicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 23,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2023, 10, 29, 15, 0, 0),
                    HomeTeamId = TeamDataConstants.BrestId,
                    AwayTeamId = TeamDataConstants.BeleneId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 24,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2023, 10, 29, 15, 0, 0),
                    HomeTeamId = TeamDataConstants.TrustenikId,
                    AwayTeamId = TeamDataConstants.NikopolId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 25,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2023, 11, 5, 15, 0, 0),
                    HomeTeamId = TeamDataConstants.NikopolId,
                    AwayTeamId = TeamDataConstants.GrivicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 26,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2023, 11, 5, 15, 0, 0),
                    HomeTeamId = TeamDataConstants.BeleneId,
                    AwayTeamId = TeamDataConstants.TrustenikId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 27,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2023, 11, 5, 15, 0, 0),
                    HomeTeamId = TeamDataConstants.TrunchovicaId,
                    AwayTeamId = TeamDataConstants.BrestId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 28,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2023, 11, 5, 15, 0, 0),
                    HomeTeamId = TeamDataConstants.GulqnciId,
                    AwayTeamId = TeamDataConstants.LepicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 29,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2024, 3, 25, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.GrivicaId,
                    AwayTeamId = TeamDataConstants.LepicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 30,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2024, 3, 25, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.GulqnciId,
                    AwayTeamId = TeamDataConstants.BrestId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 31,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2024, 3, 25, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.TrunchovicaId,
                    AwayTeamId = TeamDataConstants.TrustenikId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 32,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2024, 3, 25, 16, 0, 0),
                    HomeTeamId = TeamDataConstants.BeleneId,
                    AwayTeamId = TeamDataConstants.NikopolId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 33,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2024, 4, 8, 15, 0, 0),
                    HomeTeamId = TeamDataConstants.BeleneId,
                    AwayTeamId = TeamDataConstants.GrivicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 34,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2024, 4, 8, 15, 0, 0),
                    HomeTeamId = TeamDataConstants.NikopolId,
                    AwayTeamId = TeamDataConstants.TrunchovicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 35,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2024, 4, 8, 15, 0, 0),
                    HomeTeamId = TeamDataConstants.TrustenikId,
                    AwayTeamId = TeamDataConstants.GulqnciId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 36,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2024, 4, 8, 15, 0, 0),
                    HomeTeamId = TeamDataConstants.BrestId,
                    AwayTeamId = TeamDataConstants.LepicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 37,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2024, 4, 22, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.GrivicaId,
                    AwayTeamId = TeamDataConstants.BrestId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 38,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2024, 4, 22, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.LepicaId,
                    AwayTeamId = TeamDataConstants.TrustenikId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 39,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2024, 4, 22, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.GulqnciId,
                    AwayTeamId = TeamDataConstants.NikopolId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 40,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2024, 4, 22, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.TrunchovicaId,
                    AwayTeamId = TeamDataConstants.BeleneId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 41,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2024, 4, 29, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.TrunchovicaId,
                    AwayTeamId = TeamDataConstants.GrivicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 42,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2024, 4, 29, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.BeleneId,
                    AwayTeamId = TeamDataConstants.GulqnciId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 43,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2024, 4, 29, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.NikopolId,
                    AwayTeamId = TeamDataConstants.LepicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 44,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2024, 4, 29, 17, 0, 0),
                    HomeTeamId = TeamDataConstants.TrustenikId,
                    AwayTeamId = TeamDataConstants.BrestId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 45,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2024, 5, 13, 18, 0, 0),
                    HomeTeamId = TeamDataConstants.GrivicaId,
                    AwayTeamId = TeamDataConstants.TrustenikId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 46,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2024, 5, 13, 18, 0, 0),
                    HomeTeamId = TeamDataConstants.BrestId,
                    AwayTeamId = TeamDataConstants.NikopolId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 47,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2024, 5, 13, 18, 0, 0),
                    HomeTeamId = TeamDataConstants.LepicaId,
                    AwayTeamId = TeamDataConstants.BeleneId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 48,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2024, 5, 13, 18, 0, 0),
                    HomeTeamId = TeamDataConstants.GulqnciId,
                    AwayTeamId = TeamDataConstants.TrunchovicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 49,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2024, 5, 20, 18, 0, 0),
                    HomeTeamId = TeamDataConstants.GulqnciId,
                    AwayTeamId = TeamDataConstants.GrivicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 50,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2024, 5, 20, 18, 0, 0),
                    HomeTeamId = TeamDataConstants.TrunchovicaId,
                    AwayTeamId = TeamDataConstants.LepicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 51,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2024, 5, 20, 18, 0, 0),
                    HomeTeamId = TeamDataConstants.BeleneId,
                    AwayTeamId = TeamDataConstants.BrestId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 52,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.NikopolId,
                    FixtureTime = new DateTime(2024, 5, 20, 18, 0, 0),
                    HomeTeamId = TeamDataConstants.NikopolId,
                    AwayTeamId = TeamDataConstants.TrustenikId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 53,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2024, 5, 27, 18, 0, 0),
                    HomeTeamId = TeamDataConstants.GrivicaId,
                    AwayTeamId = TeamDataConstants.NikopolId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 54,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrustenikId,
                    FixtureTime = new DateTime(2024, 5, 27, 18, 0, 0),
                    HomeTeamId = TeamDataConstants.TrustenikId,
                    AwayTeamId = TeamDataConstants.BeleneId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 55,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BrestId,
                    FixtureTime = new DateTime(2024, 5, 27, 18, 0, 0),
                    HomeTeamId = TeamDataConstants.BrestId,
                    AwayTeamId = TeamDataConstants.TrunchovicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
                new Match()
                {
                    Id = 56,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.LepicaId,
                    FixtureTime = new DateTime(2024, 5, 27, 18, 0, 0),
                    HomeTeamId = TeamDataConstants.LepicaId,
                    AwayTeamId = TeamDataConstants.GulqnciId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                },
            };

            // Automated seed for matches for teams in zone "B regional group east" season 2022/23
            bool addedSeasonBreak = false;

            // Counts season round in which match is played
            int currentSeasonRound = 1;
            int matchesPerRoundCounter = 1;

            int matchId = 57; // Start from next free ID after hard coded matches

            DateTime fixtureTime = DateTime.Parse(SeasonDataConstants.S22And23Start); // First match is when season starts

            for (int homeTeamId = TeamDataConstants.BulgareneId; homeTeamId <= TeamDataConstants.BrushlqnicaId; homeTeamId++)
            {
                int townId = homeTeamId + 1; // NOTE: TownId is HomeTeamId + 1 (from SeedingDataConstants).

                for (int awayTeamId = TeamDataConstants.BulgareneId; awayTeamId <= TeamDataConstants.BrushlqnicaId; awayTeamId++)
                {
                    if (currentSeasonRound == 10 && !addedSeasonBreak) // Mid season break to be added
                    {
                        fixtureTime = new DateTime(2023, 3, 18, 15, 0, 0);
                        addedSeasonBreak = true;
                    }

                    if (homeTeamId == awayTeamId) // Forbit teams to play against themself
                    {
                        continue;
                    }

                    Match match = new Match()
                    {
                        Id = matchId,
                        DivisionId = DivisionDataConstants.RegionalBGroupId,
                        TownId = townId,
                        FixtureTime = fixtureTime,
                        HomeTeamId = homeTeamId,
                        AwayTeamId = awayTeamId,
                        SeasonId = SeasonDataConstants.Season22And23Id,
                        HasFinished = true,
                    };

                    matches.Add(match);

                    matchId++;
                    matchesPerRoundCounter++;
                    if (matchesPerRoundCounter > 4) // 4 matches per round
                    {
                        matchesPerRoundCounter = 1; // Reset counter
                        currentSeasonRound++; // Increment round
                        fixtureTime = fixtureTime.AddDays(7); // Go to next week
                    }
                }
            }

            return matches;
        }
    }
}
