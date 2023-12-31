﻿namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class TeamSeasonEntityConfiguration : IEntityTypeConfiguration<TeamSeason>
    {
        public void Configure(EntityTypeBuilder<TeamSeason> builder)
        {
            builder.HasKey(ts => new { ts.TeamId, ts.SeasonId });

            builder.HasOne(ts => ts.Team)
                .WithMany(t => t.TeamSeasons)
                .HasForeignKey(ts => ts.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ts => ts.Season)
                .WithMany(s => s.SeasonTeams)
                .HasForeignKey(ts => ts.SeasonId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ts => ts.Division)
                .WithMany(d => d.TeamsSeasons)
                .HasForeignKey(ts => ts.DivisionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(TeamSeasonSeeder.GenerateTeamsSeasons());
        }
    }
}
