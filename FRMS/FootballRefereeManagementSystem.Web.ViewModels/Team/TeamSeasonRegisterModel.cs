namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    public class TeamSeasonRegisterModel : TeamSeasonEditModel
    {
        public TeamSeasonRegisterModel()
        {
            this.Teams = new HashSet<TeamRegisteredListModel>();
        }

        public IEnumerable<TeamRegisteredListModel> Teams { get; set; } = null!;
    }
}
