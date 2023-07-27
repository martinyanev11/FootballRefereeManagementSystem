namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Threading.Tasks;

    public interface IEmailService
    {
        /// <summary>
        /// Sends an email to the contact system using the provided information.
        /// </summary>
        /// <param name="firstName">The first name of the sender.</param>
        /// <param name="lastName">The last name of the sender.</param>
        /// <param name="email">The email address of the sender.</param>
        /// <param name="subject">The subject of the email.</param>
        /// <param name="messageContent">The content of the email message.</param>
        /// <returns>A task representing the asynchronous operation that returns a <see langword="boolean"/> value indicating whether the email was sent successfully.</returns>
        Task<bool> SendEmailToContactSystemAsync(string firstName, string lastName, string email, string subject, string messageContent);
    }
}