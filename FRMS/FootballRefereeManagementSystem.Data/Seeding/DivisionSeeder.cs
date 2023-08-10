namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using static SeedingDataConstants.DivisionDataConstants;

    public static class DivisionSeeder
    {
        public static ICollection<Division> GenerateDivisions()
        {
            ICollection<Division> divisions = new HashSet<Division>()
            {
                new Division()
                {
                    Id = FirstProLeagueId,
                    Name = "Първа професионална футболна лига",
                    Difficulty = 5,
                    IsActive = true,
                },
                new Division()
                {
                    Id = SecondProLeagueId,
                    Name = "Втора професионална футболна лига",
                    Difficulty = 4,
                    IsActive = true,
                },
                new Division()
                {
                    Id = ThirdAmateurLeagueId,
                    Name = "Трета аматьорска футболна лига",
                    Difficulty = 3,
                    IsActive = true,
                },
                new Division()
                {
                    Id = RegionalAGroupId,
                    Name = "„А“ областнa футболнa групa",
                    Difficulty = 2,
                    IsActive = true,
                },
                new Division()
                {
                    Id = RegionalBGroupId,
                    Name = "„Б“ областнa футболнa групa",
                    Difficulty = 1,
                    IsActive = true,
                }
            };

            return divisions;
        }
    }
}
