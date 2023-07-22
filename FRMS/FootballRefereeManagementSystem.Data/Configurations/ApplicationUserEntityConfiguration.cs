﻿namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        private readonly ApplicationUserSeeder userSeeder;

        public ApplicationUserEntityConfiguration()
        {
            this.userSeeder = new ApplicationUserSeeder();
        }

        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(this.userSeeder.GenerateApplicationUsers());
        }
    }
}