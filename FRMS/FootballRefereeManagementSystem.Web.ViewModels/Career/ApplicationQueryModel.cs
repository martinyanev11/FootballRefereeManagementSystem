namespace FootballRefereeManagementSystem.Web.ViewModels.Career
{
    using FootballRefereeManagementSystem.Web.ViewModels.Career.Enums;

    public class ApplicationQueryModel
    {
        public ApplicationQueryModel()
        {
            this.Applications = new HashSet<ApplicationViewModel>();
        }

        public StatusSorting StatusSorting { get; set; }

        public DateSorting DateSorting { get; set; }

        public bool IsRegisteredIsChecked { get; set; }

        public IEnumerable<ApplicationViewModel> Applications { get; set; } = null!;
    }
}
