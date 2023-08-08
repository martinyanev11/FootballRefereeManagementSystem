namespace FootballRefereeManagementSystem.Web.ViewModels.Referee
{
    public class RefereeViewModel : RefereeListModel
    {
        public string Role { get; set; } = null!;

        public DateTime CareerStart { get; set; }

        public int TotalMatchesOfficiated { get; set; }
    }
}
