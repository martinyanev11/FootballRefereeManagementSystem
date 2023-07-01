namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class RefereeSquadEntityConfiguration : IEntityTypeConfiguration<RefereeSquad>
    {
        public void Configure(EntityTypeBuilder<RefereeSquad> builder)
        {
            builder.HasOne(refsquad => refsquad.Referee)
                .WithMany(r => r.RefereeSquads)
                .HasForeignKey(refsquad => refsquad.RefereeId);

            builder.HasOne(refsquad => refsquad.FirstAssistantReferee)
                .WithMany(r => r.RefereeSquads)
                .HasForeignKey(refsquad => refsquad.FirstAssistantRefereeId);

            builder.HasOne(refsquad => refsquad.SecondAssistantReferee)
                .WithMany(r => r.RefereeSquads)
                .HasForeignKey(refsquad => refsquad.SecondAssistantRefereeId);

            builder.HasOne(refsquad => refsquad.Delegate)
                .WithMany(r => r.RefereeSquads)
                .HasForeignKey(refsquad => refsquad.DelegateId);

            builder.HasOne(refsquad => refsquad.Match)
                .WithOne(m => m.RefereeSquad)
                .HasForeignKey<RefereeSquad>(refsquad => refsquad.MatchId);
        }
    }
}
