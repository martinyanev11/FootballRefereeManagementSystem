namespace FootballRefereeManagementSystem.Services
{
    using Data;
    using Contracts;

    public class PlayerService : IPlayerService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public PlayerService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
