namespace FootballRefereeManagementSystem.Services.Contracts
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(string recipient, string subject, string content);
    }
}
