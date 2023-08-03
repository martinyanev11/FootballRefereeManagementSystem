namespace FootballRefereeManagementSystem.Web.ViewModels.Referee
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Referee;

    public class RefereeFormModel
    {
        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength,
            ErrorMessage = "Името трябва да е с дължина между 2 и 50 символа")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength,
            ErrorMessage = "Фамилията трябва да е с дължина между 2 и 50 символа")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        [Range(AgeMinValue, AgeMaxValue, ErrorMessage = "Възрастта трябва да бъде между 15 и 50 години.")]
        public int Age { get; set; }

        [StringLength(ImageUrlMaxLength, ErrorMessage = "Линка е прекалено дълъг")]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [Phone(ErrorMessage = "Въведете валиден телефонен номер")]
        [StringLength(ContactLength, MinimumLength = ContactLength,
            ErrorMessage = "Телефонния номер трябва да е с дължина точно 10 цифри")]
        public string Contact { get; set; } = null!;

        public string StartingRole { get; set; } = null!;
        public string StartingDivision { get; set; } = null!;
        public string UserId { get; set; } = null!;
    }
}
