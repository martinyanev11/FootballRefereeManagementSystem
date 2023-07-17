namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;

    using Web.ViewModels.Referee;

    public interface IRefereeService
    {
        Task<IEnumerable<RefereeViewModel>> GetAllRefereesAsync();
    }
}
