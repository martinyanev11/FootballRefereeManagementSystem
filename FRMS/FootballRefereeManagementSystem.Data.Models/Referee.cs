namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    using Microsoft.EntityFrameworkCore;

    using Enums;
    using static Common.EntityValidationConstants.Referee;

    [Comment("The main entity of the application")]
    public class Referee
    {
        public Referee()
        {
            this.CareerStart = DateTime.UtcNow;
            this.RefereeDivisions = new HashSet<RefereeDivision>();
            this.MainRefereeSquads = new HashSet<RefereeSquad>();
            this.FirstAssistantRefereeSquads = new HashSet<RefereeSquad>();
            this.SecondAssistantRefereeSquads = new HashSet<RefereeSquad>();
            this.DelegateRefereeSquads = new HashSet<RefereeSquad>();
        }

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

        [Comment("Picture of the person represented by this entity")]
        public string? ImageUrl { get; set; }

        [Comment("Phone number of the person represented by this entity")]
        [Required]
        [MaxLength(ContactLength)]
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
        public ApplicationUser User { get; set; } = null!;

        [Comment("Gives information if person is free to officiate matches for current round")]
        public bool IsAvaliable { get; set; }

        [Comment("The number of matches appointed to this entity on current round")]
        public int CurrentlyAppointedMatchesCount { get; set; }

        [Comment("Collection of all divisions the referee is allowed to officiate")]
        public ICollection<RefereeDivision> RefereeDivisions { get; set; } = null!;

        [Comment("Collection of all squads where this referee was main referee")]
        [InverseProperty(nameof(RefereeSquad.MainReferee))]
        public ICollection<RefereeSquad> MainRefereeSquads { get; set; } = null!;

        [Comment("Collection of all squads where this referee was first assistant referee")]
        [InverseProperty(nameof(RefereeSquad.FirstAssistantReferee))]
        public ICollection<RefereeSquad> FirstAssistantRefereeSquads { get; set; } = null!;

        [Comment("Collection of all squads where this referee was second assistant referee")]
        [InverseProperty(nameof(RefereeSquad.SecondAssistantReferee))]
        public ICollection<RefereeSquad> SecondAssistantRefereeSquads { get; set; } = null!;

        [Comment("Collection of all squads where this referee was delegate")]
        [InverseProperty(nameof(RefereeSquad.Delegate))]
        public ICollection<RefereeSquad> DelegateRefereeSquads { get; set; } = null!;

        [Comment("Messages in RefereeSquads by this Referee")]
        public ICollection<Message> Messages { get; set; } = null!;
    }
}