﻿namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Models.Enums;
    using Seeding;

    internal class SeasonEntityConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(EntityTypeBuilder<Season> builder)
        {
            builder.Property(s => s.Status)
                .HasDefaultValue(SeasonStatus.InPreparation);

            builder.HasData(SeasonSeeder.GenerateSeasons());
        }
    }
}
