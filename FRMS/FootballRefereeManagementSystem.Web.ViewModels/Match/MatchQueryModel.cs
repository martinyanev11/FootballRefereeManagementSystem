namespace FootballRefereeManagementSystem.Web.ViewModels.Match
{
    public class MatchQueryModel
    {
        public MatchQueryModel()
        {
            this.DivisionOptions = new HashSet<string>();
            this.WeeklyMatches = new HashSet<MatchRefereeSquadSummaryViewModel>();
        }

        public string? SearchString { get; set; }

        public string? DivisionFilter { get; set; }

        public IEnumerable<string> DivisionOptions { get; set; } = null!;

        public IEnumerable<MatchRefereeSquadSummaryViewModel> WeeklyMatches { get; set; } = null!;
    }
}
