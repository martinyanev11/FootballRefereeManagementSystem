namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using static DataGenerator.RandomDataGenerator;
    using static SeedingDataConstants.ManagerDataConstants;

    internal class ManagerSeeder
    {
        internal ICollection<Manager> GenerateManagers()
        {
            ICollection<Manager> managers = new HashSet<Manager>()
            {
                new Manager()
                {
                    Id = 1,
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    Age = GenerateRandomAge(AgeMinValue, AgeMaxValue),
                },
                new Manager()
                {
                    Id = 2,
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    Age = GenerateRandomAge(AgeMinValue, AgeMaxValue),
                },
                new Manager()
                {
                    Id = 3,
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    Age = GenerateRandomAge(AgeMinValue, AgeMaxValue),
                },
                new Manager()
                {
                    Id = 4,
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    Age = GenerateRandomAge(AgeMinValue, AgeMaxValue),
                }
            };

            return managers;
        }
    }
}
