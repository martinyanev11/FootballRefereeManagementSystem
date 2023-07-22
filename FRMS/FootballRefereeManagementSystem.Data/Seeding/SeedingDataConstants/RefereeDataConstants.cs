namespace FootballRefereeManagementSystem.Data.Seeding.SeedingDataConstants
{
    internal static class RefereeDataConstants
    {
        // ID
        public const int MainRefereeId = 1;
        public const int AssistantRefereeOneId = 2;
        public const int AssistantRefereeTwoId = 3;
        public const int DelegateId = 4;
        public const int AdministratorId = 5;

        // Age range for dynamic seeding
        public const int AgeMinValue = 16;
        public const int AgeMaxValue = 55;

        // Values for non-dynamic seeding
        public const string FirstNameValue = "ИмеСъдия";
        public const string LastNameValue = "ФламилияСъдия";
        public const int AgeValue = 30;
        public const string ContactValue = "0898556248";
        public const string CareerStartValue = "2018/8/15";
    }
}
