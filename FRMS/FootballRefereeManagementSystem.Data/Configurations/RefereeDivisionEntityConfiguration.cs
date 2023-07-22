namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class RefereeDivisionEntityConfiguration : IEntityTypeConfiguration<RefereeDivision>
    {
        private readonly RefereeDivisionSeeder seeder;

        public RefereeDivisionEntityConfiguration()
        {
            this.seeder = new RefereeDivisionSeeder();
        }

        public void Configure(EntityTypeBuilder<RefereeDivision> builder)
        {
            builder.HasKey(rd => new { rd.RefereeId, rd.DivisionId });

            builder.HasOne(rd => rd.Referee)
                .WithMany(r => r.RefereeDivisions)
                .HasForeignKey(rd => rd.RefereeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(rd => rd.Division)
                .WithMany(d => d.DivisionReferees)
                .HasForeignKey(rd => rd.DivisionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(this.seeder.GenerateRefereeDivisions());
        }
    }
}
