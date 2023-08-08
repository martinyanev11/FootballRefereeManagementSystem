namespace FootballRefereeManagementSystem.Web.ViewModels.Player
{
    public class PlayerQueryModel
    {
        public PlayerQueryModel()
        {
            Players = new HashSet<PlayerDetailsViewModel>();
        }

        public string? SearchString { get; set; }

        public IEnumerable<PlayerDetailsViewModel> Players { get; set; }
    }
}
