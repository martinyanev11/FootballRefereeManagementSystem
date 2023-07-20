namespace FootballRefereeManagementSystem.Services.Contracts
{
    using Web.ViewModels.Season;
    using System.Threading.Tasks;

    public interface ISeasonService
    {
        Task<SeasonQueryModel> AllAsync(SeasonQueryModel queryModel);
    }
}
