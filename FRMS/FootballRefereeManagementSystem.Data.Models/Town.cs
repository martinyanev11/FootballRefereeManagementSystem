namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Town;

    [Comment("Where teams and referees are located and matches are played")]
    public class Town
    {
        public Town()
        {
            this.Teams = new HashSet<Team>();
            this.Matches = new HashSet<Match>();
            this.IsActive = true;
        }

        [Comment("Primary key")]
        [Key]
        public int Id { get; set; }

        [Comment("Name of the town")]
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Comment("Zone in which town is located")]
        [ForeignKey(nameof(Zone))]
        public int ZoneId { get; set; }
        public Zone Zone { get; set; } = null!;

        [Comment("Collection of all teams located in this town")]
        public ICollection<Team> Teams { get; set; } = null!;

        [Comment("Collection of all matches that are played in this town")]
        public ICollection<Match> Matches { get; set; } = null!;

        [Comment("Soft delete value")]
        public bool IsActive { get; set; }
    }
}
