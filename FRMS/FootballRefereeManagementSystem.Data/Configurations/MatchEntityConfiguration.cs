namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class MatchEntityConfiguration : IEntityTypeConfiguration<Match>
    {
        private readonly MatchSeeder matchSeeder;

        public MatchEntityConfiguration()
        {
            this.matchSeeder = new MatchSeeder();
        }

        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasOne(m => m.HomeTeam)
                .WithMany(ts => ts.HomeGames)
                .HasForeignKey(m => new { m.HomeTeamId, m.SeasonId })
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.AwayTeam)
                .WithMany(ts => ts.AwayGames)
                .HasForeignKey(m => new { m.AwayTeamId, m.SeasonId })
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(m => m.HasFinished)
                .HasDefaultValue(false);

            builder.HasData(this.matchSeeder.GenerateMatches());
        }
    }
}
