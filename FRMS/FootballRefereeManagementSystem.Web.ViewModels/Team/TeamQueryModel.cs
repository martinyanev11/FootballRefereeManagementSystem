namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    public class TeamQueryModel
    {
        public TeamQueryModel()
        {
            this.SeasonsOptions = new HashSet<string>();
        }

        public string SeasonFilter { get; set; } = null!;

        public IEnumerable<string> SeasonsOptions { get; set; } = null!;

        public TeamDetailsViewModel GeneralInformation { get; set; } = null!;

        public TeamSeasonDetailsViewModel SeasonalInformation { get; set; } = null!;
    }
}
