﻿namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    [Comment("Information about a football match")]
    public class Match
    {
        public Match()
        {
            this.MatchReferees = new HashSet<RefereeMatch>();
        }

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

        [Comment("Information about host team")]
        public int HomeTeamId { get; set; }
        [Comment("Information about guest team")]
        public int AwayTeamId { get; set; }
        [Comment("Season during which match takes place")]
        public int SeasonId { get; set; }
        public TeamSeason HomeTeam { get; set; } = null!;
        public TeamSeason AwayTeam { get; set; } = null!;

        public ICollection<RefereeMatch> MatchReferees { get; set; } = null!;
    }
}
