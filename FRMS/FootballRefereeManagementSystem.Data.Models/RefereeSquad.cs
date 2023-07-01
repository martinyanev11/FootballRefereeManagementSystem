namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    [Comment("Referee + 2 AR + Delegate and the Match they will officiate")]
    public class RefereeSquad
    {
        public RefereeSquad()
        {
            this.Id = Guid.NewGuid();
        }

        [Comment("Primary key")]
        [Key]
        public Guid Id { get; set; }

        [Comment("The main referee of the match")]
        [ForeignKey(nameof(Referee))]
        public int RefereeId { get; set; }
        public Referee Referee { get; set; } = null!;

        [Comment("First assistant referee")]
        [ForeignKey(nameof(FirstAssistantReferee))]
        public int FirstAssistantRefereeId { get; set; }
        public Referee FirstAssistantReferee { get; set; } = null!;

        [Comment("Second assistant referee")]
        [ForeignKey(nameof(SecondAssistantReferee))]
        public int SecondAssistantRefereeId { get; set; }
        public Referee SecondAssistantReferee { get; set; } = null!;

        [Comment("Match delegate to supervise the offcials")]
        [ForeignKey(nameof(Delegate))]
        public int DelegateId { get; set; }
        public Referee Delegate { get; set; } = null!;

        [Comment("Assigned match to the squad")]
        [ForeignKey(nameof(Match))]
        public int MatchId { get; set; }
        public Match Match { get; set; } = null!;
    }
}