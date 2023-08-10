namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using SeedingDataConstants;

    public static class RefereeDivisionSeeder
    {
        public static ICollection<RefereeDivision> GenerateRefereeDivisions()
        {
            ICollection<RefereeDivision> refereeDivisions = new HashSet<RefereeDivision>()
            {
                // Main referee - divisions
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.MainRefereeId,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    IsActive = true,
                },
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.MainRefereeId,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    IsActive = true,
                },

                // First AR - divisions
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.AssistantRefereeOneId,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    IsActive = true,
                },
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.AssistantRefereeOneId,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    IsActive = true,
                },

                // Second AR - divisions
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.AssistantRefereeTwoId,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    IsActive = true,
                },
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.AssistantRefereeTwoId,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    IsActive = true,
                },

                // Delegate - divisions
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.DelegateId,
                    DivisionId = DivisionDataConstants.RegionalBGroupId,
                    IsActive = true,
                },
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.DelegateId,
                    DivisionId = DivisionDataConstants.RegionalAGroupId,
                    IsActive = true,
                },
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.DelegateId,
                    DivisionId = DivisionDataConstants.ThirdAmateurLeagueId,
                    IsActive = true,
                },

                // Administration referee - divisions
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.AdministratorId,
                    DivisionId = DivisionDataConstants.SecondProLeagueId,
                    IsActive = true,
                },
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.AdministratorId,
                    DivisionId = DivisionDataConstants.FirstProLeagueId,
                    IsActive = true,
                },
            };

            return refereeDivisions;
        }
    }
}
