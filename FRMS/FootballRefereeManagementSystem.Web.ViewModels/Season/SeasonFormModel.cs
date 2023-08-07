namespace FootballRefereeManagementSystem.Web.ViewModels.Season
{
    using System.ComponentModel.DataAnnotations;

    public class SeasonFormModel
    {
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}
