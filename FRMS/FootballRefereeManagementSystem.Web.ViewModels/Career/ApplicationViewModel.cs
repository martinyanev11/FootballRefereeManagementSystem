namespace FootballRefereeManagementSystem.Web.ViewModels.Career
{
    public class ApplicationViewModel
    {
        public string FullName { get; set; } = null!;

        public int Age { get; set; }

        public int Weight { get; set; }

        public string ContactNumber { get; set; } = null!;

        public string EmailAddress { get; set; } = null!;

        public string Id { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public bool IsRegistered { get; set; }

        public string Status { get; set; } = null!;

        public bool HasDriverLicense { get; set; }

        public bool HasCar { get; set; }
    }
}
