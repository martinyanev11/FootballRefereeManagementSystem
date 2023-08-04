namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class TownEntityConfiguration : IEntityTypeConfiguration<Town>
    {
        private readonly TownSeeder townSeeder;

        public TownEntityConfiguration()
        {
            this.townSeeder = new TownSeeder();
        }

        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.Property(t => t.IsActive)
                .HasDefaultValue(true);

            builder.HasData(this.townSeeder.GenerateTowns());
        }
    }
}
