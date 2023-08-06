namespace FootballRefereeManagementSystem.Common
{
    public static class EmailConstants
    {
        public static class EmailConfirmationConstants
        {
            public const string Subject = "Потвърждение на имейл адрес";
            public const string PlainTextContent = "";
            public const string HtmlContent = "Моля натиснете на линка за да потвърдите своят имейл адрес. <a href='{0}'>Потвърди</a>.";
        }

        public static class EmailChangeConstants
        {
            public const string Subject = "Промяна на имейл адрес";
            public const string PlainTextContent = "";
            public const string HtmlContent = "Моля натиснете на линка за да потвърдите, че искате да промените своят имейл адрес. <a href='{0}'>Потвърди</a>.";
        }

        public static class EmailCareerApproval
        {
            public const string CareerSystemName = "Кариерен Център";
            public const string Subject = "Кандидатура за съдия";
            public const string PlainTextContent = 
                @"Здравейте {0},
                С радост Ви съобщаваме, че Вашата кандидатура беше успешна, и искаме да Ви поздравим за приемането Ви на позицията асистент съдия в БФС Плевен!
                През следния линк може да направите своя личен профил в нашата Съдийска система - https://localhost:7251/Identity/Account/Register?id={1}
                С уважение,
                {2}";
            public const string HtmlContent = "";
        }

        public static class EmailCareerDecline
        {
            public const string CareerSystemName = "Кариерен Център";
            public const string Subject = "Кандидатура за съдия";
            public const string PlainTextContent =
                @"Здравейте {0},
                Благодарим Ви за интереса, който проявихте и за участието Ви в нашия подборен процес за позицията на футболен съдия.

                Бихме искали да Ви уведомим, че след дълъг и внимателен разглед, нашето ръководство взеха решение да продължат напред с друг кандидат, който най-добре отговаря на нашите настоящи нужди и изисквания.
                С уважение,
                {1}";
            public const string HtmlContent = "";
        }

        public static class EmailForgotPassword
        {
            public const string CareerSystemName = "Съдийска Система";
            public const string Subject = "Забравена парола";
            public const string PlainTextContent = "";
            public const string HtmlContent = "За да промените своята парола натиснете <a href='{0}'>тук</a>.";
        }
    }
}