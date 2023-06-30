namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    [Comment("Customization of Default Identity User")]
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Comment("The navigation to the referee for this user")]
        [ForeignKey(nameof(Referee))]
        public Guid RefereeId { get; set; }
        public Referee Referee { get; set; } = null!;
    }
}
