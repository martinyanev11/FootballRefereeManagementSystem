namespace FootballRefereeManagementSystem.Data.Models
{
    using Microsoft.EntityFrameworkCore;

    [Comment("Mapping table for Referee and Match")]
    public class RefereeMatch
    {
        [Comment("Referee who will officiate a match")]
        public int RefereeId { get; set; }
        public Referee Referee { get; set; } = null!;

        [Comment("Match which the referee will officiate")]
        public int MatchId { get; set; }
        public Match Match { get; set; } = null!;
    }
}
