namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class PlayerEntityConfiguration : IEntityTypeConfiguration<Player>
    {
        private readonly PlayerSeeder playerSeeder;

        public PlayerEntityConfiguration()
        {
            this.playerSeeder = new PlayerSeeder();
        }

        public void Configure(EntityTypeBuilder<Player> builder)
        {
            //builder.HasData(this.playerSeeder.GeneratePlayers(44));
        }
    }
}
