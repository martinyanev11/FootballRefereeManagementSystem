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
                    TeamId = TeamDataConstants.TrunchovicaId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.White,
                    ManagerId = 1,
                },
                new TeamSeason()
                {
                    TeamId = TeamDataConstants.GulqnciId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Red,
                    ManagerId = 2,
                },
                new TeamSeason()
                {
                    TeamId = TeamDataConstants.BeleneId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Blue,
                    ManagerId = 3,
                },
                new TeamSeason()
                {
                    TeamId = TeamDataConstants.GrivicaId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Yellow,
                    ManagerId = 4,
                },
                new TeamSeason()
                {
                    TeamId = TeamDataConstants.TrunchovicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.White,
                    ManagerId = 1,
                },
                new TeamSeason()
                {
                    TeamId = TeamDataConstants.GulqnciId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Red,
                    ManagerId = 2,
                },
                new TeamSeason()
                {
                    TeamId = TeamDataConstants.BeleneId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Blue,
                    ManagerId = 3,
                },
                new TeamSeason()
                {
                    TeamId = TeamDataConstants.GrivicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Yellow,
                    ManagerId = 4,
                },
                new TeamSeason()
                {
                    TeamId = TeamDataConstants.BrestId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Pink,
                    ManagerId = 5,
                },
                new TeamSeason()
                {
                    TeamId = TeamDataConstants.LepicaId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Purple,
                    ManagerId = 6,
                },
                new TeamSeason()
                {
                    TeamId = TeamDataConstants.NikopolId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Orange,
                    ManagerId = 7,
                },
                new TeamSeason()
                {
                    TeamId = TeamDataConstants.TrustenikId,
                    SeasonId = SeasonDataConstants.Season23And24Id,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    ShirtColor = Color.Black,
                    ManagerId = 8,
                },
                new TeamSeason()
                {
                    TeamId = TeamDataConstants.BulgareneId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
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
                    TeamId = TeamDataConstants.VulchitrunId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
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
                    TeamId = TeamDataConstants.ZgalevoId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
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
                    TeamId = TeamDataConstants.IzgrevId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
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
                    TeamId = TeamDataConstants.ObnovaId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
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
                    TeamId = TeamDataConstants.NovacheneId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
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
                    TeamId = TeamDataConstants.MuselievoId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
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
                    TeamId = TeamDataConstants.PordimId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
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
                    TeamId = TeamDataConstants.BrushlqnicaId,
                    SeasonId = SeasonDataConstants.Season22And23Id,
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
