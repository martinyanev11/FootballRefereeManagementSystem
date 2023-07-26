namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    using Player;
    using Match;

    public class TeamSeasonDetailsViewModel
    {
        public TeamSeasonDetailsViewModel()
        {
            this.Players = new HashSet<PlayerDetailsViewModel>();
            this.MatchHistory = new HashSet<DetailsHistoryViewModel>();
        }

        public string Division { get; set; } = null!;

        public string ManagerName { get; set; } = null!;

        public int ManagerAge { get; set; }

        public IEnumerable<PlayerDetailsViewModel> Players { get; set; } = null!;

        public IEnumerable<DetailsHistoryViewModel> MatchHistory { get; set; } = null!;
    }
}
