namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Zone;

    [Comment("Zone that is part of region in the country")]
    public class Zone
    {
        public Zone()
        {
            this.Towns = new HashSet<Town>();
        }

        [Comment("Primary key")]
        [Key]
        public int Id { get; set; }

        [Comment("Name of the zone")]
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Comment("Collection of all towns located in the zone")]
        public ICollection<Town> Towns { get; set; } = null!;
    }
}
