namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class ZoneEntityConfiguration : IEntityTypeConfiguration<Zone>
    {
        private readonly ZoneSeeder zoneSeeder;

        public ZoneEntityConfiguration()
        {
            this.zoneSeeder = new ZoneSeeder();
        }

        public void Configure(EntityTypeBuilder<Zone> builder)
        {
            builder.Property(z => z.IsActive)
                .HasDefaultValue(true);

            builder.HasData(this.zoneSeeder.GenerateZones());
        }
    }
}
