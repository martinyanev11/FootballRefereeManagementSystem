namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;

    using Enums;
    using static Common.EntityValidationConstants.Referee;

    [Comment("The main entity of the application")]
    public class Referee
    {
        public Referee()
        {
            this.Id = Guid.NewGuid();
            this.CareerStart = DateTime.UtcNow;
            this.RefereeDivisions = new HashSet<RefereeDivision>();
            this.MatchHistory = new HashSet<RefereeSquad>();
        }

        [Comment("Primary key")]
        [Key]
        public Guid Id { get; set; }

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

        [Comment("Picture of the person represented by this entity")]
        public string ImageUrl { get; set; } = null!;

        [Comment("Phone number of the person represented by this entity")]
        [Required]
        [MaxLength(ContactMaxLength)]
        [Phone]
        public string Contact { get; set; } = null!;

        [Comment("Current role of the person represented by this entity within the organization")]
        [Required]
        public Role Role { get; set; }

        [Comment("Date and time of registration within the organization")]
        public DateTime CareerStart { get; set; }

        [Comment("Number of matches officiated")]
        public int TotalMatchesOfficiated { get; set; }

        [Comment("Current town which the person represented by this entity resides")]
        [ForeignKey(nameof(Town))]
        public int TownId { get; set; }
        public Town Town { get; set; } = null!;

        [Comment("The registered user related to this entity")]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public IdentityUser User { get; set; } = null!;

        [Comment("The number of matches appointed to this entity on current round")]
        public int CurrentlyAppointedMatchesCount { get; set; }

        [Comment("Collection of all divisions the referee is allowed to officiate")]
        public ICollection<RefereeDivision> RefereeDivisions { get; set; } = null!;

        [Comment("Collection of all matches the referee officiated")]
        public ICollection<RefereeSquad> MatchHistory { get; set; } = null!;
    }
}