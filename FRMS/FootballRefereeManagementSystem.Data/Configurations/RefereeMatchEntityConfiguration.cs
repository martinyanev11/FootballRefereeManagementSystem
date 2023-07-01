namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class RefereeMatchEntityConfiguration : IEntityTypeConfiguration<RefereeMatch>
    {
        public void Configure(EntityTypeBuilder<RefereeMatch> builder)
        {
            builder.HasKey(rm => new { rm.RefereeId, rm.MatchId });

            builder.HasOne(rm => rm.Referee)
                .WithMany(r => r.RefereeMatches)
                .HasForeignKey(rm => rm.RefereeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(rm => rm.Match)
                .WithMany(m => m.MatchReferees)
                .HasForeignKey(rm => rm.MatchId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
