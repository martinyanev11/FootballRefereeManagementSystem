namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class TeamEntityConfiguration : IEntityTypeConfiguration<Team>
    {
        private readonly TeamSeeder teamSeeder;

        public TeamEntityConfiguration()
        {
            this.teamSeeder = new TeamSeeder();
        }

        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasData(this.teamSeeder.GenerateTeams());
        }
    }
}
