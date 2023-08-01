namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using Enums;
    using static Common.EntityValidationConstants.Application;
    using System.ComponentModel.DataAnnotations.Schema;

    [Comment("Application request to become a referee")]
    public class Application
    {
        public Application()
        {
            this.Id = Guid.NewGuid();
            this.CreatedOn = DateTime.UtcNow;
            this.IsRegistered = false;
            this.Status = 0;
        }

        [Comment("Primary key")]
        [Key]
        public Guid Id { get; set; }

        [Comment("First name of applicant")]
        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Comment("Last name of applicant")]
        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Comment("Age of applicant")]
        public int Age { get; set; }

        [Comment("Number of years of experience for similar job")]
        public int ExperienceInYears { get; set; }

        [Comment("Email of applicant")]
        [Required]
        public string Email { get; set; } = null!;

        [Comment("Contact number of applicant")]
        [Required]
        [MaxLength(ContactMaxLength)]
        public string Contact { get; set; } = null!;

        public Status Status { get; set; }

        [Comment("To track for one-time use for registration")]
        [Required]
        public bool IsRegistered { get; set; }

        [Comment("Date and time of creation")]
        [Required]
        public DateTime CreatedOn { get; set; }

        [Comment("Позицията, която този кандидат е подходящ да заема")]
        public Role StartingRole { get; set; }

        [Comment("Дивизия, в която кандидата е подходящ да работи")]
        [ForeignKey(nameof(StartingDivision))]
        public int StartingDivisionId { get; set; }
        public Division StartingDivision { get; set; } = null!;
    }
}