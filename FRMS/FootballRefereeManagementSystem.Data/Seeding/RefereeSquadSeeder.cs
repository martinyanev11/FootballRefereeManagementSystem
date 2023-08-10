namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using SeedingDataConstants;

    public static class RefereeSquadSeeder
    {
        public static ICollection<RefereeSquad> GenerateRefereeSquads()
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
