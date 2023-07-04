namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;

    internal class PlayerTeamSeasonSeeder
    {
        internal ICollection<PlayerTeamSeason> GeneratePlayersTeamsSeasons()
        {
            ICollection<PlayerTeamSeason> ptsCollection = new HashSet<PlayerTeamSeason>();

            int counter = 1;
            while (counter < 45)
            {
                if (counter <= 11)
                {
                    PlayerTeamSeason pts = new PlayerTeamSeason()
                    {
                        TeamId = 1,
                        SeasonId = 1,
                        PlayerId = counter
                    };

                    ptsCollection.Add(pts);
                }
                else if (counter <= 22)
                {
                    PlayerTeamSeason pts = new PlayerTeamSeason()
                    {
                        TeamId = 2,
                        SeasonId = 1,
                        PlayerId = counter
                    };

                    ptsCollection.Add(pts);
                }
                else if (counter <= 33)
                {
                    PlayerTeamSeason pts = new PlayerTeamSeason()
                    {
                        TeamId = 3,
                        SeasonId = 1,
                        PlayerId = counter
                    };

                    ptsCollection.Add(pts);
                }
                else
                {
                    PlayerTeamSeason pts = new PlayerTeamSeason()
                    {
                        TeamId = 4,
                        SeasonId = 1,
                        PlayerId = counter
                    };

                    ptsCollection.Add(pts);
                }

                counter++;
            }

            return ptsCollection;
        }
    }
}
