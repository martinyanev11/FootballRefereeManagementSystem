namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Web.ViewModels.Message;

    public interface IMessageService
    {
        /// <summary>
        /// Adds a new message to the database for a specific referee squad.
        /// </summary>
        /// <param name="model">The message information to add.</param>
        Task AddNewMessageAsync(MessageFormModel model);

        /// <summary>
        /// Checks if a message with the specified ID exists in the database.
        /// </summary>
        /// <param name="messageId">The ID of the message to check for existence.</param>
        /// <returns><see langword="true"/> if a message with the specified ID exists in the database, <see langword="false"/> otherwise.</returns>
        Task<bool> CheckMessageExistance(string messageId);

        /// <summary>
        /// Retrieves all messages for a specific referee squad from the database.
        /// </summary>
        /// <param name="refereeSquadId">The ID of the referee squad.</param>
        /// <returns>A collection of <see cref="MessageViewModel"/> representing the messages for the specified referee squad.</returns>
        Task<IEnumerable<MessageViewModel>> GetAllMessagesForRefereeSquadAsync(string refereeSquadId);

        /// <summary>
        /// Retrieves the ID of the referee squad associated with a specific message.
        /// </summary>
        /// <param name="messageId">The ID of the message.</param>
        /// <returns>The ID of the referee squad associated with the message.</returns>
        Task<string> GetRefereeSquadIdAsync(string messageId);

        /// <summary>
        /// Removes a message by setting its active status to <see langword="false"/>.
        /// </summary>
        /// <param name="messageId">The ID of the message to be removed.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task RemoveMessageAsync(string messageId);
    }
}
