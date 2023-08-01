namespace FootballRefereeManagementSystem.Services.Common
{
    using FootballRefereeManagementSystem.Data.Models.Enums;

    internal static class Translator
    {
        public static string TranslateRole(string role)
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

        public static string TranslateStatus(string status)
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
