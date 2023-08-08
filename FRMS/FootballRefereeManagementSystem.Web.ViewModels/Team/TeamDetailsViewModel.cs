namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    public class TeamDetailsViewModel
    {
        public int Id { get; set; }

        public string TeamName { get; set; } = null!;

        public string TeamLocation { get; set; } = null!;

        public int HighestPlacement { get; set; }

        public string YearOfHighestPlacement { get; set; } = null!;
    }
}
