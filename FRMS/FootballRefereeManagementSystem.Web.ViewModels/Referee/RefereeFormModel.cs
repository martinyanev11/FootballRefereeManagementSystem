namespace FootballRefereeManagementSystem.Web.ViewModels.Referee
{
    public class RefereeFormModel
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Age { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Contact { get; set; } = null!;

        public string Role { get; set; } = null!;

        public string Town { get; set; } = null!;

        public string Division { get; set; } = null!;

        public string UserId { get; set; } = null!;
    }
}
