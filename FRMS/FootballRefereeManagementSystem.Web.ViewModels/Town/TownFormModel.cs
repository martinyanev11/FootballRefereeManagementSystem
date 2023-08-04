namespace FootballRefereeManagementSystem.Web.ViewModels.Town
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Town;

    public class TownFormModel
    {
        public TownFormModel()
        {
            this.Zones = new HashSet<string>();
        }

        [Required(ErrorMessage = "Полето е задължително.")]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength,
            ErrorMessage = "Името е невалидно")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително.")]
        public string Zone { get; set; } = null!;

        public int ZoneId { get; set; }

        public IEnumerable<string> Zones { get; set; } = null!;
    }
}
