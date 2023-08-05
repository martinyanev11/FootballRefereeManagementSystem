namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    public class TeamAdminQueryModel
    {
        public TeamAdminQueryModel()
        {
            this.Teams = new HashSet<TeamAdminViewModel>();
            this.Zones = new HashSet<string>();
        }

        public IEnumerable<TeamAdminViewModel> Teams { get; set; } = null!;

        public string? SearchString { get; set; }

        public string? Zone { get; set; }

        public IEnumerable<string> Zones { get; set; } = null!;
    }
}
