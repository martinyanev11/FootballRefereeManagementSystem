namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    using System.ComponentModel.DataAnnotations;

    using Division;

    public class TeamSeasonRegisterModel
    {
        public TeamSeasonRegisterModel()
        {
            this.Teams = new HashSet<TeamListModel>();
            this.Divisions = new HashSet<DivisionViewModel>();
            this.ShirtColors = new HashSet<string>();
        }

        [Required]
        public int SeasonId { get; set; }

        [Required]
        public int TeamId { get; set; }

        [Required]
        public int DivisionId { get; set; }

        [Required]
        public string ShirtColor { get; set; } = null!;

        public IEnumerable<TeamListModel> Teams { get; set; } = null!;

        public IEnumerable<DivisionViewModel> Divisions { get; set; } = null!;

        public IEnumerable<string> ShirtColors { get; set; } = null!;
    }
}
