namespace FootballRefereeManagementSystem.Data.Models
{
    using Microsoft.EntityFrameworkCore;

    [Comment("Mapping table for Referee and Division")]
    public class RefereeDivision
    {
        [Comment("Referee in specific division")]
        public int RefereeId { get; set; }
        public Referee Referee { get; set; } = null!;

        [Comment("Division in which referee is allowed to offciate")]
        public int DivisionId { get; set; }
        public Division Division { get; set; } = null!;

        [Comment("The count of matches referee officiated in this division")]
        public int DivisionMatchesOfficiated { get; set; }

        [Comment("Soft delete value")]
        public bool IsActive { get; set; }
    }
}
