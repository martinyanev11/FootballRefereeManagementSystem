namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class ArticleEntityConfiguration : IEntityTypeConfiguration<Article>
    {
        private readonly ArticleSeeder seeder;

        public ArticleEntityConfiguration()
        {
            this.seeder = new ArticleSeeder();
        }

        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(a => a.IsActive)
                .HasDefaultValue(true);

            builder.HasData(seeder.GenerateArticles());
        }
    }
}
