namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Application;

    [Comment("Application request to become a referee")]
    public class Application
    {
        [Comment("Primary key")]
        [Key]
        public int Id { get; set; }

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
    }
}