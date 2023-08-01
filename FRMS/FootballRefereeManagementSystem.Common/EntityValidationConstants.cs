﻿namespace FootballRefereeManagementSystem.Common
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

            public const int ContactLength = 10;

            public const int AgeMinValue = 15;
            public const int AgeMaxValue = 50;
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

        public static class Player
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;

            public const int PositionMinLength = 2;
            public const int PositionMaxLength = 20;
        }

        public static class Town
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 26;
        }

        public static class Zone
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 40;
        }

        public static class Division
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;
        }

        public static class Season
        {
            public const int DescriptionMaxLength = 7;
        }

        public static class Message
        {
            public const int ContentMinLength = 1;
            public const int ContentMaxLength = 300;
        }

        public static class Article
        {
            public const int TitleMinLegnth = 3;
            public const int TitleMaxLength = 100;

            public const int ContentMinLength = 10;
            public const int ContentMaxLength = 1500;

            public const int ImageUrlMaxLength = 2048;
        }

        public static class Application
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;

            public const int ContactMinLength = 10;
            public const int ContactMaxLength = 10;

            public const int AgeMinValue = 15;
            public const int AgeMaxValue = 65;

            public const int ExperienceMinValue = 0;
            public const int ExperienceMaxValue = 50;
        }

        public static class ContactMessage
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;

            public const int TitleMinLength = 3;
            public const int TitleMaxLength = 100;

            public const int MessageMinLength = 10;
            public const int MessageMaxLength = 1000;
        }
    }
}
