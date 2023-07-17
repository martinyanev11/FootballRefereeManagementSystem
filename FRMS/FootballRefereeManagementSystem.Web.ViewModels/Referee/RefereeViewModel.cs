namespace FootballRefereeManagementSystem.Web.ViewModels.Referee
{
    public class RefereeViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

        public string Role { get; set; } = null!;

        public DateTime CareerStart { get; set; }

        public int TotalMatchesOfficiated { get; set; }
    }
}
