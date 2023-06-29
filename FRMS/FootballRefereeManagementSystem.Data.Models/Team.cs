namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Team;

    [Comment("Team that plays matches in specific division during specific season")]
    public class Team
    {
        public Team()
        {
            this.TeamSeasons = new HashSet<TeamSeason>();
        }

        [Comment("Primary key")]
        [Key]
        public int Id { get; set; }

        [Comment("Name of the team")]
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Comment("Abbreviation of the team")]
        [Required]
        [MaxLength(AbbreviationMaxLength)]
        public string Abbreviation { get; set; } = null!;

        [Comment("In which town the team is located")]
        [ForeignKey(nameof(Town))]
        public int TownId { get; set; }
        public Town Town { get; set; } = null!;

        [Comment("Collection of seasons the team participated in")]
        public ICollection<TeamSeason> TeamSeasons { get; set; } = null!;
    }
}