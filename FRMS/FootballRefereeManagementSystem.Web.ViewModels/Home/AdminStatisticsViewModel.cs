namespace FootballRefereeManagementSystem.Web.ViewModels.Home
{
    using Referee;
    using Season;

    public class AdminStatisticsViewModel
    {
        public SeasonStatisticsViewModel SeasonStatistics { get; set; } = null!;

        public RefereesStatisticsViewModel RefereesStatistics { get; set; } = null!;
    }
}
