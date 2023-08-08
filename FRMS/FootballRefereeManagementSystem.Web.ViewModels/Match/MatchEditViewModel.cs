namespace FootballRefereeManagementSystem.Web.ViewModels.Match
{
    using FootballRefereeManagementSystem.Web.ViewModels.Town;
    using System.ComponentModel.DataAnnotations;

    public class MatchEditViewModel
    {
        public MatchEditViewModel()
        {
            this.Towns = new HashSet<TownListModel>();
        }

        public string? HomeTeamName { get; set; } = null!;

        public string? AwayTeamName { get; set; } = null!;

        public string? DivisionName { get; set; } = null!;

        [Required]
        public DateTime FixtureTime { get; set; }

        public int TownId { get; set; }

        public string? MatchLocation { get; set; } = null!;

        public IEnumerable<TownListModel> Towns { get; set; } = null!;

        [Range(0, 99)]
        public int HomeTeamScore { get; set; }

        [Range(0, 99)]
        public int AwayTeamScore { get; set; }
    }
}
