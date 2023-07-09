namespace FootballRefereeManagementSystem.Web.ViewModels.Career
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Application;

    public class ApplicationFormModel
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
        [Range(AgeMinValue, AgeMaxValue, ErrorMessage = "Възрастта трябва да бъде между 15 и 65 години.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [EmailAddress(ErrorMessage = "Моля, въведете валиден имейл адрес.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        [Range(WeightMinValue, WeightMaxValue, ErrorMessage = "Въведеното тегло е извън допустимото")]
        public int Weight { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [Phone(ErrorMessage = "Въведете валиден телефонен номер")]
        [StringLength(ContactMaxLength, MinimumLength = ContactMinLength,
            ErrorMessage = "Телефонния номер трябва да е с дължина точно 10 цифри")]
        public string Contact { get; set; } = null!;

        public bool HasDriverLicense { get; set; }

        public bool HasCar { get; set; }

        public bool KnowsFootballRules { get; set; }
    }
}
