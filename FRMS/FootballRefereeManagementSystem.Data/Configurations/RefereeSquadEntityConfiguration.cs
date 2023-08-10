namespace FootballRefereeManagementSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    using Seeding;

    internal class RefereeSquadEntityConfiguration : IEntityTypeConfiguration<RefereeSquad>
    {
        public void Configure(EntityTypeBuilder<RefereeSquad> builder)
        {
            builder.HasOne(rs => rs.MainReferee)
                .WithMany(r => r.MainRefereeSquads)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(rs => rs.FirstAssistantReferee)
                .WithMany(r => r.FirstAssistantRefereeSquads)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(rs => rs.SecondAssistantReferee)
               .WithMany(r => r.SecondAssistantRefereeSquads)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(rs => rs.Delegate)
               .WithMany(r => r.DelegateRefereeSquads)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(rs => rs.Match)
                .WithOne(m => m.RefereeSquad)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(rs => rs.Messages)
                .WithOne(msg => msg.RefereeSquad)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(RefereeSquadSeeder.GenerateRefereeSquads());
        }
    }
}
