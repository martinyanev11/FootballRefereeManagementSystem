namespace FootballRefereeManagementSystem.Web.ViewModels.Season
{
    public class SeasonQueryModel
    {
        public SeasonQueryModel()
        {
            this.SeasonsOptions = new HashSet<string>();
            this.DivisionsOptions = new HashSet<string>();
        }

        public SeasonTableViewModel MatchesTable { get; set; } = null!;

        public SeasonStandingsViewModel Standings { get; set; } = null!;

        public string SeasonSorting { get; set; } = null!;

        public string DivisionSorting { get; set; } = null!;

        public IEnumerable<string> SeasonsOptions { get; set; } = null!;

        public IEnumerable<string> DivisionsOptions { get; set; } = null!;
    }
}
