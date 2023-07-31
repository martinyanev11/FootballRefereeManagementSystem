namespace FootballRefereeManagementSystem.Web.ViewModels.Referee
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Referee;
    using static Common.EntityValidationConstants.Town;

    public class RefereeFormModel
    {
        public RefereeFormModel()
        {
            this.Zones = new HashSet<string>();
        }

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

        [StringLength(ImageUrlMaxLength, ErrorMessage = "Линка е прекалено дълъг")]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [Phone(ErrorMessage = "Въведете валиден телефонен номер")]
        [StringLength(ContactLength, MinimumLength = ContactLength,
            ErrorMessage = "Телефонния номер трябва да е с дължина точно 10 цифри")]
        public string Contact { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength,
            ErrorMessage = "Името на града трябва да е между 2 и 26 символа")]
        public string Town { get; set; } = null!;

        public int TownId { get; set; }

        public string Role { get; set; } = null!;
        public string Division { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string Zone { get; set; } = null!;
        public IEnumerable<string> Zones { get; set; } = null!;
    }
}
