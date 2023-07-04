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
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2022, 9, 17, 13, 0, 0),
                    HomeTeamId = 1,
                    AwayTeamId = 2,
                    SeasonId = 1,
                    RefereeSquadId = new Guid(RefereeSquadDataConstants.RefereeSquadGuid)
                },
                new Match()
                {
                    Id = 2,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2022, 9, 24, 15, 0, 0),
                    HomeTeamId = 1,
                    AwayTeamId = 3,
                    SeasonId = 1,
                },
                new Match()
                {
                    Id = 3,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.TrunchovicaId,
                    FixtureTime = new DateTime(2022, 10, 1, 18, 0, 0),
                    HomeTeamId = 1,
                    AwayTeamId = 4,
                    SeasonId = 1,
                },
                new Match()
                {
                    Id = 4,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2022, 10, 8, 11, 0, 0),
                    HomeTeamId = 2,
                    AwayTeamId = 1,
                    SeasonId = 1,
                },
                new Match()
                {
                    Id = 5,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2022, 9, 25, 11, 0, 0),
                    HomeTeamId = 2,
                    AwayTeamId = 3,
                    SeasonId = 1,
                },
                new Match()
                {
                    Id = 6,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GulqnciId,
                    FixtureTime = new DateTime(2022, 9, 18, 11, 0, 0),
                    HomeTeamId = 2,
                    AwayTeamId = 4,
                    SeasonId = 1,
                },
                new Match()
                {
                    Id = 7,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2022, 10, 2, 16, 0, 0),
                    HomeTeamId = 3,
                    AwayTeamId = 1,
                    SeasonId = 1,
                },
                new Match()
                {
                    Id = 8,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2022, 10, 9, 12, 0, 0),
                    HomeTeamId = 3,
                    AwayTeamId = 2,
                    SeasonId = 1,
                },
                new Match()
                {
                    Id = 9,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.BeleneId,
                    FixtureTime = new DateTime(2022, 9, 17, 11, 0, 0),
                    HomeTeamId = 3,
                    AwayTeamId = 4,
                    SeasonId = 1,
                },
                new Match()
                {
                    Id = 10,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2022, 9, 25, 11, 0, 0),
                    HomeTeamId = 4,
                    AwayTeamId = 1,
                    SeasonId = 1,
                },
                new Match()
                {
                    Id = 11,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2022, 9, 24, 15, 0, 0),
                    HomeTeamId = 4,
                    AwayTeamId = 2,
                    SeasonId = 1,
                },
                new Match()
                {
                    Id = 12,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    TownId = TownDataConstants.GrivicaId,
                    FixtureTime = new DateTime(2022, 10, 8, 11, 0, 0),
                    HomeTeamId = 4,
                    AwayTeamId = 3,
                    SeasonId = 1,
                },
            };

            return matches;
        }
    }
}
