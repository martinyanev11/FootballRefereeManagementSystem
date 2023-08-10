namespace FootballRefereeManagementSystem.Services
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using Data;
    using Data.Models;
    using Contracts;
    using Web.ViewModels.Message;

    public class MessageService : IMessageService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public MessageService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddNewMessageAsync(MessageFormModel model)
        {
            Message messageToAdd = new Message()
            {
                RefereeSquadId = Guid.Parse(model.RefereeSquadId!),
                UserId = Guid.Parse(model.UserId!),
                Content = model.Content,
            };

            await this.dbContext.Messages.AddAsync(messageToAdd);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> CheckMessageExistance(string messageId)
        {
            return await this.dbContext
                .Messages
                .AnyAsync(m => m.Id.ToString() == messageId && m.IsActive);
        }

        public async Task<IEnumerable<MessageViewModel>> GetAllMessagesForRefereeSquadAsync(string refereeSquadId)
        {
            return await this.dbContext
                .Messages
                .Where(m => m.RefereeSquadId.ToString() == refereeSquadId && m.IsActive)
                .OrderByDescending(m => m.CreatedOn)
                .Select(m => new MessageViewModel()
                {
                    Id = m.Id.ToString(),
                    UserId = m.UserId.ToString(),
                    AuthorName = $"{m.User.Referee!.FirstName} {m.User.Referee.LastName}",
                    Content = m.Content,
                    CreatedOn = m.CreatedOn,
                })
                .ToArrayAsync();
        }

        public async Task<string> GetRefereeSquadIdAsync(string messageId)
        {
            return await this.dbContext
                .Messages
                .Where(m => m.Id.ToString() == messageId)
                .Select(m => m.RefereeSquadId.ToString())
                .FirstAsync();
        }

        public async Task RemoveMessageAsync(string messageId)
        {
            Message messageToDelete = await this.dbContext
                .Messages
                .Where(m => m.Id.ToString() == messageId)
                .FirstAsync();

            messageToDelete.IsActive = false;

            await this.dbContext.SaveChangesAsync();
        }
    }
}