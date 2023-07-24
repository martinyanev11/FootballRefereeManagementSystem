namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;

    using Web.ViewModels.Referee;

    public interface IRefereeService
    {
        Task<IEnumerable<RefereeViewModel>> GetAllRefereesFilteredAsync(RefereeQueryModel queryModel);
        Task<RefereeDetailsViewModel> GetRefereeDetailsByIdAsync(int id);
        Task<int> GetRefereeIdByUserIdAsync(string userId);
    }
}
