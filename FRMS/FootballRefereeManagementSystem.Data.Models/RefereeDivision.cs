namespace FootballRefereeManagementSystem.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    [Comment("Mapping table for Referee and Division")]
    public class RefereeDivision
    {
        [Comment("Referee in specific division")]
        [ForeignKey(nameof(Referee))]
        public Guid RefereeId { get; set; }
        public Referee Referee { get; set; } = null!;

        [Comment("Division in which referee is allowed to offciate")]
        [ForeignKey(nameof(Division))]
        public int DivisionId { get; set; }
        public Division Division { get; set; } = null!;

        [Comment("The count of matches referee officiated in this division")]
        public int DivisionMatchesOfficiated { get; set; }
    }
}
