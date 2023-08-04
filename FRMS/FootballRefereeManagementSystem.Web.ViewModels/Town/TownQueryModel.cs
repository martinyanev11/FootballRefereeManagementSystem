namespace FootballRefereeManagementSystem.Web.ViewModels.Town
{
    public class TownQueryModel
    {
        public string? Zone { get; set; }

        public string? SearchString { get; set; }

        public IEnumerable<TownViewModel> Towns { get; set; } = null!;

        public IEnumerable<string> Zones { get; set; } = null!;
    }
}