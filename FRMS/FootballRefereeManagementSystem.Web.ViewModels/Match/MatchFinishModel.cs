namespace FootballRefereeManagementSystem.Web.ViewModels.Match
{
    using System.ComponentModel.DataAnnotations;

    public class MatchFinishModel
    {
        public int MatchId { get; set; }

        [Range(0, 99)]
        public int HomeTeamScore { get; set; }

        [Range(0, 99)]
        public int AwayTeamScore { get; set; }

        public string? RefereeSquadId { get; set; }
    }
}
