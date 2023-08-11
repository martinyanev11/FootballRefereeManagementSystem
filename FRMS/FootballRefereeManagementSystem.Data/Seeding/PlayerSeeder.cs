namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using static DataGenerator.RandomDataGenerator;
    using static SeedingDataConstants.PlayerDataConstants;

    public static class PlayerSeeder
    {
        public static ICollection<Player> GeneratePlayers(int count)
        {
            ICollection<Player> players = new HashSet<Player>();

            int id = 1;
            while (players.Count < count)
            {
                Player player = new Player()
                {
                    Id = id++,
                    //FirstName = PlayerDataConstants.FirstNameConstantValue,
                    //LastName = PlayerDataConstants.LastNameConstantValue,
                    //Age = PlayerDataConstants.AgeConstantValue,
                    IsActive = true,
                    //// Dynamic seeding
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
