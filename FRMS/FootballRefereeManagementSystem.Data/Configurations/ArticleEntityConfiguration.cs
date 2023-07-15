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
            //builder
            //    .HasOne(a => a.Author)
            //    .WithMany(user => user.Articles)
            //    .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(seeder.GenerateArticles());
        }
    }
}
