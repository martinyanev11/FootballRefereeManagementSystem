namespace FootballRefereeManagementSystem.Web.ViewModels.Season
{
    using Match;
    using Player;
    using Team;

    public class SeasonPreparationModel : SeasonFormModel
    {
        public SeasonPreparationModel()
        {
            this.RegisteredTeams = new HashSet<TeamRegisteredListModel>();
            this.SeasonMatches = new HashSet<MatchRefereeSquadSummaryViewModel>();
        }

        public string Description { get; set; } = null!;

        public IEnumerable<TeamRegisteredListModel> RegisteredTeams { get; set; } = null!;

        public IEnumerable<MatchRefereeSquadSummaryViewModel> SeasonMatches { get; set; } = null!;
    }
}
