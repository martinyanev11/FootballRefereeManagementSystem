namespace FootballRefereeManagementSystem.Web.ViewModels.Division
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Division;

    public class DivisionFormModel
    {
        [Required(ErrorMessage = "Полето е задължително.")]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength,
            ErrorMessage = "Името на дивизията трябва да е между 2 и 50 символа.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително.")]
        public int Difficulty { get; set; }
    }
}
