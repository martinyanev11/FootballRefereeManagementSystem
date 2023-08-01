namespace FootballRefereeManagementSystem.Web.ViewModels.Career
{
    public class ApplicationViewModel
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Age { get; set; }

        public int Experience { get; set; }

        public string ContactNumber { get; set; } = null!;

        public string EmailAddress { get; set; } = null!;

        public string Id { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public bool IsRegistered { get; set; }

        public string Status { get; set; } = null!;

        public string Role { get; set; } = null!;

        public string Division { get; set; } = null!;
    }
}
