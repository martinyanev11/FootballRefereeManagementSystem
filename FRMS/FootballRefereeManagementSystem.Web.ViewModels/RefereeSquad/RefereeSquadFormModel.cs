namespace FootballRefereeManagementSystem.Web.ViewModels.RefereeSquad
{
    using System.ComponentModel.DataAnnotations;

    using Referee;

    public class RefereeSquadFormModel
    {
        public RefereeSquadFormModel()
        {
            this.MainRefereesList = new HashSet<RefereeListModel>();
            this.AssistantRefereesList = new HashSet<RefereeListModel>();
            this.DelegatesList = new HashSet<RefereeListModel>();
        }

        public int DivisionId { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        public int MainRefereeId { get; set; }

        public IEnumerable<RefereeListModel> MainRefereesList { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        public int AssistantRefereeOneId { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        public int AssistantRefereeTwoId { get; set; }

        public IEnumerable<RefereeListModel> AssistantRefereesList { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        public int DelegateId { get; set; }

        public IEnumerable<RefereeListModel> DelegatesList { get; set; } = null!;
    }
}
