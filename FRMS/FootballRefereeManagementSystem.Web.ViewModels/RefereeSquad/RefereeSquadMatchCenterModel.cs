namespace FootballRefereeManagementSystem.Web.ViewModels.RefereeSquad
{
    public class RefereeSquadMatchCenterModel
    {
        public string Id { get; set; } = null!;

        public string MainRefereeName { get; set; } = null!;
        public string MainRefereeContact { get; set; } = null!;

        public string FirstARName { get; set; } = null!;
        public string FirstARContact { get; set; } = null!;

        public string SecondARName { get; set; } = null!;
        public string SecondARContact { get; set; } = null!;

        public string DelegateName { get; set; } = null!;
        public string DelegateContact { get; set; } = null!;
    }
}
