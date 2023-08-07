﻿namespace FootballRefereeManagementSystem.Web.ViewModels.Referee
{
    public class RefereesStatisticsViewModel
    {
        public RefereesStatisticsViewModel()
        {
            this.Roles = new HashSet<string>();
        }

        public int RefereesTotalCount { get; set; }

        public int MainRefereesCount { get; set; }

        public int AssistantRefereesCount { get; set; }

        public int DelegatesCount { get; set; }

        public int AdministrationCount { get; set; }

        public int CurrentlyAvaliableReferees { get; set; }

        public int AverageRefereesAge { get; set; }

        public IEnumerable<string> Roles { get; set; } = null!;
    }
}
