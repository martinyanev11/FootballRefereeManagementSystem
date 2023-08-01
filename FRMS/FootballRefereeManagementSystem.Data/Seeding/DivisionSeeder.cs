namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using static SeedingDataConstants.DivisionDataConstants;

    internal class DivisionSeeder
    {
        internal ICollection<Division> GenerateDivisions()
        {
            ICollection<Division> divisions = new HashSet<Division>()
            {
                new Division()
                {
                    Id = FirstProLeagueId,
                    Name = "Първа професионална футболна лига",
                    Difficulty = 5,
                },
                new Division()
                {
                    Id = SecondProLeagueId,
                    Name = "Втора професионална футболна лига",
                    Difficulty = 4,
                },
                new Division()
                {
                    Id = ThirdAmateurLeagueId,
                    Name = "Трета аматьорска футболна лига",
                    Difficulty = 3,
                },
                new Division()
                {
                    Id = RegionalAGroupId,
                    Name = "„А“ областнa футболнa групa",
                    Difficulty = 2,
                },
                new Division()
                {
                    Id = RegionalBGroupId,
                    Name = "„Б“ областнa футболнa групa",
                    Difficulty = 1,
                }
            };

            return divisions;
        }
    }
}
