namespace FootballRefereeManagementSystem.Web.ViewModels.Division
{
    public class DivisionAllViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Difficulty { get; set; }

        public int RefereesCount { get; set; }
    }
}
