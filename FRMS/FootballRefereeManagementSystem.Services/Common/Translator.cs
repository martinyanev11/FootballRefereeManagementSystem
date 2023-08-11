namespace FootballRefereeManagementSystem.Services.Common
{
    using Data.Models.Enums;

    public static class Translator
    {
        public static string TranslateRoleToBulgarian(string role)
        {
            if (role == Role.Referee.ToString())
            {
                role = "Главен съдия";
            }
            else if (role == Role.AssistantReferee.ToString())
            {
                role = "Асистент съдия";
            }
            else if (role == Role.Delegate.ToString())
            {
                role = "Делегат";
            }
            else if (role == Role.Administration.ToString())
            {
                role = "Администрация";
            }

            return role;
        }

        public static string TranslateRoleToEnglish(string role)
        {
            if (role == "Главен съдия")
            {
                role = Role.Referee.ToString();
            }
            else if (role == "Асистент съдия")
            {
                role = Role.AssistantReferee.ToString();
            }
            else if (role == "Делегат")
            {
                role = Role.Delegate.ToString();
            }
            else if (role == "Администрация")
            {
                role = Role.Administration.ToString();
            }

            return role;
        }

        public static string TranslateStatusToBulgarian(string status)
        {
            if (status == Status.Waiting.ToString())
            {
                status = "В процес";
            }
            else if (status == Status.Approved.ToString())
            {
                status = "Одобрен";
            }
            else if (status == Status.Declined.ToString())
            {
                status = "Отхвърлен";
            }

            return status;
        }

        public static IEnumerable<string> GetAllRolesTranslated()
        {
            return Enum.GetValues(typeof(Role))
                       .Cast<Role>()
                       .Select(r => Translator.TranslateRoleToBulgarian(r.ToString()))
                       .ToList();
        }

        public static IEnumerable<string> TranslateAllColorsToBulgarian(IEnumerable<string> shirtColorsInEnglish)
        {
            Dictionary<string, string> translatedColorNames = new Dictionary<string, string>
            {
                {"Red", "Червен"},
                {"Orange", "Оранжев"},
                {"Yellow", "Жълт"},
                {"Green", "Зелен"},
                {"Blue", "Син"},
                {"Violet", "Виолетов"},
                {"Purple", "Лилав"},
                {"Pink", "Розов"},
                {"Brown", "Кафяв"},
                {"Gray", "Сив"},
                {"Black", "Черен"},
                {"White", "Бял"}
            };

            foreach (string color in shirtColorsInEnglish)
            {
                yield return translatedColorNames[color];
            }
        }

        public static string TranslateColorToEnglish(string color)
        {
            Dictionary<string, string> colorTranslations = new Dictionary<string, string>
            {
                { "Червен", "Red" },
                { "Оранжев", "Orange" },
                { "Жълт", "Yellow" },
                { "Зелен", "Green" },
                { "Син", "Blue" },
                { "Виолетов", "Violet" },
                { "Лилав", "Purple" },
                { "Розов", "Pink" },
                { "Кафяв", "Brown" },
                { "Сив", "Gray" },
                { "Черен", "Black" },
                { "Бял", "White" }
            };

            color = colorTranslations[color];
            return color;
        }

        public static string TranslateColorToBulgarian(string color)
        {
            Dictionary<string, string> colorTranslations = new Dictionary<string, string>
            {
                {"Red", "Червен"},
                {"Orange", "Оранжев"},
                {"Yellow", "Жълт"},
                {"Green", "Зелен"},
                {"Blue", "Син"},
                {"Violet", "Виолетов"},
                {"Purple", "Лилав"},
                {"Pink", "Розов"},
                {"Brown", "Кафяв"},
                {"Gray", "Сив"},
                {"Black", "Черен"},
                {"White", "Бял"}
            };

            color = colorTranslations[color];
            return color;
        }
    }
}
