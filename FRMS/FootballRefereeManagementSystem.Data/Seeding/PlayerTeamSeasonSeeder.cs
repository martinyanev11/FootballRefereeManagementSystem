namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using SeedingDataConstants;

    internal class PlayerTeamSeasonSeeder
    {
        internal ICollection<PlayerTeamSeason> GeneratePlayersTeamsSeasons(int ptsToGenerate)
        {
            // Seeding 11 players per team for "A regional group" teams.
            ICollection<PlayerTeamSeason> ptsCollection = new HashSet<PlayerTeamSeason>();

            int teamId = TownDataConstants.TrunchovicaId;
            int playersPerTeamCounter = 0;

            for (int playerId = 1; playerId <= ptsToGenerate; playerId++)
            {
                PlayerTeamSeason pts = new PlayerTeamSeason()
                {
                    PlayerId = playerId,
                    TeamId = teamId,
                    SeasonId = SeasonDataConstants.Season22And23Id
                };

                ptsCollection.Add(pts);
                playersPerTeamCounter++;

                if (playersPerTeamCounter > 11)
                {
                    playersPerTeamCounter = 0;
                    teamId++;
                }
            }

            return ptsCollection;
        }
    }
}
