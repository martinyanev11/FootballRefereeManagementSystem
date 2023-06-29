namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    using Enums;

    [Comment("Mapping table for team and season")]
    public class TeamSeason
    {
        public TeamSeason()
        {
            this.Players = new HashSet<Player>();
            this.HomeGames = new HashSet<Match>();
            this.AwayGames = new HashSet<Match>();
        }

        [Comment("Team that participates specific season")]
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public Team Team { get; set; } = null!;

        [Comment("The specific season")]
        [ForeignKey(nameof(Season))]
        public int SeasonId { get; set; }
        public Season Season { get; set; } = null!;

        [Comment("In which division the team plays")]
        [ForeignKey(nameof(Division))]
        public int DivisionId { get; set; }
        public Division Division { get; set; } = null!;

        [Comment("Points earned during season")]
        public int Points { get; set; }

        [Comment("Placement in the division during the season")]
        public int Placement { get; set; }

        [Comment("Color of the player's shirts")]
        public Color ShirtColor { get; set; }

        [Comment("The manager of the team for specific season")]
        [ForeignKey(nameof(Manager))]
        public int ManagerId { get; set; }
        public Manager Manager { get; set; } = null!;

        [Comment("Collection of all the team's players for specific season")]
        public ICollection<Player> Players { get; set; } = null!;

        [Comment("Collection of home games for specific season")]
        public ICollection<Match> HomeGames { get; set; } = null!;

        [Comment("Collection of away games for specific season")]
        public ICollection<Match> AwayGames { get; set; } = null!;
    }
}
