namespace FootballRefereeManagementSystem.Web.ViewModels.Player
{
    public class PlayerTeamSeasonFormModel
    {
        public PlayerTeamSeasonFormModel()
        {
            Players = new HashSet<PlayerDetailsViewModel>();
        }

        public int PlayerId { get; set; }

        public int TeamId { get; set; }

        public string? TeamName { get; set; }

        public string? Teamlocation { get; set; }

        public int SeasonId { get; set; }

        public IEnumerable<PlayerDetailsViewModel> Players { get; set; } = null!;
    }
}
