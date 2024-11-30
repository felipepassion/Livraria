using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;

namespace Niu.Nutri.Chat.Api.Controllers
{
    public partial class ConversationController
    {
        [HttpPost("set-my-messages-read/{conversationId}/{myId}")]
        public async Task<GetHttpResponseDTO> SetMyMessageToRead(int conversationId, int myId)
        {
            var result = await _conversationAppService.SetMessagesToRead(conversationId, myId);
            return result.Success ? GetHttpResponseDTO.Ok() : GetHttpResponseDTO.BadRequest(result);
        }
    }
}
