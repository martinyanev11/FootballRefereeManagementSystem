﻿namespace FootballRefereeManagementSystem.Services.Contracts
{
    using FootballRefereeManagementSystem.Web.ViewModels.Career;
    using System.Threading.Tasks;

    public interface IEmailService
    {
        /// <summary>
        /// Asynchronously sends an approval email to a career candidate. The email contains personal registration link.
        /// </summary>
        /// <param name="emailModel">The ApplicationEmailModel containing the candidate's information.</param>
        /// <returns>Task representing the asynchronous operation. The result indicates whether the email was sent successfully.</returns>
        Task<bool> SendApproveEmailToCareerCandidateAsync(ApplicationEmailModel emailModel);

        /// <summary>
        /// Asynchronously sends a decline email to a career candidate.
        /// </summary>
        /// <param name="emailModel">The ApplicationEmailModel containing the candidate's information.</param>
        /// <returns>Task representing the asynchronous operation. The result indicates whether the email was sent successfully.</returns>
        Task<bool> SendDeclineEmailToCareerCandidateAsync(ApplicationEmailModel emailModel);

        /// <summary>
        /// Asynchronously sends an email to a user for account mangement operations (e.g. password reset, email change etc...).
        /// </summary>
        /// <param name="email">User email that will receive the messaeg.</param>
        /// <param name="subject">The email subject.</param>
        /// <param name="plainTextContent">Message text content.</param>
        /// <param name="htmlContent">Message html content.</param>
        /// <returns><see langword="true"/> if email is successfully sent otherwise <see langword="false"/></returns>
        Task<bool> SendEmailConfirmation(string email, string subject, string plainTextContent, string htmlContent);

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