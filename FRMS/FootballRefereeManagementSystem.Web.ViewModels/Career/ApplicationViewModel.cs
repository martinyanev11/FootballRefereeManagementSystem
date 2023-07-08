namespace FootballRefereeManagementSystem.Web.ViewModels.Career
{
    using System.ComponentModel.DataAnnotations;

    public class ApplicationViewModel
    {
        [Required(ErrorMessage = "Моля, въведете вашето пълно име.")]
        public string FullName { get; set; } = null!;

        [Required(ErrorMessage = "Моля, въведете вашия имейл адрес.")]
        [EmailAddress(ErrorMessage = "Моля, въведете валиден имейл адрес.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Моля, въведете вашия телефонен номер.")]
        public string Phone { get; set; } = null!;

        [Required(ErrorMessage = "Моля, въведете позицията, за която кандидатствате.")]
        public string Position { get; set; } = null!;

        //[Required(ErrorMessage = "Моля, прикачете своето резюме.")]
        //public IFormFile Resume { get; set; }
    }
}
