namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Match;

    [Comment("Information about a football match")]
    public class Match
    {
        [Comment("Primary key")]
        [Key]
        public int Id { get; set; }

        [Comment("In what division is the match played")]
        [ForeignKey(nameof(Division))]
        public int DivisionId { get; set; }
        public Division Division { get; set; } = null!;        

        [Comment("Town in which the match is played")]
        [ForeignKey(nameof(Town))]
        public int TownId { get; set; }
        public Town Town { get; set; } = null!;

        [Comment("Date and time the match is played")]
        public DateTime FixtureTime { get; set; }

        [Comment("The final result of the match")]
        [MaxLength(FinalResultMaxLength)]
        public string? FinalResult { get; set; }

        [Comment("Information about host team")]
        public int HomeTeamId { get; set; }
        [Comment("Information about guest team")]
        public int AwayTeamId { get; set; }
        [Comment("Season during which match takes place")]
        public int SeasonId { get; set; }
        public TeamSeason HomeTeam { get; set; } = null!;
        public TeamSeason AwayTeam { get; set; } = null!;

        [Comment("The referee squad appointed to officiate the match")]
        public Guid RefereeSquadId { get; set; }
        public RefereeSquad RefereeSquad { get; set; } = null!;
    }
}
