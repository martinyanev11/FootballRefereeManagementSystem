namespace FootballRefereeManagementSystem.Data.Models
{
    using Microsoft.EntityFrameworkCore;

    [Comment("Player playing in a team during a season")]
    public class PlayerTeamSeason
    {
        [Comment("Team playing in specific season")]
        public int TeamId { get; set; }
        public int SeasonId { get; set; }
        public TeamSeason TeamSeason { get; set; } = null!;

        [Comment("The player in the team")]
        public int PlayerId { get; set; }
        public Player Player { get; set; } = null!;
    }
}
