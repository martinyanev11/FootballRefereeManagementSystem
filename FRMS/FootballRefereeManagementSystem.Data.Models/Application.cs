namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.EntityFrameworkCore;

    using Enums;
    using static Common.EntityValidationConstants.Application;

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

        [Comment("Email of applicant")]
        [Required]
        public string Email { get; set; } = null!;

        [Comment("Age of applicant")]
        public int Age { get; set; }

        [Comment("Weight of applicant")]
        public int Weight { get; set; }

        [Comment("Contact number of applicant")]
        [Required]
        [MaxLength(ContactMaxLength)]
        public string Contact { get; set; } = null!;

        [Comment("Does applicant have drivers license")]
        public bool HasDriverLicense { get; set; }

        [Comment("Does applicant have car")]
        public bool HasCar { get; set; }

        public Status Status { get; set; }

        [Comment("To track for one-time use for registration")]
        [Required]
        public bool IsRegistered { get; set; }

        [Comment("Date and time of creation")]
        [Required]
        public DateTime CreatedOn { get; set; }
    }
}