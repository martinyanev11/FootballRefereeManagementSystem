namespace FootballRefereeManagementSystem.Services.Contracts
{
    using FootballRefereeManagementSystem.Web.ViewModels.Player;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPlayerService
    {
        Task<IEnumerable<PlayerDetailsViewModel>> GetTeamPlayersForSeasonAsync(int id, int seasonId);
    }
}
