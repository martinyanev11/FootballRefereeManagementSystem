namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using Models.Enums;
    using SeedingDataConstants;

    internal class TeamSeasonSeeder
    {
        internal ICollection<TeamSeason> GenerateTeamsSeasons()
        {
            ICollection<TeamSeason> teamsSeasons = new HashSet<TeamSeason>()
            {
                new TeamSeason()
                {
                    TeamId = TownDataConstants.TrunchovicaId,
                    SeasonId = 2,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.White,
                    ManagerId = 1,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.GulqnciId,
                    SeasonId = 2,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Red,
                    ManagerId = 2,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.BeleneId,
                    SeasonId = 2,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Blue,
                    ManagerId = 3,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.GrivicaId,
                    SeasonId = 2,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Yellow,
                    ManagerId = 4,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.BrestId,
                    SeasonId = 2,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Pink,
                    ManagerId = 5,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.LepicaId,
                    SeasonId = 2,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Purple,
                    ManagerId = 6,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.NikopolId,
                    SeasonId = 2,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Orange,
                    ManagerId = 7,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.TrustenikId,
                    SeasonId = 2,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Black,
                    ManagerId = 8,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.BulgareneId,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    Wins = 8,
                    Draws = 3,
                    Losses = 5,
                    GoalsFor = 37,
                    GoalsAgainst = 32,
                    ShirtColor = Color.Red,
                    ManagerId = 9,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.VulchitrunId,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    Wins = 1,
                    Draws = 1,
                    Losses = 14,
                    GoalsFor = 20,
                    GoalsAgainst = 73,
                    ShirtColor = Color.Black,
                    ManagerId = 10,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.ZgalevoId,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    Wins = 6,
                    Draws = 1,
                    Losses = 9,
                    GoalsFor = 33,
                    GoalsAgainst = 56,
                    ShirtColor = Color.Violet,
                    ManagerId = 11,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.IzgrevId,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    Wins = 11,
                    Draws = 2,
                    Losses = 3,
                    GoalsFor = 48,
                    GoalsAgainst = 19,
                    ShirtColor = Color.White,
                    ManagerId = 12,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.ObnovaId,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    Wins = 13,
                    Draws = 1,
                    Losses = 2,
                    GoalsFor = 62,
                    GoalsAgainst = 20,
                    ShirtColor = Color.Brown,
                    ManagerId = 13,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.NovacheneId,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    Wins = 4,
                    Draws = 1,
                    Losses = 11,
                    GoalsFor = 26,
                    GoalsAgainst = 36,
                    ShirtColor = Color.Red,
                    ManagerId = 14,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.MuselievoId,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    Wins = 5,
                    Draws = 2,
                    Losses = 9,
                    GoalsFor = 28,
                    GoalsAgainst = 38,
                    ShirtColor = Color.Blue,
                    ManagerId = 15,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.PordimId,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    Wins = 4,
                    Draws = 3,
                    Losses = 9,
                    GoalsFor = 22,
                    GoalsAgainst = 37,
                    ShirtColor = Color.Yellow,
                    ManagerId = 16,
                },
                new TeamSeason()
                {
                    TeamId = TownDataConstants.BrushlqnicaId,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    Wins = 11,
                    Draws = 4,
                    Losses = 1,
                    GoalsFor = 51,
                    GoalsAgainst = 16,
                    ShirtColor = Color.Green,
                    ManagerId = 17,
                },
            };

            return teamsSeasons;
        }
    }
}
