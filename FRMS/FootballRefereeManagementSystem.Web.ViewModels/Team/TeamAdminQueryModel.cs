namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    public class TeamAdminQueryModel
    {
        public int Id { get; set; }

        public string TeamName { get; set; } = null!;

        public string TeamLocation { get; set; } = null!;

        public string? SearchString { get; set; }

        public string? Zone { get; set; }

        public IEnumerable<string> Zones { get; set; } = null!;
    }
}
