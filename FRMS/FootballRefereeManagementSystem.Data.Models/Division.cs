namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Division;

    [Comment("Division represents the level of the teams playing in it")]
    public class Division
    {
        public Division()
        {
            this.TeamsSeasons = new HashSet<TeamSeason>();
            this.DivisionReferees = new HashSet<RefereeDivision>();
            this.Matches = new HashSet<Match>();
            this.Applications = new HashSet<Application>();
        }

        [Comment("Primary key")]
        [Key]
        public int Id { get; set; }

        [Comment("Division name")]
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Comment("Number representing the difficulty level of a division compared to the rest")]
        [Required]
        public int Difficulty { get; set; }

        [Comment("Collection of a teams during specific season playing in this division")]
        public ICollection<TeamSeason> TeamsSeasons { get; set; } = null!;

        [Comment("Collection of all referees in a division")]
        public ICollection<RefereeDivision> DivisionReferees { get; set; } = null!;

        [Comment("Collection of all matches played in a division")]
        public ICollection<Match> Matches { get; set; } = null!;

        [Comment("Collection of all applications who are suitable for this division")]
        public ICollection<Application> Applications { get; set; } = null!;
    }
}
