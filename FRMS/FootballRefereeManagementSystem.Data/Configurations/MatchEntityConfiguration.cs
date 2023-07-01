namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    internal class MatchEntityConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasOne(m => m.TeamSeasonHomeTeam)
                .WithMany(ts => ts.HomeGames)
                .HasForeignKey(m => new { m.HomeTeamId, m.SeasonId });

            builder.HasOne(m => m.TeamSeasonAwayTeam)
                .WithMany(ts => ts.AwayGames)
                .HasForeignKey(m => new { m.AwayTeamId, m.SeasonId });
        }
    }
}
