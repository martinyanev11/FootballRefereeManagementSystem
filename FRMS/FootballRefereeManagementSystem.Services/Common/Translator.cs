namespace FootballRefereeManagementSystem.Services.Common
{
    using FootballRefereeManagementSystem.Data.Models.Enums;

    internal static class Translator
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
    }
}
