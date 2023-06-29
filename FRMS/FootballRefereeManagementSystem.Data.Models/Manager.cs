namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Manager;

    [Comment("Manager is the one who is in charge of team")]
    public class Manager
    {
        // The Manager does not have navigation property to TeamSeason entity
        // because it is One-To-One relation and I won't need to access TeamSeason from manager
        // The relation is configured in the TeamSeason entity configuration with Fluent API

        [Comment("Primary key")]
        [Key]
        public int Id { get; set; }

        [Comment("First name of the person represented by this entity")]
        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Comment("Last name of the person represented by this entity")]
        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Comment("Age of the person represented by this entity")]
        [Required]
        public int Age { get; set; }
    }
}
