namespace FootballRefereeManagementSystem.Services
{
    using System.Text;

    using SendGrid;
    using SendGrid.Helpers.Mail;

    using Microsoft.Extensions.Configuration;

    using Contracts;

    public class EmailService : IEmailService
    {
        private readonly IConfiguration configuration;
        private readonly string apiKey;

        public EmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.apiKey = configuration["EmailSettings:ApiKey"];
        }

        public async Task<bool> SendDeclineEmailToCareerCandidateAsync(string candidateFullName, string candidateEmail)
        {
            SendGridClient client = new SendGridClient(apiKey);

            string careerSystemEmail = configuration["EmailSettings:ContactSystem:Email"];
            string careerSystemName = "Кариерен център - БФС Плевен";
            EmailAddress senderEmail = new EmailAddress(careerSystemEmail, careerSystemName);

            EmailAddress recieverEmail = new EmailAddress(candidateEmail);

            string subject = "Кандидатура за съдия";
            string plainTextContent =
                @$"Здравейте {candidateFullName},
                Благодарим Ви за интереса, който проявихте и за участието Ви в нашия подборен процес за позицията на футболен съдия.

                Бихме искали да Ви уведомим, че след дълъг и внимателен разглед, нашето ръководство взеха решение да продължат напред с друг кандидат, който най-добре отговаря на нашите настоящи нужди и изисквания.
                С уважение,
                {careerSystemName}";

            string htmlContent = "";

            SendGridMessage? msg = MailHelper.CreateSingleEmail(senderEmail, recieverEmail, subject, plainTextContent, htmlContent);

            Response? response = await client.SendEmailAsync(msg);

            // Check the response status code
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                // Email sent successfully
                return true;
            }

            // An error occurred while sending the email
            return false;
        }

        public async Task<bool> SendApproveEmailToCareerCandidateAsync(string candidateFullName, string candidateEmail, string applicationId)
        {
            SendGridClient client = new SendGridClient(apiKey);

            string careerSystemEmail = configuration["EmailSettings:ContactSystem:Email"];
            string careerSystemName = "Кариерен център - БФС Плевен";
            EmailAddress senderEmail = new EmailAddress(careerSystemEmail, careerSystemName);

            EmailAddress recieverEmail = new EmailAddress(candidateEmail);

            string subject = "Кандидатура за съдия";
            string plainTextContent =
                @$"Здравейте {candidateFullName},
                С радост Ви съобщаваме, че Вашата кандидатура беше успешна, и искаме да Ви поздравим за приемането Ви на позицията асистент съдия в БФС Плевен!
                През следния линк може да направите своя личен профил в нашата Съдийска система - https://localhost:7251/Identity/Account/Register?id={applicationId}
                С уважение,
                {careerSystemName}";

            string htmlContent = "";

            SendGridMessage? msg = MailHelper.CreateSingleEmail(senderEmail, recieverEmail, subject, plainTextContent, htmlContent);

            Response? response = await client.SendEmailAsync(msg);

            // Check the response status code
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                // Email sent successfully
                return true;
            }

            // An error occurred while sending the email
            return false;
        }

        public async Task<bool> SendEmailToContactSystemAsync(string firstName, string lastName, string email, string subject, string messageContent)
        {
            SendGridClient client = new SendGridClient(apiKey);

            string contactSystemEmail = configuration["EmailSettings:ContactSystem:Email"];
            string contactSystemName = configuration["EmailSettings:ContactSystem:Name"];
            EmailAddress senderEmail = new EmailAddress(contactSystemEmail, contactSystemName);

            // Sender and reciever are the same email address due to lack of Domain Authentication in SendGrid.
            // Just for development purposes. Has to be modified for production.
            EmailAddress recieverEmail = new EmailAddress(contactSystemEmail, "Sent by guest");

            string guestFullName = $"{firstName} {lastName}";
            string guestEmail = email;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{guestFullName} - ({guestEmail})\n");
            sb.AppendLine(messageContent);

            string plainTextContent = sb.ToString().TrimEnd();
            string htmlContent = "";

            SendGridMessage? msg = MailHelper.CreateSingleEmail(senderEmail, recieverEmail, subject, plainTextContent, htmlContent);

            Response? response = await client.SendEmailAsync(msg);

            // Check the response status code
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                // Email sent successfully
                return true;
            }

            // An error occurred while sending the email
            return false;
        }

    }
}
