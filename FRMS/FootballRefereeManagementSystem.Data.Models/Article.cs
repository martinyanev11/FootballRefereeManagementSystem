namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Article;

    [Comment("Any news or announcements on the platform")]
    public class Article
    {
        public Article()
        {
            this.CreatedOn = DateTime.UtcNow;
            this.IsActive = true;
        }

        [Comment("Primary key")]
        [Key]
        public int Id { get; set; }

        [Comment("Title of the article")]
        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Comment("Content of the article")]
        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        [Comment("Image related to this article")]
        [MaxLength(ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }

        [Comment("Soft delete value")]
        public bool IsActive { get; set; }
    }
}