namespace FootballRefereeManagementSystem.Web.ViewModels.Referee
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Referee;

    public class RefereeEditFormModel
    {
        public RefereeEditFormModel()
        {
            this.Roles = new HashSet<string>();
            this.CurrentDivisionIds = new HashSet<int>();
            this.SelectedDivisionIds = new HashSet<int>();
            this.Divisions = new Dictionary<int, string>();
        }

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength,
            ErrorMessage = "Името трябва да е с дължина между 2 и 50 символа")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength,
            ErrorMessage = "Фамилията трябва да е с дължина между 2 и 50 символа")]
        public string LastName { get; set; } = null!;

        [StringLength(ImageUrlMaxLength, ErrorMessage = "Линка е прекалено дълъг")]
        public string? ImageUrl { get; set; }

        public string Role { get; set; } = null!;

        public IEnumerable<string> Roles { get; set; } = null!;

        public IEnumerable<int> CurrentDivisionIds { get; set; } = null!;

        public IEnumerable<int> SelectedDivisionIds { get; set; } = null!;

        public IDictionary<int, string> Divisions { get; set; } = null!;
    }
}
