namespace FootballRefereeManagementSystem.Data.Seeding
{
    using FootballRefereeManagementSystem.Data.Models;
    using SeedingDataConstants;
    using Models.Enums;

    internal class TeamSeasonSeeder
    {
        internal ICollection<TeamSeason> GenerateTeamsSeasons()
        {
            ICollection<TeamSeason> teamsSeasons = new HashSet<TeamSeason>()
            {
                new TeamSeason()
                {
                    TeamId = 1,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    Points = 0,
                    Placement = 1,
                    ShirtColor = Color.White,
                    ManagerId = 1,
                },
                new TeamSeason()
                {
                    TeamId = 2,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    Points= 0,
                    Placement = 1,
                    ShirtColor = Color.Red,
                    ManagerId = 2,
                },
                new TeamSeason()
                {
                    TeamId = 3,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    Points= 0,
                    Placement = 1,
                    ShirtColor = Color.Blue,
                    ManagerId = 3,
                },
                new TeamSeason()
                {
                    TeamId = 4,
                    SeasonId = 1,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    Points= 0,
                    Placement = 1,
                    ShirtColor = Color.Yellow,
                    ManagerId = 4,
                }
            };

            return teamsSeasons;
        }
    }
}
