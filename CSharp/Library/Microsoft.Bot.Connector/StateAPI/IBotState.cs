// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    

    /// <summary>
    /// BotState operations.
    /// </summary>
    public partial interface IBotState
    {
        /// <summary>
        /// GetUserData
        /// </summary>
        /// Get a BotData record for the user
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='userId'>
        /// The user Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetUserDataWithHttpMessagesAsync(string botId, string channelId, string userId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// SetUserData
        /// </summary>
        /// Update the bot user data
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='userId'>
        /// The user Id
        /// </param>
        /// <param name='botData'>
        /// the new botdata
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> SetUserDataWithHttpMessagesAsync(string botId, string channelId, string userId, BotData botData, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// GetConversationData
        /// </summary>
        /// get the bot data for a conversation
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='conversationId'>
        /// The conversationId
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetConversationDataWithHttpMessagesAsync(string botId, string channelId, string conversationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// SetConversationData
        /// </summary>
        /// Update the bot conversation data
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='conversationId'>
        /// conversation id
        /// </param>
        /// <param name='botData'>
        /// the new botdata
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> SetConversationDataWithHttpMessagesAsync(string botId, string channelId, string conversationId, BotData botData, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// GetPerUserConversationData
        /// </summary>
        /// get the bot data for a user in a conversation
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='conversationId'>
        /// The conversationId
        /// </param>
        /// <param name='userId'>
        /// The user Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetPerUserConversationDataWithHttpMessagesAsync(string botId, string channelId, string conversationId, string userId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// SetPerUserInConversationData
        /// </summary>
        /// Update the bot user in a conversation data
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='conversationId'>
        /// conversation id
        /// </param>
        /// <param name='userId'>
        /// user id
        /// </param>
        /// <param name='botData'>
        /// the new botdata
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> SetPerUserInConversationDataWithHttpMessagesAsync(string botId, string channelId, string conversationId, string userId, BotData botData, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}