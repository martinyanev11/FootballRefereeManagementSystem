namespace FootballRefereeManagementSystem.Web.ViewModels.Zone
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Zone;

    public class ZoneFormModel
    {
        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength,
            ErrorMessage = "Името трябва да е с дължина между 2 и 40 символа")]
        public string Name { get; set; } = null!;
    }
}
