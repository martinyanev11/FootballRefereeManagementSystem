﻿namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using FootballRefereeManagementSystem.Data.Models.Enums;
    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Season;

    [Comment("Season is the timespan in which all matches between teams are played")]
    public class Season
    {
        public Season()
        {
            this.SeasonTeams = new HashSet<TeamSeason>();
        }

        [Comment("Primary key")]
        [Key]
        public int Id { get; set; }

        [Comment("Short name for the season (e.g. 2004/05, 2011/12, 2022/23)")]
        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Comment("Start of the season")]
        [Required]
        public DateTime Start { get; set; }

        [Comment("End of the season")]
        [Required]
        public DateTime End { get; set; }

        [Comment("Current status of the season")]
        [Required]
        public SeasonStatus Status { get; set; }

        [Comment("Collection of teams for season")]
        public ICollection<TeamSeason> SeasonTeams { get; set; } = null!;
    }
}
