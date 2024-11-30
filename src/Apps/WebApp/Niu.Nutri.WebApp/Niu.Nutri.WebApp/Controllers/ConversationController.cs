using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Requests;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;

namespace Niu.Nutri.Chat.Controllers;

public partial class ConversationController
{
    [Authorize]
    [HttpPost("set-my-messages-read/{conversationId}")]
    public async Task<GetHttpResponseDTO> SetMyMessageToRead(int conversationId)
    {
        var myId = User.GetUserId();
        var result = await this.PostAsync<ConversationDTO>(null, $"set-my-messages-read/{conversationId}/{myId}");
        return GetHttpResponseDTO.Ok();
    }
}