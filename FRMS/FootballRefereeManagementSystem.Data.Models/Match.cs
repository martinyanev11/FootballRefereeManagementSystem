namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    [Comment("Information about a football match")]
    public class Match
    {
        [Comment("Primary key")]
        [Key]
        public Guid Id { get; set; }

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

        [Comment("Referees who will officiate the match")]
        [ForeignKey(nameof(RefereeSquad))]
        public Guid RefereeSquadId { get; set; }
        public RefereeSquad RefereeSquad { get; set; } = null!;

        [Comment("Information about host team")]
        public int HomeTeamId { get; set; }
        [Comment("Information about guest team")]
        public int AwayTeamId { get; set; }
        [Comment("Season during which match takes place")]
        public int SeasonId { get; set; }
        public TeamSeason TeamSeasonHomeTeam { get; set; } = null!;
        public TeamSeason TeamSeasonAwayTeam { get; set; } = null!;
    }
}
