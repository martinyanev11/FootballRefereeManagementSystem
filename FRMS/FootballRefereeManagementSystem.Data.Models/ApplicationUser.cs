namespace FootballRefereeManagementSystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    [Comment("Customization of Default Identity User")]
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Articles = new HashSet<Article>();
        }

        [Comment("The navigation to the referee for this user")]
        public int? RefereeId { get; set; }
        public Referee? Referee { get; set; }

        [Comment("Whether user has been approved to become referee")]
        public bool IsApprovedForReferee { get; set; }

        [Comment("Any news or announcements user created")]
        public ICollection<Article> Articles { get; set; } = null!;

        [Comment("Application for becoming a referee")]
        public int? ApplicationId { get; set; }
        public Application? Application { get; set; } = null!;
    }
}