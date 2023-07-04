namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using SeedingDataConstants;

    internal class RefereeSquadSeeder
    {
        internal ICollection<RefereeSquad> GenerateRefereeSquads()
        {
            ICollection<RefereeSquad> refereeSquads = new HashSet<RefereeSquad>()
            {
                new RefereeSquad()
                {
                    Id = new Guid(RefereeSquadDataConstants.RefereeSquadGuid),
                    MainRefereeId = RefereeDataConstants.MainRefereeId,
                    FirstAssistantRefereeId = RefereeDataConstants.AssistantRefereeOneId,
                    SecondAssistantRefereeId = RefereeDataConstants.AssistantRefereeTwoId,
                    DelegateId = RefereeDataConstants.DelegateId,
                    MatchId = 1
                }
            };

            return refereeSquads;
        }
    }
}
