﻿namespace FootballRefereeManagementSystem.Web.ViewModels.RefereeSquad
{
    using Match;
    using Message;

    public class MatchCenterViewModel
    {
        public MatchCenterViewModel()
        {
            this.Messages = new HashSet<MessageViewModel>();
            this.NewMessage = new MessageFormModel();
        }

        public RefereeSquadMatchCenterModel RefereeSquad { get; set; } = null!;

        public MatchDetailsViewModel MatchInformation { get; set; } = null!;

        public IEnumerable<MessageViewModel> Messages { get; set; } = null!;

        public MessageFormModel NewMessage { get; set; } = null!;
    }
}
