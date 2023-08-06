namespace FootballRefereeManagementSystem.Web.ViewModels.User
{
    using Referee;
    using Season;

    public class ApplicationUserViewModel
    {
        public string FullName { get; set; } = null!;

        public bool IsAvaliable { get; set; }

        public int CurrentlyAppointedMatchesCount { get; set; }

        public SeasonViewModel CurrrentSeasonInformation { get; set; } = null!;

        public RefereeDetailsViewModel RefereeDetails { get; set; } = null!;
    }
}
