namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class RefereeDivisionEntityConfiguration : IEntityTypeConfiguration<RefereeDivision>
    {
        public void Configure(EntityTypeBuilder<RefereeDivision> builder)
        {
            builder.HasKey(rd => new {rd.RefereeId, rd.DivisionId});

            builder.HasOne(rd => rd.Referee)
                .WithMany(r => r.RefereeDivisions)
                .HasForeignKey(rd => rd.RefereeId);

            builder.HasOne(rd => rd.Division)
                .WithMany(d => d.RefereesDivision)
                .HasForeignKey(rd => rd.DivisionId);
        }
    }
}
