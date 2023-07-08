namespace FootballRefereeManagementSystem.Web.ViewModels.Contact
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.ContactMessage;

    public class ContactFormModel
    {
        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength, 
            ErrorMessage = "Името трябва да е между 2 и 50 символа")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength,
            ErrorMessage = "Фамилията трябва да е между 2 и 50 символа")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        [EmailAddress(ErrorMessage = "Моля въведете валиден имейл")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength,
            ErrorMessage = "Темата трябва да е между 3 и 100 символа")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(MessageMaxLength, MinimumLength = MessageMinLength,
            ErrorMessage = "Съобщението трябва да е между 10 и 1000 символа")]
        public string Message { get; set; } = null!;
    }
}
