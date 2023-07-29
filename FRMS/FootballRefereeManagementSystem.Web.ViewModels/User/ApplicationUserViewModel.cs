namespace FootballRefereeManagementSystem.Web.ViewModels.User
{
    using FootballRefereeManagementSystem.Web.ViewModels.Referee;

    public class ApplicationUserViewModel
    {
        public string FullName { get; set; } = null!;

        public bool IsAvaliable { get; set; }

        public int CurrentlyAppointedMatchesCount { get; set; }

        public RefereeDetailsViewModel RefereeDetails { get; set; } = null!;
    }
}
