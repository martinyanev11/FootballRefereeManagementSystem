namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Message;

    [Comment("Messages the referee write in match center")]
    public class Message
    {
        public Message()
        {
            this.Id = Guid.NewGuid();
            this.CreatedOn = DateTime.UtcNow;
        }

        [Comment("Primary key")]
        [Key]
        public Guid Id { get; set; }

        [Comment("Name of the message creator")]
        [Required]
        public string Author { get; set; } = null!;

        [Comment("Time and date of creation")]
        public DateTime CreatedOn { get; set; }

        [Comment("The content of the message")]
        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;

        [Comment("The match center where comment was made")]
        [ForeignKey(nameof(RefereeSquad))]
        public Guid RefereeSquadId { get; set; }
        public RefereeSquad RefereeSquad { get; set; } = null!;
    }
}
