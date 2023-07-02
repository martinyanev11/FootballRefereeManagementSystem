﻿namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    internal class MatchEntityConfiguration : IEntityTypeConfiguration<Match>
    {
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
        }
    }
}
