namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using static DataGenerator.RandomDataGenerator;
    using static SeedingDataConstants.PlayerDataConstants;

    internal class PlayerSeeder
    {
        internal ICollection<Player> GeneratePlayers(int count)
        {
            ICollection<Player> players = new HashSet<Player>();

            int id = 1;
            while (players.Count < count)
            {
                Player player = new Player()
                {
                    Id = id++,
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    Age = GenerateRandomAge(AgeMinValue, AgeMaxValue)
                };

                players.Add(player);
            }

            return players;
        }
    }
}
