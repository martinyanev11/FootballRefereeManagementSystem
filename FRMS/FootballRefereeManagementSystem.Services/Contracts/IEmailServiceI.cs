namespace FootballRefereeManagementSystem.Services.Contracts
{
    public interface IEmailService
    {
        /// <summary>
        /// Sends <typeparamref name="SendGridMessage"/> message via pre-determined <typeparamref name="EmailAddress"/>.<br></br>
        /// The guest message is addressed to email which is configured as reciever <typeparamref name="EmailAddress"/>.
        /// </summary>
        /// <param name="firstName">Message sender first name.</param>
        /// <param name="lastName">Message sender last name.</param>
        /// <param name="email">Message sender email address.</param>
        /// <param name="subject">Message topic.</param>
        /// <param name="messageContent">Message content.</param>
        /// <returns><see langword="true"/> if the email has been delivered successfully.</returns>
        Task<bool> SendEmailToContactSystemAsync(string firstName, string lastName, string email, string subject, string messageContent);
    }
}