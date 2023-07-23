namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using SeedingDataConstants;

    internal class PlayerTeamSeasonSeeder
    {
        internal ICollection<PlayerTeamSeason> GeneratePlayersTeamsSeasons(int ptsToGenerate)
        {
            // Seeding 11 players per team for "A regional group" teams for season 2023/24.
            ICollection<PlayerTeamSeason> ptsCollection = new HashSet<PlayerTeamSeason>();

            int teamId = TeamDataConstants.TrunchovicaId;
            int playersPerTeamCounter = 1;

            for (int playerId = 1; playerId <= ptsToGenerate; playerId++)
            {
                PlayerTeamSeason pts = new PlayerTeamSeason()
                {
                    PlayerId = playerId,
                    TeamId = teamId,
                    SeasonId = SeasonDataConstants.Season23And24Id
                };

                ptsCollection.Add(pts);
                playersPerTeamCounter++;

                if (playersPerTeamCounter > 11)
                {
                    playersPerTeamCounter = 1;
                    teamId++;
                }
            }

            return ptsCollection;
        }
    }
}
