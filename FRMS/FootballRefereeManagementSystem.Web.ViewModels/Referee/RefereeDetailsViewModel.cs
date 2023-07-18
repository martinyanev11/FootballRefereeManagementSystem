namespace FootballRefereeManagementSystem.Web.ViewModels.Referee
{
    public class RefereeDetailsViewModel
    {
        public RefereeDetailsViewModel()
        {
            this.DivisionsAndMatchesCount = new Dictionary<string, int>();
        }

        public string FullName { get; set; } = null!;

        public int Age { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Contact { get; set; } = null!;

        public string Role { get; set; } = null!;

        public DateTime CareerStart { get; set; }

        public int TotalMatchesOfficiated { get; set; }

        public string Town { get; set; } = null!;

        public IDictionary<string, int> DivisionsAndMatchesCount { get; set; } = null!;
    }
}
