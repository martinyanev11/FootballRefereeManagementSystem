namespace FootballRefereeManagementSystem.Web.ViewModels.Match
{
    using System.ComponentModel.DataAnnotations;

    using Team;

    public class MatchFormModel
    {
        public MatchFormModel()
        {
            Teams = new HashSet<TeamListModel>();
        }

        [Required]
        public DateTime FixtureTime { get; set; }

        [Required]
        public int HomeTeamId { get; set; }

        [Required]
        public int AwayTeamId { get; set; }

        [Required]
        public int SeasonId { get; set; }

        public int DivisionId { get; set; }

        public int TownId { get; set; }

        public IEnumerable<TeamListModel> Teams { get; set; } = null!;
    }
}
