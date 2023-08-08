namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    public class TeamDetailsViewModel : TeamListModel
    {
        public int HighestPlacement { get; set; }

        public string YearOfHighestPlacement { get; set; } = null!;
    }
}
