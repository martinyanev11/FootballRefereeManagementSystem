namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class PlayerEntityConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasOne(p => p.TeamSeason)
                .WithMany(ts => ts.Players)
                .HasForeignKey(ts => new { ts.TeamId, ts.SeasonId })
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
