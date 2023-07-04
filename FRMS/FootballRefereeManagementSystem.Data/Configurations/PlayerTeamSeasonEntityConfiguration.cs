namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class PlayerTeamSeasonEntityConfiguration : IEntityTypeConfiguration<PlayerTeamSeason>
    {
        private readonly PlayerTeamSeasonSeeder seeder;

        public PlayerTeamSeasonEntityConfiguration()
        {
            this.seeder = new PlayerTeamSeasonSeeder();
        }

        public void Configure(EntityTypeBuilder<PlayerTeamSeason> builder)
        {
            builder.HasKey(pts => new { pts.TeamId, pts.SeasonId, pts.PlayerId });

            builder.HasOne(pts => pts.TeamSeason)
                .WithMany(ts => ts.TeamSeasonPlayers)
                .HasForeignKey(pts => new { pts.TeamId, pts.SeasonId })
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pts => pts.Player)
                .WithMany(p => p.PlayerTeamsSeasons)
                .HasForeignKey(pts => pts.PlayerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(this.seeder.GeneratePlayersTeamsSeasons());
        }
    }
}
