namespace FootballRefereeManagementSystem.Services
{
    using Contracts;
    using FootballRefereeManagementSystem.Data;

    public class MatchService : IMatchService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public MatchService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
