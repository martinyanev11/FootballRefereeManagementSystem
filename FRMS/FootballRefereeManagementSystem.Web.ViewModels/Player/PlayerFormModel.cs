namespace FootballRefereeManagementSystem.Web.ViewModels.Player
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Player;

    public class PlayerFormModel
    {
        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength,
            ErrorMessage = "Името трябва да е между 2 и 50 символа")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength,
            ErrorMessage = "Името трябва да е между 2 и 50 символа")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        [Range(AgeMinValue, AgeMaxValue, ErrorMessage = "Играча трябва да е между 15 и 50 години.")]
        public int Age { get; set; }

        [StringLength(PositionMaxLength, MinimumLength = PositionMinLength,
            ErrorMessage = "Позицията трябва да е между 2 и 20 символа")]
        public string? Position { get; set; }
    }
}
