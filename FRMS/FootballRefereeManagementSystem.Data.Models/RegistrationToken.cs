namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    [Comment("Registration token is used to restrict register of random users")]
    public class RegistrationToken
    {
        public RegistrationToken(string email)
        {
            this.Id = Guid.NewGuid();
            this.CreatedOn = DateTime.UtcNow;
            this.IsRegistered = false;
            this.Email = email;
        }

        [Comment("Primary key")]
        [Key]
        public Guid Id { get; set; }

        [Comment("Email of user who is invited to register")]
        [Required]
        public string Email { get; set; } = null!;

        [Comment("To track for one-time use of this token")]
        [Required]
        public bool IsRegistered { get; set; }

        [Comment("Date and time of creation of the token")]
        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
