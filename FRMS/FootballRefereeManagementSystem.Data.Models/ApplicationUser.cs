namespace FootballRefereeManagementSystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    [Comment("Customization of Default Identity User")]
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Messages = new HashSet<Message>();
        }

        [Comment("The navigation to the referee for this user")]
        public int? RefereeId { get; set; }
        public Referee? Referee { get; set; }

        [Comment("Messages wrote by user")]
        public ICollection<Message> Messages { get; set; } = null!;
    }
}