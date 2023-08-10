namespace FootballRefereeManagementSystem.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using Data;
    using Data.Models;
    using Data.Seeding;

    public class TestDatabaseFixture
    {
        protected FootballRefereeManagementSystemDbContext dbContext;

        protected ICollection<ApplicationUser> users;
        protected ICollection<Article> articles;
        protected ICollection<Division> divisions;
        protected ICollection<Match> matches;
        protected ICollection<Player> players;
        protected ICollection<PlayerTeamSeason> playerTeamSeasons;
        protected ICollection<RefereeDivision> refereeDivisions;
        protected ICollection<Referee> referees;
        protected ICollection<RefereeSquad> refereeSquads;
        protected ICollection<Season> seasons;
        protected ICollection<TeamSeason> teamSeasons;
        protected ICollection<Team> teams;
        protected ICollection<Town> towns;
        protected ICollection<Zone> zones;

        [SetUp]
        public async Task InitializeDatabaseForTests()
        {
            var options = new DbContextOptionsBuilder<FootballRefereeManagementSystemDbContext>()
                .UseInMemoryDatabase("FRMSDataBase" + Guid.NewGuid())
                .Options;

            this.dbContext = new FootballRefereeManagementSystemDbContext(options);

            // Seed data
            this.users = ApplicationUserSeeder.GenerateApplicationUsers();
            this.articles = ArticleSeeder.GenerateArticles();
            this.divisions = DivisionSeeder.GenerateDivisions();
            this.matches = MatchSeeder.GenerateMatches();
            this.players = PlayerSeeder.GeneratePlayers(88);
            this.playerTeamSeasons = PlayerTeamSeasonSeeder.GeneratePlayersTeamsSeasons(88);
            this.refereeDivisions = RefereeDivisionSeeder.GenerateRefereeDivisions();
            this.referees = RefereeSeeder.GenerateReferees();
            this.refereeSquads = RefereeSquadSeeder.GenerateRefereeSquads();
            this.seasons = SeasonSeeder.GenerateSeasons();
            this.teamSeasons = TeamSeasonSeeder.GenerateTeamsSeasons();
            this.teams = TeamSeeder.GenerateTeams();
            this.towns = TownSeeder.GenerateTowns();
            this.zones = ZoneSeeder.GenerateZones();

            // Add data to the context
            await this.dbContext.AddRangeAsync(this.users);
            await this.dbContext.AddRangeAsync(this.articles);
            await this.dbContext.AddRangeAsync(this.divisions);
            await this.dbContext.AddRangeAsync(this.matches);
            await this.dbContext.AddRangeAsync(this.players);
            await this.dbContext.AddRangeAsync(this.playerTeamSeasons);
            await this.dbContext.AddRangeAsync(this.refereeDivisions);
            await this.dbContext.AddRangeAsync(this.referees);
            await this.dbContext.AddRangeAsync(this.refereeSquads);
            await this.dbContext.AddRangeAsync(this.seasons);
            await this.dbContext.AddRangeAsync(this.teamSeasons);
            await this.dbContext.AddRangeAsync(this.teams);
            await this.dbContext.AddRangeAsync(this.towns);
            await this.dbContext.AddRangeAsync(this.zones);

            await this.dbContext.SaveChangesAsync();
        }
    }
}
