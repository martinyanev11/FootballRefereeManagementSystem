namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using static DataGenerator.RandomDataGenerator;
    using static SeedingDataConstants.ManagerDataConstants;

    internal class ManagerSeeder
    {
        internal ICollection<Manager> GenerateManagers(int entitesToGenerate)
        {
            ICollection<Manager> managers = new HashSet<Manager>();

            for (int i = 1; i <= entitesToGenerate; i++)
            {
                Manager manager = new Manager()
                {
                    Id = i,
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    Age = GenerateRandomAge(AgeMinValue, AgeMaxValue),
                };

                managers.Add(manager);
            }

            return managers;
        }
    }
}
