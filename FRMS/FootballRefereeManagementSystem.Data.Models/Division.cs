namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Division;

    [Comment("Division represents the level of the teams playing in it")]
    public class Division
    {
        [Comment("Primary key")]
        [Key]
        public int Id { get; set; }

        [Comment("Division name")]
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        // One team plays in one division during one season
        public int TeamId { get; set; }
        public int SeasonId { get; set; }
        public TeamSeason TeamSeason { get; set; } = null!;

        [Comment("Collection of all referees in a division")]
        public ICollection<RefereeDivision> RefereesDivision { get; set; } = null!;

        [Comment("Collection of all matches played in a division")]
        public ICollection<Match> Matches { get; set; } = null!;
    }
}
