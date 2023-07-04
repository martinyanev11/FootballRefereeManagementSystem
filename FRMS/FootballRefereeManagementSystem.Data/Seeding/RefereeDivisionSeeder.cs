namespace FootballRefereeManagementSystem.Data.Seeding
{
    using Models;
    using SeedingDataConstants;

    internal class RefereeDivisionSeeder
    {
        internal ICollection<RefereeDivision> GenerateRefereeDivisions()
        {
            ICollection<RefereeDivision> refereeDivisions = new HashSet<RefereeDivision>()
            {
                // Main referee - divisions
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.MainRefereeId,
                    DivisionId = DivisionDataConstants.RegionalBGroupId
                },
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.MainRefereeId,
                    DivisionId = DivisionDataConstants.RegionalAGroupId
                },

                // First AR - divisions
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.AssistantRefereeOneId,
                    DivisionId = DivisionDataConstants.RegionalBGroupId
                },
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.AssistantRefereeOneId,
                    DivisionId = DivisionDataConstants.RegionalAGroupId
                },

                // Second AR - divisions
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.AssistantRefereeTwoId,
                    DivisionId = DivisionDataConstants.RegionalBGroupId
                },
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.AssistantRefereeTwoId,
                    DivisionId = DivisionDataConstants.RegionalAGroupId
                },

                // Delegate - divisions
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.DelegateId,
                    DivisionId = DivisionDataConstants.RegionalBGroupId
                },
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.DelegateId,
                    DivisionId = DivisionDataConstants.RegionalAGroupId
                },
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.DelegateId,
                    DivisionId = DivisionDataConstants.ThirdAmateurLeagueId
                },

                // Administration referee - divisions
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.AdministratorId,
                    DivisionId = DivisionDataConstants.SecondProLeagueId
                },
                new RefereeDivision()
                {
                    RefereeId = RefereeDataConstants.AdministratorId,
                    DivisionId = DivisionDataConstants.FirstProLeagueId
                },
            };

            return refereeDivisions;
        }
    }
}
