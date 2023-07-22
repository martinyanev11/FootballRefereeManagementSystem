namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class RefereeEntityConfiguration : IEntityTypeConfiguration<Referee>
    {
        private readonly RefereeSeeder refereeSeeder;

        public RefereeEntityConfiguration()
        {
            this.refereeSeeder = new RefereeSeeder();
        }

        public void Configure(EntityTypeBuilder<Referee> builder)
        {
            builder.Property(r => r.ImageUrl)
                .HasDefaultValue("~/Images/Referees/referee-default-avatar.png");

            builder.HasData(this.refereeSeeder.GenerateReferees());
        }
    }
}
