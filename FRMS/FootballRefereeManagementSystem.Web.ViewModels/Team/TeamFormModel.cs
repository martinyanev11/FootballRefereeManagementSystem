namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    public class TeamFormModel
    {
        public TeamFormModel()
        {
            this.Towns = new HashSet<string>();
        }

        public string Name { get; set; } = null!;

        public int TownId { get; set; }

        public string Town { get; set; } = null!;

        public IEnumerable<string> Towns { get; set; } = null!;
    }
}
