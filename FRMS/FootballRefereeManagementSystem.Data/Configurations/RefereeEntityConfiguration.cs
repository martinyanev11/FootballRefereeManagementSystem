namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class RefereeEntityConfiguration : IEntityTypeConfiguration<Referee>
    {
        public void Configure(EntityTypeBuilder<Referee> builder)
        {
            builder.Property(r => r.ImageUrl)
                .HasDefaultValue("~/Images/Referees/referee-default-avatar.png");

            builder.Property(r => r.IsActive)
                .HasDefaultValue(true);

            builder.HasData(RefereeSeeder.GenerateReferees());
        }
    }
}
