namespace FootballRefereeManagementSystem.Common
{
    public static class EntityValidationConstants
    {
        public static class Referee
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;

            public const int ImageUrlMaxLength = 2048;

            public const int ContactMinLength = 10;
            public const int ContactMaxLength = 10;
        }

        public static class Team
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;

            public const int AbbreviationMinLength = 2;
            public const int AbbreviationMaxLength = 4;
        }

        public static class Manager
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;
        }
    }
}
