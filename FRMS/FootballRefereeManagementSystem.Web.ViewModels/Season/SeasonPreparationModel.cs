namespace FootballRefereeManagementSystem.Web.ViewModels.Season
{
    using Match;
    using Player;
    using Team;

    public class SeasonPreparationModel : SeasonFormModel
    {
        public SeasonPreparationModel()
        {
            this.RegisteredTeams = new HashSet<TeamDetailsViewModel>();
            this.RegisteredPlayers = new HashSet<PlayerDetailsViewModel>();
            this.SeasonMatches = new HashSet<MatchRefereeSquadSummaryViewModel>();
        }

        public string Description { get; set; } = null!;

        public IEnumerable<TeamDetailsViewModel> RegisteredTeams { get; set; } = null!;

        public IEnumerable<PlayerDetailsViewModel> RegisteredPlayers { get; set; } = null!;

        public IEnumerable<MatchRefereeSquadSummaryViewModel> SeasonMatches { get; set; } = null!;
    }
}
