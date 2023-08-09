namespace FootballRefereeManagementSystem.Web.ViewModels.Message
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Message;

    public class MessageFormModel
    {
        [Required(ErrorMessage = "Не може да изпратите празно съобщение.")]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength,
            ErrorMessage = "Съобщението трябва да е между 1 и 300 символа.")]
        public string Content { get; set; } = null!;

        public string? RefereeSquadId { get; set; }

        public string? UserId { get; set; }
    }
}
