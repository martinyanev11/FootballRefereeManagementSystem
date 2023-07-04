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
                    Name = "Първа професионална футболна лига"
                },
                new Division()
                {
                    Id = SecondProLeagueId,
                    Name = "Втора професионална футболна лига"
                },
                new Division()
                {
                    Id = ThirdAmateurLeagueId,
                    Name = "Трета аматьорска футболна лига"
                },
                new Division()
                {
                    Id = RegionalAGroupId,
                    Name = "„А“ областнa футболнa групa"
                },
                new Division()
                {
                    Id = RegionalBGroupId,
                    Name = "„Б“ областнa футболнa групa"
                }
            };

            return divisions;
        }
    }
}
