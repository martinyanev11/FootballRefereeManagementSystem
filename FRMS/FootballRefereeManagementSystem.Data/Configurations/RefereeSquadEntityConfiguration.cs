namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class RefereeSquadEntityConfiguration : IEntityTypeConfiguration<RefereeSquad>
    {
        public void Configure(EntityTypeBuilder<RefereeSquad> builder)
        {
            builder.HasOne(rs => rs.Referee)
                .WithMany(r => r.MatchHistory)
                .HasForeignKey(rs => rs.RefereeId);

            builder.HasOne(rs => rs.FirstAssistantReferee)
                .WithMany(r => r.MatchHistory)
                .HasForeignKey(rs => rs.FirstAssistantRefereeId);

            builder.HasOne(rs => rs.SecondAssistantReferee)
                .WithMany(r => r.MatchHistory)
                .HasForeignKey(rs => rs.SecondAssistantRefereeId);

            builder.HasOne(rs => rs.Delegate)
                .WithMany(r => r.MatchHistory)
                .HasForeignKey(rs => rs.DelegateId);

            builder.HasOne(rs => rs.Match)
                .WithOne(m => m.RefereeSquad)
                .HasForeignKey<RefereeSquad>(rs => rs.MatchId);
        }
    }
}
