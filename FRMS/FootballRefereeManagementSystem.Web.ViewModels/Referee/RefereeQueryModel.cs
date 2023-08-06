namespace FootballRefereeManagementSystem.Web.ViewModels.Referee
{
    using FootballRefereeManagementSystem.Web.ViewModels.Referee.Enums;

    public class RefereeQueryModel
    {
        public RefereeQueryModel()
        {
            this.Referees = new HashSet<RefereeViewModel>();
        }

        public RefereeNameSortingOrder NameSortingOrder { get; set; }

        public RefereeExperienceSortingOrder ExperienceSortingOrder { get; set; }

        public RefereeMatchCountSortingOrder MatchCountSortingOrder { get; set; }

        public string? SearchString { get; set; }

        public bool IsCheckedReferee { get; set; }

        public bool IsCheckedAssistantReferee { get; set; }

        public bool IsCheckedDelegate { get; set; }

        public bool IsCheckedAdministration { get; set; }

        public IEnumerable<RefereeViewModel> Referees { get; set; } = null!;
    }
}
