namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Article;

    [Comment("Any news or announcements on the platform")]
    public class Article
    {
        public Article()
        {
            this.CreatedOn = DateTime.UtcNow;
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

        //[Comment("Author of the article")]
        //[ForeignKey(nameof(Author))]
        //public Guid AuthorId { get; set; }
        //public ApplicationUser Author { get; set; } = null!;
    }
}