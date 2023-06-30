namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class TeamSeasonEntityConfiguration : IEntityTypeConfiguration<TeamSeason>
    {
        public void Configure(EntityTypeBuilder<TeamSeason> builder)
        {
            builder.HasKey(ts => new { ts.TeamId, ts.SeasonId });

            builder.HasOne(ts => ts.Team)
                .WithMany(t => t.TeamSeasons)
                .HasForeignKey(ts => ts.TeamId);

            builder.HasOne(ts => ts.Season)
                .WithMany(s => s.TeamsSeason)
                .HasForeignKey(ts => ts.SeasonId);
        }
    }
}
