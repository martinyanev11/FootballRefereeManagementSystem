namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class SeasonEntityConfiguration : IEntityTypeConfiguration<Season>
    {
        private readonly SeasonSeeder seasonSeeder;

        public SeasonEntityConfiguration()
        {
            this.seasonSeeder = new SeasonSeeder();
        }

        public void Configure(EntityTypeBuilder<Season> builder)
        {
            builder.HasData(this.seasonSeeder.GenerateSeasons());
        }
    }
}
