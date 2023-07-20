namespace FootballRefereeManagementSystem.Web.ViewModels.Season
{
    using Match;

    public class SeasonTableViewModel
    {
        public SeasonTableViewModel()
        {
            this.Matches = new HashSet<MatchTableViewModel>();
        }

        public int DivisionId { get; set; }

        public int SeasonId { get; set; }

        public IEnumerable<MatchTableViewModel> Matches { get; set; } = null!;
    }
}
