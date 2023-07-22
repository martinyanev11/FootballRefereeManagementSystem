namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class DivisionEntityConfiguration : IEntityTypeConfiguration<Division>
    {
        private readonly DivisionSeeder divisionSeeder;

        public DivisionEntityConfiguration()
        {
            this.divisionSeeder = new DivisionSeeder();
        }

        public void Configure(EntityTypeBuilder<Division> builder)
        {
            //builder.HasData(this.divisionSeeder.GenerateDivisions());
        }
    }
}
