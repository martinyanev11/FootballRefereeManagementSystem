namespace FootballRefereeManagementSystem.Data
{
    using System.Reflection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Configurations;
    using Models;

    public class FootballRefereeManagementSystemDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public FootballRefereeManagementSystemDbContext(DbContextOptions<FootballRefereeManagementSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Division> Divisions { get; set; } = null!;
        public DbSet<Manager> Managers { get; set; } = null!;
        public DbSet<Match> Matches { get; set; } = null!;
        public DbSet<Player> Players { get; set; } = null!;
        public DbSet<Referee> Referees { get; set; } = null!;
        public DbSet<RefereeDivision> RefereesDivisions { get; set; } = null!;
        public DbSet<RefereeSquad> RefereeSquads { get; set; } = null!;
        public DbSet<Season> Seasons { get; set; } = null!;
        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<TeamSeason> TeamsSeasons { get; set; } = null!;
        public DbSet<Town> Towns { get; set; } = null!;
        public DbSet<Zone> Zones { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Assembly configurationsAssembly = 
            //    Assembly.GetAssembly(typeof(FootballRefereeManagementSystemDbContext)) ??
            //    Assembly.GetExecutingAssembly();

            //builder.ApplyConfigurationsFromAssembly(configurationsAssembly);

            builder.ApplyConfiguration(new DivisionEntityConfiguration());
            builder.ApplyConfiguration(new MatchEntityConfiguration());
            builder.ApplyConfiguration(new PlayerEntityConfiguration());
            builder.ApplyConfiguration(new RefereeDivisionEntityConfiguration());
            builder.ApplyConfiguration(new RefereeEntityConfiguration());
            builder.ApplyConfiguration(new RefereeSquadEntityConfiguration());
            builder.ApplyConfiguration(new TeamSeasonEntityConfiguration());

            base.OnModelCreating(builder);
        }
    }
}