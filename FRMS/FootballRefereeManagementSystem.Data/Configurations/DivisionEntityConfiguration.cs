namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class DivisionEntityConfiguration : IEntityTypeConfiguration<Division>
    {
        public void Configure(EntityTypeBuilder<Division> builder)
        {
            //builder.HasOne(d => d.TeamSeason)
            //    .WithOne(ts => ts.Division)
            //    .HasForeignKey<TeamSeason>(ts => new { ts.TeamId, ts.SeasonId })
            //    .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(d => d.TeamsSeasons)
                .WithOne(ts => ts.Division)
                .HasForeignKey(ts => new { ts.TeamId, ts.DivisionId })
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
