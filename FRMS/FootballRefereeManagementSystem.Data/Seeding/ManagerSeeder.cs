namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    //using static DataGenerator.RandomDataGenerator;
    using SeedingDataConstants;

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
                    FirstName = ManagerDataConstants.FirstNameConstantValue,
                    LastName = ManagerDataConstants.LastNameConstantValue,
                    Age = ManagerDataConstants.AgeConstantValue

                    // Use the DataGenerator for more realistic data seeding
                    //FirstName = GenerateRandomFirstName(),
                    //LastName = GenerateRandomLastName(),
                    //Age = GenerateRandomAge(AgeMinValue, AgeMaxValue),
                };

                managers.Add(manager);
            }

            return managers;
        }
    }
}
