namespace FootballRefereeManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    [Comment("Every referee squad consists of 1 main ref, 2 assitants and a delegate")]
    public class RefereeSquad
    {
        public RefereeSquad()
        {
            this.Id = Guid.NewGuid();
            this.Messages = new HashSet<Message>();
        }

        [Comment("Primary key")]
        [Key]
        public Guid Id { get; set; }

        [Comment("Main referee of the squad")]
        [ForeignKey(nameof(MainReferee))]
        public int MainRefereeId { get; set; }
        public Referee MainReferee { get; set; } = null!;

        [Comment("First assistant of the match")]
        [ForeignKey(nameof(FirstAssistantReferee))]
        public int FirstAssistantRefereeId { get; set; }
        public Referee FirstAssistantReferee { get; set; } = null!;

        [Comment("Second assistant of the match")]
        [ForeignKey(nameof(SecondAssistantReferee))]
        public int SecondAssistantRefereeId { get; set; }
        public Referee SecondAssistantReferee { get; set; } = null!;

        [Comment("Delegate who will supervise the officials")]
        [ForeignKey(nameof(Delegate))]
        public int DelegateId { get; set; }
        public Referee Delegate { get; set; } = null!;

        [Comment("Match assigned to the squad")]
        [ForeignKey(nameof(Match))]
        public int MatchId { get; set; }
        public Match Match { get; set; } = null!;

        [Comment("Collection of internal squad messages")]
        public ICollection<Message> Messages { get; set; } = null!;
    }
}
