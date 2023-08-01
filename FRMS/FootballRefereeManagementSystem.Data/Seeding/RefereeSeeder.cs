namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using Models.Enums;
    using SeedingDataConstants;
    //using static DataGenerator.RandomDataGenerator;

    internal class RefereeSeeder
    {
        internal ICollection<Referee> GenerateReferees()
        {
            ICollection<Referee> referees = new HashSet<Referee>()
            {
                new Referee()
                {
                    Id = RefereeDataConstants.MainRefereeId,
                    FirstName = RefereeDataConstants.FirstNameValue,
                    LastName = RefereeDataConstants.LastNameValue,
                    Age = RefereeDataConstants.AgeValue,
                    Contact = RefereeDataConstants.ContactValue,
                    CareerStart = DateTime.Parse(RefereeDataConstants.CareerStartValue),
                    //FirstName = GenerateRandomFirstName(),
                    //LastName = GenerateRandomLastName(),
                    //Age = GenerateRandomAge(RefereeDataConstants.AgeMinValue, RefereeDataConstants.AgeMaxValue),
                    //Contact = GeneratePhoneNumber(),
                    //CareerStart = GenerateRandomDateTime(2016, 1, 1),
                    Role = Role.Referee,
                    UserId = new Guid(ApplicationUserDataConstants.RefereeId),
                    IsAvaliable = true
                },
                new Referee()
                {
                    Id = RefereeDataConstants.AssistantRefereeOneId,
                    FirstName = RefereeDataConstants.FirstNameValue,
                    LastName = RefereeDataConstants.LastNameValue,
                    Age = RefereeDataConstants.AgeValue,
                    Contact = RefereeDataConstants.ContactValue,
                    CareerStart = DateTime.Parse(RefereeDataConstants.CareerStartValue),
                    //FirstName = GenerateRandomFirstName(),
                    //LastName = GenerateRandomLastName(),
                    //Age = GenerateRandomAge(RefereeDataConstants.AgeMinValue, RefereeDataConstants.AgeMaxValue),
                    //Contact = GeneratePhoneNumber(),
                    //CareerStart = GenerateRandomDateTime(2016, 1, 1),
                    Role = Role.AssistantReferee,
                    UserId = new Guid(ApplicationUserDataConstants.AssistantRefereeOneId),
                    IsAvaliable = true
                },
                new Referee()
                {
                    Id = RefereeDataConstants.AssistantRefereeTwoId,
                    FirstName = RefereeDataConstants.FirstNameValue,
                    LastName = RefereeDataConstants.LastNameValue,
                    Age = RefereeDataConstants.AgeValue,
                    Contact = RefereeDataConstants.ContactValue,
                    CareerStart = DateTime.Parse(RefereeDataConstants.CareerStartValue),
                    //FirstName = GenerateRandomFirstName(),
                    //LastName = GenerateRandomLastName(),
                    //Age = GenerateRandomAge(RefereeDataConstants.AgeMinValue, RefereeDataConstants.AgeMaxValue),
                    //Contact = GeneratePhoneNumber(),
                    //CareerStart = GenerateRandomDateTime(2016, 1, 1),
                    Role = Role.AssistantReferee,
                    UserId = new Guid(ApplicationUserDataConstants.AssistantRefereeTwoId),
                    IsAvaliable = true
                },
                new Referee()
                {
                    Id = RefereeDataConstants.DelegateId,
                    FirstName = RefereeDataConstants.FirstNameValue,
                    LastName = RefereeDataConstants.LastNameValue,
                    Age = RefereeDataConstants.AgeValue,
                    Contact = RefereeDataConstants.ContactValue,
                    CareerStart = DateTime.Parse(RefereeDataConstants.CareerStartValue),
                    //FirstName = GenerateRandomFirstName(),
                    //LastName = GenerateRandomLastName(),
                    //Age = GenerateRandomAge(RefereeDataConstants.AgeMinValue, RefereeDataConstants.AgeMaxValue),
                    //Contact = GeneratePhoneNumber(),
                    //CareerStart = GenerateRandomDateTime(2016, 1, 1),
                    Role = Role.Delegate,
                    UserId = new Guid(ApplicationUserDataConstants.DelegateId),
                    IsAvaliable = true
                },
                new Referee()
                {
                    Id = RefereeDataConstants.AdministratorId,
                    FirstName = RefereeDataConstants.FirstNameValue,
                    LastName = RefereeDataConstants.LastNameValue,
                    Age = RefereeDataConstants.AgeValue,
                    Contact = RefereeDataConstants.ContactValue,
                    CareerStart = DateTime.Parse(RefereeDataConstants.CareerStartValue),
                    //FirstName = GenerateRandomFirstName(),
                    //LastName = GenerateRandomLastName(),
                    //Age = GenerateRandomAge(RefereeDataConstants.AgeMinValue, RefereeDataConstants.AgeMaxValue),
                    //Contact = GeneratePhoneNumber(),
                    //CareerStart = GenerateRandomDateTime(2016, 1, 1),
                    Role = Role.Administration,
                    UserId = new Guid(ApplicationUserDataConstants.AdministratorId),
                    IsAvaliable = false
                },
            };

            return referees;
        }
    }
}
