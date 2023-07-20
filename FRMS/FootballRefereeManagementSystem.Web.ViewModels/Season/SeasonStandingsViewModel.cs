namespace FootballRefereeManagementSystem.Web.ViewModels.Season
{
    using Team;

    public class SeasonStandingsViewModel
    {
        public SeasonStandingsViewModel()
        {
            this.Teams = new HashSet<TeamStandingsViewModel>();
        }

        public int SeasonId { get; set; }

        public int DivisionId { get; set; }

        public IEnumerable<TeamStandingsViewModel> Teams { get; set; } = null!;
    }
}
