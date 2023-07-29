namespace FootballRefereeManagementSystem.Web.ViewModels.RefereeSquad
{
    using FootballRefereeManagementSystem.Web.ViewModels.Match;

    public class RefereeSquadViewModel
    {
        public RefereeSquadViewModel()
        {
            this.RefereeIds = new HashSet<int>();
        }

        public string RefereeSquadId { get; set; } = null!;

        public string MainRefereeFullName { get; set; } = null!;

        public string AssistantRefereeOneFullName { get; set; } = null!;

        public string AssistantRefereeTwoFullName { get; set; } = null!;

        public string DelegateFullName { get; set; } = null!;

        public IEnumerable<int> RefereeIds { get; set; } = null!;

        public MatchRefereeSquadSummaryViewModel Match { get; set; } = null!;
    }
}
