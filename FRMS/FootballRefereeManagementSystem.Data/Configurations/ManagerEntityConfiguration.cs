namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class ManagerEntityConfiguration : IEntityTypeConfiguration<Manager>
    {
        private readonly ManagerSeeder managerSeeder;

        public ManagerEntityConfiguration()
        {
            this.managerSeeder = new ManagerSeeder();
        }

        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasData(this.managerSeeder.GenerateManagers(17));
        }
    }
}
