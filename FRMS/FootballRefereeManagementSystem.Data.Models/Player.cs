namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Player;

    [Comment("Player playing in specific team during specific season")]
    public class Player
    {
        public Player()
        {
            this.PlayerTeamsSeasons = new HashSet<PlayerTeamSeason>();
        }

        [Comment("Primary key")]
        [Key]
        public int Id { get; set; }

        [Comment("First name of the player")]
        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Comment("Last name of the player")]
        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Comment("Age of the player")]
        public int Age { get; set; }

        [Comment("In what position the player plays in the team")]
        [MaxLength(PositionMaxLength)]
        public string? Position { get; set; }

        // A player can play in one team during one season
        [Comment("In which team he plays during a certain season")]
        public ICollection<PlayerTeamSeason> PlayerTeamsSeasons { get; set; } = null!;

        [Comment("Soft delete value")]
        public bool IsActive { get; set; }
    }
}
