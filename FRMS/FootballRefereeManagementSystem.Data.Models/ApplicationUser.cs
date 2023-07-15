namespace FootballRefereeManagementSystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    [Comment("Customization of Default Identity User")]
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Comment("The navigation to the referee for this user")]
        public int? RefereeId { get; set; }
        public Referee? Referee { get; set; }

        [Comment("Application for becoming a referee")]
        public int? ApplicationId { get; set; }
        public Application? Application { get; set; } = null!;
    }
}