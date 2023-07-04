namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using Models.Enums;
    using SeedingDataConstants;
    using static DataGenerator.RandomDataGenerator;

    internal class RefereeSeeder
    {
        internal ICollection<Referee> GenerateReferees()
        {
            ICollection<Referee> referees = new HashSet<Referee>()
            {
                new Referee()
                {
                    Id = RefereeDataConstants.MainRefereeId,
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    Age = GenerateRandomAge(RefereeDataConstants.AgeMinValue, RefereeDataConstants.AgeMaxValue),
                    Contact = GeneratePhoneNumber(),
                    CareerStart = GenerateRandomDateTime(2016, 1, 1),
                    Role = Role.Referee,
                    TownId = TownDataConstants.PlevenTownId,
                    UserId = new Guid(ApplicationUserDataConstants.RefereeGuid),
                    IsAvaliable = true
                },
                new Referee()
                {
                    Id = RefereeDataConstants.AssistantRefereeOneId,
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    Age = GenerateRandomAge(RefereeDataConstants.AgeMinValue, RefereeDataConstants.AgeMaxValue),
                    Contact = GeneratePhoneNumber(),
                    CareerStart = GenerateRandomDateTime(2016, 1, 1),
                    Role = Role.AssistantReferee,
                    TownId = TownDataConstants.PlevenTownId,
                    UserId = new Guid(ApplicationUserDataConstants.AssistantRefereeOneGuid),
                    IsAvaliable = true
                },
                new Referee()
                {
                    Id = RefereeDataConstants.AssistantRefereeTwoId,
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    Age = GenerateRandomAge(RefereeDataConstants.AgeMinValue, RefereeDataConstants.AgeMaxValue),
                    Contact = GeneratePhoneNumber(),
                    CareerStart = GenerateRandomDateTime(2016, 1, 1),
                    Role = Role.AssistantReferee,
                    TownId = TownDataConstants.PlevenTownId,
                    UserId = new Guid(ApplicationUserDataConstants.AssistantRefereeTwoGuid),
                    IsAvaliable = true
                },
                new Referee()
                {
                    Id = RefereeDataConstants.DelegateId,
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    Age = GenerateRandomAge(RefereeDataConstants.AgeMinValue, RefereeDataConstants.AgeMaxValue),
                    Contact = GeneratePhoneNumber(),
                    CareerStart = GenerateRandomDateTime(2016, 1, 1),
                    Role = Role.Delegate,
                    TownId = TownDataConstants.PlevenTownId,
                    UserId = new Guid(ApplicationUserDataConstants.DelegateGuid),
                    IsAvaliable = true
                },
                new Referee()
                {
                    Id = RefereeDataConstants.AdministratorId,
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    Age = GenerateRandomAge(RefereeDataConstants.AgeMinValue, RefereeDataConstants.AgeMaxValue),
                    Contact = GeneratePhoneNumber(),
                    CareerStart = GenerateRandomDateTime(2016, 1, 1),
                    Role = Role.Administration,
                    TownId = TownDataConstants.PlevenTownId,
                    UserId = new Guid(ApplicationUserDataConstants.AdministratorGuid),
                    IsAvaliable = false
                },
            };

            return referees;
        }
    }
}
